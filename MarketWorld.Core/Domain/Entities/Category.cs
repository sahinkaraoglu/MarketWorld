using MarketWorld.Core.Domain.Entities.Base;
using System;
using System.Collections.Generic;

namespace MarketWorld.Core.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string ShortenedEntityName { get; set; }
        public string Description { get; set; }
        public ICollection<SubCategory>? SubCategories { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}