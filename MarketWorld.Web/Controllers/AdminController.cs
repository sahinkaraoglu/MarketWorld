using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Infrastructure.Data;
using MarketWorld.Domain.Entities;
using MarketWorld.Web.Models.Admin;

namespace MarketWorld.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly MarketWorldDbContext _context;

        public AdminController(MarketWorldDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Products()
        {
            var products = await _context.Products
                .Include(p => p.SubCategory)
                    .ThenInclude(sc => sc.Category)
                .Include(p => p.Brand)
                .ToListAsync();

            var viewModel = products.Select(p => new ProductAdminViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Stock = p.Stock,
                CategoryId = p.SubCategory?.CategoryId ?? 0,
                CategoryName = p.SubCategory?.Category?.Name ?? "Kategorisiz",
                SubCategoryId = p.SubCategoryId ?? 0,
                SubCategoryName = p.SubCategory?.Name ?? "Alt Kategorisiz",
                BrandId = p.BrandId,
                BrandName = p.Brand?.Name ?? "Markasız"
            }).ToList();

            return View(viewModel);
        }

        public async Task<IActionResult> Categories()
        {
            var categories = await _context.Categories
                .Include(c => c.SubCategories)
                .ToListAsync();

            return View(categories);
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            try
            {
                var categories = await _context.Categories
                    .Select(c => new { id = c.Id, name = c.Name })
                    .ToListAsync();

                System.Diagnostics.Debug.WriteLine($"Bulunan kategori sayısı: {categories.Count}");
                return Json(categories);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Kategori getirme hatası: {ex.Message}");
                return Json(new { error = ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetBrands()
        {
            var brands = await _context.Brands
                .Select(b => new { id = b.Id, name = b.Name })
                .ToListAsync();
            return Json(brands);
        }

        [HttpGet]
        [Route("Admin/GetSubCategories/{categoryId}")]
        public async Task<IActionResult> GetSubCategories(int categoryId)
        {
            try
            {
                var category = await _context.Categories
                    .Include(c => c.SubCategories)
                    .FirstOrDefaultAsync(c => c.Id == categoryId);

                if (category == null)
                {
                    return NotFound($"Kategori bulunamadı: {categoryId}");
                }

                var subCategories = category.SubCategories
                    .Where(sc => !sc.IsDeleted)
                    .Select(sc => new { id = sc.Id, name = sc.Name })
                    .ToList();

                return Json(subCategories);
            }
            catch (Exception ex)
            {
                return BadRequest($"Alt kategoriler getirilirken hata oluştu: {ex.Message}");
            }
        }

        [HttpPost]
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
                Stock = model.Stock,
                Description = model.Description,
                IsActive = model.IsActive,
                HasDiscount = model.HasDiscount,
                SubCategoryId = model.SubCategoryId,
                CreatedDate = DateTime.Now,
                Images = new List<Image>()
            };

            if (model.Images != null && model.Images.Any())
            {
                foreach (var imageFile in model.Images)
                {
                    if (imageFile.Length > 0)
                    {
                        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                        var filePath = Path.Combine("wwwroot", "img", "products", fileName);

                        // Dizin yoksa oluştur
                        Directory.CreateDirectory(Path.Combine("wwwroot", "img", "products"));

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await imageFile.CopyToAsync(stream);
                        }

                        product.Images.Add(new Image
                        {
                            Path = $"img/products/{fileName}",
                            EntityId = product.Id
                        });
                    }
                }
            }

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Products));
        }

        [HttpGet]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _context.Products
                .Include(p => p.SubCategory)
                    .ThenInclude(sc => sc.Category)
                .Include(p => p.Brand)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
                return NotFound();

            var viewModel = new ProductAdminViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock,
                CategoryId = product.SubCategory?.CategoryId ?? 0,
                SubCategoryId = product.SubCategoryId ?? 0,
                BrandId = product.BrandId
            };

            return Json(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductAdminViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var product = await _context.Products.FindAsync(model.Id);
            if (product == null)
                return NotFound();

            product.Name = model.Name;
            product.BrandId = model.BrandId;
            product.SubCategoryId = model.SubCategoryId;
            product.Price = model.Price;
            product.Stock = model.Stock;

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
                return NotFound();

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
} 