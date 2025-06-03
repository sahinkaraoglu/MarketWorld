using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using MarketWorld.Web.Attributes;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Core.Interfaces.Services;

namespace MarketWorld.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
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

        public async Task<IActionResult> EditAddress(int id)
        {
            var userId = HttpContext.Items["UserId"].ToString();

            var address = await _accountService.GetAddressByIdAsync(id, userId);

            if (address == null)
            {
                return NotFound();
            }

            return View("~/Views/Account/Address/Edit.cshtml", address);
        }

        [HttpPost]
        public async Task<IActionResult> EditAddress(Address address)
        {
            var userId = HttpContext.Items["UserId"].ToString();
            address.UserId = userId;

            if (ModelState.IsValid)
            {
                var result = await _accountService.UpdateAddressAsync(address);
                if (result)
                {
                    return RedirectToAction("Addresses");
                }
            }

            return View("~/Views/Account/Address/Edit.cshtml", address);
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

            if (user != null)
            {
                ViewBag.UserProfile = new
                {
                    FirstName = user.FirstName ?? "Kullanıcı",
                    LastName = user.LastName ?? "",
                    Email = user.Email ?? ""
                };
            }

            return View("~/Views/Account/Order/Index.cshtml");
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