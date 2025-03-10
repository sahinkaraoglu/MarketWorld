using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace MarketWorld.Web.Models.Admin
{
    public class AddProductViewModel
    {
        [Required(ErrorMessage = "Ürün adı zorunludur")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Marka seçimi zorunludur")]
        public int BrandId { get; set; }

        [Required(ErrorMessage = "Fiyat zorunludur")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Fiyat 0'dan büyük olmalıdır")]
        public decimal Price { get; set; }

        public decimal? DiscountPrice { get; set; }

        [Required(ErrorMessage = "Stok miktarı zorunludur")]
        [Range(0, int.MaxValue, ErrorMessage = "Stok miktarı 0 veya daha büyük olmalıdır")]
        public int Stock { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public bool HasDiscount { get; set; }

        [Required(ErrorMessage = "Alt kategori seçimi zorunludur")]
        public int SubCategoryId { get; set; }

        public List<IFormFile> Images { get; set; }
    }
} 