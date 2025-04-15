using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Infrastructure.Data;
using MarketWorld.Domain.Entities;
using MarketWorld.Web.Models.Admin;

namespace MarketWorld.Web.Controllers
{
    public class PanelController : Controller
    {
        private readonly MarketWorldDbContext _context;

        public PanelController(MarketWorldDbContext context)
        {
            _context = context;
        }

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
            ViewBag.ShippingOrdersCount = orders.Count(o => o.Status == MarketWorld.Domain.Enums.OrderStatus.Shipped);
            
            // Kullanıcı istatistikleri
            ViewBag.TotalUsersCount = await _context.Users.CountAsync();
            ViewBag.NewUsersCount = await _context.Users
                .Where(u => u.CreatedDate >= DateTime.Now.AddDays(-7))
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

        public async Task<IActionResult> Products()
        {
            var products = await _context.Products
                .Include(p => p.SubCategory)
                    .ThenInclude(sc => sc.Category)
                .Include(p => p.Brand)
                .Include(p => p.Images)
                .Include(p => p.ProductProperties)
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
                ProductNumber = p.ProductNumber
            }).ToList();

            return View(viewModel);
        }

        public async Task<IActionResult> Categories()
        {
            var categories = await _context.Categories
                .Include(c => c.SubCategories)
                    .ThenInclude(sc => sc.Products)
                .Include(c => c.Products)
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
        [Route("Panel/GetSubCategories/{categoryId}")]
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
                Description = model.Description,
                IsActive = model.IsActive,
                HasDiscount = model.HasDiscount,
                SubCategoryId = model.SubCategoryId,
                CreatedDate = DateTime.Now,
                Images = new List<Image>(),
                ProductProperties = new List<ProductProperty>()
            };
            
            product.GenerateRandomProductNumber();
            
            // Veritabanında var mı kontrol et ve benzersiz olana kadar tekrar oluştur
            while (await _context.Products.AnyAsync(p => p.ProductNumber == product.ProductNumber))
            {
                product.GenerateRandomProductNumber();
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
                Stock = product.ProductProperties != null && product.ProductProperties.Any() ? 
                    product.GetTotalStock() : 0,
                CategoryId = product.SubCategory?.CategoryId ?? 0,
                SubCategoryId = product.SubCategoryId ?? 0,
                BrandId = product.BrandId,
                ProductNumber = product.ProductNumber
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
            
            // Eğer ProductNumber yoksa veya boşsa yeni oluştur
            if (string.IsNullOrEmpty(product.ProductNumber) || product.ProductNumber == "000000")
            {
                product.GenerateRandomProductNumber();
                
                // Veritabanında var mı kontrol et ve benzersiz olana kadar tekrar oluştur
                while (await _context.Products.AnyAsync(p => p.Id != product.Id && p.ProductNumber == product.ProductNumber))
                {
                    product.GenerateRandomProductNumber();
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
                    IsActive = true
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
        public async Task<IActionResult> GetPropertyTypes()
        {
            var propertyTypes = await _context.PropertyTypes
                .Where(pt => pt.IsActive && !pt.IsDeleted)
                .Select(pt => new { id = pt.Id, name = pt.Name })
                .ToListAsync();

            return Json(propertyTypes);
        }

        [HttpGet]
        [Route("Panel/GetPropertyValues/{propertyTypeId}")]
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
        public async Task<IActionResult> GetProducts(int page = 1, int pageSize = 30, string productNumber = "", string status = "")
        {
            try
            {
                var query = _context.Products
                    .Include(p => p.SubCategory)
                        .ThenInclude(sc => sc.Category)
                    .Include(p => p.Brand)
                    .Include(p => p.Images)
                    .Include(p => p.ProductProperties)
                    .AsQueryable();
                
                // Ürün kodu ile filtreleme
                if (!string.IsNullOrEmpty(productNumber))
                {
                    query = query.Where(p => p.ProductNumber.Contains(productNumber));
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
                    ProductNumber = p.ProductNumber
                }).ToList();

                return Json(new { 
                    products = viewModel, 
                    totalPages = totalPages,
                    totalProducts = totalProducts,
                    currentPage = page
                });
            }
            catch (Exception ex)
            {
                return BadRequest($"Ürünler yüklenirken bir hata oluştu: {ex.Message}");
            }
        }

        [HttpGet]
        public async Task<IActionResult> LoadMoreProducts(int page = 1, int pageSize = 30, string productNumber = "")
        {
            try
            {
                var query = _context.Products
                    .Include(p => p.SubCategory)
                        .ThenInclude(sc => sc.Category)
                    .Include(p => p.Brand)
                    .Include(p => p.Images)
                    .Include(p => p.ProductProperties)
                    .AsQueryable();
                
                // Ürün kodu ile filtreleme
                if (!string.IsNullOrEmpty(productNumber))
                {
                    query = query.Where(p => p.ProductNumber.Contains(productNumber));
                }

                var totalCount = await query.CountAsync();
                
                var products = await query
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
                    ProductNumber = p.ProductNumber
                }).ToList();

                bool hasMore = (page * pageSize) < totalCount;

                return Json(new { 
                    products = viewModel, 
                    hasMore = hasMore,
                    totalCount = totalCount,
                    currentPage = page
                });
            }
            catch (Exception ex)
            {
                return BadRequest($"Ürünler yüklenirken hata oluştu: {ex.Message}");
            }
        }

        [HttpPost]
        [Route("Panel/DeleteCategory/{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            try
            {
                var category = await _context.Categories
                    .Include(c => c.SubCategories)
                    .Include(c => c.Products)
                    .FirstOrDefaultAsync(c => c.Id == id);

                if (category == null)
                {
                    return Json(new { success = false, message = "Kategori bulunamadı" });
                }

                // Alt kategorileri veya ürünleri olan bir kategori silinememeli
                if ((category.SubCategories != null && category.SubCategories.Any()) || 
                    (category.Products != null && category.Products.Any()))
                {
                    return Json(new { 
                        success = false, 
                        message = "Bu kategorinin alt kategorileri veya ürünleri bulunmaktadır. Önce bunları silmelisiniz." 
                    });
                }

                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        [Route("Panel/DeleteSubCategory/{id}")]
        public async Task<IActionResult> DeleteSubCategory(int id)
        {
            try
            {
                var subCategory = await _context.SubCategories
                    .Include(sc => sc.Products)
                    .FirstOrDefaultAsync(sc => sc.Id == id);

                if (subCategory == null)
                {
                    return Json(new { success = false, message = "Alt kategori bulunamadı" });
                }

                // Ürünleri olan bir alt kategori silinememeli
                if (subCategory.Products != null && subCategory.Products.Any())
                {
                    return Json(new { 
                        success = false, 
                        message = "Bu alt kategorinin ürünleri bulunmaktadır. Önce ürünleri silmelisiniz." 
                    });
                }

                _context.SubCategories.Remove(subCategory);
                await _context.SaveChangesAsync();

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

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

                return View(orders);
            }
            catch (Exception ex)
            {
                // Hata durumunda boş liste gönderiyoruz, böylece sayfa hata vermeden açılır
                return View(new List<Order>());
            }
        }
        
        [HttpGet]
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
        public async Task<IActionResult> UpdateOrderStatus(int orderId, int status, string note)
        {
            try
            {
                var order = await _context.Orders.FindAsync(orderId);
                if (order == null)
                {
                    return Json(new { success = false, message = "Sipariş bulunamadı" });
                }

                order.Status = (MarketWorld.Domain.Enums.OrderStatus)status;
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
    }
} 