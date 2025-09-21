using System;
using System.Collections.Generic;

namespace CatalogService.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountedPrice { get; set; }
        public int TotalStock { get; set; }
        public string ProductCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public decimal Rating { get; set; }
        public int ViewCount { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        
        // Navigation properties
        public string CategoryName { get; set; }
        public string BrandName { get; set; }
        public List<string> ImageUrls { get; set; } = new List<string>();
    }
}
