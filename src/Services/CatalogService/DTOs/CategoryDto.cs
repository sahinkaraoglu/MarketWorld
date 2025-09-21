using System;
using System.Collections.Generic;

namespace CatalogService.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int? ParentCategoryId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        
        // Navigation properties
        public string ParentCategoryName { get; set; }
        public List<CategoryDto> SubCategories { get; set; } = new List<CategoryDto>();
        public int ProductCount { get; set; }
    }
}
