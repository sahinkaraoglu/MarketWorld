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
        public double Rating { get; set; }
        public int ReviewCount { get; set; }
        public bool HasFreeShipping { get; set; }
        public int Stock { get; set; }
        public int SubCategoryId { get; set; }


    }
} 