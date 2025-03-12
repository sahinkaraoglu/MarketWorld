using System;
using System.Collections.Generic;

namespace MarketWorld.Web.Models
{
    public class ProductDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountPrice { get; set; }
        public bool HasDiscount { get; set; }
        public int Stock { get; set; }
        public double Rating { get; set; }
        public int ReviewCount { get; set; }
        public List<string> Images { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public bool HasFreeShipping { get; set; }
        public List<ProductPropertyViewModel> ColorOptions { get; set; }
        public List<ProductPropertyViewModel> MemoryOptions { get; set; }
    }
} 