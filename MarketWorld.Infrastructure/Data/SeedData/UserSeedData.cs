using MarketWorld.Domain.Entities;
using MarketWorld.Domain.Enums;

namespace MarketWorld.Infrastructure.Data.SeedData
{
    public static class UserSeedData
    {
        public static List<UserRole> GetUserRoles()
        {
            return new List<UserRole>
            {
                new UserRole
                {
                    Id = 1,
                    Role = "Admin"
                },
                 new UserRole
                {
                    Id = 2,
                    Role = "User"
                }
            };
        }


        public static List<User> GetUser()
        {
            return new List<User>
            {
                new User
                {
                    Id = 1,
                    FirstName = "Þahin",
                    Username = "admin",
                    Password = "123",
                    UserRoleId = 1,
                    Email = "admin@admin.com"

                },
                 new User
                {
                    Id = 2,
                    FirstName = "Ali",
                    Username = "aliuzun",
                    Password = "456",
                    UserRoleId = 2,
                    Email = "ali@example.com"
                }
            };
        }


    }
}