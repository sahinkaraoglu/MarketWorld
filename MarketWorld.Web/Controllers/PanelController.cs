using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Infrastructure.Data;
using MarketWorld.Domain.Entities;
using MarketWorld.Web.Models.Admin;
using MarketWorld.Web.Models;
using Microsoft.AspNetCore.Identity;

namespace MarketWorld.Web.Controllers
{
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
                ProductCode = p.ProductCode
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

        public async Task<IActionResult> Brands(int page = 1, int pageSize = 20)
        {
            // Aktif ve toplam marka sayılarını hesapla
            ViewBag.TotalBrandsCount = await _context.Brands.CountAsync();
            ViewBag.ActiveBrandsCount = await _context.Brands.Where(b => !b.IsDeleted).CountAsync();
            
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
            
            // Toplam sayfa sayısını hesapla
            var totalBrands = await _context.Brands.CountAsync();
            var totalPages = (int)Math.Ceiling(totalBrands / (double)pageSize);
            
            // Markaları sayfalayarak getir
            var brands = await _context.Brands
                .Include(b => b.Products)
                .OrderBy(b => b.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            
            // Sayfalama bilgilerini ViewBag'e ekle
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.PageSize = pageSize;
                
            return View(brands);
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
                ProductCode = product.ProductCode
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
        public async Task<IActionResult> GetProducts(int page = 1, int pageSize = 30, string productCode = "", string status = "")
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
                    ProductCode = p.ProductCode
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
                    .AsQueryable();
                
                // Ürün kodu ile filtreleme
                if (!string.IsNullOrEmpty(productCode) && int.TryParse(productCode, out int productNum))
                {
                    query = query.Where(p => p.ProductCode == productNum);
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
                    ProductCode = p.ProductCode
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

        // Kullanıcı listesi sayfası
        public async Task<IActionResult> Users()
        {
            var users = await _userManager.Users
                .Select(u => new UserViewModel
                {
                    Id = u.Id,
                    Username = u.UserName,
                    Email = u.Email,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Role = _context.UserRoles
                        .Join(_context.Roles, ur => ur.RoleId, r => r.Id, (ur, r) => new { ur, r })
                        .Where(x => x.ur.UserId == u.Id)
                        .Select(x => x.r.Name)
                        .FirstOrDefault() ?? "Kullanıcı",
                    IsActive = u.IsActive,
                    RegistrationDate = u.CreateDate
                })
                .ToListAsync();
            
            // Kullanıcı istatistikleri
            ViewBag.TotalUsersCount = users.Count();
            ViewBag.ActiveUsersCount = users.Count(u => u.IsActive);
            ViewBag.NewUsersCount = users.Count(u => u.RegistrationDate >= DateTime.Now.AddDays(-30));
            
            return View(users);
        }

        // Kullanıcı bilgilerini getir
        [HttpGet]
        [Route("Panel/GetUser/{id}")]
        public async Task<IActionResult> GetUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            
            if (user == null)
            {
                return NotFound();
            }
            
            var userRoles = await _userManager.GetRolesAsync(user);
            var roleName = userRoles.FirstOrDefault() ?? "Kullanıcı";
            
            return Json(new
            {
                id = user.Id,
                username = user.UserName,
                email = user.Email,
                firstName = user.FirstName,
                lastName = user.LastName,
                role = roleName,
                isActive = user.IsActive
            });
        }

        // Yeni kullanıcı ekle
        [HttpPost]
        [Route("Panel/AddUser")]
        public async Task<IActionResult> AddUser([FromBody] UserViewModel model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest(new { success = false, message = "Geçersiz veri" });
                }
                
                // Yeni kullanıcı eklerken Id alanı gerekmediği için ModelState'den kaldırıyoruz
                ModelState.Remove("Id");
                
                if (!ModelState.IsValid)
                {
                    var validationErrors = string.Join(", ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
                    return BadRequest(new { success = false, message = $"Geçersiz veri: {validationErrors}" });
                }
                
                // Email ve kullanıcı adı benzersiz olmalı
                var existingUser = await _userManager.FindByEmailAsync(model.Email);
                if (existingUser != null)
                {
                    return BadRequest(new { success = false, message = "Bu email adresi zaten kullanımda" });
                }
                
                existingUser = await _userManager.FindByNameAsync(model.Username);
                if (existingUser != null)
                {
                    return BadRequest(new { success = false, message = "Bu kullanıcı adı zaten kullanımda" });
                }
                
                // Şifre doğrulama kontrolünü client tarafında da yaptık ama burada da kontrol edelim
                if (string.IsNullOrEmpty(model.Password) || model.Password != model.ConfirmPassword)
                {
                    return BadRequest(new { success = false, message = "Şifreler eşleşmiyor" });
                }
                
                // Yeni kullanıcı oluştur
                var user = new ApplicationUser
                {
                    UserName = model.Username,
                    Email = model.Email,
                    FirstName = model.FirstName ?? "",
                    LastName = model.LastName ?? "",
                    IsActive = model.IsActive,
                    EmailConfirmed = model.IsActive,
                    CreateDate = DateTime.Now
                };
                
                // Kullanıcıyı oluştur
                var result = await _userManager.CreateAsync(user, model.Password);
                
                if (result.Succeeded)
                {
                    // Rol kontrolü
                    if (string.IsNullOrEmpty(model.Role))
                    {
                        model.Role = "User"; // Varsayılan rol
                    }
                    
                    // Rol mevcut mu kontrol et
                    var roleExists = await _roleManager.RoleExistsAsync(model.Role);
                    if (!roleExists)
                    {
                        // Rol yoksa oluştur
                        await _roleManager.CreateAsync(new IdentityRole(model.Role));
                    }
                    
                    // Kullanıcıya rol atama
                    await _userManager.AddToRoleAsync(user, model.Role);
                    
                    return Json(new { success = true, message = "Kullanıcı başarıyla eklendi" });
                }
                
                var errorMessages = string.Join(", ", result.Errors.Select(e => e.Description));
                return BadRequest(new { success = false, message = errorMessages });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Sunucu hatası: {ex.Message}" });
            }
        }

        // Kullanıcı güncelle
        [HttpPost]
        [Route("Panel/UpdateUser")]
        public async Task<IActionResult> UpdateUser([FromBody] UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { success = false, message = "Geçersiz veri" });
            }
            
            var user = await _userManager.FindByIdAsync(model.Id);
            
            if (user == null)
            {
                return NotFound(new { success = false, message = "Kullanıcı bulunamadı" });
            }
            
            // Email ve kullanıcı adı benzersiz olmalı (kendisi hariç)
            var existingUser = await _userManager.FindByEmailAsync(model.Email);
            if (existingUser != null && existingUser.Id != model.Id)
            {
                return BadRequest(new { success = false, message = "Bu email adresi zaten kullanımda" });
            }
            
            existingUser = await _userManager.FindByNameAsync(model.Username);
            if (existingUser != null && existingUser.Id != model.Id)
            {
                return BadRequest(new { success = false, message = "Bu kullanıcı adı zaten kullanımda" });
            }
            
            // Kullanıcı bilgilerini güncelle
            user.UserName = model.Username;
            user.Email = model.Email;
            user.FirstName = model.FirstName ?? user.FirstName;
            user.LastName = model.LastName ?? user.LastName;
            user.IsActive = model.IsActive;
            user.EmailConfirmed = model.IsActive;
            
            // Şifre değiştirme işlemi
            if (!string.IsNullOrEmpty(model.Password))
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var passwordChangeResult = await _userManager.ResetPasswordAsync(user, token, model.Password);
                
                if (!passwordChangeResult.Succeeded)
                {
                    return BadRequest(new { success = false, message = "Şifre değiştirme işlemi başarısız: " + string.Join(", ", passwordChangeResult.Errors.Select(e => e.Description)) });
                }
            }
            
            // Kullanıcı güncelleme
            var updateResult = await _userManager.UpdateAsync(user);
            
            if (!updateResult.Succeeded)
            {
                return BadRequest(new { success = false, message = "Kullanıcı güncelleme işlemi başarısız: " + string.Join(", ", updateResult.Errors.Select(e => e.Description)) });
            }
            
            // Kullanıcı rolleri güncelleme
            var userRoles = await _userManager.GetRolesAsync(user);
            await _userManager.RemoveFromRolesAsync(user, userRoles);
            await _userManager.AddToRoleAsync(user, model.Role);
            
            return Json(new { success = true, message = "Kullanıcı başarıyla güncellendi" });
        }

        // Kullanıcı silme
        [HttpPost]
        [Route("Panel/DeleteUser/{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            
            if (user == null)
            {
                return NotFound(new { success = false, message = "Kullanıcı bulunamadı" });
            }
            
            // Kullanıcıyı silme
            var result = await _userManager.DeleteAsync(user);
            
            if (result.Succeeded)
            {
                return Json(new { success = true, message = "Kullanıcı başarıyla silindi" });
            }
            
            return BadRequest(new { success = false, message = "Kullanıcı silme işlemi başarısız: " + string.Join(", ", result.Errors.Select(e => e.Description)) });
        }
    }
} 