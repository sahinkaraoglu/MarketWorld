using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Infrastructure.Context;
using MarketWorld.Web.Areas.Admin.Models.Panel;
using MarketWorld.Application.Services.Interfaces;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace MarketWorld.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IPropertyTypeService _propertyTypeService;
        private readonly IPropertyValueService _propertyValueService;
        private readonly IDistributedCache _cache;
        private readonly JsonSerializerOptions _jsonOptions;

        public ProductController(
            IProductService productService,
            IPropertyTypeService propertyTypeService,
            IPropertyValueService propertyValueService,
            IDistributedCache cache)
        {
            _productService = productService;
            _propertyTypeService = propertyTypeService;
            _propertyValueService = propertyValueService;
            _cache = cache;
            _jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        [HttpGet]
        [Route("")]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAllProducts();
            ViewBag.TotalProducts = products.Count();
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
            var products = await _productService.GetAllProducts();
            while (products.Any(p => p.ProductCode == product.ProductCode))
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

            await _productService.CreateProduct(product);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Route("Products")]
        public async Task<IActionResult> Products()
        {
            string cacheKey = "admin_products_list";
            string cachedProducts = await _cache.GetStringAsync(cacheKey);

            if (!string.IsNullOrEmpty(cachedProducts))
            {
                var cachedResult = JsonSerializer.Deserialize<List<ProductAdminViewModel>>(cachedProducts, _jsonOptions);
                ViewBag.TotalProducts = cachedResult.Count;
                return View("~/Areas/Admin/Views/Product/Index.cshtml", cachedResult);
            }

            var products = await _productService.GetAllProducts();
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

            ViewBag.TotalProducts = viewModel.Count;

            var cacheOptions = new DistributedCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromMinutes(10))
                .SetAbsoluteExpiration(TimeSpan.FromHours(1));

            await _cache.SetStringAsync(
                cacheKey,
                JsonSerializer.Serialize(viewModel, _jsonOptions),
                cacheOptions
            );

            return View("~/Areas/Admin/Views/Product/Index.cshtml", viewModel);
        }

        [HttpGet]
        [Route("GetProduct/{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _productService.GetProductById(id);

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

            var product = await _productService.GetProductById(model.Id);
                
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
                var products = await _productService.GetAllProducts();
                while (products.Any(p => p.Id != product.Id && p.ProductCode == product.ProductCode))
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

            await _productService.UpdateProduct(product);
            return Ok();
        }

        [HttpPost]
        [Route("DeleteProduct/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productService.DeleteProduct(id);
            return Ok();
        }

        [HttpGet]
        [Route("GetProducts")]
        public async Task<IActionResult> GetProducts(int page = 1, int pageSize = 30, string productCode = "", string status = "")
        {
            try
            {
                var products = await _productService.GetAllProducts();
                
                // Ürün kodu ile filtreleme
                if (!string.IsNullOrEmpty(productCode) && int.TryParse(productCode, out int productNum))
                {
                    products = products.Where(p => p.ProductCode == productNum);
                }

                // Durum ile filtreleme
                if (!string.IsNullOrEmpty(status))
                {
                    if (status == "active")
                    {
                        products = products.Where(p => p.IsActive);
                    }
                    else if (status == "inactive")
                    {
                        products = products.Where(p => !p.IsActive);
                    }
                }

                var totalProducts = products.Count();
                var totalPages = (int)Math.Ceiling(totalProducts / (double)pageSize);
                
                var pagedProducts = products
                    .OrderBy(p => p.Id)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize);

                var viewModel = pagedProducts.Select(p => new ProductAdminViewModel
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
            var propertyTypes = await _propertyTypeService.GetAllPropertyTypesAsync();
            var result = propertyTypes
                .Where(pt => pt.IsActive && !pt.IsDeleted)
                .Select(pt => new { id = pt.Id, name = pt.Name })
                .ToList();

            return Json(result);
        }

        [HttpGet]
        [Route("GetPropertyValues/{propertyTypeId}")]
        public async Task<IActionResult> GetPropertyValues(int propertyTypeId)
        {
            try
            {
                var propertyValues = await _propertyValueService.GetPropertyValuesByTypeIdAsync(propertyTypeId);
                var result = propertyValues
                    .Where(pv => pv.IsActive && !pv.IsDeleted)
                    .Select(pv => new { id = pv.Id, value = pv.Value })
                    .ToList();

                return Json(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Özellik değerleri getirilirken hata oluştu: {ex.Message}");
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

        [HttpGet]
        [Route("LoadMoreProducts")]
        public async Task<IActionResult> LoadMoreProducts(int page = 1, int pageSize = 30, string productCode = "")
        {
            try
            {
                var products = await _productService.GetAllProducts();

                // Ürün kodu ile filtreleme
                if (!string.IsNullOrEmpty(productCode) && int.TryParse(productCode, out int productNum))
                {
                    products = products.Where(p => p.ProductCode == productNum);
                }

                var totalCount = products.Count();

                var pagedProducts = products
                    .OrderBy(p => p.Id)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize);

                var viewModel = pagedProducts.Select(p => new ProductAdminViewModel
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

                return Json(new
                {
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

    }
}