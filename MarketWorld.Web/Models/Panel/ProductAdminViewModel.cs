using System.ComponentModel.DataAnnotations;

namespace MarketWorld.Web.Models.Admin
{
    public class ProductAdminViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public decimal Rating { get; set; }
        public string Status { get; set; }
        public string ImageUrl { get; set; } = "/img/ProductsPicture/default.jpg";
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string ProductNumber { get; set; } = "000000";
    }
} 