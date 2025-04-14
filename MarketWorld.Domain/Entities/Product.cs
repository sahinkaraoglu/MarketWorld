using MarketWorld.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace MarketWorld.Domain.Entities
{
    public class Product : BaseEntity
    {
        [StringLength(6)]
        /// <summary>
        /// Ürün için benzersiz 6 haneli rastgele oluşturulan ürün numarası
        /// </summary>
        public string ProductNumber { get; set; } = "000000";
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
        
        public int GetTotalStock()
        {
            if (ProductProperties == null || !ProductProperties.Any())
                return 0;
                
            return ProductProperties.Where(pp => pp.IsActive).Sum(pp => pp.Stock);
        }

        /// <summary>
        /// 6 haneli rastgele bir ürün numarası oluşturur
        /// </summary>
        public void GenerateRandomProductNumber()
        {
            var random = new Random();
            ProductNumber = random.Next(100000, 1000000).ToString();
        }
    }
}
