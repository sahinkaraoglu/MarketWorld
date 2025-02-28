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
        
        public string Description { get; set; }
        
        public long? SubCategoryId { get; set; }
        
        public SubCategory? SubCategory { get; set; }
    }
}
