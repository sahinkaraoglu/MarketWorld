namespace MarketWorld.Web.Models.Api
{
    public class CommentDto
    {
        public int? Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public int Rating { get; set; }
        public bool IsApproved { get; set; } = false;
        public int ProductId { get; set; }
        public int ProductCode { get; set; }
        public Guid? UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
    }
}
