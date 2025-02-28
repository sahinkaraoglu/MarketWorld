using MarketWorld.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketWorld.Domain.Entities
{
    public class SubCategories : BaseEntity
    {
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        
        public long CategoryId { get; set; }
        
        [ForeignKey("CategoryId")]
        public Categories Categories { get; set; }
        
        public ICollection<Products>? Products { get; set; }
    }
} 