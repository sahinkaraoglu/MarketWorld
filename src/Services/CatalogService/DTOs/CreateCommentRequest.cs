using System;

namespace CatalogService.DTOs
{
    public class CreateCommentRequest
    {
        public int ProductId { get; set; }
        public string Content { get; set; } = string.Empty;
        public int Rating { get; set; }
    }
}
