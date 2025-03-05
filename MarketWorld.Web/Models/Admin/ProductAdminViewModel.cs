namespace MarketWorld.Web.Models.Admin
{
    public class ProductAdminViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
} 