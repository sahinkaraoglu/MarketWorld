using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using MarketWorld.Core.Domain.Entities.Base;

namespace MarketWorld.Core.Domain.Entities
{
    public class Product : BaseEntity
    {
        public int ProductCode { get; set; } = 0;
        public string Name { get; set; }
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; } = true;
        public string Description { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal Rating { get; set; }
        public bool HasDiscount { get; set; } = false;
        public List<Image> Images { get; set; }

        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        public int? SubCategoryId { get; set; }
        public SubCategory? SubCategory { get; set; }
        public Brand? Brand { get; set; }
        
        public ICollection<OrderItem>? OrderItems { get; set; }
        public ICollection<CartItem>? CartItems { get; set; }
        public ICollection<ProductProperty> ProductProperties { get; set; }
        public ICollection<Comment> Comments { get; set; }
        
        public int GetTotalStock()
        {
            if (ProductProperties == null || !ProductProperties.Any())
                return 0;
                
            return ProductProperties.Where(pp => pp.IsActive).Sum(pp => pp.Stock);
        }

        /// <summary>
        /// 6 haneli rastgele bir ürün numarası oluşturur
        /// </summary>
        public void GenerateRandomProductCode()
        {
            var random = new Random();
            ProductCode = random.Next(100000, 1000000);
        }
    }
}
