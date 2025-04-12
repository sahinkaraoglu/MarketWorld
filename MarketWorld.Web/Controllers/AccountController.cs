using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Infrastructure.Data;
using MarketWorld.Domain.Entities;
using System.Threading.Tasks;
using System.Linq;
using System;
using MarketWorld.Infrastructure.Data.SeedData;

namespace MarketWorld.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly MarketWorldDbContext _context;

        public AccountController(MarketWorldDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (!userId.HasValue)
            {
                return RedirectToAction("Index", "Login");
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Id == userId);

            return View(user);
        }

        public async Task<IActionResult> Addresses()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (!userId.HasValue)
            {
                return RedirectToAction("Index", "Login");
            }

            var user = await _context.Users
                .Include(u => u.Addresses)
                .FirstOrDefaultAsync(u => u.Id == userId);

            return View(user);
        }

        public IActionResult AddAddress()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (!userId.HasValue)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }

        [HttpPost]
        [ActionName("AddAddress")]
        public async Task<IActionResult> AddAddressPost()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (!userId.HasValue)
            {
                return RedirectToAction("Index", "Login");
            }

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
                return View();
            }

            // AddressType ve IsDefault değerlerini dönüştürüyoruz
            Enum.TryParse<Domain.Enums.AddressType>(Request.Form["AddressType"], out var addressType);
            bool.TryParse(Request.Form["IsDefault"], out var isDefault);

            Console.WriteLine($"Form verileri: {title}, {city}, {district}, {phone}, {addressType}, {isDefault}");

            try
            {
                // Yeni adres oluştur
                var address = new Address
                {
                    UserId = userId.Value,
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
                return View();
            }
        }

        public async Task<IActionResult> EditAddress(int id)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (!userId.HasValue)
            {
                return RedirectToAction("Index", "Login");
            }

            var address = await _context.Addresses
                .FirstOrDefaultAsync(a => a.Id == id && a.UserId == userId);

            if (address == null)
            {
                return NotFound();
            }

            return View(address);
        }

        [HttpPost]
        public async Task<IActionResult> EditAddress(Address address)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (!userId.HasValue)
            {
                return RedirectToAction("Index", "Login");
            }

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

            return View(address);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (!userId.HasValue)
            {
                return RedirectToAction("Index", "Login");
            }

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
            var userId = HttpContext.Session.GetInt32("UserId");
            if (!userId.HasValue)
            {
                return RedirectToAction("Index", "Login");
            }

            var orders = await _context.Orders
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Product)
                .Where(o => o.UserId == userId)
                .OrderByDescending(o => o.OrderDate)
                .ToListAsync();

            return View(orders);
        }
    }
} 