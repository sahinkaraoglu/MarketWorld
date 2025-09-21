using MarketWorld.Core.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketWorld.Infrastructure.Data.SeedData
{
    public static class AdminSeedData
    {
        public static async Task SeedAdminUserAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            // Admin rolünü oluştur
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }

            if (!await roleManager.RoleExistsAsync("User"))
            {
                await roleManager.CreateAsync(new IdentityRole("User"));
            }

            // Admin kullanıcısını kontrol et
            var adminEmail = "admin@marketworld.com";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);

            if (adminUser == null)
            {
                adminUser = new ApplicationUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true,
                    FirstName = "Admin",
                    LastName = "User",
                    Phone = "+905551234567",
                    IsActive = true,
                    CreateDate = DateTime.UtcNow,
                    NormalizedEmail = adminEmail.ToUpper(),
                    NormalizedUserName = adminEmail.ToUpper()
                };

                // Admin kullanıcısını oluştur (şifre: Admin123!)
                var result = await userManager.CreateAsync(adminUser, "Admin123!");

                if (result.Succeeded)
                {
                    // Admin rolünü ata
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
            else
            {
                // Mevcut admin kullanıcısının Admin rolüne sahip olup olmadığını kontrol et
                if (!await userManager.IsInRoleAsync(adminUser, "Admin"))
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }

        public static ApplicationUser GetAdminUser()
        {
            return new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "admin@marketworld.com",
                Email = "admin@marketworld.com",
                EmailConfirmed = true,
                FirstName = "Admin",
                LastName = "User",
                Phone = "+905551234567",
                IsActive = true,
                CreateDate = DateTime.UtcNow,
                NormalizedEmail = "ADMIN@MARKETWORLD.COM",
                NormalizedUserName = "ADMIN@MARKETWORLD.COM"


                //Kullanıcı Adı: admin@marketworld.com
                //Şifre: Admin123!
            };
        }
    }
}
