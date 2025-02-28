using MarketWorld.Domain.Entities.Base;
using System;
using System.Collections.Generic;

namespace MarketWorld.Domain.Entities
{
    public class Categories : BaseEntity
    {
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public ICollection<SubCategories>? SubCategories { get; set; }
        
        public ICollection<Products>? Products { get; set; }
    }
}