using Microsoft.AspNetCore.Mvc;
using MarketWorld.Web.Models;

namespace MarketWorld.Web.ViewComponents
{
    public class PhoneListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var phones = new List<PhoneViewModel>
            {
                new PhoneViewModel
                {
                    Id = 1,
                    Brand = "Apple",
                    Model = "iPhone 13 128 GB",
                    Price = 33618.99m,
                    ImageUrl = "/images/phones/iphone13.jpg",
                    Rating = 4.5,
                    ReviewCount = 3253,
                    HasFreeShipping = true
                },
                new PhoneViewModel
                {
                    Id = 2,
                    Brand = "Xiaomi",
                    Model = "Redmi 14C 8 GB 256 GB",
                    Price = 8189,
                    ImageUrl = "/images/phones/redmi14c.jpg",
                    Rating = 4.7,
                    ReviewCount = 170,
                    HasFreeShipping = true
                },
                // Diğer telefonlar buraya eklenebilir
            };

            return View(phones);
        }
    }
} 