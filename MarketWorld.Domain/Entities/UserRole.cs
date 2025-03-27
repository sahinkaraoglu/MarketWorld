using MarketWorld.Domain.Entities.Base;
using System;
using System.Collections.Generic;

namespace MarketWorld.Domain.Entities
{
    public class UserRole : BaseEntity
    {
        public string Role { get; set; }
        public ICollection<User> Users { get; set; }
    }
} 