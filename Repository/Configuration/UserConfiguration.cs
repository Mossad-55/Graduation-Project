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
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
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
            },
            new User
            {
                Id = "7A369173-1E2F-491F-874F-7B324C034BC2",
                UserName = "bob.smith@example.com",
                NormalizedUserName = "BOB.SMITH@EXAMPLE.COM",
                Email = "bob.smith@example.com",
                NormalizedEmail = "BOB.SMITH@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Bob@123456"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Bob",
                LastName = "Smith",
                PhoneNumber = "011234356789"
            },
            new User
            {
                Id = "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2",
                UserName = "sara.jones@example.com",
                NormalizedUserName = "SARA.JONES@EXAMPLE.COM",
                Email = "sara.jones@example.com",
                NormalizedEmail = "SARA.JONES@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Jones@654321"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sara",
                LastName = "Jones",
                PhoneNumber = "010765432231"
            }
        );
    }
}
