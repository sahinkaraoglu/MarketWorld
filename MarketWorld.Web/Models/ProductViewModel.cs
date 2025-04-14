using MarketWorld.Domain.Entities;

namespace MarketWorld.Web.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public string ImageUrl { get; set; }
        public decimal Rating { get; set; }
        public int ReviewCount { get; set; }
        public bool HasFreeShipping { get; set; }
        public int Stock { get; set; }
        public string CategoryName { get; set; }
        public int SubCategoryId { get; set; }
        public bool HasDiscount { get; set; }
        public decimal? DiscountPrice { get; set; }
        public string ProductNumber { get; set; } = "000000";


    }
} 