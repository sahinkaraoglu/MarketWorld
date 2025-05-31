using MarketWorld.Core.Domain.Entities.Base;
using MarketWorld.Core.Enums;
using System;

namespace MarketWorld.Core.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public string PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public PaymentStatus Status { get; set; }
        public DateTime PaymentDate { get; set; }
        public string TransactionId { get; set; }
        
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
} 