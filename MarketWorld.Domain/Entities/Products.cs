using MarketWorld.Domain.Entities.Base;
using System;

namespace MarketWorld.Domain.Entities
{
    public class Products : BaseEntity
    {
        public string Name { get; set; }
        
        public string Brand { get; set; }
        
        public decimal Price { get; set; }
        
        public int Stock { get; set; }
        public bool IsActive { get; set; } = true;

        public string Description { get; set; }
        
        public SubCategories? SubCategory { get; set; }
    }
}
