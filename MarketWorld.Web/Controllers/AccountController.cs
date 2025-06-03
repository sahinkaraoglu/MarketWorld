using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using System;
using MarketWorld.Infrastructure.Data.SeedData;
using MarketWorld.Web.Attributes;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Infrastructure.Context;

namespace MarketWorld.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly MarketWorldDbContext _context;

        public AccountController(MarketWorldDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var userId = HttpContext.Items["UserId"].ToString();

            // Kullanıcı bilgilerini veritabanından al
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Id == userId);

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

            return View("~/Views/Account/Profile/Index.cshtml");
        }

        public async Task<IActionResult> Addresses()
        {
            var userId = HttpContext.Items["UserId"].ToString();

            // Kullanıcı bilgilerini veritabanından al
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Id == userId);

            // Kullanıcı adreslerini getir
            var userAddresses = await _context.Addresses
                .Where(a => a.UserId == userId)
                .ToListAsync();
            
            // Kullanıcı bilgilerini ViewBag ile gönder
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

            // Form verilerini alıyoruz
            var title = Request.Form["Title"].ToString();
            var fullAddress = Request.Form["FullAddress"].ToString();
            var city = Request.Form["City"].ToString();
            var district = Request.Form["District"].ToString();
            var phone = Request.Form["Phone"].ToString();

            // Validasyon kontrolleri
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

            // AddressType ve IsDefault değerlerini dönüştürüyoruz
            Enum.TryParse<Core.Enums.AddressType>(Request.Form["AddressType"], out var addressType);
            bool.TryParse(Request.Form["IsDefault"], out var isDefault);

            Console.WriteLine($"Form verileri: {title}, {city}, {district}, {phone}, {addressType}, {isDefault}");

            try
            {
                // Yeni adres oluştur
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

                // Veritabanına ekle
                _context.Addresses.Add(address);
                var result = await _context.SaveChangesAsync();

                Console.WriteLine($"Adres kaydedildi: {result} satır etkilendi, ID: {address.Id}");

                // Adresler sayfasına yönlendir
                return RedirectToAction("Addresses");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                ViewBag.Error = "Adres kaydı sırasında bir hata oluştu: " + ex.Message;
                return View("~/Views/Account/Address/Create.cshtml");
            }
        }

        public async Task<IActionResult> EditAddress(int id)
        {
            var userId = HttpContext.Items["UserId"].ToString();

            var address = await _context.Addresses
                .FirstOrDefaultAsync(a => a.Id == id && a.UserId == userId);

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

            var existingAddress = await _context.Addresses
                .FirstOrDefaultAsync(a => a.Id == address.Id && a.UserId == userId);

            if (existingAddress == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                existingAddress.Title = address.Title;
                existingAddress.FullAddress = address.FullAddress;
                existingAddress.City = address.City;
                existingAddress.District = address.District;
                existingAddress.Phone = address.Phone;

                await _context.SaveChangesAsync();
                return RedirectToAction("Addresses");
            }

            return View("~/Views/Account/Address/Edit.cshtml", address);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            var userId = HttpContext.Items["UserId"].ToString();

            var address = await _context.Addresses
                .FirstOrDefaultAsync(a => a.Id == id && a.UserId == userId);

            if (address == null)
            {
                return NotFound();
            }

            _context.Addresses.Remove(address);
            await _context.SaveChangesAsync();

            return RedirectToAction("Addresses");
        }

        public async Task<IActionResult> Orders()
        {
            var userId = HttpContext.Items["UserId"].ToString();

            // Kullanıcı bilgilerini veritabanından al
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Id == userId);

            // Kullanıcı bilgilerini ViewBag ile gönder
            if (user != null)
            {
                ViewBag.UserProfile = new
                {
                    FirstName = user.FirstName ?? "Kullanıcı",
                    LastName = user.LastName ?? "",
                    Email = user.Email ?? ""
                };
            }
            else
            {
                ViewBag.UserProfile = new
                {
                    FirstName = "Kullanıcı",
                    LastName = "",
                    Email = ""
                };
            }

            var orders = await _context.Orders
                .Where(o => o.UserId == userId)
                .OrderByDescending(o => o.OrderDate)
                .ToListAsync();

            return View("~/Views/Account/Order/Index.cshtml", orders);
        }

        public async Task<IActionResult> Edit()
        {
            var userId = HttpContext.Items["UserId"].ToString();

            // Kullanıcı bilgilerini veritabanından al
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Id == userId);

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
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Id == userId);

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

                await _context.SaveChangesAsync();

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