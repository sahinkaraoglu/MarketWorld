using MarketWorld.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketWorld.Domain.Entities
{
    public class SubCategory : BaseEntity
    {
        public string Name { get; set; }
        public string SeoName { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
  
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        
        public ICollection<Product>? Products { get; set; }
    }
} 