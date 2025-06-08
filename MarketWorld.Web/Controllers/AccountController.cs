using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using MarketWorld.Web.Attributes;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Application.Services.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using MarketWorld.Core.Enums;

namespace MarketWorld.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IOrderService _orderService;
        private readonly ILogger<AccountController> _logger;

        public AccountController(IAccountService accountService, IOrderService orderService, ILogger<AccountController> logger)
        {
            _accountService = accountService;
            _orderService = orderService;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var userId = HttpContext.Items["UserId"].ToString();

            var user = await _accountService.GetUserByIdAsync(userId);

            if (user != null)
            {
                ViewBag.UserId = userId;
                ViewBag.FirstName = user.FirstName;
                ViewBag.LastName = user.LastName;
                ViewBag.Email = user.Email;
                ViewBag.Phone = user.PhoneNumber;
                ViewBag.CreateDate = user.CreateDate.ToString("dd.MM.yyyy");
            }
            else
            {
                ViewBag.UserId = userId;
            }

            return View("~/Views/Account/Profile/Index.cshtml");
        }

        public async Task<IActionResult> Addresses()
        {
            var userId = HttpContext.Items["UserId"].ToString();

            var user = await _accountService.GetUserByIdAsync(userId);
            var userAddresses = await _accountService.GetUserAddressesAsync(userId);
            
            if (user != null)
            {
                ViewBag.UserFirstName = user.FirstName;
                ViewBag.UserLastName = user.LastName;
                ViewBag.UserEmail = user.Email;
            }
            else
            {
                ViewBag.UserFirstName = "Kullanıcı";
                ViewBag.UserLastName = "";
                ViewBag.UserEmail = "";
            }

            return View("~/Views/Account/Address/Index.cshtml", userAddresses);
        }

        public IActionResult AddAddress()
        {
            return View("~/Views/Account/Address/Create.cshtml");
        }

        [HttpPost]
        [ActionName("AddAddress")]
        public async Task<IActionResult> AddAddressPost()
        {
            var userId = HttpContext.Items["UserId"].ToString();

            var title = Request.Form["Title"].ToString();
            var fullAddress = Request.Form["FullAddress"].ToString();
            var city = Request.Form["City"].ToString();
            var district = Request.Form["District"].ToString();
            var phone = Request.Form["Phone"].ToString();

            bool isValid = true;
            if (string.IsNullOrWhiteSpace(title))
            {
                ModelState.AddModelError("Title", "Adres başlığı boş olamaz");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(fullAddress))
            {
                ModelState.AddModelError("FullAddress", "Açık adres boş olamaz");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(city))
            {
                ModelState.AddModelError("City", "İl seçimi yapılmalıdır");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(district))
            {
                ModelState.AddModelError("District", "İlçe seçimi yapılmalıdır");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                ModelState.AddModelError("Phone", "Telefon numarası boş olamaz");
                isValid = false;
            }

            if (!isValid)
            {
                ViewBag.Error = "Lütfen tüm zorunlu alanları doldurun";
                return View("~/Views/Account/Address/Create.cshtml");
            }

            Enum.TryParse<Core.Enums.AddressType>(Request.Form["AddressType"], out var addressType);
            bool.TryParse(Request.Form["IsDefault"], out var isDefault);

            try
            {
                var address = new Address
                {
                    UserId = userId,
                    Title = title,
                    FullAddress = fullAddress,
                    City = city,
                    District = district,
                    Phone = phone,
                    Country = "Türkiye",
                    AddressType = addressType,
                    IsDefault = isDefault,
                    CreatedDate = DateTime.Now
                };

                var result = await _accountService.AddAddressAsync(address);

                if (result)
                {
                    return RedirectToAction("Addresses");
                }
                else
                {
                    ViewBag.Error = "Adres kaydedilirken bir hata oluştu";
                    return View("~/Views/Account/Address/Create.cshtml");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Adres kaydı sırasında bir hata oluştu: " + ex.Message;
                return View("~/Views/Account/Address/Create.cshtml");
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditAddress(int id)
        {
            try
            {
                var userId = HttpContext.Items["UserId"].ToString();
                var address = await _accountService.GetAddressByIdAsync(id, userId);

                if (address == null)
                {
                    _logger.LogWarning($"Address not found. AddressId: {id}, UserId: {userId}");
                    return NotFound();
                }

                // Adres detaylarını kontrol et ve varsayılan değerleri ata
                if (string.IsNullOrEmpty(address.FullName))
                {
                    var user = await _accountService.GetUserByIdAsync(userId);
                    address.FullName = $"{user.FirstName} {user.LastName}".Trim();
                }

                if (string.IsNullOrEmpty(address.PostalCode))
                {
                    address.PostalCode = "34000"; // Varsayılan posta kodu
                }

                if (string.IsNullOrEmpty(address.Country))
                {
                    address.Country = "Türkiye";
                }

                _logger.LogInformation($"EditAddress view loaded successfully. AddressId: {id}");
                return View("~/Views/Account/Address/Edit.cshtml", address);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error loading EditAddress view. AddressId: {id}");
                return View("Error");
            }
        }

        [HttpPost]
        [ActionName("EditAddress")]
        public async Task<IActionResult> EditAddressPost(int id)
        {
            try
            {
                var address = new Address
                {
                    Id = id,
                    UserId = HttpContext.Items["UserId"].ToString(),
                    FullName = Request.Form["FullName"].ToString(),
                    Title = Request.Form["Title"].ToString(),
                    FullAddress = Request.Form["FullAddress"].ToString(),
                    City = Request.Form["City"].ToString(),
                    District = Request.Form["District"].ToString(),
                    Phone = Request.Form["Phone"].ToString(),
                    PostalCode = Request.Form["PostalCode"].ToString(),
                    Country = Request.Form["Country"].ToString(),
                    AddressType = (AddressType)int.Parse(Request.Form["AddressType"].ToString()),
                    IsDefault = bool.Parse(Request.Form["IsDefault"].ToString()),
                    UpdatedDate = DateTime.Now
                };

                if (!ModelState.IsValid)
                {
                    var errors = string.Join(", ", ModelState.Values
                        .SelectMany(v => v.Errors)
                        .Select(e => e.ErrorMessage));
                    _logger.LogError($"Model validation failed: {errors}");
                    return Json(new { success = false, message = errors });
                }

                var result = await _accountService.UpdateAddressAsync(address);
                if (result)
                {
                    _logger.LogInformation($"Address updated successfully. AddressId: {id}");
                    return RedirectToAction(nameof(Addresses));
                }

                _logger.LogWarning($"Address update failed. AddressId: {id}");
                return Json(new { success = false, message = "Adres güncellenirken bir hata oluştu." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error updating address. AddressId: {id}");
                return Json(new { success = false, message = $"Bir hata oluştu: {ex.Message}" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            var userId = HttpContext.Items["UserId"].ToString();

            var result = await _accountService.DeleteAddressAsync(id, userId);
            if (!result)
            {
                return NotFound();
            }

            return RedirectToAction("Addresses");
        }

        public async Task<IActionResult> Orders()
        {
            var userId = HttpContext.Items["UserId"].ToString();

            var user = await _accountService.GetUserByIdAsync(userId);
            var orders = await _orderService.GetUserOrdersAsync(userId);

            if (user != null)
            {
                ViewBag.UserProfile = new
                {
                    FirstName = user.FirstName ?? "Kullanıcı",
                    LastName = user.LastName ?? "",
                    Email = user.Email ?? ""
                };
            }

            return View("~/Views/Account/Order/Index.cshtml", orders);
        }

        public async Task<IActionResult> Edit()
        {
            var userId = HttpContext.Items["UserId"].ToString();

            // Kullanıcı bilgilerini veritabanından al
            var user = await _accountService.GetUserByIdAsync(userId);

            if (user != null)
            {
                // Veritabanından gelen bilgileri ViewBag ile view'e aktar
                ViewBag.UserId = userId;
                ViewBag.FirstName = user.FirstName;
                ViewBag.LastName = user.LastName;
                ViewBag.Email = user.Email;
                ViewBag.Phone = user.PhoneNumber;
                ViewBag.CreateDate = user.CreateDate.ToString("dd.MM.yyyy");
            }
            else
            {
                ViewBag.UserId = userId;
            }

            return View("~/Views/Account/Profile/Edit.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string FirstName, string LastName, string Email, string Phone)
        {
            var userId = HttpContext.Items["UserId"].ToString();

            // Kullanıcı bilgilerini veritabanından al
            var user = await _accountService.GetUserByIdAsync(userId);

            if (user == null)
            {
                ViewBag.Error = "Kullanıcı bulunamadı.";
                return View("~/Views/Account/Profile/Edit.cshtml");
            }

            // Validasyon kontrolleri
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(FirstName))
            {
                ModelState.AddModelError("FirstName", "Ad alanı boş olamaz");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(LastName))
            {
                ModelState.AddModelError("LastName", "Soyad alanı boş olamaz");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(Email))
            {
                ModelState.AddModelError("Email", "E-posta alanı boş olamaz");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(Phone))
            {
                ModelState.AddModelError("Phone", "Telefon alanı boş olamaz");
                isValid = false;
            }

            if (!isValid)
            {
                ViewBag.Error = "Lütfen tüm zorunlu alanları doldurun";
                ViewBag.UserId = userId;
                ViewBag.FirstName = FirstName;
                ViewBag.LastName = LastName;
                ViewBag.Email = Email;
                ViewBag.Phone = Phone;
                return View("~/Views/Account/Profile/Edit.cshtml");
            }

            try
            {
                // Kullanıcı bilgilerini güncelle
                user.FirstName = FirstName;
                user.LastName = LastName;
                user.Email = Email;
                user.PhoneNumber = Phone;
                user.CreateDate = DateTime.Now;

                await _accountService.UpdateUserAsync(user);

                // Başarılı mesajını ekle
                ViewBag.Success = "Hesap bilgileriniz başarıyla güncellendi.";
                
                // Güncellenmiş bilgileri ViewBag'e ekle
                ViewBag.UserId = userId;
                ViewBag.FirstName = user.FirstName;
                ViewBag.LastName = user.LastName;
                ViewBag.Email = user.Email;
                ViewBag.Phone = user.PhoneNumber;
                ViewBag.CreateDate = user.CreateDate.ToString("dd.MM.yyyy");
                
                return View("~/Views/Account/Profile/Edit.cshtml");
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Bilgiler güncellenirken bir hata oluştu: " + ex.Message;
                ViewBag.UserId = userId;
                ViewBag.FirstName = FirstName;
                ViewBag.LastName = LastName;
                ViewBag.Email = Email;
                ViewBag.Phone = Phone;
                return View("~/Views/Account/Profile/Edit.cshtml");
            }
        }
    }
} 