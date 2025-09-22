using System.ComponentModel.DataAnnotations;

namespace MarketWorld.Web.Models.Api
{
    public class CreateCommentRequest
    {
        [Required]
        public int ProductId { get; set; }
        
        [Required]
        [StringLength(1000, MinimumLength = 10)]
        public string Content { get; set; } = string.Empty;
        
        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }
    }
}
