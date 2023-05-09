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
            },
            new User
            {
                Id = "4093fa25-ed6b-11ed-a6df-105badc84798",
                UserName = "Hamza.Najmb32d@example.com",
                NormalizedUserName = "HAMZA.NAJMB32D@EXAMPLE.COM",
                Email = "Hamza.Najmb32d@example.com",
                NormalizedEmail = "HAMZA.NAJMB32D@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Hamza",
                LastName = "Najmb32d",
                PhoneNumber = "01232988337"
            },

            new User
            {
                Id = "4093fa27-ed6b-11ed-8922-105badc84798",
                UserName = "Malek.Sheikh9cd6@example.com",
                NormalizedUserName = "MALEK.SHEIKH9CD6@EXAMPLE.COM",
                Email = "Malek.Sheikh9cd6@example.com",
                NormalizedEmail = "MALEK.SHEIKH9CD6@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Malek",
                LastName = "Sheikh9cd6",
                PhoneNumber = "01220871240"
            },

            new User
            {
                Id = "4093fa29-ed6b-11ed-85ba-105badc84798",
                UserName = "Zachariah.Hishamiaac8@example.com",
                NormalizedUserName = "ZACHARIAH.HISHAMIAAC8@EXAMPLE.COM",
                Email = "Zachariah.Hishamiaac8@example.com",
                NormalizedEmail = "ZACHARIAH.HISHAMIAAC8@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Zachariah",
                LastName = "Hishamiaac8",
                PhoneNumber = "01269689816"
            },

            new User
            {
                Id = "4093fa2b-ed6b-11ed-9be9-105badc84798",
                UserName = "Bassam.Barra9103@example.com",
                NormalizedUserName = "BASSAM.BARRA9103@EXAMPLE.COM",
                Email = "Bassam.Barra9103@example.com",
                NormalizedEmail = "BASSAM.BARRA9103@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Bassam",
                LastName = "Barra9103",
                PhoneNumber = "01287718443"
            },

            new User
            {
                Id = "4093fa2d-ed6b-11ed-a65f-105badc84798",
                UserName = "​​Karim.Ahmed9826@example.com",
                NormalizedUserName = "​​KARIM.AHMED9826@EXAMPLE.COM",
                Email = "​​Karim.Ahmed9826@example.com",
                NormalizedEmail = "​​KARIM.AHMED9826@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "​​Karim",
                LastName = "Ahmed9826",
                PhoneNumber = "01229669039"
            },

            new User
            {
                Id = "409676b0-ed6b-11ed-9fd6-105badc84798",
                UserName = "Russell.Jawada950@example.com",
                NormalizedUserName = "RUSSELL.JAWADA950@EXAMPLE.COM",
                Email = "Russell.Jawada950@example.com",
                NormalizedEmail = "RUSSELL.JAWADA950@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Russell",
                LastName = "Jawada950",
                PhoneNumber = "01258890451"
            },

            new User
            {
                Id = "409676b2-ed6b-11ed-b62e-105badc84798",
                UserName = "Helsey.Bahiabb8@example.com",
                NormalizedUserName = "HELSEY.BAHIABB8@EXAMPLE.COM",
                Email = "Helsey.Bahiabb8@example.com",
                NormalizedEmail = "HELSEY.BAHIABB8@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Helsey",
                LastName = "Bahiabb8",
                PhoneNumber = "01271822961"
            },

            new User
            {
                Id = "409676b4-ed6b-11ed-b886-105badc84798",
                UserName = "Adel.Fidaa8283@example.com",
                NormalizedUserName = "ADEL.FIDAA8283@EXAMPLE.COM",
                Email = "Adel.Fidaa8283@example.com",
                NormalizedEmail = "ADEL.FIDAA8283@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Adel",
                LastName = "Fidaa8283",
                PhoneNumber = "01252839445"
            },

            new User
            {
                Id = "409676b6-ed6b-11ed-b477-105badc84798",
                UserName = "Haor.Medhatbb1e@example.com",
                NormalizedUserName = "HAOR.MEDHATBB1E@EXAMPLE.COM",
                Email = "Haor.Medhatbb1e@example.com",
                NormalizedEmail = "HAOR.MEDHATBB1E@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Haor",
                LastName = "Medhatbb1e",
                PhoneNumber = "01249787781"
            },

            new User
            {
                Id = "409676b8-ed6b-11ed-9c16-105badc84798",
                UserName = "Hassan.Haor9c0d@example.com",
                NormalizedUserName = "HASSAN.HAOR9C0D@EXAMPLE.COM",
                Email = "Hassan.Haor9c0d@example.com",
                NormalizedEmail = "HASSAN.HAOR9C0D@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Hassan",
                LastName = "Haor9c0d",
                PhoneNumber = "01252429834"
            },

            new User
            {
                Id = "409676ba-ed6b-11ed-adbf-105badc84798",
                UserName = "Sameh.Hilalb0d8@example.com",
                NormalizedUserName = "SAMEH.HILALB0D8@EXAMPLE.COM",
                Email = "Sameh.Hilalb0d8@example.com",
                NormalizedEmail = "SAMEH.HILALB0D8@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sameh",
                LastName = "Hilalb0d8",
                PhoneNumber = "01212885239"
            },

            new User
            {
                Id = "409676bc-ed6b-11ed-9b21-105badc84798",
                UserName = "Ghaith.Asim9678@example.com",
                NormalizedUserName = "GHAITH.ASIM9678@EXAMPLE.COM",
                Email = "Ghaith.Asim9678@example.com",
                NormalizedEmail = "GHAITH.ASIM9678@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Ghaith",
                LastName = "Asim9678",
                PhoneNumber = "01286981596"
            },

            new User
            {
                Id = "409676be-ed6b-11ed-902b-105badc84798",
                UserName = "Waseem.Ghanem9305@example.com",
                NormalizedUserName = "WASEEM.GHANEM9305@EXAMPLE.COM",
                Email = "Waseem.Ghanem9305@example.com",
                NormalizedEmail = "WASEEM.GHANEM9305@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Waseem",
                LastName = "Ghanem9305",
                PhoneNumber = "01267352439"
            },

            new User
            {
                Id = "409676c0-ed6b-11ed-a990-105badc84798",
                UserName = "Badri.Basemacbd@example.com",
                NormalizedUserName = "BADRI.BASEMACBD@EXAMPLE.COM",
                Email = "Badri.Basemacbd@example.com",
                NormalizedEmail = "BADRI.BASEMACBD@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Badri",
                LastName = "Basemacbd",
                PhoneNumber = "01297327850"
            },

            new User
            {
                Id = "409676c2-ed6b-11ed-a696-105badc84798",
                UserName = "Bacari.Sharmb5af@example.com",
                NormalizedUserName = "BACARI.SHARMB5AF@EXAMPLE.COM",
                Email = "Bacari.Sharmb5af@example.com",
                NormalizedEmail = "BACARI.SHARMB5AF@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Bacari",
                LastName = "Sharmb5af",
                PhoneNumber = "01282353516"
            },

            new User
            {
                Id = "409676c4-ed6b-11ed-a637-105badc84798",
                UserName = "Yakon.Sharm9d1a@example.com",
                NormalizedUserName = "YAKON.SHARM9D1A@EXAMPLE.COM",
                Email = "Yakon.Sharm9d1a@example.com",
                NormalizedEmail = "YAKON.SHARM9D1A@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Yakon",
                LastName = "Sharm9d1a",
                PhoneNumber = "01216786378"
            },

            new User
            {
                Id = "40977647-ed6b-11ed-aad8-105badc84798",
                UserName = "Fidaa.Adham9867@example.com",
                NormalizedUserName = "FIDAA.ADHAM9867@EXAMPLE.COM",
                Email = "Fidaa.Adham9867@example.com",
                NormalizedEmail = "FIDAA.ADHAM9867@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Fidaa",
                LastName = "Adham9867",
                PhoneNumber = "01218203642"
            },

            new User
            {
                Id = "40977649-ed6b-11ed-973e-105badc84798",
                UserName = "Firas.Bassel82fd@example.com",
                NormalizedUserName = "FIRAS.BASSEL82FD@EXAMPLE.COM",
                Email = "Firas.Bassel82fd@example.com",
                NormalizedEmail = "FIRAS.BASSEL82FD@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Firas",
                LastName = "Bassel82fd",
                PhoneNumber = "01217707960"
            },

            new User
            {
                Id = "4097764b-ed6b-11ed-b259-105badc84798",
                UserName = "Sameh.Hishami8757@example.com",
                NormalizedUserName = "SAMEH.HISHAMI8757@EXAMPLE.COM",
                Email = "Sameh.Hishami8757@example.com",
                NormalizedEmail = "SAMEH.HISHAMI8757@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sameh",
                LastName = "Hishami8757",
                PhoneNumber = "01272041260"
            },

            new User
            {
                Id = "4097973c-ed6b-11ed-9913-105badc84798",
                UserName = "Noah.Nahar9371@example.com",
                NormalizedUserName = "NOAH.NAHAR9371@EXAMPLE.COM",
                Email = "Noah.Nahar9371@example.com",
                NormalizedEmail = "NOAH.NAHAR9371@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Noah",
                LastName = "Nahar9371",
                PhoneNumber = "01244828073"
            },

            new User
            {
                Id = "4097973e-ed6b-11ed-929c-105badc84798",
                UserName = "Saden.Ali8050@example.com",
                NormalizedUserName = "SADEN.ALI8050@EXAMPLE.COM",
                Email = "Saden.Ali8050@example.com",
                NormalizedEmail = "SADEN.ALI8050@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Saden",
                LastName = "Ali8050",
                PhoneNumber = "01243048322"
            },

            new User
            {
                Id = "40979740-ed6b-11ed-8c11-105badc84798",
                UserName = "Ghaith.Basselb8db@example.com",
                NormalizedUserName = "GHAITH.BASSELB8DB@EXAMPLE.COM",
                Email = "Ghaith.Basselb8db@example.com",
                NormalizedEmail = "GHAITH.BASSELB8DB@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Ghaith",
                LastName = "Basselb8db",
                PhoneNumber = "01288105916"
            },

            new User
            {
                Id = "40979742-ed6b-11ed-b3de-105badc84798",
                UserName = "​​Karim.Basem9bee@example.com",
                NormalizedUserName = "​​KARIM.BASEM9BEE@EXAMPLE.COM",
                Email = "​​Karim.Basem9bee@example.com",
                NormalizedEmail = "​​KARIM.BASEM9BEE@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "​​Karim",
                LastName = "Basem9bee",
                PhoneNumber = "01273133463"
            },

            new User
            {
                Id = "40979744-ed6b-11ed-8abc-105badc84798",
                UserName = "Minali.Medhat86ba@example.com",
                NormalizedUserName = "MINALI.MEDHAT86BA@EXAMPLE.COM",
                Email = "Minali.Medhat86ba@example.com",
                NormalizedEmail = "MINALI.MEDHAT86BA@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Minali",
                LastName = "Medhat86ba",
                PhoneNumber = "01279049557"
            },

            new User
            {
                Id = "4097c4fc-ed6b-11ed-84e8-105badc84798",
                UserName = "Bilal.Zachariah83af@example.com",
                NormalizedUserName = "BILAL.ZACHARIAH83AF@EXAMPLE.COM",
                Email = "Bilal.Zachariah83af@example.com",
                NormalizedEmail = "BILAL.ZACHARIAH83AF@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Bilal",
                LastName = "Zachariah83af",
                PhoneNumber = "01293395937"
            },

            new User
            {
                Id = "4097c4fe-ed6b-11ed-b56a-105badc84798",
                UserName = "Abi.Radwana902@example.com",
                NormalizedUserName = "ABI.RADWANA902@EXAMPLE.COM",
                Email = "Abi.Radwana902@example.com",
                NormalizedEmail = "ABI.RADWANA902@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Abi",
                LastName = "Radwana902",
                PhoneNumber = "01269899834"
            },

            new User
            {
                Id = "4097c500-ed6b-11ed-b1ae-105badc84798",
                UserName = "Russell.Hosni9590@example.com",
                NormalizedUserName = "RUSSELL.HOSNI9590@EXAMPLE.COM",
                Email = "Russell.Hosni9590@example.com",
                NormalizedEmail = "RUSSELL.HOSNI9590@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Russell",
                LastName = "Hosni9590",
                PhoneNumber = "01219006694"
            },

            new User
            {
                Id = "4097d8e5-ed6b-11ed-8a0f-105badc84798",
                UserName = "Samhi.Baqibff9@example.com",
                NormalizedUserName = "SAMHI.BAQIBFF9@EXAMPLE.COM",
                Email = "Samhi.Baqibff9@example.com",
                NormalizedEmail = "SAMHI.BAQIBFF9@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Samhi",
                LastName = "Baqibff9",
                PhoneNumber = "01254158559"
            },

            new User
            {
                Id = "4097d8e7-ed6b-11ed-b377-105badc84798",
                UserName = "Ghanem.Adham8b37@example.com",
                NormalizedUserName = "GHANEM.ADHAM8B37@EXAMPLE.COM",
                Email = "Ghanem.Adham8b37@example.com",
                NormalizedEmail = "GHANEM.ADHAM8B37@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Ghanem",
                LastName = "Adham8b37",
                PhoneNumber = "01217050688"
            },

            new User
            {
                Id = "4097d8e9-ed6b-11ed-83d1-105badc84798",
                UserName = "Dagher.Hilali951a@example.com",
                NormalizedUserName = "DAGHER.HILALI951A@EXAMPLE.COM",
                Email = "Dagher.Hilali951a@example.com",
                NormalizedEmail = "DAGHER.HILALI951A@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Dagher",
                LastName = "Hilali951a",
                PhoneNumber = "01268897899"
            },

            new User
            {
                Id = "4097d8eb-ed6b-11ed-8f98-105badc84798",
                UserName = "Hussein.Sameha5e1@example.com",
                NormalizedUserName = "HUSSEIN.SAMEHA5E1@EXAMPLE.COM",
                Email = "Hussein.Sameha5e1@example.com",
                NormalizedEmail = "HUSSEIN.SAMEHA5E1@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Hussein",
                LastName = "Sameha5e1",
                PhoneNumber = "01242105816"
            },

            new User
            {
                Id = "4097d8ed-ed6b-11ed-9f99-105badc84798",
                UserName = "Hamaqy.Saber9b17@example.com",
                NormalizedUserName = "HAMAQY.SABER9B17@EXAMPLE.COM",
                Email = "Hamaqy.Saber9b17@example.com",
                NormalizedEmail = "HAMAQY.SABER9B17@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Hamaqy",
                LastName = "Saber9b17",
                PhoneNumber = "01273898120"
            },

            new User
            {
                Id = "4097d8ef-ed6b-11ed-8cd4-105badc84798",
                UserName = "Sheila.Sheilaa655@example.com",
                NormalizedUserName = "SHEILA.SHEILAA655@EXAMPLE.COM",
                Email = "Sheila.Sheilaa655@example.com",
                NormalizedEmail = "SHEILA.SHEILAA655@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sheila",
                LastName = "Sheilaa655",
                PhoneNumber = "01267569088"
            },

            new User
            {
                Id = "4097d8f1-ed6b-11ed-aa86-105badc84798",
                UserName = "Daniel.Bahib5ad@example.com",
                NormalizedUserName = "DANIEL.BAHIB5AD@EXAMPLE.COM",
                Email = "Daniel.Bahib5ad@example.com",
                NormalizedEmail = "DANIEL.BAHIB5AD@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Daniel",
                LastName = "Bahib5ad",
                PhoneNumber = "01262123625"
            },

            new User
            {
                Id = "4097d8f3-ed6b-11ed-9479-105badc84798",
                UserName = "Halsi.Kolthouma5c7@example.com",
                NormalizedUserName = "HALSI.KOLTHOUMA5C7@EXAMPLE.COM",
                Email = "Halsi.Kolthouma5c7@example.com",
                NormalizedEmail = "HALSI.KOLTHOUMA5C7@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Halsi",
                LastName = "Kolthouma5c7",
                PhoneNumber = "01262132489"
            },

            new User
            {
                Id = "4097d8f5-ed6b-11ed-aca2-105badc84798",
                UserName = "Mahmoud.Wael9d18@example.com",
                NormalizedUserName = "MAHMOUD.WAEL9D18@EXAMPLE.COM",
                Email = "Mahmoud.Wael9d18@example.com",
                NormalizedEmail = "MAHMOUD.WAEL9D18@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Mahmoud",
                LastName = "Wael9d18",
                PhoneNumber = "01231638303"
            },

            new User
            {
                Id = "4097d8f7-ed6b-11ed-98e4-105badc84798",
                UserName = "Osama.Basem92cb@example.com",
                NormalizedUserName = "OSAMA.BASEM92CB@EXAMPLE.COM",
                Email = "Osama.Basem92cb@example.com",
                NormalizedEmail = "OSAMA.BASEM92CB@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Osama",
                LastName = "Basem92cb",
                PhoneNumber = "01218566576"
            },

            new User
            {
                Id = "4097d8f9-ed6b-11ed-8f23-105badc84798",
                UserName = "Nahar.Shehabiac20@example.com",
                NormalizedUserName = "NAHAR.SHEHABIAC20@EXAMPLE.COM",
                Email = "Nahar.Shehabiac20@example.com",
                NormalizedEmail = "NAHAR.SHEHABIAC20@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Nahar",
                LastName = "Shehabiac20",
                PhoneNumber = "01241146819"
            },

            new User
            {
                Id = "4097d8fb-ed6b-11ed-b285-105badc84798",
                UserName = "Marawan.Zachariah8daa@example.com",
                NormalizedUserName = "MARAWAN.ZACHARIAH8DAA@EXAMPLE.COM",
                Email = "Marawan.Zachariah8daa@example.com",
                NormalizedEmail = "MARAWAN.ZACHARIAH8DAA@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Marawan",
                LastName = "Zachariah8daa",
                PhoneNumber = "01292596275"
            },

            new User
            {
                Id = "4097d8fd-ed6b-11ed-b6a3-105badc84798",
                UserName = "Adham.Dagherb00d@example.com",
                NormalizedUserName = "ADHAM.DAGHERB00D@EXAMPLE.COM",
                Email = "Adham.Dagherb00d@example.com",
                NormalizedEmail = "ADHAM.DAGHERB00D@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Adham",
                LastName = "Dagherb00d",
                PhoneNumber = "01264741807"
            },

            new User
            {
                Id = "4097d8ff-ed6b-11ed-85f9-105badc84798",
                UserName = "Majid.Asami943b@example.com",
                NormalizedUserName = "MAJID.ASAMI943B@EXAMPLE.COM",
                Email = "Majid.Asami943b@example.com",
                NormalizedEmail = "MAJID.ASAMI943B@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Majid",
                LastName = "Asami943b",
                PhoneNumber = "01258015535"
            },

            new User
            {
                Id = "4097d901-ed6b-11ed-9297-105badc84798",
                UserName = "Ghaith.Bahiracf6@example.com",
                NormalizedUserName = "GHAITH.BAHIRACF6@EXAMPLE.COM",
                Email = "Ghaith.Bahiracf6@example.com",
                NormalizedEmail = "GHAITH.BAHIRACF6@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Ghaith",
                LastName = "Bahiracf6",
                PhoneNumber = "01232394458"
            },

            new User
            {
                Id = "4097d903-ed6b-11ed-855f-105badc84798",
                UserName = "Yunus.Zachariah8945@example.com",
                NormalizedUserName = "YUNUS.ZACHARIAH8945@EXAMPLE.COM",
                Email = "Yunus.Zachariah8945@example.com",
                NormalizedEmail = "YUNUS.ZACHARIAH8945@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Yunus",
                LastName = "Zachariah8945",
                PhoneNumber = "01288556434"
            },

            new User
            {
                Id = "4097d905-ed6b-11ed-b302-105badc84798",
                UserName = "Ramzy.Osamaafb5@example.com",
                NormalizedUserName = "RAMZY.OSAMAAFB5@EXAMPLE.COM",
                Email = "Ramzy.Osamaafb5@example.com",
                NormalizedEmail = "RAMZY.OSAMAAFB5@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Ramzy",
                LastName = "Osamaafb5",
                PhoneNumber = "01272846023"
            },

            new User
            {
                Id = "4097d907-ed6b-11ed-b6b6-105badc84798",
                UserName = "Bahi.Yisrib844@example.com",
                NormalizedUserName = "BAHI.YISRIB844@EXAMPLE.COM",
                Email = "Bahi.Yisrib844@example.com",
                NormalizedEmail = "BAHI.YISRIB844@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Bahi",
                LastName = "Yisrib844",
                PhoneNumber = "01289220737"
            },

            new User
            {
                Id = "4097d909-ed6b-11ed-93d8-105badc84798",
                UserName = "Sheikh.Kafar97f1@example.com",
                NormalizedUserName = "SHEIKH.KAFAR97F1@EXAMPLE.COM",
                Email = "Sheikh.Kafar97f1@example.com",
                NormalizedEmail = "SHEIKH.KAFAR97F1@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sheikh",
                LastName = "Kafar97f1",
                PhoneNumber = "01228387515"
            },

            new User
            {
                Id = "4097d90b-ed6b-11ed-a99b-105badc84798",
                UserName = "Fares.Hassanbdf6@example.com",
                NormalizedUserName = "FARES.HASSANBDF6@EXAMPLE.COM",
                Email = "Fares.Hassanbdf6@example.com",
                NormalizedEmail = "FARES.HASSANBDF6@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Fares",
                LastName = "Hassanbdf6",
                PhoneNumber = "01278694578"
            },

            new User
            {
                Id = "4097d90d-ed6b-11ed-956f-105badc84798",
                UserName = "Samir.Sheila8b49@example.com",
                NormalizedUserName = "SAMIR.SHEILA8B49@EXAMPLE.COM",
                Email = "Samir.Sheila8b49@example.com",
                NormalizedEmail = "SAMIR.SHEILA8B49@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Samir",
                LastName = "Sheila8b49",
                PhoneNumber = "01214800867"
            },

            new User
            {
                Id = "4097d90f-ed6b-11ed-a0cc-105badc84798",
                UserName = "Yakon.Adhamaaa9@example.com",
                NormalizedUserName = "YAKON.ADHAMAAA9@EXAMPLE.COM",
                Email = "Yakon.Adhamaaa9@example.com",
                NormalizedEmail = "YAKON.ADHAMAAA9@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Yakon",
                LastName = "Adhamaaa9",
                PhoneNumber = "01299862932"
            },

            new User
            {
                Id = "4097d911-ed6b-11ed-b614-105badc84798",
                UserName = "Fidaa.Sameha430@example.com",
                NormalizedUserName = "FIDAA.SAMEHA430@EXAMPLE.COM",
                Email = "Fidaa.Sameha430@example.com",
                NormalizedEmail = "FIDAA.SAMEHA430@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Fidaa",
                LastName = "Sameha430",
                PhoneNumber = "01283485131"
            },

            new User
            {
                Id = "4097d913-ed6b-11ed-816e-105badc84798",
                UserName = "Yusuf.Baqi8945@example.com",
                NormalizedUserName = "YUSUF.BAQI8945@EXAMPLE.COM",
                Email = "Yusuf.Baqi8945@example.com",
                NormalizedEmail = "YUSUF.BAQI8945@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Yusuf",
                LastName = "Baqi8945",
                PhoneNumber = "01235586777"
            },

            new User
            {
                Id = "4097d915-ed6b-11ed-a890-105badc84798",
                UserName = "Kahter.Minali8e83@example.com",
                NormalizedUserName = "KAHTER.MINALI8E83@EXAMPLE.COM",
                Email = "Kahter.Minali8e83@example.com",
                NormalizedEmail = "KAHTER.MINALI8E83@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Kahter",
                LastName = "Minali8e83",
                PhoneNumber = "01237394610"
            },

            new User
            {
                Id = "4098b15b-ed6b-11ed-9dc2-105badc84798",
                UserName = "Hamaki.Waela1d0@example.com",
                NormalizedUserName = "HAMAKI.WAELA1D0@EXAMPLE.COM",
                Email = "Hamaki.Waela1d0@example.com",
                NormalizedEmail = "HAMAKI.WAELA1D0@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Hamaki",
                LastName = "Waela1d0",
                PhoneNumber = "01216731361"
            },

            new User
            {
                Id = "4098b15d-ed6b-11ed-8903-105badc84798",
                UserName = "Samhi.Ahmed8548@example.com",
                NormalizedUserName = "SAMHI.AHMED8548@EXAMPLE.COM",
                Email = "Samhi.Ahmed8548@example.com",
                NormalizedEmail = "SAMHI.AHMED8548@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Samhi",
                LastName = "Ahmed8548",
                PhoneNumber = "01295806415"
            },

            new User
            {
                Id = "4098b15f-ed6b-11ed-a7e2-105badc84798",
                UserName = "Hishami.Dagherbd70@example.com",
                NormalizedUserName = "HISHAMI.DAGHERBD70@EXAMPLE.COM",
                Email = "Hishami.Dagherbd70@example.com",
                NormalizedEmail = "HISHAMI.DAGHERBD70@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Hishami",
                LastName = "Dagherbd70",
                PhoneNumber = "01216081772"
            },

            new User
            {
                Id = "4098b161-ed6b-11ed-b0d0-105badc84798",
                UserName = "Minali.Haor85f2@example.com",
                NormalizedUserName = "MINALI.HAOR85F2@EXAMPLE.COM",
                Email = "Minali.Haor85f2@example.com",
                NormalizedEmail = "MINALI.HAOR85F2@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Minali",
                LastName = "Haor85f2",
                PhoneNumber = "01264213362"
            },

            new User
            {
                Id = "4098b163-ed6b-11ed-b901-105badc84798",
                UserName = "Bilal.Asimac85@example.com",
                NormalizedUserName = "BILAL.ASIMAC85@EXAMPLE.COM",
                Email = "Bilal.Asimac85@example.com",
                NormalizedEmail = "BILAL.ASIMAC85@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Bilal",
                LastName = "Asimac85",
                PhoneNumber = "01236247368"
            },

            new User
            {
                Id = "4098b165-ed6b-11ed-a2fd-105badc84798",
                UserName = "Kamel.Waseemb3f8@example.com",
                NormalizedUserName = "KAMEL.WASEEMB3F8@EXAMPLE.COM",
                Email = "Kamel.Waseemb3f8@example.com",
                NormalizedEmail = "KAMEL.WASEEMB3F8@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Kamel",
                LastName = "Waseemb3f8",
                PhoneNumber = "01227742375"
            },

            new User
            {
                Id = "4098b167-ed6b-11ed-9dcf-105badc84798",
                UserName = "Yamen.Hilalia185@example.com",
                NormalizedUserName = "YAMEN.HILALIA185@EXAMPLE.COM",
                Email = "Yamen.Hilalia185@example.com",
                NormalizedEmail = "YAMEN.HILALIA185@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Yamen",
                LastName = "Hilalia185",
                PhoneNumber = "01226708337"
            },

            new User
            {
                Id = "4098b169-ed6b-11ed-9b69-105badc84798",
                UserName = "Sheila.Badri806c@example.com",
                NormalizedUserName = "SHEILA.BADRI806C@EXAMPLE.COM",
                Email = "Sheila.Badri806c@example.com",
                NormalizedEmail = "SHEILA.BADRI806C@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sheila",
                LastName = "Badri806c",
                PhoneNumber = "01250629461"
            },

            new User
            {
                Id = "4098b16b-ed6b-11ed-bc54-105badc84798",
                UserName = "Bahi.Sharma930@example.com",
                NormalizedUserName = "BAHI.SHARMA930@EXAMPLE.COM",
                Email = "Bahi.Sharma930@example.com",
                NormalizedEmail = "BAHI.SHARMA930@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Bahi",
                LastName = "Sharma930",
                PhoneNumber = "01264225474"
            },

            new User
            {
                Id = "4098b16d-ed6b-11ed-abd9-105badc84798",
                UserName = "Hilal.Hilal9e6a@example.com",
                NormalizedUserName = "HILAL.HILAL9E6A@EXAMPLE.COM",
                Email = "Hilal.Hilal9e6a@example.com",
                NormalizedEmail = "HILAL.HILAL9E6A@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Hilal",
                LastName = "Hilal9e6a",
                PhoneNumber = "01280080449"
            },

            new User
            {
                Id = "4098b16f-ed6b-11ed-ae81-105badc84798",
                UserName = "Yisri.Saden9224@example.com",
                NormalizedUserName = "YISRI.SADEN9224@EXAMPLE.COM",
                Email = "Yisri.Saden9224@example.com",
                NormalizedEmail = "YISRI.SADEN9224@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Yisri",
                LastName = "Saden9224",
                PhoneNumber = "01266306998"
            },

            new User
            {
                Id = "4098b171-ed6b-11ed-bd08-105badc84798",
                UserName = "Helsey.Samiraa00@example.com",
                NormalizedUserName = "HELSEY.SAMIRAA00@EXAMPLE.COM",
                Email = "Helsey.Samiraa00@example.com",
                NormalizedEmail = "HELSEY.SAMIRAA00@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Helsey",
                LastName = "Samiraa00",
                PhoneNumber = "01217458085"
            },

            new User
            {
                Id = "4098b173-ed6b-11ed-9e0c-105badc84798",
                UserName = "Wael.Waseembb41@example.com",
                NormalizedUserName = "WAEL.WASEEMBB41@EXAMPLE.COM",
                Email = "Wael.Waseembb41@example.com",
                NormalizedEmail = "WAEL.WASEEMBB41@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Wael",
                LastName = "Waseembb41",
                PhoneNumber = "01284333280"
            },

            new User
            {
                Id = "4098b175-ed6b-11ed-a3d4-105badc84798",
                UserName = "Najm.Bahirbab8@example.com",
                NormalizedUserName = "NAJM.BAHIRBAB8@EXAMPLE.COM",
                Email = "Najm.Bahirbab8@example.com",
                NormalizedEmail = "NAJM.BAHIRBAB8@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Najm",
                LastName = "Bahirbab8",
                PhoneNumber = "01287732484"
            },

            new User
            {
                Id = "4098b177-ed6b-11ed-b8db-105badc84798",
                UserName = "Dahi.Adelbabc@example.com",
                NormalizedUserName = "DAHI.ADELBABC@EXAMPLE.COM",
                Email = "Dahi.Adelbabc@example.com",
                NormalizedEmail = "DAHI.ADELBABC@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Dahi",
                LastName = "Adelbabc",
                PhoneNumber = "01214965124"
            },

            new User
            {
                Id = "4098b179-ed6b-11ed-acd6-105badc84798",
                UserName = "Sajid.Majdibec5@example.com",
                NormalizedUserName = "SAJID.MAJDIBEC5@EXAMPLE.COM",
                Email = "Sajid.Majdibec5@example.com",
                NormalizedEmail = "SAJID.MAJDIBEC5@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sajid",
                LastName = "Majdibec5",
                PhoneNumber = "01226566171"
            },

            new User
            {
                Id = "4098b17b-ed6b-11ed-bfb2-105badc84798",
                UserName = "Salim.Waseem9d1b@example.com",
                NormalizedUserName = "SALIM.WASEEM9D1B@EXAMPLE.COM",
                Email = "Salim.Waseem9d1b@example.com",
                NormalizedEmail = "SALIM.WASEEM9D1B@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Salim",
                LastName = "Waseem9d1b",
                PhoneNumber = "01223503517"
            },

            new User
            {
                Id = "4098b17d-ed6b-11ed-a36b-105badc84798",
                UserName = "Baqi.Zaki9e26@example.com",
                NormalizedUserName = "BAQI.ZAKI9E26@EXAMPLE.COM",
                Email = "Baqi.Zaki9e26@example.com",
                NormalizedEmail = "BAQI.ZAKI9E26@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Baqi",
                LastName = "Zaki9e26",
                PhoneNumber = "01295728341"
            },

            new User
            {
                Id = "4098b17f-ed6b-11ed-9639-105badc84798",
                UserName = "Sahami.Sheikhy80fb@example.com",
                NormalizedUserName = "SAHAMI.SHEIKHY80FB@EXAMPLE.COM",
                Email = "Sahami.Sheikhy80fb@example.com",
                NormalizedEmail = "SAHAMI.SHEIKHY80FB@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sahami",
                LastName = "Sheikhy80fb",
                PhoneNumber = "01269675036"
            },

            new User
            {
                Id = "4098b181-ed6b-11ed-84ef-105badc84798",
                UserName = "Badri.Sareea3a3@example.com",
                NormalizedUserName = "BADRI.SAREEA3A3@EXAMPLE.COM",
                Email = "Badri.Sareea3a3@example.com",
                NormalizedEmail = "BADRI.SAREEA3A3@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Badri",
                LastName = "Sareea3a3",
                PhoneNumber = "01260728699"
            },

            new User
            {
                Id = "4098b183-ed6b-11ed-91ba-105badc84798",
                UserName = "Faisal.Ryan93db@example.com",
                NormalizedUserName = "FAISAL.RYAN93DB@EXAMPLE.COM",
                Email = "Faisal.Ryan93db@example.com",
                NormalizedEmail = "FAISAL.RYAN93DB@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Faisal",
                LastName = "Ryan93db",
                PhoneNumber = "01215094196"
            },

            new User
            {
                Id = "4098b185-ed6b-11ed-a00a-105badc84798",
                UserName = "Omar.Sahami9f51@example.com",
                NormalizedUserName = "OMAR.SAHAMI9F51@EXAMPLE.COM",
                Email = "Omar.Sahami9f51@example.com",
                NormalizedEmail = "OMAR.SAHAMI9F51@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Omar",
                LastName = "Sahami9f51",
                PhoneNumber = "01271704961"
            },

            new User
            {
                Id = "4098b187-ed6b-11ed-911e-105badc84798",
                UserName = "Loay.Basem8ee7@example.com",
                NormalizedUserName = "LOAY.BASEM8EE7@EXAMPLE.COM",
                Email = "Loay.Basem8ee7@example.com",
                NormalizedEmail = "LOAY.BASEM8EE7@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Loay",
                LastName = "Basem8ee7",
                PhoneNumber = "01253444230"
            },

            new User
            {
                Id = "4098b189-ed6b-11ed-97ff-105badc84798",
                UserName = "Halsi.Ryana491@example.com",
                NormalizedUserName = "HALSI.RYANA491@EXAMPLE.COM",
                Email = "Halsi.Ryana491@example.com",
                NormalizedEmail = "HALSI.RYANA491@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Halsi",
                LastName = "Ryana491",
                PhoneNumber = "01243084731"
            },

            new User
            {
                Id = "4098b18b-ed6b-11ed-9c96-105badc84798",
                UserName = "Noah.Waela26a@example.com",
                NormalizedUserName = "NOAH.WAELA26A@EXAMPLE.COM",
                Email = "Noah.Waela26a@example.com",
                NormalizedEmail = "NOAH.WAELA26A@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Noah",
                LastName = "Waela26a",
                PhoneNumber = "01265189792"
            },

            new User
            {
                Id = "4098b18d-ed6b-11ed-86a0-105badc84798",
                UserName = "Malek.Minalia6b0@example.com",
                NormalizedUserName = "MALEK.MINALIA6B0@EXAMPLE.COM",
                Email = "Malek.Minalia6b0@example.com",
                NormalizedEmail = "MALEK.MINALIA6B0@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Malek",
                LastName = "Minalia6b0",
                PhoneNumber = "01272439716"
            },

            new User
            {
                Id = "4098b18f-ed6b-11ed-9b38-105badc84798",
                UserName = "Kahter.Sharmaf90@example.com",
                NormalizedUserName = "KAHTER.SHARMAF90@EXAMPLE.COM",
                Email = "Kahter.Sharmaf90@example.com",
                NormalizedEmail = "KAHTER.SHARMAF90@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Kahter",
                LastName = "Sharmaf90",
                PhoneNumber = "01297951939"
            },

            new User
            {
                Id = "4098b191-ed6b-11ed-87ba-105badc84798",
                UserName = "Sajid.Zachariah82c1@example.com",
                NormalizedUserName = "SAJID.ZACHARIAH82C1@EXAMPLE.COM",
                Email = "Sajid.Zachariah82c1@example.com",
                NormalizedEmail = "SAJID.ZACHARIAH82C1@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sajid",
                LastName = "Zachariah82c1",
                PhoneNumber = "01218467982"
            },

            new User
            {
                Id = "4098b193-ed6b-11ed-b6af-105badc84798",
                UserName = "Dahi.Danielad4c@example.com",
                NormalizedUserName = "DAHI.DANIELAD4C@EXAMPLE.COM",
                Email = "Dahi.Danielad4c@example.com",
                NormalizedEmail = "DAHI.DANIELAD4C@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Dahi",
                LastName = "Danielad4c",
                PhoneNumber = "01214991654"
            },

            new User
            {
                Id = "4098b195-ed6b-11ed-a317-105badc84798",
                UserName = "Ahmed.Samehbda8@example.com",
                NormalizedUserName = "AHMED.SAMEHBDA8@EXAMPLE.COM",
                Email = "Ahmed.Samehbda8@example.com",
                NormalizedEmail = "AHMED.SAMEHBDA8@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Ahmed",
                LastName = "Samehbda8",
                PhoneNumber = "01214023531"
            },

            new User
            {
                Id = "4098b197-ed6b-11ed-a380-105badc84798",
                UserName = "Hamaki.Salimb1fa@example.com",
                NormalizedUserName = "HAMAKI.SALIMB1FA@EXAMPLE.COM",
                Email = "Hamaki.Salimb1fa@example.com",
                NormalizedEmail = "HAMAKI.SALIMB1FA@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Hamaki",
                LastName = "Salimb1fa",
                PhoneNumber = "01237177143"
            },

            new User
            {
                Id = "4098b199-ed6b-11ed-bf11-105badc84798",
                UserName = "Latfi.Latfi8c51@example.com",
                NormalizedUserName = "LATFI.LATFI8C51@EXAMPLE.COM",
                Email = "Latfi.Latfi8c51@example.com",
                NormalizedEmail = "LATFI.LATFI8C51@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Latfi",
                LastName = "Latfi8c51",
                PhoneNumber = "01287157511"
            },

            new User
            {
                Id = "4098b19b-ed6b-11ed-9acc-105badc84798",
                UserName = "Fadi.Medhatbc78@example.com",
                NormalizedUserName = "FADI.MEDHATBC78@EXAMPLE.COM",
                Email = "Fadi.Medhatbc78@example.com",
                NormalizedEmail = "FADI.MEDHATBC78@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Fadi",
                LastName = "Medhatbc78",
                PhoneNumber = "01231139763"
            },

            new User
            {
                Id = "4098b19d-ed6b-11ed-9edb-105badc84798",
                UserName = "Fahed.Minali85eb@example.com",
                NormalizedUserName = "FAHED.MINALI85EB@EXAMPLE.COM",
                Email = "Fahed.Minali85eb@example.com",
                NormalizedEmail = "FAHED.MINALI85EB@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Fahed",
                LastName = "Minali85eb",
                PhoneNumber = "01256275160"
            },

            new User
            {
                Id = "4098b19f-ed6b-11ed-8419-105badc84798",
                UserName = "Wael.Zachariahb0c2@example.com",
                NormalizedUserName = "WAEL.ZACHARIAHB0C2@EXAMPLE.COM",
                Email = "Wael.Zachariahb0c2@example.com",
                NormalizedEmail = "WAEL.ZACHARIAHB0C2@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Wael",
                LastName = "Zachariahb0c2",
                PhoneNumber = "01218944525"
            },

            new User
            {
                Id = "4098b1a1-ed6b-11ed-abac-105badc84798",
                UserName = "Zarif.Bahi9d47@example.com",
                NormalizedUserName = "ZARIF.BAHI9D47@EXAMPLE.COM",
                Email = "Zarif.Bahi9d47@example.com",
                NormalizedEmail = "ZARIF.BAHI9D47@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Zarif",
                LastName = "Bahi9d47",
                PhoneNumber = "01283196507"
            },

            new User
            {
                Id = "4098b1a3-ed6b-11ed-a583-105badc84798",
                UserName = "Bara.Bahia873@example.com",
                NormalizedUserName = "BARA.BAHIA873@EXAMPLE.COM",
                Email = "Bara.Bahia873@example.com",
                NormalizedEmail = "BARA.BAHIA873@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Bara",
                LastName = "Bahia873",
                PhoneNumber = "01234054165"
            },

            new User
            {
                Id = "4098b1a5-ed6b-11ed-bf0d-105badc84798",
                UserName = "Hamaqy.Noorad52@example.com",
                NormalizedUserName = "HAMAQY.NOORAD52@EXAMPLE.COM",
                Email = "Hamaqy.Noorad52@example.com",
                NormalizedEmail = "HAMAQY.NOORAD52@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Hamaqy",
                LastName = "Noorad52",
                PhoneNumber = "01249013827"
            },

            new User
            {
                Id = "4098b1a7-ed6b-11ed-bd68-105badc84798",
                UserName = "Fares.Bahirb03c@example.com",
                NormalizedUserName = "FARES.BAHIRB03C@EXAMPLE.COM",
                Email = "Fares.Bahirb03c@example.com",
                NormalizedEmail = "FARES.BAHIRB03C@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Fares",
                LastName = "Bahirb03c",
                PhoneNumber = "01245035379"
            },

            new User
            {
                Id = "4099e9d3-ed6b-11ed-b4e8-105badc84798",
                UserName = "Jalal.Majid82af@example.com",
                NormalizedUserName = "JALAL.MAJID82AF@EXAMPLE.COM",
                Email = "Jalal.Majid82af@example.com",
                NormalizedEmail = "JALAL.MAJID82AF@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Jalal",
                LastName = "Majid82af",
                PhoneNumber = "01292058402"
            },

            new User
            {
                Id = "4099e9d5-ed6b-11ed-8061-105badc84798",
                UserName = "Saden.Waelb102@example.com",
                NormalizedUserName = "SADEN.WAELB102@EXAMPLE.COM",
                Email = "Saden.Waelb102@example.com",
                NormalizedEmail = "SADEN.WAELB102@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Saden",
                LastName = "Waelb102",
                PhoneNumber = "01227228988"
            },

            new User
            {
                Id = "4099e9d7-ed6b-11ed-976d-105badc84798",
                UserName = "Dahi.Sajid849e@example.com",
                NormalizedUserName = "DAHI.SAJID849E@EXAMPLE.COM",
                Email = "Dahi.Sajid849e@example.com",
                NormalizedEmail = "DAHI.SAJID849E@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Dahi",
                LastName = "Sajid849e",
                PhoneNumber = "01263561273"
            },

            new User
            {
                Id = "4099e9d9-ed6b-11ed-bca8-105badc84798",
                UserName = "Adel.Hilalab94@example.com",
                NormalizedUserName = "ADEL.HILALAB94@EXAMPLE.COM",
                Email = "Adel.Hilalab94@example.com",
                NormalizedEmail = "ADEL.HILALAB94@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Adel",
                LastName = "Hilalab94",
                PhoneNumber = "01275990302"
            },

            new User
            {
                Id = "4099e9db-ed6b-11ed-9009-105badc84798",
                UserName = "Samir.Bassam897e@example.com",
                NormalizedUserName = "SAMIR.BASSAM897E@EXAMPLE.COM",
                Email = "Samir.Bassam897e@example.com",
                NormalizedEmail = "SAMIR.BASSAM897E@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Samir",
                LastName = "Bassam897e",
                PhoneNumber = "01234422680"
            },

            new User
            {
                Id = "4099e9dd-ed6b-11ed-8e81-105badc84798",
                UserName = "Sajid.Sheikha8b1@example.com",
                NormalizedUserName = "SAJID.SHEIKHA8B1@EXAMPLE.COM",
                Email = "Sajid.Sheikha8b1@example.com",
                NormalizedEmail = "SAJID.SHEIKHA8B1@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sajid",
                LastName = "Sheikha8b1",
                PhoneNumber = "01210144261"
            },

            new User
            {
                Id = "4099e9df-ed6b-11ed-bb40-105badc84798",
                UserName = "Russell.Ghanem9478@example.com",
                NormalizedUserName = "RUSSELL.GHANEM9478@EXAMPLE.COM",
                Email = "Russell.Ghanem9478@example.com",
                NormalizedEmail = "RUSSELL.GHANEM9478@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Russell",
                LastName = "Ghanem9478",
                PhoneNumber = "01290670217"
            },

            new User
            {
                Id = "4099e9e1-ed6b-11ed-b492-105badc84798",
                UserName = "Haor.Wael82ce@example.com",
                NormalizedUserName = "HAOR.WAEL82CE@EXAMPLE.COM",
                Email = "Haor.Wael82ce@example.com",
                NormalizedEmail = "HAOR.WAEL82CE@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Haor",
                LastName = "Wael82ce",
                PhoneNumber = "01255444010"
            },

            new User
            {
                Id = "4099e9e3-ed6b-11ed-92d1-105badc84798",
                UserName = "Dagher.Zachariahb6b1@example.com",
                NormalizedUserName = "DAGHER.ZACHARIAHB6B1@EXAMPLE.COM",
                Email = "Dagher.Zachariahb6b1@example.com",
                NormalizedEmail = "DAGHER.ZACHARIAHB6B1@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Dagher",
                LastName = "Zachariahb6b1",
                PhoneNumber = "01224788521"
            },

            new User
            {
                Id = "4099e9e5-ed6b-11ed-b38a-105badc84798",
                UserName = "Hishami.Halsib62b@example.com",
                NormalizedUserName = "HISHAMI.HALSIB62B@EXAMPLE.COM",
                Email = "Hishami.Halsib62b@example.com",
                NormalizedEmail = "HISHAMI.HALSIB62B@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Hishami",
                LastName = "Halsib62b",
                PhoneNumber = "01237896983"
            },

            new User
            {
                Id = "4099e9e7-ed6b-11ed-9432-105badc84798",
                UserName = "Marawan.Shahib1ef@example.com",
                NormalizedUserName = "MARAWAN.SHAHIB1EF@EXAMPLE.COM",
                Email = "Marawan.Shahib1ef@example.com",
                NormalizedEmail = "MARAWAN.SHAHIB1EF@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Marawan",
                LastName = "Shahib1ef",
                PhoneNumber = "01271273824"
            },

            new User
            {
                Id = "4099e9e9-ed6b-11ed-af1e-105badc84798",
                UserName = "Fidaa.Baqia533@example.com",
                NormalizedUserName = "FIDAA.BAQIA533@EXAMPLE.COM",
                Email = "Fidaa.Baqia533@example.com",
                NormalizedEmail = "FIDAA.BAQIA533@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Fidaa",
                LastName = "Baqia533",
                PhoneNumber = "01218117934"
            },

            new User
            {
                Id = "4099e9eb-ed6b-11ed-8d45-105badc84798",
                UserName = "Radwan.Kamel90c3@example.com",
                NormalizedUserName = "RADWAN.KAMEL90C3@EXAMPLE.COM",
                Email = "Radwan.Kamel90c3@example.com",
                NormalizedEmail = "RADWAN.KAMEL90C3@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Radwan",
                LastName = "Kamel90c3",
                PhoneNumber = "01262457869"
            },

            new User
            {
                Id = "4099e9ed-ed6b-11ed-8755-105badc84798",
                UserName = "Loay.Bahi9d3c@example.com",
                NormalizedUserName = "LOAY.BAHI9D3C@EXAMPLE.COM",
                Email = "Loay.Bahi9d3c@example.com",
                NormalizedEmail = "LOAY.BAHI9D3C@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Loay",
                LastName = "Bahi9d3c",
                PhoneNumber = "01298984959"
            },

            new User
            {
                Id = "4099e9ef-ed6b-11ed-a4a1-105badc84798",
                UserName = "Ryan.Moses82e6@example.com",
                NormalizedUserName = "RYAN.MOSES82E6@EXAMPLE.COM",
                Email = "Ryan.Moses82e6@example.com",
                NormalizedEmail = "RYAN.MOSES82E6@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Ryan",
                LastName = "Moses82e6",
                PhoneNumber = "01287007236"
            },

            new User
            {
                Id = "4099e9f1-ed6b-11ed-b017-105badc84798",
                UserName = "Fahed.Hishamia1b1@example.com",
                NormalizedUserName = "FAHED.HISHAMIA1B1@EXAMPLE.COM",
                Email = "Fahed.Hishamia1b1@example.com",
                NormalizedEmail = "FAHED.HISHAMIA1B1@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Fahed",
                LastName = "Hishamia1b1",
                PhoneNumber = "01295741865"
            },

            new User
            {
                Id = "4099e9f3-ed6b-11ed-92c8-105badc84798",
                UserName = "Horr.Basselb860@example.com",
                NormalizedUserName = "HORR.BASSELB860@EXAMPLE.COM",
                Email = "Horr.Basselb860@example.com",
                NormalizedEmail = "HORR.BASSELB860@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Horr",
                LastName = "Basselb860",
                PhoneNumber = "01231479095"
            },

            new User
            {
                Id = "4099e9f5-ed6b-11ed-9bbb-105badc84798",
                UserName = "Asim.Bahia196@example.com",
                NormalizedUserName = "ASIM.BAHIA196@EXAMPLE.COM",
                Email = "Asim.Bahia196@example.com",
                NormalizedEmail = "ASIM.BAHIA196@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Asim",
                LastName = "Bahia196",
                PhoneNumber = "01293315685"
            },

            new User
            {
                Id = "4099e9f7-ed6b-11ed-aa9d-105badc84798",
                UserName = "Bara.Shahib692@example.com",
                NormalizedUserName = "BARA.SHAHIB692@EXAMPLE.COM",
                Email = "Bara.Shahib692@example.com",
                NormalizedEmail = "BARA.SHAHIB692@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Bara",
                LastName = "Shahib692",
                PhoneNumber = "01240292772"
            },

            new User
            {
                Id = "4099e9f9-ed6b-11ed-8af4-105badc84798",
                UserName = "Fadi.Adhama536@example.com",
                NormalizedUserName = "FADI.ADHAMA536@EXAMPLE.COM",
                Email = "Fadi.Adhama536@example.com",
                NormalizedEmail = "FADI.ADHAMA536@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Fadi",
                LastName = "Adhama536",
                PhoneNumber = "01239956926"
            },

            new User
            {
                Id = "4099e9fb-ed6b-11ed-88c6-105badc84798",
                UserName = "Medhat.Hammadbdb5@example.com",
                NormalizedUserName = "MEDHAT.HAMMADBDB5@EXAMPLE.COM",
                Email = "Medhat.Hammadbdb5@example.com",
                NormalizedEmail = "MEDHAT.HAMMADBDB5@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Medhat",
                LastName = "Hammadbdb5",
                PhoneNumber = "01224361401"
            },

            new User
            {
                Id = "4099e9fd-ed6b-11ed-a891-105badc84798",
                UserName = "Najm.Shehabia8de@example.com",
                NormalizedUserName = "NAJM.SHEHABIA8DE@EXAMPLE.COM",
                Email = "Najm.Shehabia8de@example.com",
                NormalizedEmail = "NAJM.SHEHABIA8DE@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Najm",
                LastName = "Shehabia8de",
                PhoneNumber = "01264500973"
            },

            new User
            {
                Id = "4099e9ff-ed6b-11ed-a802-105badc84798",
                UserName = "Hussein.Jalal89d8@example.com",
                NormalizedUserName = "HUSSEIN.JALAL89D8@EXAMPLE.COM",
                Email = "Hussein.Jalal89d8@example.com",
                NormalizedEmail = "HUSSEIN.JALAL89D8@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Hussein",
                LastName = "Jalal89d8",
                PhoneNumber = "01243463663"
            },

            new User
            {
                Id = "4099ea01-ed6b-11ed-a7d5-105badc84798",
                UserName = "Saden.Fares8d49@example.com",
                NormalizedUserName = "SADEN.FARES8D49@EXAMPLE.COM",
                Email = "Saden.Fares8d49@example.com",
                NormalizedEmail = "SADEN.FARES8D49@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Saden",
                LastName = "Fares8d49",
                PhoneNumber = "01231665315"
            },

            new User
            {
                Id = "4099ea03-ed6b-11ed-9ac8-105badc84798",
                UserName = "Bahir.Najma6fb@example.com",
                NormalizedUserName = "BAHIR.NAJMA6FB@EXAMPLE.COM",
                Email = "Bahir.Najma6fb@example.com",
                NormalizedEmail = "BAHIR.NAJMA6FB@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Bahir",
                LastName = "Najma6fb",
                PhoneNumber = "01257564173"
            },

            new User
            {
                Id = "4099ea05-ed6b-11ed-b96b-105badc84798",
                UserName = "Bahi.Fidaa88f9@example.com",
                NormalizedUserName = "BAHI.FIDAA88F9@EXAMPLE.COM",
                Email = "Bahi.Fidaa88f9@example.com",
                NormalizedEmail = "BAHI.FIDAA88F9@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Bahi",
                LastName = "Fidaa88f9",
                PhoneNumber = "01244926851"
            },

            new User
            {
                Id = "4099ea07-ed6b-11ed-9c9b-105badc84798",
                UserName = "Dahi.Waseembc12@example.com",
                NormalizedUserName = "DAHI.WASEEMBC12@EXAMPLE.COM",
                Email = "Dahi.Waseembc12@example.com",
                NormalizedEmail = "DAHI.WASEEMBC12@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Dahi",
                LastName = "Waseembc12",
                PhoneNumber = "01237376445"
            },

            new User
            {
                Id = "4099ea09-ed6b-11ed-9690-105badc84798",
                UserName = "Osama.Hilal82e1@example.com",
                NormalizedUserName = "OSAMA.HILAL82E1@EXAMPLE.COM",
                Email = "Osama.Hilal82e1@example.com",
                NormalizedEmail = "OSAMA.HILAL82E1@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Osama",
                LastName = "Hilal82e1",
                PhoneNumber = "01248547700"
            },

            new User
            {
                Id = "4099ea0b-ed6b-11ed-b0ef-105badc84798",
                UserName = "Moses.Hilaliaa93@example.com",
                NormalizedUserName = "MOSES.HILALIAA93@EXAMPLE.COM",
                Email = "Moses.Hilaliaa93@example.com",
                NormalizedEmail = "MOSES.HILALIAA93@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Moses",
                LastName = "Hilaliaa93",
                PhoneNumber = "01298932026"
            },

            new User
            {
                Id = "4099ea0d-ed6b-11ed-aa2b-105badc84798",
                UserName = "Omar.Kahterb214@example.com",
                NormalizedUserName = "OMAR.KAHTERB214@EXAMPLE.COM",
                Email = "Omar.Kahterb214@example.com",
                NormalizedEmail = "OMAR.KAHTERB214@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Omar",
                LastName = "Kahterb214",
                PhoneNumber = "01280480167"
            },

            new User
            {
                Id = "4099ea0f-ed6b-11ed-9d4e-105badc84798",
                UserName = "Dahi.Basselaed6@example.com",
                NormalizedUserName = "DAHI.BASSELAED6@EXAMPLE.COM",
                Email = "Dahi.Basselaed6@example.com",
                NormalizedEmail = "DAHI.BASSELAED6@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Dahi",
                LastName = "Basselaed6",
                PhoneNumber = "01243086819"
            },

            new User
            {
                Id = "4099ea11-ed6b-11ed-8a4f-105badc84798",
                UserName = "Fidaa.Yusuf9983@example.com",
                NormalizedUserName = "FIDAA.YUSUF9983@EXAMPLE.COM",
                Email = "Fidaa.Yusuf9983@example.com",
                NormalizedEmail = "FIDAA.YUSUF9983@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Fidaa",
                LastName = "Yusuf9983",
                PhoneNumber = "01230841385"
            },

            new User
            {
                Id = "4099ea13-ed6b-11ed-839a-105badc84798",
                UserName = "Kamel.Danielb073@example.com",
                NormalizedUserName = "KAMEL.DANIELB073@EXAMPLE.COM",
                Email = "Kamel.Danielb073@example.com",
                NormalizedEmail = "KAMEL.DANIELB073@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Kamel",
                LastName = "Danielb073",
                PhoneNumber = "01241136225"
            },

            new User
            {
                Id = "4099ea15-ed6b-11ed-8dbe-105badc84798",
                UserName = "Ghanem.Maleka044@example.com",
                NormalizedUserName = "GHANEM.MALEKA044@EXAMPLE.COM",
                Email = "Ghanem.Maleka044@example.com",
                NormalizedEmail = "GHANEM.MALEKA044@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Ghanem",
                LastName = "Maleka044",
                PhoneNumber = "01251094640"
            },

            new User
            {
                Id = "4099ea17-ed6b-11ed-bb52-105badc84798",
                UserName = "Jawad.Mahmoudb443@example.com",
                NormalizedUserName = "JAWAD.MAHMOUDB443@EXAMPLE.COM",
                Email = "Jawad.Mahmoudb443@example.com",
                NormalizedEmail = "JAWAD.MAHMOUDB443@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Jawad",
                LastName = "Mahmoudb443",
                PhoneNumber = "01278247237"
            },

            new User
            {
                Id = "4099ea19-ed6b-11ed-85c8-105badc84798",
                UserName = "Kamel.Danielaa21@example.com",
                NormalizedUserName = "KAMEL.DANIELAA21@EXAMPLE.COM",
                Email = "Kamel.Danielaa21@example.com",
                NormalizedEmail = "KAMEL.DANIELAA21@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Kamel",
                LastName = "Danielaa21",
                PhoneNumber = "01234246942"
            },

            new User
            {
                Id = "4099ea1b-ed6b-11ed-b4c0-105badc84798",
                UserName = "Kahter.Danielab00@example.com",
                NormalizedUserName = "KAHTER.DANIELAB00@EXAMPLE.COM",
                Email = "Kahter.Danielab00@example.com",
                NormalizedEmail = "KAHTER.DANIELAB00@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Kahter",
                LastName = "Danielab00",
                PhoneNumber = "01214469178"
            },

            new User
            {
                Id = "4099ea1d-ed6b-11ed-a4c6-105badc84798",
                UserName = "Idris.Goodbaab@example.com",
                NormalizedUserName = "IDRIS.GOODBAAB@EXAMPLE.COM",
                Email = "Idris.Goodbaab@example.com",
                NormalizedEmail = "IDRIS.GOODBAAB@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Idris",
                LastName = "Goodbaab",
                PhoneNumber = "01275050210"
            },

            new User
            {
                Id = "4099ea1f-ed6b-11ed-9f62-105badc84798",
                UserName = "Badri.Turki86e8@example.com",
                NormalizedUserName = "BADRI.TURKI86E8@EXAMPLE.COM",
                Email = "Badri.Turki86e8@example.com",
                NormalizedEmail = "BADRI.TURKI86E8@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Badri",
                LastName = "Turki86e8",
                PhoneNumber = "01296658918"
            },

            new User
            {
                Id = "409b2251-ed6b-11ed-9a82-105badc84798",
                UserName = "Hilal.Sajidab3b@example.com",
                NormalizedUserName = "HILAL.SAJIDAB3B@EXAMPLE.COM",
                Email = "Hilal.Sajidab3b@example.com",
                NormalizedEmail = "HILAL.SAJIDAB3B@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Hilal",
                LastName = "Sajidab3b",
                PhoneNumber = "01269184301"
            },

            new User
            {
                Id = "409b2253-ed6b-11ed-b650-105badc84798",
                UserName = "Nahar.Kahterb7e4@example.com",
                NormalizedUserName = "NAHAR.KAHTERB7E4@EXAMPLE.COM",
                Email = "Nahar.Kahterb7e4@example.com",
                NormalizedEmail = "NAHAR.KAHTERB7E4@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Nahar",
                LastName = "Kahterb7e4",
                PhoneNumber = "01299448511"
            },

            new User
            {
                Id = "409b2255-ed6b-11ed-87ce-105badc84798",
                UserName = "Badri.​​Karim8bc1@example.com",
                NormalizedUserName = "BADRI.​​KARIM8BC1@EXAMPLE.COM",
                Email = "Badri.​​Karim8bc1@example.com",
                NormalizedEmail = "BADRI.​​KARIM8BC1@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Badri",
                LastName = "​​Karim8bc1",
                PhoneNumber = "01258445075"
            },

            new User
            {
                Id = "409b2257-ed6b-11ed-8f44-105badc84798",
                UserName = "Noor.Mahmoudaee2@example.com",
                NormalizedUserName = "NOOR.MAHMOUDAEE2@EXAMPLE.COM",
                Email = "Noor.Mahmoudaee2@example.com",
                NormalizedEmail = "NOOR.MAHMOUDAEE2@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Noor",
                LastName = "Mahmoudaee2",
                PhoneNumber = "01224192049"
            },

            new User
            {
                Id = "409b2259-ed6b-11ed-ac78-105badc84798",
                UserName = "Zarif.Asamib250@example.com",
                NormalizedUserName = "ZARIF.ASAMIB250@EXAMPLE.COM",
                Email = "Zarif.Asamib250@example.com",
                NormalizedEmail = "ZARIF.ASAMIB250@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Zarif",
                LastName = "Asamib250",
                PhoneNumber = "01279796291"
            },

            new User
            {
                Id = "409b225b-ed6b-11ed-bf67-105badc84798",
                UserName = "Barra.Osamaa94c@example.com",
                NormalizedUserName = "BARRA.OSAMAA94C@EXAMPLE.COM",
                Email = "Barra.Osamaa94c@example.com",
                NormalizedEmail = "BARRA.OSAMAA94C@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Barra",
                LastName = "Osamaa94c",
                PhoneNumber = "01265372285"
            },

            new User
            {
                Id = "409b225d-ed6b-11ed-8369-105badc84798",
                UserName = "Jika.Sameh99c4@example.com",
                NormalizedUserName = "JIKA.SAMEH99C4@EXAMPLE.COM",
                Email = "Jika.Sameh99c4@example.com",
                NormalizedEmail = "JIKA.SAMEH99C4@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Jika",
                LastName = "Sameh99c4",
                PhoneNumber = "01224100592"
            },

            new User
            {
                Id = "409b225f-ed6b-11ed-8d6a-105badc84798",
                UserName = "Wael.​​Karim9585@example.com",
                NormalizedUserName = "WAEL.​​KARIM9585@EXAMPLE.COM",
                Email = "Wael.​​Karim9585@example.com",
                NormalizedEmail = "WAEL.​​KARIM9585@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Wael",
                LastName = "​​Karim9585",
                PhoneNumber = "01270034864"
            },

            new User
            {
                Id = "409b2261-ed6b-11ed-b7f8-105badc84798",
                UserName = "Hilal.Faisal9236@example.com",
                NormalizedUserName = "HILAL.FAISAL9236@EXAMPLE.COM",
                Email = "Hilal.Faisal9236@example.com",
                NormalizedEmail = "HILAL.FAISAL9236@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Hilal",
                LastName = "Faisal9236",
                PhoneNumber = "01221565927"
            },

            new User
            {
                Id = "409b2263-ed6b-11ed-93b0-105badc84798",
                UserName = "Adel.Bahir82d6@example.com",
                NormalizedUserName = "ADEL.BAHIR82D6@EXAMPLE.COM",
                Email = "Adel.Bahir82d6@example.com",
                NormalizedEmail = "ADEL.BAHIR82D6@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Adel",
                LastName = "Bahir82d6",
                PhoneNumber = "01276197853"
            },

            new User
            {
                Id = "409b2265-ed6b-11ed-8a51-105badc84798",
                UserName = "Mahmoud.Daniel964c@example.com",
                NormalizedUserName = "MAHMOUD.DANIEL964C@EXAMPLE.COM",
                Email = "Mahmoud.Daniel964c@example.com",
                NormalizedEmail = "MAHMOUD.DANIEL964C@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Mahmoud",
                LastName = "Daniel964c",
                PhoneNumber = "01244504780"
            },

            new User
            {
                Id = "409b2267-ed6b-11ed-9ed8-105badc84798",
                UserName = "Adel.Hamaki94da@example.com",
                NormalizedUserName = "ADEL.HAMAKI94DA@EXAMPLE.COM",
                Email = "Adel.Hamaki94da@example.com",
                NormalizedEmail = "ADEL.HAMAKI94DA@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Adel",
                LastName = "Hamaki94da",
                PhoneNumber = "01227940951"
            },

            new User
            {
                Id = "409b2269-ed6b-11ed-96a1-105badc84798",
                UserName = "Adham.Basembae6@example.com",
                NormalizedUserName = "ADHAM.BASEMBAE6@EXAMPLE.COM",
                Email = "Adham.Basembae6@example.com",
                NormalizedEmail = "ADHAM.BASEMBAE6@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Adham",
                LastName = "Basembae6",
                PhoneNumber = "01295804031"
            },

            new User
            {
                Id = "409b226b-ed6b-11ed-b5d0-105badc84798",
                UserName = "Lail.Bilalbdd5@example.com",
                NormalizedUserName = "LAIL.BILALBDD5@EXAMPLE.COM",
                Email = "Lail.Bilalbdd5@example.com",
                NormalizedEmail = "LAIL.BILALBDD5@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Lail",
                LastName = "Bilalbdd5",
                PhoneNumber = "01264886434"
            },

            new User
            {
                Id = "409b226d-ed6b-11ed-9578-105badc84798",
                UserName = "Bara.Badri8be3@example.com",
                NormalizedUserName = "BARA.BADRI8BE3@EXAMPLE.COM",
                Email = "Bara.Badri8be3@example.com",
                NormalizedEmail = "BARA.BADRI8BE3@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Bara",
                LastName = "Badri8be3",
                PhoneNumber = "01232443399"
            },

            new User
            {
                Id = "409b226f-ed6b-11ed-af75-105badc84798",
                UserName = "Sheikh.Sheikha7a4@example.com",
                NormalizedUserName = "SHEIKH.SHEIKHA7A4@EXAMPLE.COM",
                Email = "Sheikh.Sheikha7a4@example.com",
                NormalizedEmail = "SHEIKH.SHEIKHA7A4@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sheikh",
                LastName = "Sheikha7a4",
                PhoneNumber = "01245074460"
            },

            new User
            {
                Id = "409b2271-ed6b-11ed-b13a-105badc84798",
                UserName = "Loay.Hamaqyaf12@example.com",
                NormalizedUserName = "LOAY.HAMAQYAF12@EXAMPLE.COM",
                Email = "Loay.Hamaqyaf12@example.com",
                NormalizedEmail = "LOAY.HAMAQYAF12@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Loay",
                LastName = "Hamaqyaf12",
                PhoneNumber = "01295630957"
            },

            new User
            {
                Id = "409b2273-ed6b-11ed-984c-105badc84798",
                UserName = "Maher.Good90c5@example.com",
                NormalizedUserName = "MAHER.GOOD90C5@EXAMPLE.COM",
                Email = "Maher.Good90c5@example.com",
                NormalizedEmail = "MAHER.GOOD90C5@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Maher",
                LastName = "Good90c5",
                PhoneNumber = "01211245634"
            },

            new User
            {
                Id = "409b2275-ed6b-11ed-8ea0-105badc84798",
                UserName = "Bassam.Russella913@example.com",
                NormalizedUserName = "BASSAM.RUSSELLA913@EXAMPLE.COM",
                Email = "Bassam.Russella913@example.com",
                NormalizedEmail = "BASSAM.RUSSELLA913@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Bassam",
                LastName = "Russella913",
                PhoneNumber = "01277681415"
            },

            new User
            {
                Id = "409b2277-ed6b-11ed-a519-105badc84798",
                UserName = "Sheikhy.Jawada4e1@example.com",
                NormalizedUserName = "SHEIKHY.JAWADA4E1@EXAMPLE.COM",
                Email = "Sheikhy.Jawada4e1@example.com",
                NormalizedEmail = "SHEIKHY.JAWADA4E1@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sheikhy",
                LastName = "Jawada4e1",
                PhoneNumber = "01249047718"
            },

            new User
            {
                Id = "409b2279-ed6b-11ed-a66d-105badc84798",
                UserName = "Hassan.Hosni80b2@example.com",
                NormalizedUserName = "HASSAN.HOSNI80B2@EXAMPLE.COM",
                Email = "Hassan.Hosni80b2@example.com",
                NormalizedEmail = "HASSAN.HOSNI80B2@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Hassan",
                LastName = "Hosni80b2",
                PhoneNumber = "01247655370"
            },

            new User
            {
                Id = "409b227b-ed6b-11ed-a6a6-105badc84798",
                UserName = "Minali.Yamen9b11@example.com",
                NormalizedUserName = "MINALI.YAMEN9B11@EXAMPLE.COM",
                Email = "Minali.Yamen9b11@example.com",
                NormalizedEmail = "MINALI.YAMEN9B11@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Minali",
                LastName = "Yamen9b11",
                PhoneNumber = "01244701551"
            },

            new User
            {
                Id = "409b227d-ed6b-11ed-b8fd-105badc84798",
                UserName = "Battari.Ghanema3e1@example.com",
                NormalizedUserName = "BATTARI.GHANEMA3E1@EXAMPLE.COM",
                Email = "Battari.Ghanema3e1@example.com",
                NormalizedEmail = "BATTARI.GHANEMA3E1@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Battari",
                LastName = "Ghanema3e1",
                PhoneNumber = "01261605249"
            },

            new User
            {
                Id = "409b227f-ed6b-11ed-9609-105badc84798",
                UserName = "Yusuf.Maherac9c@example.com",
                NormalizedUserName = "YUSUF.MAHERAC9C@EXAMPLE.COM",
                Email = "Yusuf.Maherac9c@example.com",
                NormalizedEmail = "YUSUF.MAHERAC9C@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Yusuf",
                LastName = "Maherac9c",
                PhoneNumber = "01293092536"
            },

            new User
            {
                Id = "409b2281-ed6b-11ed-968e-105badc84798",
                UserName = "Saree.Idrisb0ef@example.com",
                NormalizedUserName = "SAREE.IDRISB0EF@EXAMPLE.COM",
                Email = "Saree.Idrisb0ef@example.com",
                NormalizedEmail = "SAREE.IDRISB0EF@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Saree",
                LastName = "Idrisb0ef",
                PhoneNumber = "01220329770"
            },

            new User
            {
                Id = "409b2283-ed6b-11ed-90f7-105badc84798",
                UserName = "Adham.Bahiraf53@example.com",
                NormalizedUserName = "ADHAM.BAHIRAF53@EXAMPLE.COM",
                Email = "Adham.Bahiraf53@example.com",
                NormalizedEmail = "ADHAM.BAHIRAF53@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Adham",
                LastName = "Bahiraf53",
                PhoneNumber = "01259225260"
            },

            new User
            {
                Id = "409b2285-ed6b-11ed-945d-105badc84798",
                UserName = "Saden.Salim9973@example.com",
                NormalizedUserName = "SADEN.SALIM9973@EXAMPLE.COM",
                Email = "Saden.Salim9973@example.com",
                NormalizedEmail = "SADEN.SALIM9973@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Saden",
                LastName = "Salim9973",
                PhoneNumber = "01251768428"
            },

            new User
            {
                Id = "409b2287-ed6b-11ed-bdd8-105badc84798",
                UserName = "Sameh.Hassana203@example.com",
                NormalizedUserName = "SAMEH.HASSANA203@EXAMPLE.COM",
                Email = "Sameh.Hassana203@example.com",
                NormalizedEmail = "SAMEH.HASSANA203@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sameh",
                LastName = "Hassana203",
                PhoneNumber = "01212703009"
            },

            new User
            {
                Id = "409b2289-ed6b-11ed-8a33-105badc84798",
                UserName = "Yusuf.Fidaa92d2@example.com",
                NormalizedUserName = "YUSUF.FIDAA92D2@EXAMPLE.COM",
                Email = "Yusuf.Fidaa92d2@example.com",
                NormalizedEmail = "YUSUF.FIDAA92D2@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Yusuf",
                LastName = "Fidaa92d2",
                PhoneNumber = "01216037425"
            },

            new User
            {
                Id = "409b228b-ed6b-11ed-82cb-105badc84798",
                UserName = "Dagher.Baraa698@example.com",
                NormalizedUserName = "DAGHER.BARAA698@EXAMPLE.COM",
                Email = "Dagher.Baraa698@example.com",
                NormalizedEmail = "DAGHER.BARAA698@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Dagher",
                LastName = "Baraa698",
                PhoneNumber = "01228632027"
            },

            new User
            {
                Id = "409b228d-ed6b-11ed-9862-105badc84798",
                UserName = "Bassel.Ibrahima080@example.com",
                NormalizedUserName = "BASSEL.IBRAHIMA080@EXAMPLE.COM",
                Email = "Bassel.Ibrahima080@example.com",
                NormalizedEmail = "BASSEL.IBRAHIMA080@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Bassel",
                LastName = "Ibrahima080",
                PhoneNumber = "01299705532"
            },

            new User
            {
                Id = "409b228f-ed6b-11ed-bba0-105badc84798",
                UserName = "Kamel.Samhi885f@example.com",
                NormalizedUserName = "KAMEL.SAMHI885F@EXAMPLE.COM",
                Email = "Kamel.Samhi885f@example.com",
                NormalizedEmail = "KAMEL.SAMHI885F@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Kamel",
                LastName = "Samhi885f",
                PhoneNumber = "01280062716"
            },

            new User
            {
                Id = "409b2291-ed6b-11ed-82b0-105badc84798",
                UserName = "Bara.Fahedb92d@example.com",
                NormalizedUserName = "BARA.FAHEDB92D@EXAMPLE.COM",
                Email = "Bara.Fahedb92d@example.com",
                NormalizedEmail = "BARA.FAHEDB92D@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Bara",
                LastName = "Fahedb92d",
                PhoneNumber = "01272696536"
            },

            new User
            {
                Id = "409b2293-ed6b-11ed-a281-105badc84798",
                UserName = "Samhi.Hilal8bd1@example.com",
                NormalizedUserName = "SAMHI.HILAL8BD1@EXAMPLE.COM",
                Email = "Samhi.Hilal8bd1@example.com",
                NormalizedEmail = "SAMHI.HILAL8BD1@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Samhi",
                LastName = "Hilal8bd1",
                PhoneNumber = "01278276213"
            },

            new User
            {
                Id = "409b2295-ed6b-11ed-a03f-105badc84798",
                UserName = "Faisal.Samirbd6b@example.com",
                NormalizedUserName = "FAISAL.SAMIRBD6B@EXAMPLE.COM",
                Email = "Faisal.Samirbd6b@example.com",
                NormalizedEmail = "FAISAL.SAMIRBD6B@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Faisal",
                LastName = "Samirbd6b",
                PhoneNumber = "01296553303"
            },

            new User
            {
                Id = "409b2297-ed6b-11ed-9620-105badc84798",
                UserName = "Wael.Sahami86d0@example.com",
                NormalizedUserName = "WAEL.SAHAMI86D0@EXAMPLE.COM",
                Email = "Wael.Sahami86d0@example.com",
                NormalizedEmail = "WAEL.SAHAMI86D0@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Wael",
                LastName = "Sahami86d0",
                PhoneNumber = "01283688266"
            },

            new User
            {
                Id = "409b2299-ed6b-11ed-8cd7-105badc84798",
                UserName = "Muhammad.Yad826b@example.com",
                NormalizedUserName = "MUHAMMAD.YAD826B@EXAMPLE.COM",
                Email = "Muhammad.Yad826b@example.com",
                NormalizedEmail = "MUHAMMAD.YAD826B@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Muhammad",
                LastName = "Yad826b",
                PhoneNumber = "01241209071"
            },

            new User
            {
                Id = "409b229b-ed6b-11ed-b5e4-105badc84798",
                UserName = "Wael.Bahi97f5@example.com",
                NormalizedUserName = "WAEL.BAHI97F5@EXAMPLE.COM",
                Email = "Wael.Bahi97f5@example.com",
                NormalizedEmail = "WAEL.BAHI97F5@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Wael",
                LastName = "Bahi97f5",
                PhoneNumber = "01280616076"
            },

            new User
            {
                Id = "409c5ba9-ed6b-11ed-a9f0-105badc84798",
                UserName = "Sameh.Osama98c7@example.com",
                NormalizedUserName = "SAMEH.OSAMA98C7@EXAMPLE.COM",
                Email = "Sameh.Osama98c7@example.com",
                NormalizedEmail = "SAMEH.OSAMA98C7@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sameh",
                LastName = "Osama98c7",
                PhoneNumber = "01242267999"
            },

            new User
            {
                Id = "409c5bab-ed6b-11ed-9ebb-105badc84798",
                UserName = "Dagher.Sareead13@example.com",
                NormalizedUserName = "DAGHER.SAREEAD13@EXAMPLE.COM",
                Email = "Dagher.Sareead13@example.com",
                NormalizedEmail = "DAGHER.SAREEAD13@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Dagher",
                LastName = "Sareead13",
                PhoneNumber = "01280522970"
            },

            new User
            {
                Id = "409c5bad-ed6b-11ed-b06e-105badc84798",
                UserName = "Yad.Hamaqy909a@example.com",
                NormalizedUserName = "YAD.HAMAQY909A@EXAMPLE.COM",
                Email = "Yad.Hamaqy909a@example.com",
                NormalizedEmail = "YAD.HAMAQY909A@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Yad",
                LastName = "Hamaqy909a",
                PhoneNumber = "01268125360"
            },

            new User
            {
                Id = "409c5baf-ed6b-11ed-b43f-105badc84798",
                UserName = "Bassel.Kamelaef1@example.com",
                NormalizedUserName = "BASSEL.KAMELAEF1@EXAMPLE.COM",
                Email = "Bassel.Kamelaef1@example.com",
                NormalizedEmail = "BASSEL.KAMELAEF1@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Bassel",
                LastName = "Kamelaef1",
                PhoneNumber = "01281713510"
            },

            new User
            {
                Id = "409c5bb1-ed6b-11ed-b22e-105badc84798",
                UserName = "Lail.Minali8f58@example.com",
                NormalizedUserName = "LAIL.MINALI8F58@EXAMPLE.COM",
                Email = "Lail.Minali8f58@example.com",
                NormalizedEmail = "LAIL.MINALI8F58@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Lail",
                LastName = "Minali8f58",
                PhoneNumber = "01211017057"
            },

            new User
            {
                Id = "409c5bb3-ed6b-11ed-8aea-105badc84798",
                UserName = "Majid.Adlia9c6@example.com",
                NormalizedUserName = "MAJID.ADLIA9C6@EXAMPLE.COM",
                Email = "Majid.Adlia9c6@example.com",
                NormalizedEmail = "MAJID.ADLIA9C6@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Majid",
                LastName = "Adlia9c6",
                PhoneNumber = "01276042209"
            },

            new User
            {
                Id = "409c5bb5-ed6b-11ed-81ec-105badc84798",
                UserName = "Firas.Yakonaf22@example.com",
                NormalizedUserName = "FIRAS.YAKONAF22@EXAMPLE.COM",
                Email = "Firas.Yakonaf22@example.com",
                NormalizedEmail = "FIRAS.YAKONAF22@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Firas",
                LastName = "Yakonaf22",
                PhoneNumber = "01248361000"
            },

            new User
            {
                Id = "409c5bb7-ed6b-11ed-a54a-105badc84798",
                UserName = "Saden.Hassanaf93@example.com",
                NormalizedUserName = "SADEN.HASSANAF93@EXAMPLE.COM",
                Email = "Saden.Hassanaf93@example.com",
                NormalizedEmail = "SADEN.HASSANAF93@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Saden",
                LastName = "Hassanaf93",
                PhoneNumber = "01252473730"
            },

            new User
            {
                Id = "409c5bb9-ed6b-11ed-a374-105badc84798",
                UserName = "Helsey.Noor82e8@example.com",
                NormalizedUserName = "HELSEY.NOOR82E8@EXAMPLE.COM",
                Email = "Helsey.Noor82e8@example.com",
                NormalizedEmail = "HELSEY.NOOR82E8@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Helsey",
                LastName = "Noor82e8",
                PhoneNumber = "01293212396"
            },

            new User
            {
                Id = "409c5bbb-ed6b-11ed-a145-105badc84798",
                UserName = "Ali.Ryan921d@example.com",
                NormalizedUserName = "ALI.RYAN921D@EXAMPLE.COM",
                Email = "Ali.Ryan921d@example.com",
                NormalizedEmail = "ALI.RYAN921D@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Ali",
                LastName = "Ryan921d",
                PhoneNumber = "01240558815"
            },

            new User
            {
                Id = "409c5bbd-ed6b-11ed-a7f3-105badc84798",
                UserName = "Yad.Najm91d8@example.com",
                NormalizedUserName = "YAD.NAJM91D8@EXAMPLE.COM",
                Email = "Yad.Najm91d8@example.com",
                NormalizedEmail = "YAD.NAJM91D8@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Yad",
                LastName = "Najm91d8",
                PhoneNumber = "01256088190"
            },

            new User
            {
                Id = "409c5bbf-ed6b-11ed-afcf-105badc84798",
                UserName = "Good.Hilal8ebc@example.com",
                NormalizedUserName = "GOOD.HILAL8EBC@EXAMPLE.COM",
                Email = "Good.Hilal8ebc@example.com",
                NormalizedEmail = "GOOD.HILAL8EBC@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Good",
                LastName = "Hilal8ebc",
                PhoneNumber = "01233135538"
            },

            new User
            {
                Id = "409c5bc1-ed6b-11ed-880d-105badc84798",
                UserName = "Bara.Omar96e5@example.com",
                NormalizedUserName = "BARA.OMAR96E5@EXAMPLE.COM",
                Email = "Bara.Omar96e5@example.com",
                NormalizedEmail = "BARA.OMAR96E5@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Bara",
                LastName = "Omar96e5",
                PhoneNumber = "01253668931"
            },

            new User
            {
                Id = "409c5bc3-ed6b-11ed-b2b0-105badc84798",
                UserName = "Jika.Faisal9ca6@example.com",
                NormalizedUserName = "JIKA.FAISAL9CA6@EXAMPLE.COM",
                Email = "Jika.Faisal9ca6@example.com",
                NormalizedEmail = "JIKA.FAISAL9CA6@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Jika",
                LastName = "Faisal9ca6",
                PhoneNumber = "01270653239"
            },

            new User
            {
                Id = "409c5bc5-ed6b-11ed-9c33-105badc84798",
                UserName = "Fares.Turkib5c8@example.com",
                NormalizedUserName = "FARES.TURKIB5C8@EXAMPLE.COM",
                Email = "Fares.Turkib5c8@example.com",
                NormalizedEmail = "FARES.TURKIB5C8@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Fares",
                LastName = "Turkib5c8",
                PhoneNumber = "01298016974"
            },

            new User
            {
                Id = "409c5bc7-ed6b-11ed-a584-105badc84798",
                UserName = "Waseem.Zachariah8b80@example.com",
                NormalizedUserName = "WASEEM.ZACHARIAH8B80@EXAMPLE.COM",
                Email = "Waseem.Zachariah8b80@example.com",
                NormalizedEmail = "WASEEM.ZACHARIAH8B80@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Waseem",
                LastName = "Zachariah8b80",
                PhoneNumber = "01233473594"
            },

            new User
            {
                Id = "409c5bc9-ed6b-11ed-94df-105badc84798",
                UserName = "Basem.Zaki9209@example.com",
                NormalizedUserName = "BASEM.ZAKI9209@EXAMPLE.COM",
                Email = "Basem.Zaki9209@example.com",
                NormalizedEmail = "BASEM.ZAKI9209@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Basem",
                LastName = "Zaki9209",
                PhoneNumber = "01247188081"
            },

            new User
            {
                Id = "409c5bcb-ed6b-11ed-ae48-105badc84798",
                UserName = "Firas.Fahedb115@example.com",
                NormalizedUserName = "FIRAS.FAHEDB115@EXAMPLE.COM",
                Email = "Firas.Fahedb115@example.com",
                NormalizedEmail = "FIRAS.FAHEDB115@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Firas",
                LastName = "Fahedb115",
                PhoneNumber = "01238482001"
            },

            new User
            {
                Id = "409c5bcd-ed6b-11ed-82bc-105badc84798",
                UserName = "Hilal.Asim8263@example.com",
                NormalizedUserName = "HILAL.ASIM8263@EXAMPLE.COM",
                Email = "Hilal.Asim8263@example.com",
                NormalizedEmail = "HILAL.ASIM8263@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Hilal",
                LastName = "Asim8263",
                PhoneNumber = "01225838899"
            },

            new User
            {
                Id = "409c5bcf-ed6b-11ed-a53b-105badc84798",
                UserName = "Kamel.Ghanema74f@example.com",
                NormalizedUserName = "KAMEL.GHANEMA74F@EXAMPLE.COM",
                Email = "Kamel.Ghanema74f@example.com",
                NormalizedEmail = "KAMEL.GHANEMA74F@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Kamel",
                LastName = "Ghanema74f",
                PhoneNumber = "01267168944"
            },

            new User
            {
                Id = "409c5bd1-ed6b-11ed-8709-105badc84798",
                UserName = "Firas.Adelac4e@example.com",
                NormalizedUserName = "FIRAS.ADELAC4E@EXAMPLE.COM",
                Email = "Firas.Adelac4e@example.com",
                NormalizedEmail = "FIRAS.ADELAC4E@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Firas",
                LastName = "Adelac4e",
                PhoneNumber = "01274387720"
            },

            new User
            {
                Id = "409c5bd3-ed6b-11ed-b60d-105badc84798",
                UserName = "Shehabi.Asamib745@example.com",
                NormalizedUserName = "SHEHABI.ASAMIB745@EXAMPLE.COM",
                Email = "Shehabi.Asamib745@example.com",
                NormalizedEmail = "SHEHABI.ASAMIB745@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Shehabi",
                LastName = "Asamib745",
                PhoneNumber = "01265107277"
            },

            new User
            {
                Id = "409c5bd5-ed6b-11ed-92ef-105badc84798",
                UserName = "Adam.Ryanbb23@example.com",
                NormalizedUserName = "ADAM.RYANBB23@EXAMPLE.COM",
                Email = "Adam.Ryanbb23@example.com",
                NormalizedEmail = "ADAM.RYANBB23@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Adam",
                LastName = "Ryanbb23",
                PhoneNumber = "01230210003"
            },

            new User
            {
                Id = "409c5bd7-ed6b-11ed-8e67-105badc84798",
                UserName = "Yunus.Ahmed90cb@example.com",
                NormalizedUserName = "YUNUS.AHMED90CB@EXAMPLE.COM",
                Email = "Yunus.Ahmed90cb@example.com",
                NormalizedEmail = "YUNUS.AHMED90CB@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Yunus",
                LastName = "Ahmed90cb",
                PhoneNumber = "01235122474"
            },

            new User
            {
                Id = "409c5bd9-ed6b-11ed-aac6-105badc84798",
                UserName = "Kamel.Hassan8f33@example.com",
                NormalizedUserName = "KAMEL.HASSAN8F33@EXAMPLE.COM",
                Email = "Kamel.Hassan8f33@example.com",
                NormalizedEmail = "KAMEL.HASSAN8F33@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Kamel",
                LastName = "Hassan8f33",
                PhoneNumber = "01243061369"
            },

            new User
            {
                Id = "409c5bdb-ed6b-11ed-9c54-105badc84798",
                UserName = "Sharm.Haor9abe@example.com",
                NormalizedUserName = "SHARM.HAOR9ABE@EXAMPLE.COM",
                Email = "Sharm.Haor9abe@example.com",
                NormalizedEmail = "SHARM.HAOR9ABE@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sharm",
                LastName = "Haor9abe",
                PhoneNumber = "01256605664"
            },

            new User
            {
                Id = "409c5bdd-ed6b-11ed-9d5b-105badc84798",
                UserName = "Shehabi.Radwanaea9@example.com",
                NormalizedUserName = "SHEHABI.RADWANAEA9@EXAMPLE.COM",
                Email = "Shehabi.Radwanaea9@example.com",
                NormalizedEmail = "SHEHABI.RADWANAEA9@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Shehabi",
                LastName = "Radwanaea9",
                PhoneNumber = "01247779098"
            },

            new User
            {
                Id = "409c5bdf-ed6b-11ed-8964-105badc84798",
                UserName = "Sandsi.Sareea2bb@example.com",
                NormalizedUserName = "SANDSI.SAREEA2BB@EXAMPLE.COM",
                Email = "Sandsi.Sareea2bb@example.com",
                NormalizedEmail = "SANDSI.SAREEA2BB@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sandsi",
                LastName = "Sareea2bb",
                PhoneNumber = "01295119441"
            },

            new User
            {
                Id = "409c5be1-ed6b-11ed-858f-105badc84798",
                UserName = "Ryan.Ahmed92cc@example.com",
                NormalizedUserName = "RYAN.AHMED92CC@EXAMPLE.COM",
                Email = "Ryan.Ahmed92cc@example.com",
                NormalizedEmail = "RYAN.AHMED92CC@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Ryan",
                LastName = "Ahmed92cc",
                PhoneNumber = "01280497409"
            },

            new User
            {
                Id = "409c5be3-ed6b-11ed-a6f1-105badc84798",
                UserName = "Jika.Yakon99b9@example.com",
                NormalizedUserName = "JIKA.YAKON99B9@EXAMPLE.COM",
                Email = "Jika.Yakon99b9@example.com",
                NormalizedEmail = "JIKA.YAKON99B9@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Jika",
                LastName = "Yakon99b9",
                PhoneNumber = "01264045710"
            },

            new User
            {
                Id = "409c5be5-ed6b-11ed-b9bc-105badc84798",
                UserName = "Salim.Barrab361@example.com",
                NormalizedUserName = "SALIM.BARRAB361@EXAMPLE.COM",
                Email = "Salim.Barrab361@example.com",
                NormalizedEmail = "SALIM.BARRAB361@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Salim",
                LastName = "Barrab361",
                PhoneNumber = "01249320959"
            },

            new User
            {
                Id = "409c5be7-ed6b-11ed-a4c2-105badc84798",
                UserName = "Sajid.Ghanemb2c7@example.com",
                NormalizedUserName = "SAJID.GHANEMB2C7@EXAMPLE.COM",
                Email = "Sajid.Ghanemb2c7@example.com",
                NormalizedEmail = "SAJID.GHANEMB2C7@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sajid",
                LastName = "Ghanemb2c7",
                PhoneNumber = "01277246579"
            },

            new User
            {
                Id = "409c5be9-ed6b-11ed-84f0-105badc84798",
                UserName = "Abi.Naharbab5@example.com",
                NormalizedUserName = "ABI.NAHARBAB5@EXAMPLE.COM",
                Email = "Abi.Naharbab5@example.com",
                NormalizedEmail = "ABI.NAHARBAB5@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Abi",
                LastName = "Naharbab5",
                PhoneNumber = "01229234023"
            },

            new User
            {
                Id = "409c5beb-ed6b-11ed-9119-105badc84798",
                UserName = "Sheikhy.Bahib9c1@example.com",
                NormalizedUserName = "SHEIKHY.BAHIB9C1@EXAMPLE.COM",
                Email = "Sheikhy.Bahib9c1@example.com",
                NormalizedEmail = "SHEIKHY.BAHIB9C1@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sheikhy",
                LastName = "Bahib9c1",
                PhoneNumber = "01253380211"
            },

            new User
            {
                Id = "409c5bed-ed6b-11ed-b13d-105badc84798",
                UserName = "Russell.Noor98e2@example.com",
                NormalizedUserName = "RUSSELL.NOOR98E2@EXAMPLE.COM",
                Email = "Russell.Noor98e2@example.com",
                NormalizedEmail = "RUSSELL.NOOR98E2@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Russell",
                LastName = "Noor98e2",
                PhoneNumber = "01270799028"
            },

            new User
            {
                Id = "409c5bef-ed6b-11ed-a904-105badc84798",
                UserName = "Kamel.Turkiac4a@example.com",
                NormalizedUserName = "KAMEL.TURKIAC4A@EXAMPLE.COM",
                Email = "Kamel.Turkiac4a@example.com",
                NormalizedEmail = "KAMEL.TURKIAC4A@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Kamel",
                LastName = "Turkiac4a",
                PhoneNumber = "01241657516"
            },

            new User
            {
                Id = "409c5bf1-ed6b-11ed-88f4-105badc84798",
                UserName = "Nahar.Ghanemae00@example.com",
                NormalizedUserName = "NAHAR.GHANEMAE00@EXAMPLE.COM",
                Email = "Nahar.Ghanemae00@example.com",
                NormalizedEmail = "NAHAR.GHANEMAE00@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Nahar",
                LastName = "Ghanemae00",
                PhoneNumber = "01298809343"
            },

            new User
            {
                Id = "409c5bf3-ed6b-11ed-b6f9-105badc84798",
                UserName = "Jawad.Hosni8716@example.com",
                NormalizedUserName = "JAWAD.HOSNI8716@EXAMPLE.COM",
                Email = "Jawad.Hosni8716@example.com",
                NormalizedEmail = "JAWAD.HOSNI8716@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Jawad",
                LastName = "Hosni8716",
                PhoneNumber = "01234781463"
            },

            new User
            {
                Id = "409c5bf5-ed6b-11ed-b0e0-105badc84798",
                UserName = "Zaki.Maher89ed@example.com",
                NormalizedUserName = "ZAKI.MAHER89ED@EXAMPLE.COM",
                Email = "Zaki.Maher89ed@example.com",
                NormalizedEmail = "ZAKI.MAHER89ED@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Zaki",
                LastName = "Maher89ed",
                PhoneNumber = "01218202776"
            },

            new User
            {
                Id = "409d97e6-ed6b-11ed-8b4d-105badc84798",
                UserName = "Ramzy.Sadenb6a1@example.com",
                NormalizedUserName = "RAMZY.SADENB6A1@EXAMPLE.COM",
                Email = "Ramzy.Sadenb6a1@example.com",
                NormalizedEmail = "RAMZY.SADENB6A1@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Ramzy",
                LastName = "Sadenb6a1",
                PhoneNumber = "01241175282"
            },

            new User
            {
                Id = "409d97e8-ed6b-11ed-94e7-105badc84798",
                UserName = "Basem.Ryan8fc1@example.com",
                NormalizedUserName = "BASEM.RYAN8FC1@EXAMPLE.COM",
                Email = "Basem.Ryan8fc1@example.com",
                NormalizedEmail = "BASEM.RYAN8FC1@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Basem",
                LastName = "Ryan8fc1",
                PhoneNumber = "01250561427"
            },

            new User
            {
                Id = "409d97ea-ed6b-11ed-8bcf-105badc84798",
                UserName = "Yunus.Latfi8cca@example.com",
                NormalizedUserName = "YUNUS.LATFI8CCA@EXAMPLE.COM",
                Email = "Yunus.Latfi8cca@example.com",
                NormalizedEmail = "YUNUS.LATFI8CCA@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Yunus",
                LastName = "Latfi8cca",
                PhoneNumber = "01249864317"
            },

            new User
            {
                Id = "409d97ec-ed6b-11ed-b463-105badc84798",
                UserName = "Moses.Idrisb202@example.com",
                NormalizedUserName = "MOSES.IDRISB202@EXAMPLE.COM",
                Email = "Moses.Idrisb202@example.com",
                NormalizedEmail = "MOSES.IDRISB202@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Moses",
                LastName = "Idrisb202",
                PhoneNumber = "01230711192"
            },

            new User
            {
                Id = "409d97ee-ed6b-11ed-bbdf-105badc84798",
                UserName = "Sheikhy.Ahmedb0a5@example.com",
                NormalizedUserName = "SHEIKHY.AHMEDB0A5@EXAMPLE.COM",
                Email = "Sheikhy.Ahmedb0a5@example.com",
                NormalizedEmail = "SHEIKHY.AHMEDB0A5@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sheikhy",
                LastName = "Ahmedb0a5",
                PhoneNumber = "01231051799"
            },

            new User
            {
                Id = "409d97f0-ed6b-11ed-90bb-105badc84798",
                UserName = "Kafar.Barra8ef2@example.com",
                NormalizedUserName = "KAFAR.BARRA8EF2@EXAMPLE.COM",
                Email = "Kafar.Barra8ef2@example.com",
                NormalizedEmail = "KAFAR.BARRA8EF2@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Kafar",
                LastName = "Barra8ef2",
                PhoneNumber = "01239050976"
            },

            new User
            {
                Id = "409d97f2-ed6b-11ed-a6cf-105badc84798",
                UserName = "Hamaki.Fahedadad@example.com",
                NormalizedUserName = "HAMAKI.FAHEDADAD@EXAMPLE.COM",
                Email = "Hamaki.Fahedadad@example.com",
                NormalizedEmail = "HAMAKI.FAHEDADAD@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Hamaki",
                LastName = "Fahedadad",
                PhoneNumber = "01259193188"
            },

            new User
            {
                Id = "409d97f4-ed6b-11ed-bb0c-105badc84798",
                UserName = "Hilal.Yamen95c6@example.com",
                NormalizedUserName = "HILAL.YAMEN95C6@EXAMPLE.COM",
                Email = "Hilal.Yamen95c6@example.com",
                NormalizedEmail = "HILAL.YAMEN95C6@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Hilal",
                LastName = "Yamen95c6",
                PhoneNumber = "01242866984"
            },

            new User
            {
                Id = "409d97f6-ed6b-11ed-a3b6-105badc84798",
                UserName = "Hilali.Saree8dd1@example.com",
                NormalizedUserName = "HILALI.SAREE8DD1@EXAMPLE.COM",
                Email = "Hilali.Saree8dd1@example.com",
                NormalizedEmail = "HILALI.SAREE8DD1@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Hilali",
                LastName = "Saree8dd1",
                PhoneNumber = "01223988031"
            },

            new User
            {
                Id = "409d97f8-ed6b-11ed-9814-105badc84798",
                UserName = "Idris.Radwan8d0d@example.com",
                NormalizedUserName = "IDRIS.RADWAN8D0D@EXAMPLE.COM",
                Email = "Idris.Radwan8d0d@example.com",
                NormalizedEmail = "IDRIS.RADWAN8D0D@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Idris",
                LastName = "Radwan8d0d",
                PhoneNumber = "01271365326"
            },

            new User
            {
                Id = "409d97fa-ed6b-11ed-962d-105badc84798",
                UserName = "Shehabi.Saden97b5@example.com",
                NormalizedUserName = "SHEHABI.SADEN97B5@EXAMPLE.COM",
                Email = "Shehabi.Saden97b5@example.com",
                NormalizedEmail = "SHEHABI.SADEN97B5@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Shehabi",
                LastName = "Saden97b5",
                PhoneNumber = "01273988971"
            },

            new User
            {
                Id = "409d97fc-ed6b-11ed-aad6-105badc84798",
                UserName = "Wael.Hilal86a3@example.com",
                NormalizedUserName = "WAEL.HILAL86A3@EXAMPLE.COM",
                Email = "Wael.Hilal86a3@example.com",
                NormalizedEmail = "WAEL.HILAL86A3@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Wael",
                LastName = "Hilal86a3",
                PhoneNumber = "01251588288"
            },

            new User
            {
                Id = "409d97fe-ed6b-11ed-9246-105badc84798",
                UserName = "Baqi.Medhatbcea@example.com",
                NormalizedUserName = "BAQI.MEDHATBCEA@EXAMPLE.COM",
                Email = "Baqi.Medhatbcea@example.com",
                NormalizedEmail = "BAQI.MEDHATBCEA@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Baqi",
                LastName = "Medhatbcea",
                PhoneNumber = "01257768133"
            },

            new User
            {
                Id = "409d9800-ed6b-11ed-a52b-105badc84798",
                UserName = "Adli.Mahmoud846c@example.com",
                NormalizedUserName = "ADLI.MAHMOUD846C@EXAMPLE.COM",
                Email = "Adli.Mahmoud846c@example.com",
                NormalizedEmail = "ADLI.MAHMOUD846C@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Adli",
                LastName = "Mahmoud846c",
                PhoneNumber = "01217209345"
            },

            new User
            {
                Id = "409d9802-ed6b-11ed-bc09-105badc84798",
                UserName = "Yusuf.Asima639@example.com",
                NormalizedUserName = "YUSUF.ASIMA639@EXAMPLE.COM",
                Email = "Yusuf.Asima639@example.com",
                NormalizedEmail = "YUSUF.ASIMA639@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Yusuf",
                LastName = "Asima639",
                PhoneNumber = "01296814946"
            },

            new User
            {
                Id = "409d9804-ed6b-11ed-acac-105badc84798",
                UserName = "Sheila.Horr81d8@example.com",
                NormalizedUserName = "SHEILA.HORR81D8@EXAMPLE.COM",
                Email = "Sheila.Horr81d8@example.com",
                NormalizedEmail = "SHEILA.HORR81D8@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sheila",
                LastName = "Horr81d8",
                PhoneNumber = "01292085322"
            },

            new User
            {
                Id = "409d9806-ed6b-11ed-bd30-105badc84798",
                UserName = "Hamza.Horr8273@example.com",
                NormalizedUserName = "HAMZA.HORR8273@EXAMPLE.COM",
                Email = "Hamza.Horr8273@example.com",
                NormalizedEmail = "HAMZA.HORR8273@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Hamza",
                LastName = "Horr8273",
                PhoneNumber = "01228938716"
            },

            new User
            {
                Id = "409d9808-ed6b-11ed-ad60-105badc84798",
                UserName = "Hamaqy.Kamel9d6c@example.com",
                NormalizedUserName = "HAMAQY.KAMEL9D6C@EXAMPLE.COM",
                Email = "Hamaqy.Kamel9d6c@example.com",
                NormalizedEmail = "HAMAQY.KAMEL9D6C@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Hamaqy",
                LastName = "Kamel9d6c",
                PhoneNumber = "01299940571"
            },

            new User
            {
                Id = "409d980a-ed6b-11ed-8f53-105badc84798",
                UserName = "Sameh.Bacari9f4c@example.com",
                NormalizedUserName = "SAMEH.BACARI9F4C@EXAMPLE.COM",
                Email = "Sameh.Bacari9f4c@example.com",
                NormalizedEmail = "SAMEH.BACARI9F4C@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sameh",
                LastName = "Bacari9f4c",
                PhoneNumber = "01236833834"
            },

            new User
            {
                Id = "409d980c-ed6b-11ed-ab6a-105badc84798",
                UserName = "Zachariah.Yusufbeab@example.com",
                NormalizedUserName = "ZACHARIAH.YUSUFBEAB@EXAMPLE.COM",
                Email = "Zachariah.Yusufbeab@example.com",
                NormalizedEmail = "ZACHARIAH.YUSUFBEAB@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Zachariah",
                LastName = "Yusufbeab",
                PhoneNumber = "01229346313"
            },

            new User
            {
                Id = "409d980e-ed6b-11ed-a002-105badc84798",
                UserName = "Russell.Fadiba6b@example.com",
                NormalizedUserName = "RUSSELL.FADIBA6B@EXAMPLE.COM",
                Email = "Russell.Fadiba6b@example.com",
                NormalizedEmail = "RUSSELL.FADIBA6B@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Russell",
                LastName = "Fadiba6b",
                PhoneNumber = "01258205230"
            },

            new User
            {
                Id = "409d9810-ed6b-11ed-8ef2-105badc84798",
                UserName = "Marawan.Hamaki922c@example.com",
                NormalizedUserName = "MARAWAN.HAMAKI922C@EXAMPLE.COM",
                Email = "Marawan.Hamaki922c@example.com",
                NormalizedEmail = "MARAWAN.HAMAKI922C@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Marawan",
                LastName = "Hamaki922c",
                PhoneNumber = "01226919350"
            },

            new User
            {
                Id = "409d9812-ed6b-11ed-9c48-105badc84798",
                UserName = "Halsi.Yisria65f@example.com",
                NormalizedUserName = "HALSI.YISRIA65F@EXAMPLE.COM",
                Email = "Halsi.Yisria65f@example.com",
                NormalizedEmail = "HALSI.YISRIA65F@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Halsi",
                LastName = "Yisria65f",
                PhoneNumber = "01270619764"
            },

            new User
            {
                Id = "409d9814-ed6b-11ed-b1a5-105badc84798",
                UserName = "Ghaith.Saber952b@example.com",
                NormalizedUserName = "GHAITH.SABER952B@EXAMPLE.COM",
                Email = "Ghaith.Saber952b@example.com",
                NormalizedEmail = "GHAITH.SABER952B@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Ghaith",
                LastName = "Saber952b",
                PhoneNumber = "01252978322"
            },

            new User
            {
                Id = "409d9816-ed6b-11ed-a024-105badc84798",
                UserName = "Ramzy.Sheikhy9b83@example.com",
                NormalizedUserName = "RAMZY.SHEIKHY9B83@EXAMPLE.COM",
                Email = "Ramzy.Sheikhy9b83@example.com",
                NormalizedEmail = "RAMZY.SHEIKHY9B83@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Ramzy",
                LastName = "Sheikhy9b83",
                PhoneNumber = "01214168755"
            },

            new User
            {
                Id = "409d9818-ed6b-11ed-a744-105badc84798",
                UserName = "Loay.Zaki8b60@example.com",
                NormalizedUserName = "LOAY.ZAKI8B60@EXAMPLE.COM",
                Email = "Loay.Zaki8b60@example.com",
                NormalizedEmail = "LOAY.ZAKI8B60@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Loay",
                LastName = "Zaki8b60",
                PhoneNumber = "01235082209"
            },

            new User
            {
                Id = "409d981a-ed6b-11ed-8cc2-105badc84798",
                UserName = "Sharm.Saber98d6@example.com",
                NormalizedUserName = "SHARM.SABER98D6@EXAMPLE.COM",
                Email = "Sharm.Saber98d6@example.com",
                NormalizedEmail = "SHARM.SABER98D6@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Sharm",
                LastName = "Saber98d6",
                PhoneNumber = "01286278436"
            },

            new User
            {
                Id = "409d981c-ed6b-11ed-a136-105badc84798",
                UserName = "Faisal.Hilal8943@example.com",
                NormalizedUserName = "FAISAL.HILAL8943@EXAMPLE.COM",
                Email = "Faisal.Hilal8943@example.com",
                NormalizedEmail = "FAISAL.HILAL8943@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Faisal",
                LastName = "Hilal8943",
                PhoneNumber = "01240227176"
            },

            new User
            {
                Id = "409d981e-ed6b-11ed-b364-105badc84798",
                UserName = "Dagher.Dagher9fe6@example.com",
                NormalizedUserName = "DAGHER.DAGHER9FE6@EXAMPLE.COM",
                Email = "Dagher.Dagher9fe6@example.com",
                NormalizedEmail = "DAGHER.DAGHER9FE6@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Dagher",
                LastName = "Dagher9fe6",
                PhoneNumber = "01217001819"
            },

            new User
            {
                Id = "409d9820-ed6b-11ed-b8a4-105badc84798",
                UserName = "Kahter.Kafarb2a1@example.com",
                NormalizedUserName = "KAHTER.KAFARB2A1@EXAMPLE.COM",
                Email = "Kahter.Kafarb2a1@example.com",
                NormalizedEmail = "KAHTER.KAFARB2A1@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Kahter",
                LastName = "Kafarb2a1",
                PhoneNumber = "01271704772"
            },

            new User
            {
                Id = "409d9822-ed6b-11ed-b007-105badc84798",
                UserName = "Russell.Barra8660@example.com",
                NormalizedUserName = "RUSSELL.BARRA8660@EXAMPLE.COM",
                Email = "Russell.Barra8660@example.com",
                NormalizedEmail = "RUSSELL.BARRA8660@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Russell",
                LastName = "Barra8660",
                PhoneNumber = "01278117140"
            },

            new User
            {
                Id = "409d9824-ed6b-11ed-b245-105badc84798",
                UserName = "Samher.Sharmb774@example.com",
                NormalizedUserName = "SAMHER.SHARMB774@EXAMPLE.COM",
                Email = "Samher.Sharmb774@example.com",
                NormalizedEmail = "SAMHER.SHARMB774@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Samher",
                LastName = "Sharmb774",
                PhoneNumber = "01253529119"
            },

            new User
            {
                Id = "409d9826-ed6b-11ed-903e-105badc84798",
                UserName = "Asim.Sadenb632@example.com",
                NormalizedUserName = "ASIM.SADENB632@EXAMPLE.COM",
                Email = "Asim.Sadenb632@example.com",
                NormalizedEmail = "ASIM.SADENB632@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Asim",
                LastName = "Sadenb632",
                PhoneNumber = "01214486306"
            },

            new User
            {
                Id = "409d9828-ed6b-11ed-8629-105badc84798",
                UserName = "Halsi.Maherbb85@example.com",
                NormalizedUserName = "HALSI.MAHERBB85@EXAMPLE.COM",
                Email = "Halsi.Maherbb85@example.com",
                NormalizedEmail = "HALSI.MAHERBB85@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Halsi",
                LastName = "Maherbb85",
                PhoneNumber = "01287150961"
            },

            new User
            {
                Id = "409d982a-ed6b-11ed-b3f7-105badc84798",
                UserName = "Jawad.Fahedb924@example.com",
                NormalizedUserName = "JAWAD.FAHEDB924@EXAMPLE.COM",
                Email = "Jawad.Fahedb924@example.com",
                NormalizedEmail = "JAWAD.FAHEDB924@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Jawad",
                LastName = "Fahedb924",
                PhoneNumber = "01287718327"
            },

            new User
            {
                Id = "409d982c-ed6b-11ed-9084-105badc84798",
                UserName = "Dagher.Sameh899e@example.com",
                NormalizedUserName = "DAGHER.SAMEH899E@EXAMPLE.COM",
                Email = "Dagher.Sameh899e@example.com",
                NormalizedEmail = "DAGHER.SAMEH899E@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Dagher",
                LastName = "Sameh899e",
                PhoneNumber = "01229621962"
            },

            new User
            {
                Id = "409d982e-ed6b-11ed-8e42-105badc84798",
                UserName = "Fidaa.Faisalaef2@example.com",
                NormalizedUserName = "FIDAA.FAISALAEF2@EXAMPLE.COM",
                Email = "Fidaa.Faisalaef2@example.com",
                NormalizedEmail = "FIDAA.FAISALAEF2@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Fidaa",
                LastName = "Faisalaef2",
                PhoneNumber = "01239399918"
            },

            new User
            {
                Id = "409d9830-ed6b-11ed-abc8-105badc84798",
                UserName = "Yad.Jika853c@example.com",
                NormalizedUserName = "YAD.JIKA853C@EXAMPLE.COM",
                Email = "Yad.Jika853c@example.com",
                NormalizedEmail = "YAD.JIKA853C@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Yad",
                LastName = "Jika853c",
                PhoneNumber = "01273014929"
            },

            new User
            {
                Id = "409d9832-ed6b-11ed-8176-105badc84798",
                UserName = "Dagher.Sheilaaa3b@example.com",
                NormalizedUserName = "DAGHER.SHEILAAA3B@EXAMPLE.COM",
                Email = "Dagher.Sheilaaa3b@example.com",
                NormalizedEmail = "DAGHER.SHEILAAA3B@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Dagher",
                LastName = "Sheilaaa3b",
                PhoneNumber = "01271168271"
            },

            new User
            {
                Id = "409d9834-ed6b-11ed-883a-105badc84798",
                UserName = "Ghaith.Adela089@example.com",
                NormalizedUserName = "GHAITH.ADELA089@EXAMPLE.COM",
                Email = "Ghaith.Adela089@example.com",
                NormalizedEmail = "GHAITH.ADELA089@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Ghaith",
                LastName = "Adela089",
                PhoneNumber = "01240257375"
            },

            new User
            {
                Id = "409d9836-ed6b-11ed-8979-105badc84798",
                UserName = "Ryan.Ramzybdbf@example.com",
                NormalizedUserName = "RYAN.RAMZYBDBF@EXAMPLE.COM",
                Email = "Ryan.Ramzybdbf@example.com",
                NormalizedEmail = "RYAN.RAMZYBDBF@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Ryan",
                LastName = "Ramzybdbf",
                PhoneNumber = "01282509863"
            },

            new User
            {
                Id = "409d9838-ed6b-11ed-ac79-105badc84798",
                UserName = "Bacari.Firasa5e7@example.com",
                NormalizedUserName = "BACARI.FIRASA5E7@EXAMPLE.COM",
                Email = "Bacari.Firasa5e7@example.com",
                NormalizedEmail = "BACARI.FIRASA5E7@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Bacari",
                LastName = "Firasa5e7",
                PhoneNumber = "01265289814"
            },

            new User
            {
                Id = "409d983a-ed6b-11ed-890c-105badc84798",
                UserName = "Fares.Radwana0b0@example.com",
                NormalizedUserName = "FARES.RADWANA0B0@EXAMPLE.COM",
                Email = "Fares.Radwana0b0@example.com",
                NormalizedEmail = "FARES.RADWANA0B0@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Mossad5522!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Fares",
                LastName = "Radwana0b0",
                PhoneNumber = "01231166131"
            }
        );
    }
}
