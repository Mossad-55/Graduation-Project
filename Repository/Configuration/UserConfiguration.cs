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
            },
            new User
            {
                Id = "706870e9-e373-11ed-b719-105badc84798",
                UserName = "Mo.Zi@example.com",
                NormalizedUserName = "MO.ZI@EXAMPLE.COM",
                Email = "Mo.Zi@example.com",
                NormalizedEmail = "MO.ZI@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Mo",
                LastName = "Zi",
                PhoneNumber = "01279426209"
            },
            new User
            {
                Id = "706b3236-e373-11ed-a003-105badc84798",
                UserName = "Majdi.Fares@example.com",
                NormalizedUserName = "MAJDI.FARES@EXAMPLE.COM",
                Email = "Majdi.Fares@example.com",
                NormalizedEmail = "MAJDI.FARES@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Majdi",
                LastName = "Fares",
                PhoneNumber = "01270867190"
            },

            new User
            {
                Id = "706b3237-e373-11ed-988f-105badc84798",
                UserName = "Hamza.Yisri@example.com",
                NormalizedUserName = "HAMZA.YISRI@EXAMPLE.COM",
                Email = "Hamza.Yisri@example.com",
                NormalizedEmail = "HAMZA.YISRI@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Hamza",
                LastName = "Yisri",
                PhoneNumber = "01256543256"
            },
            new User
            {
                Id = "5AAFE5DF-CB75-4DFA-898A-9A1C4E9BB5A5",
                UserName = "mosad5@gmail.com",
                NormalizedUserName = "MOSAD5@GMAIL.COM",
                Email = "mosad5@gmail.com",
                NormalizedEmail = "MOSAD5@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Mossad",
                LastName = "Ahmed",
                PhoneNumber = "+201211820083"
            },
            new User
            {
                Id = "4A8CA884-C093-43C4-A019-EE6D804BF85E",
                UserName = "mosad53@gmail.com",
                NormalizedUserName = "MOSAD53@GMAIL.COM",
                Email = "mosad53@gmail.com",
                NormalizedEmail = "MOSAD53@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Mossad",
                LastName = "Gomaa",
                PhoneNumber = "+201211820083"
            }
        );
    }
}
