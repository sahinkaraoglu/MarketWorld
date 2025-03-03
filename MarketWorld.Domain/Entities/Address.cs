using MarketWorld.Domain.Entities.Base;
using MarketWorld.Domain.Enums;

namespace MarketWorld.Domain.Entities
{
    public class Address : BaseEntity
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public bool IsDefault { get; set; }
        public AddressType AddressType { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }
    }
} 