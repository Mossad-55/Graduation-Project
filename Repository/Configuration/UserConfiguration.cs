using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasData
        (
            new User
            {
                Id = "99328045-8ECF-40A1-9F0B-0DEA6398F09A",
                UserName = "john.doe@example.com",
                NormalizedUserName = "JOHN.DOE@EXAMPLE.COM",
                Email = "john.doe@example.com",
                NormalizedEmail = "JOHN.DOE@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Password@123"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "John",
                LastName = "Doe",
                PhoneNumber = "01239931230"
            },
            new User
            {
                Id = "69E0E900-6DE2-45E8-85CA-583B32C5C5AA",
                UserName = "jane.doe@example.com",
                NormalizedUserName = "JANE.DOE@EXAMPLE.COM",
                Email = "jane.doe@example.com",
                NormalizedEmail = "JANE.DOE@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Password@456"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Jane",
                LastName = "Doe",
                PhoneNumber = "01203993009"
            }
        );
    }
}
