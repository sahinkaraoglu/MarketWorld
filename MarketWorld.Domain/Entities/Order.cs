using MarketWorld.Domain.Entities.Base;
using MarketWorld.Domain.Enums;
using System;
using System.Collections.Generic;

namespace MarketWorld.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalAmount { get; set; }
        
        public long UserId { get; set; }
        public User User { get; set; }
        
        public long? ShippingAddressId { get; set; }
        public Address ShippingAddress { get; set; }
        
        public long? BillingAddressId { get; set; }
        public Address BillingAddress { get; set; }
        
        public ICollection<OrderItem> OrderItems { get; set; }
    }
} 