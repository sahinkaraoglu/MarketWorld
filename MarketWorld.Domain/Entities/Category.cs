using MarketWorld.Domain.Entities.Base;
using System;
using System.Collections.Generic;

namespace MarketWorld.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string SeoName { get; set; }
        public string Description { get; set; }
        public ICollection<SubCategory>? SubCategories { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}