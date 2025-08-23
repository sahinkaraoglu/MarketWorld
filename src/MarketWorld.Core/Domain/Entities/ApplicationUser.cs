using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace MarketWorld.Core.Domain.Entities;

public class ApplicationUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Phone { get; set; }
    
    
    public bool IsActive { get; set; } = true;
    public DateTime CreateDate { get; set; } = DateTime.UtcNow;
    
    // Kullanıcı ilişkileri
    public virtual ICollection<Order> Orders { get; set; }
    public virtual ICollection<Address> Addresses { get; set; }  
    public virtual ICollection<CreditCard> CreditCards { get; set; }
} 