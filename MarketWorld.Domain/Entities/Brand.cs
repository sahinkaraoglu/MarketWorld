using MarketWorld.Domain.Entities.Base;
using System.Collections.Generic;

namespace MarketWorld.Domain.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
