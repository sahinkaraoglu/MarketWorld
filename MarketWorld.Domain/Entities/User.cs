using MarketWorld.Domain.Entities.Base;
using System;
using System.Collections.Generic;

namespace MarketWorld.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? PhoneNumber { get; set; }
        public int UserRoleId { get; set; }
        public UserRole UserRole { get; set; }
        public bool IsActive { get; set; } = true;
        
        public ICollection<Order> Orders { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<CreditCard> CreditCards { get; set; }
    }
} 