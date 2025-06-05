using MarketWorld.Core.Domain.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketWorld.Core.Domain.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<Product> Products { get; set; }
    }
}
