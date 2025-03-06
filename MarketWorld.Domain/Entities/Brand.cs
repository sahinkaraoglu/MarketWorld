using MarketWorld.Domain.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketWorld.Domain.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public int? SubCategoryId { get; set; }

        [ForeignKey("SubCategoryId")]
        public SubCategory? SubCategory { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
