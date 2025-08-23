using System;

namespace MarketWorld.Web.Models
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public bool IsApproved { get; set; }
        public int ProductId { get; set; }
        public int ProductCode { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
} 