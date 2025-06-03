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
    public class PanelController : Controller
    {
        private readonly MarketWorldDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public PanelController(
            MarketWorldDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        [Route("")]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            // Ürün istatistikleri
            ViewBag.ProductsCount = await _context.Products.CountAsync();
            
            // Stok az olan ürün sayısını hesaplama - GetTotalStock() veritabanında çalışmadığı için önce veriyi çekiyoruz
            var products = await _context.Products
                .Include(p => p.ProductProperties)
                .Where(p => p.IsActive)
                .ToListAsync();
                
            ViewBag.LowStockCount = products.Count(p => p.GetTotalStock() < 10);
                
            // Kategori istatistikleri
            ViewBag.CategoriesCount = await _context.Categories.CountAsync();
            ViewBag.SubCategoriesCount = await _context.SubCategories.CountAsync();
            
            // Sipariş istatistikleri
            var orders = await _context.Orders.ToListAsync();
            
            // Debug için sipariş detaylarını kontrol et
            foreach (var order in orders)
            {
                System.Diagnostics.Debug.WriteLine($"Sipariş ID: {order.Id}, Durum: {order.Status}, Tarih: {order.CreatedDate}");
            }
            
            // Sipariş sayılarını yeniden hesapla
            ViewBag.NewOrdersCount = orders.Count;
            ViewBag.ShippingOrdersCount = orders.Count(o => o.Status == Core.Enums.OrderStatus.Shipped);
            
            // Kullanıcı istatistikleri
            ViewBag.TotalUsersCount = await _context.Users.CountAsync();
            ViewBag.NewUsersCount = await _context.Users
                .Where(u => u.CreateDate >= DateTime.Now.AddDays(-7))
                .CountAsync();
                
            // Marka istatistikleri
            ViewBag.BrandsCount = await _context.Brands.CountAsync();
            
            // Çok satan markaları hesapla
            var topSellerBrands = await _context.OrderItems
                .Include(oi => oi.Product)
                .ThenInclude(p => p.Brand)
                .Where(oi => oi.Product.Brand != null)
                .GroupBy(oi => oi.Product.BrandId)
                .Select(g => new { BrandId = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .Take(10)
                .CountAsync();
                
            ViewBag.TopSellerBrandsCount = topSellerBrands;
            
            // Gelir istatistikleri
            var monthlyOrders = orders.Where(o => o.CreatedDate >= DateTime.Now.AddMonths(-1));
            var monthlyRevenue = monthlyOrders.Sum(o => o.TotalAmount);
            ViewBag.MonthlyRevenue = monthlyRevenue.ToString("0.#K");
            ViewBag.MonthlyOrdersCount = monthlyOrders.Count();
            
            // Günlük istatistikler
            var todayOrders = orders.Where(o => o.CreatedDate == DateTime.Today);
            var todayRevenue = todayOrders.Sum(o => o.TotalAmount);
            ViewBag.TodayRevenue = todayRevenue.ToString("0.#K");
            
            return View();
        }

        [HttpGet]
        [Route("Products")]
        public async Task<IActionResult> Products()
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

            return RedirectToAction(nameof(Products));
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
        [Route("LoadMoreProducts")]
        public async Task<IActionResult> LoadMoreProducts(int page = 1, int pageSize = 30, string productCode = "")
        {
            try
            {
                var query = _context.Products
                    .Include(p => p.SubCategory)
                        .ThenInclude(sc => sc.Category)
                    .Include(p => p.Brand)
                    .Include(p => p.Images)
                    .Include(p => p.ProductProperties)
                    .Where(p => !p.IsDeleted)
                    .AsQueryable();
                
                // Ürün kodu ile filtreleme
                if (!string.IsNullOrEmpty(productCode) && int.TryParse(productCode, out int productNum))
                {
                    query = query.Where(p => p.ProductCode == productNum);
                }

                var totalCount = await query.CountAsync();
                
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
                    Stock = p.ProductProperties != null && p.ProductProperties.Any() ? 
                        p.GetTotalStock() : 0,
                    Rating = p.Rating,
                    Status = p.IsActive ? "Published" : "Draft",
                    ImageUrl = p.Images?.FirstOrDefault()?.Path != null ? 
                        $"/{p.Images.FirstOrDefault().Path}" : 
                        "/img/ProductsPicture/default.jpg",
                    CategoryId = p.SubCategory?.CategoryId ?? 0,
                    CategoryName = p.SubCategory?.Category?.Name ?? "Kategorisiz",
                    SubCategoryId = p.SubCategoryId ?? 0,
                    SubCategoryName = p.SubCategory?.Name ?? "Alt Kategorisiz",
                    BrandId = p.BrandId,
                    BrandName = p.Brand?.Name ?? "Markasız",
                    ProductCode = p.ProductCode,
                    IsActive = p.IsActive,
                    Description = p.Description ?? ""
                }).ToList();

                bool hasMore = page * pageSize < totalCount;

                return Json(new { 
                    products = viewModel, 
                    hasMore,
                    totalCount,
                    currentPage = page
                });
            }
            catch (Exception ex)
            {
                return BadRequest($"Ürünler yüklenirken hata oluştu: {ex.Message}");
            }
        }

       

        [HttpGet]
        [Route("Orders")]
        public async Task<IActionResult> Orders(int? status = null)
        {
            try
            {
                var query = _context.Orders
                    .Include(o => o.User)
                    .Include(o => o.OrderItems)
                    .AsQueryable();
                
                // Durum filtresini uygula
                if (status.HasValue)
                {
                    query = query.Where(o => (int)o.Status == status.Value);
                }
                
                var orders = await query
                    .OrderByDescending(o => o.OrderDate)
                    .ToListAsync();

                return View("Order/Index", orders);
            }
            catch (Exception ex)
            {
                // Hata durumunda boş liste gönderiyoruz, böylece sayfa hata vermeden açılır
                return View("Order/Index", new List<Order>());
            }
        }
        
        [HttpGet]
        [Route("GetOrderDetails/{id}")]
        public async Task<IActionResult> GetOrderDetails(int id)
        {
            try
            {
                var order = await _context.Orders
                    .Include(o => o.User)
                    .Include(o => o.OrderItems)
                        .ThenInclude(oi => oi.Product)
                            .ThenInclude(p => p.Images)
                    .Include(o => o.ShippingAddress)
                    .Include(o => o.BillingAddress)
                    .FirstOrDefaultAsync(o => o.Id == id);

                if (order == null)
                {
                    return PartialView("_OrderNotFound");
                }

                return PartialView("_OrderDetails", order);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Sipariş detayları yüklenirken bir hata oluştu." });
            }
        }
        
        [HttpGet]
        [Route("GetOrderStatus/{id}")]
        public async Task<IActionResult> GetOrderStatus(int id)
        {
            try
            {
                var order = await _context.Orders.FindAsync(id);
                if (order == null)
                {
                    return Json(new { success = false, message = "Sipariş bulunamadı" });
                }

                return Json(new { success = true, status = (int)order.Status });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
        
        [HttpPost]
        [Route("UpdateOrderStatus")]
        public async Task<IActionResult> UpdateOrderStatus(int orderId, int status, string note)
        {
            try
            {
                var order = await _context.Orders.FindAsync(orderId);
                if (order == null)
                {
                    return Json(new { success = false, message = "Sipariş bulunamadı" });
                }

                order.Status = (Core.Enums.OrderStatus)status;
                // Not işleme eklenebilir
                
                await _context.SaveChangesAsync();
                
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
        
        [HttpGet]
        [Route("PrintOrder/{id}")]
        public async Task<IActionResult> PrintOrder(int id)
        {
            try
            {
                var order = await _context.Orders
                    .Include(o => o.User)
                    .Include(o => o.OrderItems)
                        .ThenInclude(oi => oi.Product)
                    .Include(o => o.ShippingAddress)
                    .Include(o => o.BillingAddress)
                    .FirstOrDefaultAsync(o => o.Id == id);

                if (order == null)
                {
                    return NotFound();
                }

                return View("PrintOrder", order);
            }
            catch (Exception ex)
            {
                return View("Error", ex.Message);
            }
        }

       

        [HttpGet]
        [Route("ProductsUpdate/{id}")]
        public IActionResult ProductsUpdate(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Products");
            }
            return View("~/Areas/Admin/Views/Product/Edit.cshtml");
        }
    }
} 