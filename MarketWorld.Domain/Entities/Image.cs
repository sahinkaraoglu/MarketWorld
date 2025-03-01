using MarketWorld.Domain.Entities.Base;
using System.Collections.Generic;

namespace MarketWorld.Domain.Entities
{
    public class Image : BaseEntity
    {
        public string Path { get; set; }
        public int EntityId { get; set; }
        public int EntityType { get; set; }

    }
    
    
} 
