using System;
using System.Collections.Generic;

namespace MarketWorld.API.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public int ProductCode { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; } = true;
        public string Description { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal Rating { get; set; }
        public bool HasDiscount { get; set; } = false;
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public List<string> ImageUrls { get; set; }
        public List<ProductPropertyDto> ProductProperties { get; set; }
    }

    public class ProductPropertyDto
    {
        public int Id { get; set; }
        public string PropertyTypeName { get; set; }
        public string PropertyValue { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }
    }
} 