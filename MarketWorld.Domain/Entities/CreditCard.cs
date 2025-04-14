using MarketWorld.Domain.Entities.Base;
using System;

namespace MarketWorld.Domain.Entities
{
    public class CreditCard : BaseEntity
    {
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string Cvv { get; set; }
        public string CardType { get; set; }
        public bool IsDefault { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
} 