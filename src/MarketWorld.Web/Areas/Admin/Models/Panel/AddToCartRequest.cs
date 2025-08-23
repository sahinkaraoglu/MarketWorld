namespace MarketWorld.Web.Areas.Admin.Models.Panel
{
    public class AddToCartRequest
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string Color { get; set; }
    }
} 