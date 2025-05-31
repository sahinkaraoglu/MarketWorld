using MarketWorld.Core.Domain.Entities.Base;

namespace MarketWorld.Core.Domain.Entities
{
    public class Image : BaseEntity
    {
        public string Path { get; set; }
        public int EntityId { get; set; }
        public int EntityType { get; set; }
    }
} 
