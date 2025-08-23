using MarketWorld.Core.Domain.Entities.Base;
using System;

namespace MarketWorld.Core.Domain.Entities
{
    public class CreditCard : BaseEntity
    {
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string Cvv { get; set; }
        public string CardType { get; set; }
        public bool IsDefault { get; set; }
        
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
} 