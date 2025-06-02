using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Infrastructure.Context;
using MarketWorld.Web.Areas.Admin.Models.Panel;

namespace MarketWorld.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class ProductController : Controller
    {
        private readonly MarketWorldDbContext _context;

        public ProductController(MarketWorldDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            // Sadece toplam ürün sayısını hesaplayalım
            var totalProducts = await _context.Products
                .Where(p => !p.IsDeleted)
                .CountAsync();
                
            // Sayfa yükleme verimliliği için ilk sayfada ürünleri getirmeden view'ı döndürüyoruz
            // Ürünler client tarafında AJAX ile yüklenecek
            ViewBag.TotalProducts = totalProducts;

            return View("~/Areas/Admin/Views/Product/Index.cshtml");
        }

        [HttpGet]
        [Route("Create")]
        public IActionResult Create()
        {
            return View("~/Areas/Admin/Views/Product/Create.cshtml");
        }

        [HttpGet]
        [Route("Edit/{id}")]
        public IActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            return View("~/Areas/Admin/Views/Product/Edit.cshtml");
        }

        [HttpPost]
        [Route("AddProduct")]
        public async Task<IActionResult> AddProduct(AddProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = new Product
            {
                Name = model.Name,
                BrandId = model.BrandId,
                Price = model.Price,
                DiscountPrice = model.DiscountPrice ?? 0,
                Description = model.Description,
                IsActive = model.IsActive,
                HasDiscount = model.HasDiscount,
                SubCategoryId = model.SubCategoryId,
                CreatedDate = DateTime.Now,
                Images = new List<Image>(),
                ProductProperties = new List<ProductProperty>()
            };
            
            product.GenerateRandomProductCode();
            
            // Veritabanında var mı kontrol et ve benzersiz olana kadar tekrar oluştur
            while (await _context.Products.AnyAsync(p => p.ProductCode == product.ProductCode))
            {
                product.GenerateRandomProductCode();
            }

            if (model.Images != null && model.Images.Any())
            {
                foreach (var imageFile in model.Images)
                {
                    if (imageFile.Length > 0)
                    {
                        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                        var filePath = Path.Combine("wwwroot", "img", "ProductsPicture", fileName);

                        // Dizin yoksa oluştur
                        Directory.CreateDirectory(Path.Combine("wwwroot", "img", "ProductsPicture"));

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await imageFile.CopyToAsync(stream);
                        }

                        product.Images.Add(new Image
                        {
                            Path = $"img/ProductsPicture/{fileName}",
                            EntityId = product.Id
                        });
                    }
                }
            }

            if (model.ProductProperties != null && model.ProductProperties.Any())
            {
                foreach (var prop in model.ProductProperties)
                {
                    product.ProductProperties.Add(new ProductProperty
                    {
                        PropertyTypeId = prop.PropertyTypeId,
                        PropertyValueId = prop.PropertyValueId,
                        Stock = prop.Stock,
                        IsActive = prop.IsActive,
                        CreatedDate = DateTime.Now
                    });
                }
            }

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Route("GetProduct/{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _context.Products
                .Include(p => p.SubCategory)
                    .ThenInclude(sc => sc.Category)
                .Include(p => p.Brand)
                .Include(p => p.ProductProperties)
                .Where(p => p.Id == id && !p.IsDeleted)
                .FirstOrDefaultAsync();

            if (product == null)
                return NotFound();

            var viewModel = new ProductAdminViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Stock = product.ProductProperties != null && product.ProductProperties.Any() ? 
                    product.GetTotalStock() : 0,
                CategoryId = product.SubCategory?.CategoryId ?? 0,
                SubCategoryId = product.SubCategoryId ?? 0,
                BrandId = product.BrandId,
                ProductCode = product.ProductCode,
                IsActive = product.IsActive,
                Description = product.Description ?? ""
            };

            return Json(viewModel);
        }

        [HttpPost]
        [Route("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductAdminViewModel model)
        {
            ModelState.Remove("Status");
            ModelState.Remove("BrandName");
            ModelState.Remove("CategoryName");
            ModelState.Remove("SubCategoryName");
            ModelState.Remove("ImageUrl");
            ModelState.Remove("Rating");
            
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var product = await _context.Products
                .Include(p => p.ProductProperties)
                .FirstOrDefaultAsync(p => p.Id == model.Id);
                
            if (product == null)
                return NotFound();

            product.Name = model.Name;
            product.BrandId = model.BrandId;
            product.SubCategoryId = model.SubCategoryId;
            product.Price = model.Price;
            product.IsActive = model.IsActive;
            
            if (!string.IsNullOrEmpty(model.Description))
            {
                product.Description = model.Description;
            }

            // Eğer ProductCode 0 ise yeni oluştur
            if (product.ProductCode == 0)
            {
                product.GenerateRandomProductCode();
                
                // Veritabanında var mı kontrol et ve benzersiz olana kadar tekrar oluştur
                while (await _context.Products.AnyAsync(p => p.Id != product.Id && p.ProductCode == product.ProductCode))
                {
                    product.GenerateRandomProductCode();
                }
            }
            
            // Stock özelliği artık Product sınıfında bulunmuyor, 
            // Bu yüzden model.Stock değerini ProductProperties koleksiyonuna ekleyelim
            if (product.ProductProperties == null || !product.ProductProperties.Any())
            {
                product.ProductProperties = new List<ProductProperty>();
                product.ProductProperties.Add(new ProductProperty
                {
                    PropertyTypeId = 1, // Varsayılan olarak 1 (renk) için
                    PropertyValueId = 1, // Varsayılan değer
                    Stock = model.Stock,
                    IsActive = true,
                    ProductId = product.Id,
                    CreatedDate = DateTime.Now
                });
            }
            else
            {
                // İlk property'nin stok değerini güncelle
                var property = product.ProductProperties.FirstOrDefault();
                if (property != null)
                {
                    property.Stock = model.Stock;
                }
            }

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost]
        [Route("DeleteProduct/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
                return NotFound();

            product.IsDeleted = true;
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet]
        [Route("GetProducts")]
        public async Task<IActionResult> GetProducts(int page = 1, int pageSize = 30, string productCode = "", string status = "")
        {
            try
            {
                // Performans için Select ile sadece ihtiyaç duyulan verileri çekelim
                var query = _context.Products
                    .AsNoTracking() // Performans için tracking'i kapatalım
                    .Where(p => !p.IsDeleted)
                    .Select(p => new {
                        p.Id,
                        p.Name,
                        p.Price,
                        p.Rating,
                        p.IsActive,
                        p.ProductCode,
                        p.BrandId,
                        p.SubCategoryId,
                        p.Description,
                        BrandName = p.Brand.Name,
                        SubCategoryName = p.SubCategory.Name,
                        p.SubCategory.CategoryId,
                        CategoryName = p.SubCategory.Category.Name,
                        ImageUrl = p.Images.OrderBy(i => i.Id).FirstOrDefault().Path,
                        Stock = p.ProductProperties.Where(pp => pp.IsActive).Sum(pp => pp.Stock)
                    })
                    .AsQueryable();
                
                // Ürün kodu ile filtreleme
                if (!string.IsNullOrEmpty(productCode) && int.TryParse(productCode, out int productNum))
                {
                    query = query.Where(p => p.ProductCode == productNum);
                }

                // Durum ile filtreleme
                if (!string.IsNullOrEmpty(status))
                {
                    if (status == "active")
                    {
                        query = query.Where(p => p.IsActive);
                    }
                    else if (status == "inactive")
                    {
                        query = query.Where(p => !p.IsActive);
                    }
                }

                var totalProducts = await query.CountAsync();
                var totalPages = (int)Math.Ceiling(totalProducts / (double)pageSize);
                
                var products = await query
                    .OrderBy(p => p.Id) // Eski ürünler önce gelecek şekilde sıralama
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                var viewModel = products.Select(p => new ProductAdminViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Stock = p.Stock,
                    Rating = p.Rating,
                    Status = p.IsActive ? "Published" : "Draft",
                    ImageUrl = !string.IsNullOrEmpty(p.ImageUrl) ? $"/{p.ImageUrl}" : "/img/ProductsPicture/default.jpg",
                    CategoryId = p.CategoryId,
                    CategoryName = p.CategoryName ?? "Kategorisiz",
                    SubCategoryId = p.SubCategoryId ?? 0,
                    SubCategoryName = p.SubCategoryName ?? "Alt Kategorisiz",
                    BrandId = p.BrandId,
                    BrandName = p.BrandName ?? "Markasız",
                    ProductCode = p.ProductCode,
                    IsActive = p.IsActive,
                    Description = p.Description ?? ""
                }).ToList();

                return Json(new { 
                    products = viewModel, 
                    totalPages,
                    totalProducts,
                    currentPage = page
                });
            }
            catch (Exception ex)
            {
                return BadRequest($"Ürünler yüklenirken bir hata oluştu: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("GetPropertyTypes")]
        public async Task<IActionResult> GetPropertyTypes()
        {
            var propertyTypes = await _context.PropertyTypes
                .Where(pt => pt.IsActive && !pt.IsDeleted)
                .Select(pt => new { id = pt.Id, name = pt.Name })
                .ToListAsync();

            return Json(propertyTypes);
        }

        [HttpGet]
        [Route("GetPropertyValues/{propertyTypeId}")]
        public async Task<IActionResult> GetPropertyValues(int propertyTypeId)
        {
            try
            {
                var propertyValues = await _context.PropertyValues
                    .Where(pv => pv.PropertyTypeId == propertyTypeId && pv.IsActive && !pv.IsDeleted)
                    .Select(pv => new { id = pv.Id, value = pv.Value })
                    .ToListAsync();

                return Json(propertyValues);
            }
            catch (Exception ex)
            {
                return BadRequest($"Özellik değerleri getirilirken hata oluştu: {ex.Message}");
            }
        }
    }
}