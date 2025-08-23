using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MarketWorld.Web.Models
{
    public class ProductDetailViewModel
    {
        public int Id { get; set; }

        public int ProductCode { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountPrice { get; set; }
        public bool HasDiscount { get; set; }
        public int Stock { get; set; }
        public decimal Rating { get; set; }
        public int ReviewCount { get; set; }
        public List<string> Images { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public bool HasFreeShipping { get; set; }
        public List<ProductPropertyViewModel> ColorOptions { get; set; }
        public List<ProductPropertyViewModel> MemoryOptions { get; set; }
        public List<CommentViewModel> Comments { get; set; }
        public List<ProductPropertyViewModel> Properties { get; set; }
        
        public int GetTotalStock()
        {
            var options = new List<ProductPropertyViewModel>();
            
            if (ColorOptions != null)
                options.AddRange(ColorOptions);
                
            if (MemoryOptions != null)
                options.AddRange(MemoryOptions);
                
            if (!options.Any())
                return Stock; // Eğer seçenek yoksa varsayılan stok değerini döndür
                
            return options.Sum(o => o.Stock);
        }
    }
} 