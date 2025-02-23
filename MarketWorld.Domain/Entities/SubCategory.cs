using System;

namespace MarketWorld.Domain.Entities
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int CategoryId { get; set; }  // Ana kategori ID'si
        public Category Category { get; set; }  // Ana kategori navigasyon property'si
        public ICollection<Product> Products { get; set; }
    }
} 