namespace MarketWorld.Web.Models
{
    public class PhoneViewModel
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool HasFreeShipping { get; set; }
        public double Rating { get; set; }
        public int ReviewCount { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
    }
} 