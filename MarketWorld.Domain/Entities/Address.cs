using MarketWorld.Domain.Entities.Base;
using MarketWorld.Domain.Enums;

namespace MarketWorld.Domain.Entities
{
    public class Address : BaseEntity
    {
        public string Title { get; set; }
        public string FullAddress { get; set; }
        public string? District { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public bool IsDefault { get; set; }
        public AddressType AddressType { get; set; }
        
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
} 