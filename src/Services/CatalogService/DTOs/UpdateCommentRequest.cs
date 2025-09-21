using System;

namespace CatalogService.DTOs
{
    public class UpdateCommentRequest
    {
        public string Content { get; set; } = string.Empty;
        public int Rating { get; set; }
    }
}
