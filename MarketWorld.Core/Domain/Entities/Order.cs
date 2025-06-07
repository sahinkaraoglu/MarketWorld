using MarketWorld.Core.Domain.Entities.Base;
using MarketWorld.Core.Enums;
using System;
using System.Collections.Generic;

namespace MarketWorld.Core.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalAmount { get; set; }
        
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        
        public int? ShippingAddressId { get; set; }
        public Address ShippingAddress { get; set; }
        
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<CreditCard> CreditCards { get; set; }
    }
} 