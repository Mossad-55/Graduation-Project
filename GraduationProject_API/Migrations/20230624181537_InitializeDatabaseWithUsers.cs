using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class InitializeDatabaseWithUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "64F2143D-B896-4355-90D2-AFD22424B234", "bc8c7ec6-0a7e-4153-96cb-35a3a00c0c70", "Department Admin", "DEPARTMENT ADMIN" },
                    { "A2523A70-57E3-4B69-A405-F9752517ED62", "01ec8863-52b6-45a3-848e-87f34a6a253c", "Faculty Admin", "FACULTY ADMIN" },
                    { "BEA713C7-93D2-4F39-8DC8-18F2F3070779", "6c7783a7-f863-40d7-9823-3b43717a7fe2", "University Admin", "UNIVERSITY ADMIN" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "0b9d9648-bda1-417a-99f2-2e8452052fe8", "Student", "STUDENT" },
                    { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "15824303-ac5a-4a1f-af3a-bdcae3207f61", "Professor", "PROFESSOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4093fa25-ed6b-11ed-a6df-105badc84798", 0, "23f14012-1099-4e5d-b041-32c22f6978b4", "Hamza.Najmb32d@example.com", true, "Hamza", "Najmb32d", false, null, "HAMZA.NAJMB32D@EXAMPLE.COM", "HAMZA.NAJMB32D@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHqt8ELV5oklkvgQg6DDqQEYL+tC3LSXGU3o92blkVenkH/Z0P18tv+/uLTcbmQiQQ==", "01232988337", false, "7f458389-d55a-4f1c-b6aa-9b3a138fdc04", false, "Hamza.Najmb32d@example.com" },
                    { "4093fa27-ed6b-11ed-8922-105badc84798", 0, "93281e58-0f54-4a8e-95c9-e9d220242abb", "Malek.Sheikh9cd6@example.com", true, "Malek", "Sheikh9cd6", false, null, "MALEK.SHEIKH9CD6@EXAMPLE.COM", "MALEK.SHEIKH9CD6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBCZBHvphtpXz1p7tf8uGLfjGWX7fXVK9rM3e+N6IFfHf3IF65W+LIQJxoTGPEUZ1A==", "01220871240", false, "f404c928-4d3b-40dc-ba8e-23f15a4f557f", false, "Malek.Sheikh9cd6@example.com" },
                    { "4093fa29-ed6b-11ed-85ba-105badc84798", 0, "eccaeaa6-bb32-4617-9749-373ffd91f60a", "Zachariah.Hishamiaac8@example.com", true, "Zachariah", "Hishamiaac8", false, null, "ZACHARIAH.HISHAMIAAC8@EXAMPLE.COM", "ZACHARIAH.HISHAMIAAC8@EXAMPLE.COM", "AQAAAAEAACcQAAAAELn+oZSZEVQaG5kL/bAt8Rk9xWAp8cCCqqZTfBpTHc+X2O4g1gYxcrEqJN5v+cy1Eg==", "01269689816", false, "cbfd3bff-2969-4bb4-a40a-a1b423c5930e", false, "Zachariah.Hishamiaac8@example.com" },
                    { "4093fa2b-ed6b-11ed-9be9-105badc84798", 0, "ee799154-d82c-4894-a9e7-dea53d7f097d", "Bassam.Barra9103@example.com", true, "Bassam", "Barra9103", false, null, "BASSAM.BARRA9103@EXAMPLE.COM", "BASSAM.BARRA9103@EXAMPLE.COM", "AQAAAAEAACcQAAAAECtiuaSM4YpEatPeX5Ub8mX+hbkgJLZr3miB4YoQPURUHW9dfRIrgNsP9VkYsS4UvQ==", "01287718443", false, "7c5f3091-9a55-4a9d-9327-53bbb2b7fad0", false, "Bassam.Barra9103@example.com" },
                    { "4093fa2d-ed6b-11ed-a65f-105badc84798", 0, "8feb6503-4ed4-4b34-8dd8-80470e177892", "​​Karim.Ahmed9826@example.com", true, "​​Karim", "Ahmed9826", false, null, "​​KARIM.AHMED9826@EXAMPLE.COM", "​​KARIM.AHMED9826@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOQDRheqOKyG/nSI2bP6EHFPkqW1G63DMSzOBDnB1vyGNf2b+QGkQtBinTHPLNmQbg==", "01229669039", false, "87bc15c6-e518-4c19-a198-4e78ae60cf4f", false, "​​Karim.Ahmed9826@example.com" },
                    { "409676b0-ed6b-11ed-9fd6-105badc84798", 0, "30daf72f-c3c3-4b4f-ab6b-5e31d9e5d134", "Russell.Jawada950@example.com", true, "Russell", "Jawada950", false, null, "RUSSELL.JAWADA950@EXAMPLE.COM", "RUSSELL.JAWADA950@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJupVCxeCWjosScmgKZQv1WFPCTA6OGjSp5xRxlQkZCHdQWoJZAimswiRZfBL0VHjw==", "01258890451", false, "9fbc4cca-22d8-49bb-9527-4811b94c8813", false, "Russell.Jawada950@example.com" },
                    { "409676b2-ed6b-11ed-b62e-105badc84798", 0, "10e82314-96cf-4b57-94c3-eaecaf07d08b", "Helsey.Bahiabb8@example.com", true, "Helsey", "Bahiabb8", false, null, "HELSEY.BAHIABB8@EXAMPLE.COM", "HELSEY.BAHIABB8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOKrxn4DC2xzWxROdG2pcAiwqjy4wwvcrdBG+91KIaO5h36hdMuhgbIrdDcSACfRfg==", "01271822961", false, "582af943-6135-4c2e-8a24-155a27ca0237", false, "Helsey.Bahiabb8@example.com" },
                    { "409676b4-ed6b-11ed-b886-105badc84798", 0, "5ee6d054-4b51-4978-8898-1e9595241835", "Adel.Fidaa8283@example.com", true, "Adel", "Fidaa8283", false, null, "ADEL.FIDAA8283@EXAMPLE.COM", "ADEL.FIDAA8283@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAJ6NXlXspfJJKgpOtCaujP7BejU0oAvTLQlgFxTDxgSxm9CmkoypvRYVd81Cq6BuQ==", "01252839445", false, "70b2a35e-9e5e-4251-a313-9b8c985a75d9", false, "Adel.Fidaa8283@example.com" },
                    { "409676b6-ed6b-11ed-b477-105badc84798", 0, "5daa7578-6d11-49ac-b4cd-f1cbcfbff8b9", "Haor.Medhatbb1e@example.com", true, "Haor", "Medhatbb1e", false, null, "HAOR.MEDHATBB1E@EXAMPLE.COM", "HAOR.MEDHATBB1E@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOFSxTwehE30+q/6CSJaEweUsDCd5GlE718wZVDGhYKQGOWrcnBsiEwjh5PiFQ5IFQ==", "01249787781", false, "1e663798-473e-4721-ae50-a57574dd535f", false, "Haor.Medhatbb1e@example.com" },
                    { "409676b8-ed6b-11ed-9c16-105badc84798", 0, "d2eb7133-6327-4bcd-b4bd-72b955485253", "Hassan.Haor9c0d@example.com", true, "Hassan", "Haor9c0d", false, null, "HASSAN.HAOR9C0D@EXAMPLE.COM", "HASSAN.HAOR9C0D@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAKKCYAMZAN6tHtgLdDbMuUomsFz5RVELXgsNRhoWKNbfsvh2fyVQr6XzzGWavGpsg==", "01252429834", false, "36e50a10-8196-4a75-9c65-da6fcce1a4aa", false, "Hassan.Haor9c0d@example.com" },
                    { "409676ba-ed6b-11ed-adbf-105badc84798", 0, "7f8e841a-254e-49da-930e-7d8fc0851cf2", "Sameh.Hilalb0d8@example.com", true, "Sameh", "Hilalb0d8", false, null, "SAMEH.HILALB0D8@EXAMPLE.COM", "SAMEH.HILALB0D8@EXAMPLE.COM", "AQAAAAEAACcQAAAAELxhdm0XDbfpWmmcTg+qD2BVtKYPr+h1sJoNrDvQuBvgjSRudgbbMmrTS4UI5sdG1w==", "01212885239", false, "d23a9f13-df5d-4a1c-be5d-1d0a4b6f459e", false, "Sameh.Hilalb0d8@example.com" },
                    { "409676bc-ed6b-11ed-9b21-105badc84798", 0, "e4d20e04-b530-4a45-8707-efe2d706d0df", "Ghaith.Asim9678@example.com", true, "Ghaith", "Asim9678", false, null, "GHAITH.ASIM9678@EXAMPLE.COM", "GHAITH.ASIM9678@EXAMPLE.COM", "AQAAAAEAACcQAAAAELzfh2h65UXOYsfkAvRhIgzxBOHFjJw+Z2ZJnHu1zbnbM3GeNozli+VFqBh/ds7aWg==", "01286981596", false, "822a70d9-caf2-4a81-82bf-33d102210d62", false, "Ghaith.Asim9678@example.com" },
                    { "409676be-ed6b-11ed-902b-105badc84798", 0, "c4fe541c-69fc-4c68-81f6-34eaaf0a2863", "Waseem.Ghanem9305@example.com", true, "Waseem", "Ghanem9305", false, null, "WASEEM.GHANEM9305@EXAMPLE.COM", "WASEEM.GHANEM9305@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHDaBcI6H0FWjYtp78RG1FkfxZ74y5czchvvo/SRvBQTOV0NvRUjiMN6j2lY8bqFjA==", "01267352439", false, "2be0679a-91e9-463a-acb0-e18e06291cad", false, "Waseem.Ghanem9305@example.com" },
                    { "409676c0-ed6b-11ed-a990-105badc84798", 0, "e05e63c2-f55a-41f3-90c5-f7f567f1c17e", "Badri.Basemacbd@example.com", true, "Badri", "Basemacbd", false, null, "BADRI.BASEMACBD@EXAMPLE.COM", "BADRI.BASEMACBD@EXAMPLE.COM", "AQAAAAEAACcQAAAAECRTG8RZhEcdn/XVFqNljpQ22T/cqmqYPwZzVi6RfHjjNgLkmBMlmrq9ZTyg8SeWNQ==", "01297327850", false, "d372435e-474b-4cd8-a2d8-d4f37b1be155", false, "Badri.Basemacbd@example.com" },
                    { "409676c2-ed6b-11ed-a696-105badc84798", 0, "309d4dac-ab4c-4e39-b342-8fc935adc6a1", "Bacari.Sharmb5af@example.com", true, "Bacari", "Sharmb5af", false, null, "BACARI.SHARMB5AF@EXAMPLE.COM", "BACARI.SHARMB5AF@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJ73rVcWz91sblXtn2ll/sn2PvC1RLifTUVpPkdYgEz03dvVNZiooMub1Qawx0hiWg==", "01282353516", false, "3f0f6d00-2b7a-4f1c-9d54-ac50d366bbdf", false, "Bacari.Sharmb5af@example.com" },
                    { "409676c4-ed6b-11ed-a637-105badc84798", 0, "c47da8ea-762f-40fa-9373-ea668899a4e0", "Yakon.Sharm9d1a@example.com", true, "Yakon", "Sharm9d1a", false, null, "YAKON.SHARM9D1A@EXAMPLE.COM", "YAKON.SHARM9D1A@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKyN1P7WfWIJKSyfFZJ4Fqng1e2ffHRAYHRskP/G4x9MxGjArDBfQ9jyj0ULCuM8Rg==", "01216786378", false, "93c0e852-434d-40ae-b352-ef955dc23b9e", false, "Yakon.Sharm9d1a@example.com" },
                    { "40977647-ed6b-11ed-aad8-105badc84798", 0, "445d9793-eb0d-44a6-958b-3e5a5370b00f", "Fidaa.Adham9867@example.com", true, "Fidaa", "Adham9867", false, null, "FIDAA.ADHAM9867@EXAMPLE.COM", "FIDAA.ADHAM9867@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJzIh0p9aRZU9EF9FYWiuzX3GQL02F3d7R3MVa01KniK3+oX3LS4bEhrO7ssqZUvSQ==", "01218203642", false, "d58e88fe-0f82-4863-b54a-fbf8d35cee57", false, "Fidaa.Adham9867@example.com" },
                    { "40977649-ed6b-11ed-973e-105badc84798", 0, "b94db04e-bb48-4f60-a186-923cafc25816", "Firas.Bassel82fd@example.com", true, "Firas", "Bassel82fd", false, null, "FIRAS.BASSEL82FD@EXAMPLE.COM", "FIRAS.BASSEL82FD@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBAWLQmTwckNB3DAn6YpjhrofJe5I/Y4oMAdLIjGG23/Jrgm5YzOZ0RE5h3AwDZtUg==", "01217707960", false, "bd543921-d9a8-4be9-b41a-c395fe83cb1c", false, "Firas.Bassel82fd@example.com" },
                    { "4097764b-ed6b-11ed-b259-105badc84798", 0, "ac8641cf-59e7-4088-880f-88cad532b052", "Sameh.Hishami8757@example.com", true, "Sameh", "Hishami8757", false, null, "SAMEH.HISHAMI8757@EXAMPLE.COM", "SAMEH.HISHAMI8757@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIXzgFHXv3WIWWSlqO+A0sNq7o+3BW+DFR2NmqMLTTwGFc1ctQBwfaVRr89g6i3SFg==", "01272041260", false, "5fd8526c-0f4f-4d39-90fb-b31acbeeac65", false, "Sameh.Hishami8757@example.com" },
                    { "4097973c-ed6b-11ed-9913-105badc84798", 0, "964e8057-b14f-4ed6-ba56-bfbd65be8553", "Noah.Nahar9371@example.com", true, "Noah", "Nahar9371", false, null, "NOAH.NAHAR9371@EXAMPLE.COM", "NOAH.NAHAR9371@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJfs5UdOi1P6ifN/4lkpLG000wiYxiwEChhTgC/HIxQQy3jI2ep5eiiLBe0fdFSYbQ==", "01244828073", false, "ddf24dab-33ff-45c9-bad6-b305ffcd3c27", false, "Noah.Nahar9371@example.com" },
                    { "4097973e-ed6b-11ed-929c-105badc84798", 0, "f692b869-cf1b-436d-8be8-f98fff4f0fd1", "Saden.Ali8050@example.com", true, "Saden", "Ali8050", false, null, "SADEN.ALI8050@EXAMPLE.COM", "SADEN.ALI8050@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFdVo5AQ+UiZNdnGVOlCQegmFt/M+jRcyydouEsEHXqCTVOkfqM+6zssx5gNi/9bkg==", "01243048322", false, "9aa1b209-0744-4a06-ac4f-0241a697246b", false, "Saden.Ali8050@example.com" },
                    { "40979740-ed6b-11ed-8c11-105badc84798", 0, "85dcc4bd-3f6a-4926-a9d5-08c7120cebc4", "Ghaith.Basselb8db@example.com", true, "Ghaith", "Basselb8db", false, null, "GHAITH.BASSELB8DB@EXAMPLE.COM", "GHAITH.BASSELB8DB@EXAMPLE.COM", "AQAAAAEAACcQAAAAENkHuuifZ4OjyvZjJa2wAXqXYWktAh+87ou7t2cb0oi6yR9o79l98KOWZz6Vcj/v9A==", "01288105916", false, "cc250401-ea2d-43ad-828b-37fd4f76a7ce", false, "Ghaith.Basselb8db@example.com" },
                    { "40979742-ed6b-11ed-b3de-105badc84798", 0, "637bbda5-e8fd-49b0-8019-3e7076cf817a", "​​Karim.Basem9bee@example.com", true, "​​Karim", "Basem9bee", false, null, "​​KARIM.BASEM9BEE@EXAMPLE.COM", "​​KARIM.BASEM9BEE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMMJpNemkHHF7HKnKQvpmdza1/H7m7SdNn71iPVwlCqz1KxE4tEfmHjbGADBH3RWIA==", "01273133463", false, "70b7b19d-9535-48c7-8999-df0e23f2c44c", false, "​​Karim.Basem9bee@example.com" },
                    { "40979744-ed6b-11ed-8abc-105badc84798", 0, "1a6a9c66-fb75-4942-9ba7-661c12b1c39f", "Minali.Medhat86ba@example.com", true, "Minali", "Medhat86ba", false, null, "MINALI.MEDHAT86BA@EXAMPLE.COM", "MINALI.MEDHAT86BA@EXAMPLE.COM", "AQAAAAEAACcQAAAAEC8/QgtPsZSFLAMw+8HrYeKF0KmBU01jSYkeUcfLcFVVwuczvsLkM611T0wcmfq25g==", "01279049557", false, "84313764-5e1f-4521-882f-0306efb915a4", false, "Minali.Medhat86ba@example.com" },
                    { "4097c4fc-ed6b-11ed-84e8-105badc84798", 0, "8c96d858-2abe-4d81-a02d-c88a2d29eef7", "Bilal.Zachariah83af@example.com", true, "Bilal", "Zachariah83af", false, null, "BILAL.ZACHARIAH83AF@EXAMPLE.COM", "BILAL.ZACHARIAH83AF@EXAMPLE.COM", "AQAAAAEAACcQAAAAEM0rcrSoqkHPbn3ZQx5BOvGj0Mkq59GrKBHdetp8+G0KV4ST+DJn5WxEKVbe+mOLhQ==", "01293395937", false, "9526c0c7-5de5-482a-b142-715774331ccf", false, "Bilal.Zachariah83af@example.com" },
                    { "4097c4fe-ed6b-11ed-b56a-105badc84798", 0, "edb1b431-10ed-4fbe-864a-24738394311c", "Abi.Radwana902@example.com", true, "Abi", "Radwana902", false, null, "ABI.RADWANA902@EXAMPLE.COM", "ABI.RADWANA902@EXAMPLE.COM", "AQAAAAEAACcQAAAAEN28/JEpcEy3fipicJuv4pIbq0MQQzQl8VOKkhZTH2Lf/0pmfY/7BmquZjL9W9pOgA==", "01269899834", false, "ea5a71e4-5b58-43bc-b6fe-62a6abe6e997", false, "Abi.Radwana902@example.com" },
                    { "4097c500-ed6b-11ed-b1ae-105badc84798", 0, "a5405df3-33a8-4346-bf56-89f775dbe441", "Russell.Hosni9590@example.com", true, "Russell", "Hosni9590", false, null, "RUSSELL.HOSNI9590@EXAMPLE.COM", "RUSSELL.HOSNI9590@EXAMPLE.COM", "AQAAAAEAACcQAAAAELQjEKRoBCD/4GoWP4szouMlhbQZqGhtlA36o2AG8krjswVIANKfhMUza2swAw9oaQ==", "01219006694", false, "edfbd181-2282-4769-b6dd-9b5faf18a363", false, "Russell.Hosni9590@example.com" },
                    { "4097d8e5-ed6b-11ed-8a0f-105badc84798", 0, "81d1a6cd-90a3-4f07-a975-ed96168a1217", "Samhi.Baqibff9@example.com", true, "Samhi", "Baqibff9", false, null, "SAMHI.BAQIBFF9@EXAMPLE.COM", "SAMHI.BAQIBFF9@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMwe9QiHVUZ1NNkJq/pPVei9YPjk1TzT3JuT2XC1hkBLEaEL8raZzlZ8sjoFG5wiEg==", "01254158559", false, "92bbd190-dfec-4428-be57-7efc9e95e023", false, "Samhi.Baqibff9@example.com" },
                    { "4097d8e7-ed6b-11ed-b377-105badc84798", 0, "a03e78cc-b851-4ce7-8679-e781fbe6c4a2", "Ghanem.Adham8b37@example.com", true, "Ghanem", "Adham8b37", false, null, "GHANEM.ADHAM8B37@EXAMPLE.COM", "GHANEM.ADHAM8B37@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIT2qoeEICd990Fd83pfKjpIhSk7437YKPM+gVZO3YNj+GRG0RNw265TxE+uLzQkpw==", "01217050688", false, "e90a6f93-25f6-4c3a-8d7f-b46e76bcb62b", false, "Ghanem.Adham8b37@example.com" },
                    { "4097d8e9-ed6b-11ed-83d1-105badc84798", 0, "f02f1920-be31-4e3c-85a4-2d003ab4d9db", "Dagher.Hilali951a@example.com", true, "Dagher", "Hilali951a", false, null, "DAGHER.HILALI951A@EXAMPLE.COM", "DAGHER.HILALI951A@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJ3gVYJSBXHKFYDal8sx8FOyZLFsI3VNQ6C11mHwXVS+AToKA+MpoV1aktX6u+XC8w==", "01268897899", false, "66bb363e-9567-4376-a0f3-8ad23cec2769", false, "Dagher.Hilali951a@example.com" },
                    { "4097d8eb-ed6b-11ed-8f98-105badc84798", 0, "debb3472-3acb-4085-9285-d7f0edaa2b1b", "Hussein.Sameha5e1@example.com", true, "Hussein", "Sameha5e1", false, null, "HUSSEIN.SAMEHA5E1@EXAMPLE.COM", "HUSSEIN.SAMEHA5E1@EXAMPLE.COM", "AQAAAAEAACcQAAAAELVFq+M/RQQYZcwED9hPis7YoYpd/vnHxh63WRoOJan/GKNN/tvhy2QZ/svJKW3mBQ==", "01242105816", false, "c06aab3e-8a8b-4bfb-9b5e-17c100d8bb53", false, "Hussein.Sameha5e1@example.com" },
                    { "4097d8ed-ed6b-11ed-9f99-105badc84798", 0, "2d161e43-e5ab-4408-98a4-b72ec8b04e33", "Hamaqy.Saber9b17@example.com", true, "Hamaqy", "Saber9b17", false, null, "HAMAQY.SABER9B17@EXAMPLE.COM", "HAMAQY.SABER9B17@EXAMPLE.COM", "AQAAAAEAACcQAAAAEI6cUTKJRW8/r9fqvwIGwYdbR9ZvM3GIB6eNSVOiJ/MNy2X6FxZv/mQ7wrIQ4jZXWg==", "01273898120", false, "012564f0-9635-4907-bcf7-b2ca8ce5c0df", false, "Hamaqy.Saber9b17@example.com" },
                    { "4097d8ef-ed6b-11ed-8cd4-105badc84798", 0, "d12aeb8f-e8c4-4466-987f-197d89ade70e", "Sheila.Sheilaa655@example.com", true, "Sheila", "Sheilaa655", false, null, "SHEILA.SHEILAA655@EXAMPLE.COM", "SHEILA.SHEILAA655@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMQK68GpirSMPXXev0MfnbrT7pDdGKWyLt1RvfYlXYMn5myyw5zpjuNCqkE4q52uIQ==", "01267569088", false, "1438bf63-31a2-440e-b9f6-1daa0443a7df", false, "Sheila.Sheilaa655@example.com" },
                    { "4097d8f1-ed6b-11ed-aa86-105badc84798", 0, "98714381-d95e-4185-9024-30e8d1e282df", "Daniel.Bahib5ad@example.com", true, "Daniel", "Bahib5ad", false, null, "DANIEL.BAHIB5AD@EXAMPLE.COM", "DANIEL.BAHIB5AD@EXAMPLE.COM", "AQAAAAEAACcQAAAAELy+9rVZ2IQzOczcWlg9bcPYx+ucFYEUOq+6vxtUkcTelafWY/ukhCaFw+2gjZq4mg==", "01262123625", false, "20e24a9e-ce80-4e0c-a01e-7686f4dd38b6", false, "Daniel.Bahib5ad@example.com" },
                    { "4097d8f3-ed6b-11ed-9479-105badc84798", 0, "3a69198f-5b27-41d1-b0b8-738f21b6fdd8", "Halsi.Kolthouma5c7@example.com", true, "Halsi", "Kolthouma5c7", false, null, "HALSI.KOLTHOUMA5C7@EXAMPLE.COM", "HALSI.KOLTHOUMA5C7@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEq+AlCCjFUGJ0A1yIE+w+HxJ/+hnKYjviZLl7RiSQ5D2ovIOwVIVuMpt8Ezrq7UaA==", "01262132489", false, "a7886186-8964-4792-a5ad-d5c034dc5304", false, "Halsi.Kolthouma5c7@example.com" },
                    { "4097d8f5-ed6b-11ed-aca2-105badc84798", 0, "fe529111-6b78-4776-8ebc-e1aaa4b4c924", "Mahmoud.Wael9d18@example.com", true, "Mahmoud", "Wael9d18", false, null, "MAHMOUD.WAEL9D18@EXAMPLE.COM", "MAHMOUD.WAEL9D18@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOUhQCvmiW3Sl5cE5/v33DAPgtnHhAoxXHYJOvTGzgFwlOJeiSz6oee+4r+Gy4pxzw==", "01231638303", false, "bd3d6896-903e-41de-828b-41003b0137e6", false, "Mahmoud.Wael9d18@example.com" },
                    { "4097d8f7-ed6b-11ed-98e4-105badc84798", 0, "b14b78bc-d9b6-4e43-ab25-f335982ecb95", "Osama.Basem92cb@example.com", true, "Osama", "Basem92cb", false, null, "OSAMA.BASEM92CB@EXAMPLE.COM", "OSAMA.BASEM92CB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKAyn3Ecs/ew+6z3vVMRasKPVrLLMRpXb2B1Le0/rG3A9aPOCs0tRgoY+k3hY9wmuA==", "01218566576", false, "774d2ce6-0b67-42ce-85be-eaa8887123d2", false, "Osama.Basem92cb@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4097d8f9-ed6b-11ed-8f23-105badc84798", 0, "0b9792c4-9f40-4dc7-a059-7f92aae91c13", "Nahar.Shehabiac20@example.com", true, "Nahar", "Shehabiac20", false, null, "NAHAR.SHEHABIAC20@EXAMPLE.COM", "NAHAR.SHEHABIAC20@EXAMPLE.COM", "AQAAAAEAACcQAAAAECvRm/DWn62v+azzcGfc744IGCh6T6Do23ghFtsROHKBAOtzZaxvwFD7pCYpvYZwXA==", "01241146819", false, "c10b73fc-4f31-46c7-9b26-8168900406b9", false, "Nahar.Shehabiac20@example.com" },
                    { "4097d8fb-ed6b-11ed-b285-105badc84798", 0, "6fef9de3-ba8a-4640-9f27-b74701e565c1", "Marawan.Zachariah8daa@example.com", true, "Marawan", "Zachariah8daa", false, null, "MARAWAN.ZACHARIAH8DAA@EXAMPLE.COM", "MARAWAN.ZACHARIAH8DAA@EXAMPLE.COM", "AQAAAAEAACcQAAAAENyT/ozstfMfmQP2adN0H9CdTW/sJXS0oXKOSJzySDXL8+rtPr/YC2Qrytlvwcs4bg==", "01292596275", false, "763d95ab-00e6-48fb-bb8e-ddc00f4a6495", false, "Marawan.Zachariah8daa@example.com" },
                    { "4097d8fd-ed6b-11ed-b6a3-105badc84798", 0, "0c80a76a-7b38-4f32-a2e4-a0f8bea9a055", "Adham.Dagherb00d@example.com", true, "Adham", "Dagherb00d", false, null, "ADHAM.DAGHERB00D@EXAMPLE.COM", "ADHAM.DAGHERB00D@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEWTXfBIGkq0fBYEWioR0OBFqVsW1eGjMAiU566iymSf2BGVu1WikRmPM1Pr1pYa0g==", "01264741807", false, "42e7d07e-714b-4c2d-af1b-5be98b14dba1", false, "Adham.Dagherb00d@example.com" },
                    { "4097d8ff-ed6b-11ed-85f9-105badc84798", 0, "e0a05288-2416-4e83-ba21-bb7142af38e7", "Majid.Asami943b@example.com", true, "Majid", "Asami943b", false, null, "MAJID.ASAMI943B@EXAMPLE.COM", "MAJID.ASAMI943B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEB99/DIVtxi4H5O1cDDVEDGu4tAj+cL+f2XMW1JuD6Y6ixmSlKGtoYM9abYpNznBSg==", "01258015535", false, "822b0abb-0a07-4a7f-8ba8-a396798c3ea6", false, "Majid.Asami943b@example.com" },
                    { "4097d901-ed6b-11ed-9297-105badc84798", 0, "b7958b1c-6c6d-4bd6-99ea-2cbafe450446", "Ghaith.Bahiracf6@example.com", true, "Ghaith", "Bahiracf6", false, null, "GHAITH.BAHIRACF6@EXAMPLE.COM", "GHAITH.BAHIRACF6@EXAMPLE.COM", "AQAAAAEAACcQAAAAENNqBYqz1UUrfv1QhbpmpFFyopmIvXzvOCn97VMFlOLOUhzMMF/sxs4uHZjCjs7S/w==", "01232394458", false, "1398f40f-67ba-4015-aace-5de426f84259", false, "Ghaith.Bahiracf6@example.com" },
                    { "4097d903-ed6b-11ed-855f-105badc84798", 0, "cd36b009-9ca3-4af6-9275-1121ffb137ca", "Yunus.Zachariah8945@example.com", true, "Yunus", "Zachariah8945", false, null, "YUNUS.ZACHARIAH8945@EXAMPLE.COM", "YUNUS.ZACHARIAH8945@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBHRmRgs6nzkN00zq+icbL1tXRN4r+xxIwLbQ5VixsULB5vRzfGNPgNsLDT9KCITpw==", "01288556434", false, "ca3e7bf3-7d65-48b0-843f-7de434a7e13e", false, "Yunus.Zachariah8945@example.com" },
                    { "4097d905-ed6b-11ed-b302-105badc84798", 0, "30ce685c-772a-48e3-9267-3e6d29bb057f", "Ramzy.Osamaafb5@example.com", true, "Ramzy", "Osamaafb5", false, null, "RAMZY.OSAMAAFB5@EXAMPLE.COM", "RAMZY.OSAMAAFB5@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKia3WzRIGBWyT6EjzJZ1l5nTuMdeApdWjK8ngDWPR5HG/LfA2zeEMdCDtoCehm4AQ==", "01272846023", false, "ee50a2df-b4da-4c3d-8da2-a3542dba2e18", false, "Ramzy.Osamaafb5@example.com" },
                    { "4097d907-ed6b-11ed-b6b6-105badc84798", 0, "23700afc-086c-45c8-96bd-ad5f0a547789", "Bahi.Yisrib844@example.com", true, "Bahi", "Yisrib844", false, null, "BAHI.YISRIB844@EXAMPLE.COM", "BAHI.YISRIB844@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMbs4/I4mSx53dnP7rQv7CbVlJHa410NWWQcK1PM9263QUedh32/WrdHmmjX34v9aA==", "01289220737", false, "e551b5f3-a39f-4613-b9a6-41d0da426934", false, "Bahi.Yisrib844@example.com" },
                    { "4097d909-ed6b-11ed-93d8-105badc84798", 0, "78387c89-4ac6-405b-96e8-47701d81043f", "Sheikh.Kafar97f1@example.com", true, "Sheikh", "Kafar97f1", false, null, "SHEIKH.KAFAR97F1@EXAMPLE.COM", "SHEIKH.KAFAR97F1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEhiwZubnAbtHW7aoXZTLcNiw05J64dOaJV1YNN2j0wVZ4nQjvf+igMsA7EX9phFwA==", "01228387515", false, "c5e3853e-9e43-437e-b5df-6a4eb3a17da1", false, "Sheikh.Kafar97f1@example.com" },
                    { "4097d90b-ed6b-11ed-a99b-105badc84798", 0, "31216a35-4518-41df-9c35-fbe2285adc85", "Fares.Hassanbdf6@example.com", true, "Fares", "Hassanbdf6", false, null, "FARES.HASSANBDF6@EXAMPLE.COM", "FARES.HASSANBDF6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGKAkMuD/B+ivQvpcJlp5UhJTOVjgg0zc9mSquU9vp5t5unAThUZ+NX84NTGJEGOZQ==", "01278694578", false, "b6cc4c3b-731b-4c1f-bf19-a108433d7101", false, "Fares.Hassanbdf6@example.com" },
                    { "4097d90d-ed6b-11ed-956f-105badc84798", 0, "f6115a27-7ade-45b6-8ab0-4cfa89bdef81", "Samir.Sheila8b49@example.com", true, "Samir", "Sheila8b49", false, null, "SAMIR.SHEILA8B49@EXAMPLE.COM", "SAMIR.SHEILA8B49@EXAMPLE.COM", "AQAAAAEAACcQAAAAENcm3vwUMC615L93r8ZqU9eEpzMX4/3UY78vgMwHEQDfWr0hD59j5JeGBI4CBL/Ozw==", "01214800867", false, "8f2a03b4-5932-40f6-991c-1fc25e4033c3", false, "Samir.Sheila8b49@example.com" },
                    { "4097d90f-ed6b-11ed-a0cc-105badc84798", 0, "fd396faa-a8b9-41ac-852f-1221c6d769e4", "Yakon.Adhamaaa9@example.com", true, "Yakon", "Adhamaaa9", false, null, "YAKON.ADHAMAAA9@EXAMPLE.COM", "YAKON.ADHAMAAA9@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKO9IbpOAvZGOvbmepTF8AVQsswD4gGgGfwJoH2zx3Wr2G7tzQqVQzzN+jossGtmfw==", "01299862932", false, "f57db6b8-f912-4cf4-a5dc-03ac8fbad35c", false, "Yakon.Adhamaaa9@example.com" },
                    { "4097d911-ed6b-11ed-b614-105badc84798", 0, "b38e71bd-fd17-439a-b84b-09462c1394dc", "Fidaa.Sameha430@example.com", true, "Fidaa", "Sameha430", false, null, "FIDAA.SAMEHA430@EXAMPLE.COM", "FIDAA.SAMEHA430@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBVHMSCIxVahuGLqXnmBU45iGPCcqwE3ekry6OByyIHexVh/IlbxYWM0KPpUtFWzzw==", "01283485131", false, "c20feafb-3fac-4c8d-9005-9ec1c64b1765", false, "Fidaa.Sameha430@example.com" },
                    { "4097d913-ed6b-11ed-816e-105badc84798", 0, "2a0dd3d7-cda1-4919-9432-db4d8e089ce4", "Yusuf.Baqi8945@example.com", true, "Yusuf", "Baqi8945", false, null, "YUSUF.BAQI8945@EXAMPLE.COM", "YUSUF.BAQI8945@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHe4hAH9cx61fk6ugUFKnr5z+ra4vVdjBmr3WxhMidaIlP80VNCtHbT1P05UehxesA==", "01235586777", false, "00ba5916-2bfc-420c-98b9-474904404173", false, "Yusuf.Baqi8945@example.com" },
                    { "4097d915-ed6b-11ed-a890-105badc84798", 0, "5099700c-de6c-490f-8cab-69f516934f45", "Kahter.Minali8e83@example.com", true, "Kahter", "Minali8e83", false, null, "KAHTER.MINALI8E83@EXAMPLE.COM", "KAHTER.MINALI8E83@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFjoywL6482RKfldU4zzq5W6zNxWf0y8YqzuMdSFuVrPEgJbkogFCrRixhdYYl2arQ==", "01237394610", false, "adce4e15-1d48-4efc-8190-c656bf41e6ce", false, "Kahter.Minali8e83@example.com" },
                    { "4098b15b-ed6b-11ed-9dc2-105badc84798", 0, "7fa1e46b-1a51-4159-a0cf-9b35e91f5e44", "Hamaki.Waela1d0@example.com", true, "Hamaki", "Waela1d0", false, null, "HAMAKI.WAELA1D0@EXAMPLE.COM", "HAMAKI.WAELA1D0@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMQ1wct0KKGtkLuOlEFUUN97yGa4ztuLP2W01yetmLbJliPhcOjvtfQlavvmw9lnLg==", "01216731361", false, "650c64b0-d0b2-41aa-809e-3d181c4c0863", false, "Hamaki.Waela1d0@example.com" },
                    { "4098b15d-ed6b-11ed-8903-105badc84798", 0, "7242fe65-9ef9-4e6a-aacd-7f97572d4e8a", "Samhi.Ahmed8548@example.com", true, "Samhi", "Ahmed8548", false, null, "SAMHI.AHMED8548@EXAMPLE.COM", "SAMHI.AHMED8548@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJPRFuXsMv7UcdvZLGIoLIC4w1/fAFLPr2MfzP4LdaG3P/dgMTWsEfBGDvcGZoFtpg==", "01295806415", false, "ace1a4ee-ecf0-4c47-acc6-97885a2e48bf", false, "Samhi.Ahmed8548@example.com" },
                    { "4098b15f-ed6b-11ed-a7e2-105badc84798", 0, "06d3e951-c060-4b1d-9eae-da91e30eefc5", "Hishami.Dagherbd70@example.com", true, "Hishami", "Dagherbd70", false, null, "HISHAMI.DAGHERBD70@EXAMPLE.COM", "HISHAMI.DAGHERBD70@EXAMPLE.COM", "AQAAAAEAACcQAAAAELyRnE58l4SzI7bnBylJY2c5P+be0iYGuiccrvrOcNYzIrB8Yz7I77s/fBttWS8v+A==", "01216081772", false, "991b2a41-bb8e-4088-8006-c289a8fe0ebb", false, "Hishami.Dagherbd70@example.com" },
                    { "4098b161-ed6b-11ed-b0d0-105badc84798", 0, "528b4533-0594-4d9c-a13e-6cb586d3fcbf", "Minali.Haor85f2@example.com", true, "Minali", "Haor85f2", false, null, "MINALI.HAOR85F2@EXAMPLE.COM", "MINALI.HAOR85F2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAQObJeHfIHw94tpILxXRQedtZGgTy0hHWBGzB2S1DCgsGSmaND/VYvieKq0eySurg==", "01264213362", false, "cf569ef3-d7cd-46b9-8af6-0cdbe92260af", false, "Minali.Haor85f2@example.com" },
                    { "4098b163-ed6b-11ed-b901-105badc84798", 0, "395aa005-c4b6-457c-94dc-6e61f0070b8b", "Bilal.Asimac85@example.com", true, "Bilal", "Asimac85", false, null, "BILAL.ASIMAC85@EXAMPLE.COM", "BILAL.ASIMAC85@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFUHBAqhmqfKScpRtbRO1rlrc+bwA2n78KCSnZkC8Y5xY9dXXbDiPkLx7dEMkVqkBA==", "01236247368", false, "957c711c-b02a-4f69-8a43-71321cef0bff", false, "Bilal.Asimac85@example.com" },
                    { "4098b165-ed6b-11ed-a2fd-105badc84798", 0, "637ec0aa-f0b7-49c6-9833-afec2cd7412f", "Kamel.Waseemb3f8@example.com", true, "Kamel", "Waseemb3f8", false, null, "KAMEL.WASEEMB3F8@EXAMPLE.COM", "KAMEL.WASEEMB3F8@EXAMPLE.COM", "AQAAAAEAACcQAAAAENPNvtUR3Q7FoNc3aX8AcG8wpU1NtgIUmbpRa8o1S4MK89hhpqRDBYbyoJIh5eRFTA==", "01227742375", false, "115ac935-95d0-4f4b-b1f3-e9ad875e715a", false, "Kamel.Waseemb3f8@example.com" },
                    { "4098b167-ed6b-11ed-9dcf-105badc84798", 0, "51cb6cce-48e3-47c9-b05d-45baa574a1fe", "Yamen.Hilalia185@example.com", true, "Yamen", "Hilalia185", false, null, "YAMEN.HILALIA185@EXAMPLE.COM", "YAMEN.HILALIA185@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFJpdZsClAIVMqfkUJqigjXd48Q47z4asJcN2TAvm6ivCsrcf10tKHo8DG/tY+pmrQ==", "01226708337", false, "6153f7fe-226f-4279-821a-1013f2c16a45", false, "Yamen.Hilalia185@example.com" },
                    { "4098b169-ed6b-11ed-9b69-105badc84798", 0, "187703c3-ef77-465a-8f60-a8303f0ab330", "Sheila.Badri806c@example.com", true, "Sheila", "Badri806c", false, null, "SHEILA.BADRI806C@EXAMPLE.COM", "SHEILA.BADRI806C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJ5VdH2uJTadyXqppIFUj3soUK4psij/X07A4cRoDzIibbj0iDjNR8GqmayK+DiYRQ==", "01250629461", false, "8b7c2969-eff4-46c8-94ca-8eb0d8e9aa7f", false, "Sheila.Badri806c@example.com" },
                    { "4098b16b-ed6b-11ed-bc54-105badc84798", 0, "9ec36385-391c-4ad2-9d2a-5a132a7cfc55", "Bahi.Sharma930@example.com", true, "Bahi", "Sharma930", false, null, "BAHI.SHARMA930@EXAMPLE.COM", "BAHI.SHARMA930@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBy4g7+9ermVKPeuNlizCG4iNLLB5wfwK72gQGBBTRFGMaJxZj/BzJRCpEm2I7dOUA==", "01264225474", false, "2cc9d2d4-5aa0-407c-94c8-a8a99e1b4b0a", false, "Bahi.Sharma930@example.com" },
                    { "4098b16d-ed6b-11ed-abd9-105badc84798", 0, "150b4b2e-a3b8-491b-94a3-8510b8d89db2", "Hilal.Hilal9e6a@example.com", true, "Hilal", "Hilal9e6a", false, null, "HILAL.HILAL9E6A@EXAMPLE.COM", "HILAL.HILAL9E6A@EXAMPLE.COM", "AQAAAAEAACcQAAAAED/hg4v5JL58ifsJg1sQ3yYm1+2XA/qztqgUuhc2AIZG+dsSwjHhzSLp19V+syDDQQ==", "01280080449", false, "25df9564-9efe-4b4f-a47c-a0bd41ff9a49", false, "Hilal.Hilal9e6a@example.com" },
                    { "4098b16f-ed6b-11ed-ae81-105badc84798", 0, "ba32d8a3-10e6-4676-bb59-9b2e7b318b39", "Yisri.Saden9224@example.com", true, "Yisri", "Saden9224", false, null, "YISRI.SADEN9224@EXAMPLE.COM", "YISRI.SADEN9224@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPJ6rAoxXB+vNKNrbSISj906meyLgR1c58UK9cTm+zPb6Dx1n+9K7ElxkzxcTYC74g==", "01266306998", false, "aae3d7a0-2569-498a-9a07-17a3888ddd7e", false, "Yisri.Saden9224@example.com" },
                    { "4098b171-ed6b-11ed-bd08-105badc84798", 0, "6053f983-6c98-44f7-82e8-3d391fb58602", "Helsey.Samiraa00@example.com", true, "Helsey", "Samiraa00", false, null, "HELSEY.SAMIRAA00@EXAMPLE.COM", "HELSEY.SAMIRAA00@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBsIIkXpPntnXv1pgz9ZtsYdp66HfudYFFFFdhEZumErea4ouF9mplghsvAiEbOQpg==", "01217458085", false, "cc88e2b8-fac1-4261-b410-90fc4fc093cf", false, "Helsey.Samiraa00@example.com" },
                    { "4098b173-ed6b-11ed-9e0c-105badc84798", 0, "390095c8-1ee9-4a5f-a031-8e4d8aad6871", "Wael.Waseembb41@example.com", true, "Wael", "Waseembb41", false, null, "WAEL.WASEEMBB41@EXAMPLE.COM", "WAEL.WASEEMBB41@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBgfbtgiVPJCojNecWy4rOY2QtwakoaE6bTBYn8rFUDxk9Gq1Fn4NuT59qhxV0R20w==", "01284333280", false, "770b9b6e-06f7-4f44-811c-baff1575534a", false, "Wael.Waseembb41@example.com" },
                    { "4098b175-ed6b-11ed-a3d4-105badc84798", 0, "1a3cb535-871c-41df-ba2d-db41c53a7047", "Najm.Bahirbab8@example.com", true, "Najm", "Bahirbab8", false, null, "NAJM.BAHIRBAB8@EXAMPLE.COM", "NAJM.BAHIRBAB8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEYQNujNkjkv/UYPAsi2HbnebN6Z6oL4t2vZBEDVDA54lWcza98KFxS10jGyA6rJLQ==", "01287732484", false, "45fe1592-cd0b-4162-8143-b04fe404c28d", false, "Najm.Bahirbab8@example.com" },
                    { "4098b177-ed6b-11ed-b8db-105badc84798", 0, "a6dcf224-aafd-4475-b1ff-9afecf80752b", "Dahi.Adelbabc@example.com", true, "Dahi", "Adelbabc", false, null, "DAHI.ADELBABC@EXAMPLE.COM", "DAHI.ADELBABC@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPjNIq9EqD0uLt6JPUwyGLk9ymqQE2sQvj+GH0BGxc+8rnet+XwsOL+nN/4Lg6+LEw==", "01214965124", false, "5cf98994-32a1-42a1-adb1-18ff74c83e19", false, "Dahi.Adelbabc@example.com" },
                    { "4098b179-ed6b-11ed-acd6-105badc84798", 0, "34fbbbeb-4bdc-4bec-a6bb-41bc62322757", "Sajid.Majdibec5@example.com", true, "Sajid", "Majdibec5", false, null, "SAJID.MAJDIBEC5@EXAMPLE.COM", "SAJID.MAJDIBEC5@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGZOj+pT0zTZQW70qb4Hyj+iiVw3rVkWEajgGifpYtviafnj3JaWW3lKq7zaJfEj2Q==", "01226566171", false, "363d0d95-3e79-4bda-9294-d03cee11a31f", false, "Sajid.Majdibec5@example.com" },
                    { "4098b17b-ed6b-11ed-bfb2-105badc84798", 0, "0e425d35-c22a-48c9-9e6c-93f5210cda6c", "Salim.Waseem9d1b@example.com", true, "Salim", "Waseem9d1b", false, null, "SALIM.WASEEM9D1B@EXAMPLE.COM", "SALIM.WASEEM9D1B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEA809pc48dHGQWIDDpbMg+XSOmSMG2Z1UVZPfnjF4r1DH7shXhcl9tcR6SDHIKOCxg==", "01223503517", false, "a442e723-6690-45b6-94dd-30b3686e1473", false, "Salim.Waseem9d1b@example.com" },
                    { "4098b17d-ed6b-11ed-a36b-105badc84798", 0, "712b9b49-e4f0-4a71-a9bd-ea9bb216f22c", "Baqi.Zaki9e26@example.com", true, "Baqi", "Zaki9e26", false, null, "BAQI.ZAKI9E26@EXAMPLE.COM", "BAQI.ZAKI9E26@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIAqqQGVWWg1ICbIlbCSY2eGMDf++9PJuXtiKrGCIeOM7b2sexXl3TDPj33WfYHW3A==", "01295728341", false, "78ba2c73-6263-4b88-b97f-7c6613d208d2", false, "Baqi.Zaki9e26@example.com" },
                    { "4098b17f-ed6b-11ed-9639-105badc84798", 0, "62a526e9-672a-4600-8033-c8b6097d7d36", "Sahami.Sheikhy80fb@example.com", true, "Sahami", "Sheikhy80fb", false, null, "SAHAMI.SHEIKHY80FB@EXAMPLE.COM", "SAHAMI.SHEIKHY80FB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEFizlySGa0XEqe7MYDMDHUZgYkfK0uZq5VwMPyV71Dvh2ktdEpReMUV4aAXLHIRQA==", "01269675036", false, "868f32a4-89d0-4f25-a293-e31fe4e5db6f", false, "Sahami.Sheikhy80fb@example.com" },
                    { "4098b181-ed6b-11ed-84ef-105badc84798", 0, "d6c59fa0-9d70-4983-9440-ed2beb8e7828", "Badri.Sareea3a3@example.com", true, "Badri", "Sareea3a3", false, null, "BADRI.SAREEA3A3@EXAMPLE.COM", "BADRI.SAREEA3A3@EXAMPLE.COM", "AQAAAAEAACcQAAAAELKo3ORoZPY7NWyu/LxlnlX6qQy1MLW28mlP7zmAWrBXzpyWT6zJdFfngOpZCVF08A==", "01260728699", false, "8c0f6434-e037-47ec-a6ae-f68c9db67540", false, "Badri.Sareea3a3@example.com" },
                    { "4098b183-ed6b-11ed-91ba-105badc84798", 0, "4d8c64a8-2b67-4fc3-abc1-779756e0ded7", "Faisal.Ryan93db@example.com", true, "Faisal", "Ryan93db", false, null, "FAISAL.RYAN93DB@EXAMPLE.COM", "FAISAL.RYAN93DB@EXAMPLE.COM", "AQAAAAEAACcQAAAAELLAjef9UXOkEIodwVPqNUWqyunOOM4hLRDxhqGD2+L2Xr9D3u7/PMmxn8wI9uxGmw==", "01215094196", false, "a93aa5f3-3593-41d6-86fa-7741c06bb3ff", false, "Faisal.Ryan93db@example.com" },
                    { "4098b185-ed6b-11ed-a00a-105badc84798", 0, "781f52d5-e57f-4642-bf2f-210026c0d4a2", "Omar.Sahami9f51@example.com", true, "Omar", "Sahami9f51", false, null, "OMAR.SAHAMI9F51@EXAMPLE.COM", "OMAR.SAHAMI9F51@EXAMPLE.COM", "AQAAAAEAACcQAAAAEC/iQlmSbzvq7LX83fLWrOQXk6QFJNx6g1eVIOADmTT+EnwJSbNN95Ra/w/BepHH3A==", "01271704961", false, "badb4e7e-e423-4d58-ab75-31abec01fa21", false, "Omar.Sahami9f51@example.com" },
                    { "4098b187-ed6b-11ed-911e-105badc84798", 0, "57abf365-6500-4025-82c0-f33b5d895594", "Loay.Basem8ee7@example.com", true, "Loay", "Basem8ee7", false, null, "LOAY.BASEM8EE7@EXAMPLE.COM", "LOAY.BASEM8EE7@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDtsafox8GN1kgCad9VW8srMunyvU4Poat5KiOm4cWn/a5icIBUMBXZC/XCrQT9+VA==", "01253444230", false, "b9c4e529-217e-4a75-b8fe-7aab4717c5ab", false, "Loay.Basem8ee7@example.com" },
                    { "4098b189-ed6b-11ed-97ff-105badc84798", 0, "82e60ddb-61d3-41ed-b687-87fe894c329f", "Halsi.Ryana491@example.com", true, "Halsi", "Ryana491", false, null, "HALSI.RYANA491@EXAMPLE.COM", "HALSI.RYANA491@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJnmbp7API3xR/UTmRZoW22Bb1A/78k6CCC7quis6cdvkNS/1CMXIHDQNIZ7ByJN9w==", "01243084731", false, "928907fa-42b8-48b3-a4e7-739a802a216a", false, "Halsi.Ryana491@example.com" },
                    { "4098b18b-ed6b-11ed-9c96-105badc84798", 0, "b5e537e1-f2f3-4c1f-ac34-35044018cb0d", "Noah.Waela26a@example.com", true, "Noah", "Waela26a", false, null, "NOAH.WAELA26A@EXAMPLE.COM", "NOAH.WAELA26A@EXAMPLE.COM", "AQAAAAEAACcQAAAAEP9OPO1U64gR6SleJp/Kzov9I1twIcA5904rvTOO5Lj5rK7cCzp1l0vFrVw+TsokFg==", "01265189792", false, "393ace8a-c33d-4350-bdb4-fdd027798996", false, "Noah.Waela26a@example.com" },
                    { "4098b18d-ed6b-11ed-86a0-105badc84798", 0, "abf12944-beae-49b0-ba70-3bcc3d4ffa33", "Malek.Minalia6b0@example.com", true, "Malek", "Minalia6b0", false, null, "MALEK.MINALIA6B0@EXAMPLE.COM", "MALEK.MINALIA6B0@EXAMPLE.COM", "AQAAAAEAACcQAAAAEP51isSYjrIgrxanTbj1kpPsBkEhbYKs18XeHKMi4tjHmvzD26dkBplleiyIqnJb0g==", "01272439716", false, "59fd5310-0458-48a5-92fc-5ca9fa3446f2", false, "Malek.Minalia6b0@example.com" },
                    { "4098b18f-ed6b-11ed-9b38-105badc84798", 0, "125fd1fd-1bb3-4937-8977-a40878f9a9e7", "Kahter.Sharmaf90@example.com", true, "Kahter", "Sharmaf90", false, null, "KAHTER.SHARMAF90@EXAMPLE.COM", "KAHTER.SHARMAF90@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPqJ71OcepDbGEY0yjq7FbaRJOYnvvCNk/JPykI/isgxdwjOAkfe9Wj5VNN0RoHwrA==", "01297951939", false, "f4bcc8a5-cfa1-44fc-a11c-506a30b63e35", false, "Kahter.Sharmaf90@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4098b191-ed6b-11ed-87ba-105badc84798", 0, "9f7df6b5-fc29-4b0b-aacb-79cfb3e1291c", "Sajid.Zachariah82c1@example.com", true, "Sajid", "Zachariah82c1", false, null, "SAJID.ZACHARIAH82C1@EXAMPLE.COM", "SAJID.ZACHARIAH82C1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMIoN7m1QqVTecpjnGfiDnw0NMBVCF9pkKhE899SjFPIS/RvcTCq6KL89wrs2BxaSw==", "01218467982", false, "c8b38e38-2b7f-44ad-ad5c-6e9d65388cea", false, "Sajid.Zachariah82c1@example.com" },
                    { "4098b193-ed6b-11ed-b6af-105badc84798", 0, "74f0a7ef-2ba9-4f8b-895f-a813057d3e62", "Dahi.Danielad4c@example.com", true, "Dahi", "Danielad4c", false, null, "DAHI.DANIELAD4C@EXAMPLE.COM", "DAHI.DANIELAD4C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKKwXhfXImdAHlQ6mB7DBHgXb7CCSL7rPOaboK52Pe8vEBRXldQVRIT0vNogX85PIg==", "01214991654", false, "75f43203-1181-4c7a-8830-3111f2eb0510", false, "Dahi.Danielad4c@example.com" },
                    { "4098b195-ed6b-11ed-a317-105badc84798", 0, "d34599ee-1913-4781-8ac2-33c286849aa9", "Ahmed.Samehbda8@example.com", true, "Ahmed", "Samehbda8", false, null, "AHMED.SAMEHBDA8@EXAMPLE.COM", "AHMED.SAMEHBDA8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEO3mlzPJUIcEYvMkLW0/Fyd3SydiIBxXHA+4KnoPwvWG4qRrzpE/6Vg/9QovtTVJ+Q==", "01214023531", false, "18db3444-4964-433d-bd7a-424188a0c358", false, "Ahmed.Samehbda8@example.com" },
                    { "4098b197-ed6b-11ed-a380-105badc84798", 0, "86c51a0f-f2d5-4c8f-8402-557bbbec9c90", "Hamaki.Salimb1fa@example.com", true, "Hamaki", "Salimb1fa", false, null, "HAMAKI.SALIMB1FA@EXAMPLE.COM", "HAMAKI.SALIMB1FA@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHAudbJORr6YwnsguGJ2B4rsL5Wv37+4gArVWF+imeUI4CrBPVJDkmNUSDtCHdEayg==", "01237177143", false, "bc46c29b-a24e-4e5b-b48b-5478605e871b", false, "Hamaki.Salimb1fa@example.com" },
                    { "4098b199-ed6b-11ed-bf11-105badc84798", 0, "3d845029-27b4-4ee7-8bb4-8975324f1bc2", "Latfi.Latfi8c51@example.com", true, "Latfi", "Latfi8c51", false, null, "LATFI.LATFI8C51@EXAMPLE.COM", "LATFI.LATFI8C51@EXAMPLE.COM", "AQAAAAEAACcQAAAAECJmgr9Z5DiiSp67F9d1F6e/YUvtmGeC7o9I9XdwlNY/SP8/vSLy2xTckJ3m6t1AnQ==", "01287157511", false, "2bbc3e45-92a9-4b03-8589-70c06afe043f", false, "Latfi.Latfi8c51@example.com" },
                    { "4098b19b-ed6b-11ed-9acc-105badc84798", 0, "be10c0fb-047c-4532-a9d6-2c77ab376a86", "Fadi.Medhatbc78@example.com", true, "Fadi", "Medhatbc78", false, null, "FADI.MEDHATBC78@EXAMPLE.COM", "FADI.MEDHATBC78@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMi5K7dsocR/qbc7WknEkhzszbimwnii0wTL6Q0sta74xVbOeXnXwDZgtGnNubKHSQ==", "01231139763", false, "6c27379a-9f8d-4c70-bf01-1e7deee9451a", false, "Fadi.Medhatbc78@example.com" },
                    { "4098b19d-ed6b-11ed-9edb-105badc84798", 0, "efaa6988-ba6c-4aad-bd31-2c5344350b51", "Fahed.Minali85eb@example.com", true, "Fahed", "Minali85eb", false, null, "FAHED.MINALI85EB@EXAMPLE.COM", "FAHED.MINALI85EB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMyz0lp70FRI6+mWQHmodtAjvH23jR7c+gIN4aU5FvYm+4OQJx/8YkcsqNIAIVHKOg==", "01256275160", false, "46691d1b-233e-47ee-ba5e-ba756889cacc", false, "Fahed.Minali85eb@example.com" },
                    { "4098b19f-ed6b-11ed-8419-105badc84798", 0, "8d396937-1750-4ee3-91f4-90b7a57e984e", "Wael.Zachariahb0c2@example.com", true, "Wael", "Zachariahb0c2", false, null, "WAEL.ZACHARIAHB0C2@EXAMPLE.COM", "WAEL.ZACHARIAHB0C2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHmD7NGOpWUuIX8SsmZxkOBoQja+VG1hQv5WaUdZDzdhQqb5FKGFynxr5OWGlmW64Q==", "01218944525", false, "87bae911-5165-45b8-9fbc-f4dabdace7ad", false, "Wael.Zachariahb0c2@example.com" },
                    { "4098b1a1-ed6b-11ed-abac-105badc84798", 0, "9ef3567a-cad3-4946-8b3b-fabb5f02a8ea", "Zarif.Bahi9d47@example.com", true, "Zarif", "Bahi9d47", false, null, "ZARIF.BAHI9D47@EXAMPLE.COM", "ZARIF.BAHI9D47@EXAMPLE.COM", "AQAAAAEAACcQAAAAEB0BlhfHuvFsHlDkB+VFgFl/utuD3WsayKdLyfiQHZQaPO92OpfX8gw3K71fLQnwhA==", "01283196507", false, "6dd61e31-36f3-4247-ab44-668b302c0af0", false, "Zarif.Bahi9d47@example.com" },
                    { "4098b1a3-ed6b-11ed-a583-105badc84798", 0, "078d3a1c-589b-48ad-ad80-0b562ebce197", "Bara.Bahia873@example.com", true, "Bara", "Bahia873", false, null, "BARA.BAHIA873@EXAMPLE.COM", "BARA.BAHIA873@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFxMgVGyK3UIiIfRvWWkfcQTrNXTrcNon/hYqBEMJrwg+ZUP6xrk7t1Ubez7PQn7og==", "01234054165", false, "b9990f1d-54f5-4bae-b2a6-42d75cf46469", false, "Bara.Bahia873@example.com" },
                    { "4098b1a5-ed6b-11ed-bf0d-105badc84798", 0, "73d4678f-a63b-4be0-b89c-d27d1ea6d62c", "Hamaqy.Noorad52@example.com", true, "Hamaqy", "Noorad52", false, null, "HAMAQY.NOORAD52@EXAMPLE.COM", "HAMAQY.NOORAD52@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFeYDvljAdg0028Q6uZ/+BPU1fbPmeFrAkhBMN51ftOwa7MKP5IbAMt0TKF48mqgCw==", "01249013827", false, "1b925a8b-8f75-40cc-98f9-f77f96c719ab", false, "Hamaqy.Noorad52@example.com" },
                    { "4098b1a7-ed6b-11ed-bd68-105badc84798", 0, "a01b8ced-74a4-4203-a065-c48f8f5c41f0", "Fares.Bahirb03c@example.com", true, "Fares", "Bahirb03c", false, null, "FARES.BAHIRB03C@EXAMPLE.COM", "FARES.BAHIRB03C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEI+S4PEqIkfg0rLcuC/BuwBzUfVV2T0D4A6RXfqqA9c9qjh31j4kCip5RLzt9798BQ==", "01245035379", false, "0bfaab2d-25e4-4150-ae61-57160e91ad67", false, "Fares.Bahirb03c@example.com" },
                    { "4099e9d3-ed6b-11ed-b4e8-105badc84798", 0, "d3cd394f-a030-4b4a-9b40-3f5a006814e9", "Jalal.Majid82af@example.com", true, "Jalal", "Majid82af", false, null, "JALAL.MAJID82AF@EXAMPLE.COM", "JALAL.MAJID82AF@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMupOKnvOpzl1a322P3aQLJvj1WVAF7qjMpkanP/+GzLx2+mawBC9rBUzM0vo4aPTw==", "01292058402", false, "ee2ab6cc-ed2a-43ab-9a9f-2d7902828055", false, "Jalal.Majid82af@example.com" },
                    { "4099e9d5-ed6b-11ed-8061-105badc84798", 0, "d5f289af-729d-422a-957b-5a6ceede0bc6", "Saden.Waelb102@example.com", true, "Saden", "Waelb102", false, null, "SADEN.WAELB102@EXAMPLE.COM", "SADEN.WAELB102@EXAMPLE.COM", "AQAAAAEAACcQAAAAELIzE252tx9quNiB3sBghzcxrKwWDapL/2ZTK/o834L0jP3pflKVxD8/3SdDCzRYWA==", "01227228988", false, "fecb1823-fc6d-4d14-9f89-1a3d94d2f1ce", false, "Saden.Waelb102@example.com" },
                    { "4099e9d7-ed6b-11ed-976d-105badc84798", 0, "1015ea2a-84b9-4ee8-95df-b87e6a7e266b", "Dahi.Sajid849e@example.com", true, "Dahi", "Sajid849e", false, null, "DAHI.SAJID849E@EXAMPLE.COM", "DAHI.SAJID849E@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAzABdaMOpqSU/EATzQOQDDxUlR24Bd0+qiN4MUw7W7wrT4/iteqPuDTm5tW3jqyKg==", "01263561273", false, "f51d4cfb-1a45-4bd1-bbaf-4d0ece67a473", false, "Dahi.Sajid849e@example.com" },
                    { "4099e9d9-ed6b-11ed-bca8-105badc84798", 0, "86ffe1e3-8cc0-4a3d-b2c3-e39ff31a792e", "Adel.Hilalab94@example.com", true, "Adel", "Hilalab94", false, null, "ADEL.HILALAB94@EXAMPLE.COM", "ADEL.HILALAB94@EXAMPLE.COM", "AQAAAAEAACcQAAAAELcY++xAzc3kjgZW2QJimymxXmTqLraAXV4V6zoEgYFS5Cfag71W6cG0SK0m1dtrZg==", "01275990302", false, "1205e947-8c6f-4061-b59f-22adbc8a52ce", false, "Adel.Hilalab94@example.com" },
                    { "4099e9db-ed6b-11ed-9009-105badc84798", 0, "bd0bfe7c-b9d6-44a2-afcf-dcf1c3e7ee3e", "Samir.Bassam897e@example.com", true, "Samir", "Bassam897e", false, null, "SAMIR.BASSAM897E@EXAMPLE.COM", "SAMIR.BASSAM897E@EXAMPLE.COM", "AQAAAAEAACcQAAAAENy+Pw0YJiBGJqR2FQwzn+mT88DW4W4UOlHMGCOtNMeO7oywnsmxHvoG/3/0K/CpKw==", "01234422680", false, "be9fa657-2a4c-4d26-9625-13ee3331ec6b", false, "Samir.Bassam897e@example.com" },
                    { "4099e9dd-ed6b-11ed-8e81-105badc84798", 0, "dbed6b00-9571-416f-9d73-ea28af9e6da1", "Sajid.Sheikha8b1@example.com", true, "Sajid", "Sheikha8b1", false, null, "SAJID.SHEIKHA8B1@EXAMPLE.COM", "SAJID.SHEIKHA8B1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHas/x7VshxL+pseR+tCvs73u4oaeXuE9pMngXbWjvTvQgai1l6Iw1tvrL+8BadofA==", "01210144261", false, "d8028b05-b376-48b4-b8d3-3ff69c1076f5", false, "Sajid.Sheikha8b1@example.com" },
                    { "4099e9df-ed6b-11ed-bb40-105badc84798", 0, "a987b44f-dd1e-44b8-8850-c31cce8f8be8", "Russell.Ghanem9478@example.com", true, "Russell", "Ghanem9478", false, null, "RUSSELL.GHANEM9478@EXAMPLE.COM", "RUSSELL.GHANEM9478@EXAMPLE.COM", "AQAAAAEAACcQAAAAEF6P1kHwQrdjUP+Ysc2MyJr7PsopALoILiEWSBs67myCE98lYcgiZsCBTKKumL1ZHw==", "01290670217", false, "b73d709a-fdb8-427c-8c3a-e4b93e31245e", false, "Russell.Ghanem9478@example.com" },
                    { "4099e9e1-ed6b-11ed-b492-105badc84798", 0, "9e35f997-0a61-4d05-8679-3924802feeed", "Haor.Wael82ce@example.com", true, "Haor", "Wael82ce", false, null, "HAOR.WAEL82CE@EXAMPLE.COM", "HAOR.WAEL82CE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPR4blCA2tOCqbN8ki3gExvRI57eIXJG0q+inOzqRVDvpp87oiXajCPdTr8H+fiN1g==", "01255444010", false, "0e538313-d576-4ff8-935d-8019f9c4426b", false, "Haor.Wael82ce@example.com" },
                    { "4099e9e3-ed6b-11ed-92d1-105badc84798", 0, "31fb117d-6390-4699-975a-d9234f7ba6b3", "Dagher.Zachariahb6b1@example.com", true, "Dagher", "Zachariahb6b1", false, null, "DAGHER.ZACHARIAHB6B1@EXAMPLE.COM", "DAGHER.ZACHARIAHB6B1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKd9TNnnttPEyGaBU8BGmrBAigo301XpPo9kwUJhAwJ/e8ai2+TMA1P0kHdCH8mXOA==", "01224788521", false, "57d0a4a7-a494-46ef-9f71-14346dcdfe72", false, "Dagher.Zachariahb6b1@example.com" },
                    { "4099e9e5-ed6b-11ed-b38a-105badc84798", 0, "305975c1-749d-4511-ae9a-cb77a5f90e69", "Hishami.Halsib62b@example.com", true, "Hishami", "Halsib62b", false, null, "HISHAMI.HALSIB62B@EXAMPLE.COM", "HISHAMI.HALSIB62B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEInB3DChs3sbpzGDkmlDbXNtCZYtFDxeT4VxuKs7M+/dAhYLa3BTB/nDKfLSkB/i1Q==", "01237896983", false, "a840e345-d99b-4174-af88-1f1948671cee", false, "Hishami.Halsib62b@example.com" },
                    { "4099e9e7-ed6b-11ed-9432-105badc84798", 0, "c31af3ab-a78d-4956-94bd-88e1b456bdd7", "Marawan.Shahib1ef@example.com", true, "Marawan", "Shahib1ef", false, null, "MARAWAN.SHAHIB1EF@EXAMPLE.COM", "MARAWAN.SHAHIB1EF@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMsPDnAG/gpmXLP+rL/CvI7bDbHxt3vTWbZ2i4bmHq0wDd2qvSN1sjpj6i+wEGjzNQ==", "01271273824", false, "28069394-1dc2-4118-9ff7-e6a736e25574", false, "Marawan.Shahib1ef@example.com" },
                    { "4099e9e9-ed6b-11ed-af1e-105badc84798", 0, "fc2d474b-d195-43d4-948e-ee076beb8335", "Fidaa.Baqia533@example.com", true, "Fidaa", "Baqia533", false, null, "FIDAA.BAQIA533@EXAMPLE.COM", "FIDAA.BAQIA533@EXAMPLE.COM", "AQAAAAEAACcQAAAAENBrrf12whVKLM+AGm711MHhro5n7rdLtUyyqAmK0tFyykq4AXZvLgCFiJZbgK20gQ==", "01218117934", false, "2c3ccf69-0aed-417f-88be-89b1899fe573", false, "Fidaa.Baqia533@example.com" },
                    { "4099e9eb-ed6b-11ed-8d45-105badc84798", 0, "5c826caf-4a48-4591-a2a0-eae61d738985", "Radwan.Kamel90c3@example.com", true, "Radwan", "Kamel90c3", false, null, "RADWAN.KAMEL90C3@EXAMPLE.COM", "RADWAN.KAMEL90C3@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOdQelLwPPSty99+yuTTn9nUPvPgAqphfHy4nSzHHrzQN0DEEXGCDPiK94hUDNYFhA==", "01262457869", false, "5478833e-7562-41bd-b2e5-7e3976fe2fbf", false, "Radwan.Kamel90c3@example.com" },
                    { "4099e9ed-ed6b-11ed-8755-105badc84798", 0, "c045a48f-ae61-4684-97bc-f7fb08c3ed09", "Loay.Bahi9d3c@example.com", true, "Loay", "Bahi9d3c", false, null, "LOAY.BAHI9D3C@EXAMPLE.COM", "LOAY.BAHI9D3C@EXAMPLE.COM", "AQAAAAEAACcQAAAAENoIV/7GgFt4fwnhukifDztHPTM/1lN6gesVFS4QS7IXF+IRwm9Rq4dbA16gCa4ACA==", "01298984959", false, "03b50d44-16ee-478f-a889-e61ec33cb166", false, "Loay.Bahi9d3c@example.com" },
                    { "4099e9ef-ed6b-11ed-a4a1-105badc84798", 0, "8c431435-3708-4216-9b91-9ba030f5f2b9", "Ryan.Moses82e6@example.com", true, "Ryan", "Moses82e6", false, null, "RYAN.MOSES82E6@EXAMPLE.COM", "RYAN.MOSES82E6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBp14haPLLe9MbZD1LNKV5iGATDAGwo4Fq+jHRZMc+1/wsnI29bj/Z3Jzg2pAx+zdQ==", "01287007236", false, "ee8c90e5-95d8-4c8a-815c-bb6da5578324", false, "Ryan.Moses82e6@example.com" },
                    { "4099e9f1-ed6b-11ed-b017-105badc84798", 0, "e74a8eea-6011-4912-ae49-2eaf06894590", "Fahed.Hishamia1b1@example.com", true, "Fahed", "Hishamia1b1", false, null, "FAHED.HISHAMIA1B1@EXAMPLE.COM", "FAHED.HISHAMIA1B1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEITJjz6d3Y6s8+YHrweaK4+UA7XMRoVigDuVamk5q/qt1BiZvIo/jw7LKEooHUcPLA==", "01295741865", false, "eb8c36d3-43d5-4281-8e1f-afdbf0950886", false, "Fahed.Hishamia1b1@example.com" },
                    { "4099e9f3-ed6b-11ed-92c8-105badc84798", 0, "22d72221-594c-457a-bf28-251daef2f499", "Horr.Basselb860@example.com", true, "Horr", "Basselb860", false, null, "HORR.BASSELB860@EXAMPLE.COM", "HORR.BASSELB860@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAkis9tuK1tUWv1FK5TWeebz6J+XtFfmK82aWNs+leueGhQ0iMREcti/G2H+ZgJFJg==", "01231479095", false, "39883c1c-04a7-4c47-a683-9d1a930b1b53", false, "Horr.Basselb860@example.com" },
                    { "4099e9f5-ed6b-11ed-9bbb-105badc84798", 0, "3e2a06ef-6675-4ca6-b202-df65275f9343", "Asim.Bahia196@example.com", true, "Asim", "Bahia196", false, null, "ASIM.BAHIA196@EXAMPLE.COM", "ASIM.BAHIA196@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJmnOzWWkPtAJF8/a4G8Ng3U2qJfwwrk5/ADL+9VetvSOE/BNewQ9RPulvXBs4x/nQ==", "01293315685", false, "15fbb16c-bd54-45f4-81af-04a8794dd413", false, "Asim.Bahia196@example.com" },
                    { "4099e9f7-ed6b-11ed-aa9d-105badc84798", 0, "5622e222-b432-4c86-8f09-558621b54ac4", "Bara.Shahib692@example.com", true, "Bara", "Shahib692", false, null, "BARA.SHAHIB692@EXAMPLE.COM", "BARA.SHAHIB692@EXAMPLE.COM", "AQAAAAEAACcQAAAAECm2/0398D8/FXCeWEje7MRREUW8uUhR6cLPdd16eCWKMFwbZHsWTMgen3qg5Npu1g==", "01240292772", false, "f9b7a42c-7f50-4303-a1a9-76431749ac41", false, "Bara.Shahib692@example.com" },
                    { "4099e9f9-ed6b-11ed-8af4-105badc84798", 0, "82cc1517-4481-4412-b238-cdd6a062f651", "Fadi.Adhama536@example.com", true, "Fadi", "Adhama536", false, null, "FADI.ADHAMA536@EXAMPLE.COM", "FADI.ADHAMA536@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDws2EXurbxHOVDUjoIbxov0BKTCyhUnqlX60INdSRefEnqgNtYQX3oW7U/jOBLEtQ==", "01239956926", false, "af058553-f10a-4367-9711-50c935479a28", false, "Fadi.Adhama536@example.com" },
                    { "4099e9fb-ed6b-11ed-88c6-105badc84798", 0, "4f30cf95-684f-4fbd-8840-47915ef2648b", "Medhat.Hammadbdb5@example.com", true, "Medhat", "Hammadbdb5", false, null, "MEDHAT.HAMMADBDB5@EXAMPLE.COM", "MEDHAT.HAMMADBDB5@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDWFgtH5qkxbUoMEgFV34RGPe0CTixqH7KwyFbi18IW0+38LY97R9OISb8dI6CGwyQ==", "01224361401", false, "d5480a6a-0e43-4466-ba5c-69994a6ae41f", false, "Medhat.Hammadbdb5@example.com" },
                    { "4099e9fd-ed6b-11ed-a891-105badc84798", 0, "cc824b41-0f02-4e5f-84c2-293ea17dfb43", "Najm.Shehabia8de@example.com", true, "Najm", "Shehabia8de", false, null, "NAJM.SHEHABIA8DE@EXAMPLE.COM", "NAJM.SHEHABIA8DE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBZIVMoMUlrjCP5rXMeONXfP9Rxb/p5SrrD/qnffzE3P7o/btSmi6sJP8QcIfH2BGw==", "01264500973", false, "8ef17266-f2fd-4ce6-8bef-88eabf411457", false, "Najm.Shehabia8de@example.com" },
                    { "4099e9ff-ed6b-11ed-a802-105badc84798", 0, "c793419f-535d-4565-af59-46dc0cca7dca", "Hussein.Jalal89d8@example.com", true, "Hussein", "Jalal89d8", false, null, "HUSSEIN.JALAL89D8@EXAMPLE.COM", "HUSSEIN.JALAL89D8@EXAMPLE.COM", "AQAAAAEAACcQAAAAENQp7iZN6nT5DU0IJKAxzNiMIG7Gl+PxCgI3NU2A/PIO3guKsd42F5fidxaHQsIIRw==", "01243463663", false, "ae03cd8b-3a62-4072-a0b8-9a0ee7bb7a1b", false, "Hussein.Jalal89d8@example.com" },
                    { "4099ea01-ed6b-11ed-a7d5-105badc84798", 0, "159094e9-ab89-4ab3-a80b-b4ccb3a72438", "Saden.Fares8d49@example.com", true, "Saden", "Fares8d49", false, null, "SADEN.FARES8D49@EXAMPLE.COM", "SADEN.FARES8D49@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGnTD9VXVcYQzKg24Y+TFv29dHZJs73lMTtzuLQN488l5JmnPEZG8Ln88M6Esscq+w==", "01231665315", false, "190cfa4a-69c7-4b92-9ec6-c366e2b05191", false, "Saden.Fares8d49@example.com" },
                    { "4099ea03-ed6b-11ed-9ac8-105badc84798", 0, "f3602573-e4b5-4a6e-8cc4-d1a623cfbeff", "Bahir.Najma6fb@example.com", true, "Bahir", "Najma6fb", false, null, "BAHIR.NAJMA6FB@EXAMPLE.COM", "BAHIR.NAJMA6FB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEChocKRxWWSTHlfj8uoDd9JG3DvnCF5M7vdGf+6PsQsM/HK3VVRSfgaaJxUQBAiZ+g==", "01257564173", false, "9c890417-36c7-418b-b317-a1be5941e9ca", false, "Bahir.Najma6fb@example.com" },
                    { "4099ea05-ed6b-11ed-b96b-105badc84798", 0, "120c252b-cefc-4735-b144-b3572ad561b0", "Bahi.Fidaa88f9@example.com", true, "Bahi", "Fidaa88f9", false, null, "BAHI.FIDAA88F9@EXAMPLE.COM", "BAHI.FIDAA88F9@EXAMPLE.COM", "AQAAAAEAACcQAAAAEC2DT+LmEKckebRp5wtBBf7fJvLK/CFPLam5CfFdtjpFs1EoSdAbSOYIUquoOcacaw==", "01244926851", false, "bdb4ca08-4c94-44ba-818f-4a07b8de5a83", false, "Bahi.Fidaa88f9@example.com" },
                    { "4099ea07-ed6b-11ed-9c9b-105badc84798", 0, "91d0c09e-d023-4391-ad62-f88eead7110e", "Dahi.Waseembc12@example.com", true, "Dahi", "Waseembc12", false, null, "DAHI.WASEEMBC12@EXAMPLE.COM", "DAHI.WASEEMBC12@EXAMPLE.COM", "AQAAAAEAACcQAAAAEE2DRhqcRg0TRf34gc1MSoLtfVeQ/QnlVJ49RwyFrucsH+M1yglaX3fWSYLzum4ckw==", "01237376445", false, "85bc3102-eb35-4b29-9ed3-5f0ec8e78bd4", false, "Dahi.Waseembc12@example.com" },
                    { "4099ea09-ed6b-11ed-9690-105badc84798", 0, "99c5c452-f314-4ef3-a8f1-27e260807609", "Osama.Hilal82e1@example.com", true, "Osama", "Hilal82e1", false, null, "OSAMA.HILAL82E1@EXAMPLE.COM", "OSAMA.HILAL82E1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHtjUUPJPYffn5hYaR01gGOWM6R1l0W4Utv+QCN5f0zYrjZ3G/mYDfXOz0Ttg0KTbg==", "01248547700", false, "c5b9a177-0b97-4a3d-a52a-5a18a1b1c95f", false, "Osama.Hilal82e1@example.com" },
                    { "4099ea0b-ed6b-11ed-b0ef-105badc84798", 0, "7b123017-c8ac-4ab2-8e7b-0c589eb9e14d", "Moses.Hilaliaa93@example.com", true, "Moses", "Hilaliaa93", false, null, "MOSES.HILALIAA93@EXAMPLE.COM", "MOSES.HILALIAA93@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIMUqk3zQJyJLawaZ1I8Nk3u9revvENlEwVJh3uMM1w0mda8UPTt0/ee046VSLR6bg==", "01298932026", false, "64749433-ec16-4d12-91f8-a7843f1be2bf", false, "Moses.Hilaliaa93@example.com" },
                    { "4099ea0d-ed6b-11ed-aa2b-105badc84798", 0, "8f03f2f7-57b5-41f9-9e34-37acd409ea80", "Omar.Kahterb214@example.com", true, "Omar", "Kahterb214", false, null, "OMAR.KAHTERB214@EXAMPLE.COM", "OMAR.KAHTERB214@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJYGhPkxNFsztodMPJNU8+C2diRH4YlTnKploG9FzTlFVFfddgGk4GSLGHromNz9jg==", "01280480167", false, "5523a5aa-2e70-4bc8-99ef-f8ab233546e8", false, "Omar.Kahterb214@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4099ea0f-ed6b-11ed-9d4e-105badc84798", 0, "aa11d7c6-c81c-471a-b8aa-a7ad1c0f790e", "Dahi.Basselaed6@example.com", true, "Dahi", "Basselaed6", false, null, "DAHI.BASSELAED6@EXAMPLE.COM", "DAHI.BASSELAED6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGPwxPLaIRPGD9Go4d2JLOBKX/96F6lwvuxqSyaOfGV++3e+TzZtdFKiywk9DnleVw==", "01243086819", false, "7b666acd-2df3-40c8-90a4-e5a785bbd788", false, "Dahi.Basselaed6@example.com" },
                    { "4099ea11-ed6b-11ed-8a4f-105badc84798", 0, "18e483c6-d425-4b13-8a94-7bb97c471564", "Fidaa.Yusuf9983@example.com", true, "Fidaa", "Yusuf9983", false, null, "FIDAA.YUSUF9983@EXAMPLE.COM", "FIDAA.YUSUF9983@EXAMPLE.COM", "AQAAAAEAACcQAAAAECOj8QdJg3g1MDSQgMGLq8JOrcZsoxOkwaY71HvUhwcGXhgXgGZ36ln8AiokYgNM4Q==", "01230841385", false, "c5e0be86-3229-423e-b4e5-4b5941d009cf", false, "Fidaa.Yusuf9983@example.com" },
                    { "4099ea13-ed6b-11ed-839a-105badc84798", 0, "78e1f2a2-bc2b-4697-8baf-64afbca3da30", "Kamel.Danielb073@example.com", true, "Kamel", "Danielb073", false, null, "KAMEL.DANIELB073@EXAMPLE.COM", "KAMEL.DANIELB073@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKUdqSqZYKEZxMTZiIp3bNDnYDt1gTnjiI0yXU/QuxZX5hfAbXjYh1lKDk/p/bsQIw==", "01241136225", false, "8d1389a3-be06-4b53-ae57-e9efef8016a8", false, "Kamel.Danielb073@example.com" },
                    { "4099ea15-ed6b-11ed-8dbe-105badc84798", 0, "7d64a489-5a39-40c8-8733-998ed3292887", "Ghanem.Maleka044@example.com", true, "Ghanem", "Maleka044", false, null, "GHANEM.MALEKA044@EXAMPLE.COM", "GHANEM.MALEKA044@EXAMPLE.COM", "AQAAAAEAACcQAAAAEK5Iu13Du+wnb+utgMEtJsil2Bebh/pLljCJuNQOcnc+HkKu54SRcD4rghBSgkU0XA==", "01251094640", false, "92c4398d-336d-476d-b46e-dde8f5213b0e", false, "Ghanem.Maleka044@example.com" },
                    { "4099ea17-ed6b-11ed-bb52-105badc84798", 0, "cc1120ce-4193-464e-8f27-d9825f7b6ae6", "Jawad.Mahmoudb443@example.com", true, "Jawad", "Mahmoudb443", false, null, "JAWAD.MAHMOUDB443@EXAMPLE.COM", "JAWAD.MAHMOUDB443@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAAgSOooPNr8mpoeznj2rHMPRnNjINbi+SmRMViNCm3Qb3ZCesJGGoVInryARA7S0w==", "01278247237", false, "5b447300-96fe-4d8b-adad-e6a7a62b4264", false, "Jawad.Mahmoudb443@example.com" },
                    { "4099ea19-ed6b-11ed-85c8-105badc84798", 0, "57256e52-56e6-4aff-a29a-cb24dd1299bd", "Kamel.Danielaa21@example.com", true, "Kamel", "Danielaa21", false, null, "KAMEL.DANIELAA21@EXAMPLE.COM", "KAMEL.DANIELAA21@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDj4erXdloJWvBPGMM5FhdDMB5RTZdBF4lwvw6yt4bgitAvegbBWYoHgbwHgFS+kDg==", "01234246942", false, "a005da04-d9fa-465d-83d0-d1700e971e8e", false, "Kamel.Danielaa21@example.com" },
                    { "4099ea1b-ed6b-11ed-b4c0-105badc84798", 0, "dd1b3947-e3b7-4c79-9c63-4914ad10a952", "Kahter.Danielab00@example.com", true, "Kahter", "Danielab00", false, null, "KAHTER.DANIELAB00@EXAMPLE.COM", "KAHTER.DANIELAB00@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMALfj1FAVbWwl6ZpYl7rRYBk608t2y6mpXTZULS7TeSJuCHUKtTnAASfYlghmzQNg==", "01214469178", false, "d45a4c77-d78b-4719-a0ad-6e4a3eb2e0a8", false, "Kahter.Danielab00@example.com" },
                    { "4099ea1d-ed6b-11ed-a4c6-105badc84798", 0, "0faef24d-cd4a-47b1-8c4b-6ea8e57820b1", "Idris.Goodbaab@example.com", true, "Idris", "Goodbaab", false, null, "IDRIS.GOODBAAB@EXAMPLE.COM", "IDRIS.GOODBAAB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBKsWo8f09s33tmO+6WEUaahoS5SuVo7EM+Ugey78JYDqbdLBU+Iv/lykaF26hJZWg==", "01275050210", false, "7241683e-2a2c-4cc7-94b7-bda0dc23261f", false, "Idris.Goodbaab@example.com" },
                    { "4099ea1f-ed6b-11ed-9f62-105badc84798", 0, "98eac007-2443-41ab-9157-ffd34b2c1a8d", "Badri.Turki86e8@example.com", true, "Badri", "Turki86e8", false, null, "BADRI.TURKI86E8@EXAMPLE.COM", "BADRI.TURKI86E8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGBgQs44W1qV9GiSM7FJmWJLyrxXSCzlPB0j3xKEcsJbJNH6bc1mT6wBvebb9PYz9Q==", "01296658918", false, "6c2afede-d903-44ec-81d7-bfd86cc576eb", false, "Badri.Turki86e8@example.com" },
                    { "409b2251-ed6b-11ed-9a82-105badc84798", 0, "e6f69dce-2248-49c4-90e6-37d5741d2562", "Hilal.Sajidab3b@example.com", true, "Hilal", "Sajidab3b", false, null, "HILAL.SAJIDAB3B@EXAMPLE.COM", "HILAL.SAJIDAB3B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPTE7WpVvES0yVaKBi2PB+wK7VuVhDgviEmtBIWBMzKJ2uZin7h7zsEhtOx7VsnXxA==", "01269184301", false, "7cf5bef2-81a1-4a1b-a552-7d70dd2545cd", false, "Hilal.Sajidab3b@example.com" },
                    { "409b2253-ed6b-11ed-b650-105badc84798", 0, "259d2c07-bb86-42fe-813f-e15823c33756", "Nahar.Kahterb7e4@example.com", true, "Nahar", "Kahterb7e4", false, null, "NAHAR.KAHTERB7E4@EXAMPLE.COM", "NAHAR.KAHTERB7E4@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBLPGZjdDsERZ6pfPB5zmpv9TiImr3LWwtc/XpHO3PQvSzLkFI1N3nSlXRvo1lUzBg==", "01299448511", false, "1c5db706-2c74-47ce-bd15-76a7a1c04c58", false, "Nahar.Kahterb7e4@example.com" },
                    { "409b2255-ed6b-11ed-87ce-105badc84798", 0, "a3f806d6-1e6d-40ed-8f4e-3d9d74eda1b4", "Badri.​​Karim8bc1@example.com", true, "Badri", "​​Karim8bc1", false, null, "BADRI.​​KARIM8BC1@EXAMPLE.COM", "BADRI.​​KARIM8BC1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBEqW/SXfEzCiNruEhgN6aFuKS3fy5fmIpojAVsRD8pdr/9mKkgwBeiskye0w2ygRw==", "01258445075", false, "a170f19f-64ff-4d7c-b7be-79b41baa3c64", false, "Badri.​​Karim8bc1@example.com" },
                    { "409b2257-ed6b-11ed-8f44-105badc84798", 0, "2b7854ea-a4b0-45c6-9dbf-30b3e0c8a2af", "Noor.Mahmoudaee2@example.com", true, "Noor", "Mahmoudaee2", false, null, "NOOR.MAHMOUDAEE2@EXAMPLE.COM", "NOOR.MAHMOUDAEE2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMiuYGoGzCzL15eZQm9Uf0zRgOLy4iPJ+X594LsEYE1eqBKc7hP64Z8vgdFPbUmEqQ==", "01224192049", false, "e3d613d9-2198-44f5-a436-d9b67c856b50", false, "Noor.Mahmoudaee2@example.com" },
                    { "409b2259-ed6b-11ed-ac78-105badc84798", 0, "a3f89805-6ba0-489f-9562-a68150fc011a", "Zarif.Asamib250@example.com", true, "Zarif", "Asamib250", false, null, "ZARIF.ASAMIB250@EXAMPLE.COM", "ZARIF.ASAMIB250@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKDSaPOY2Pe4zsJ7C2+KgF6aKv4dYxjIApoSunNpfTdLx7+4GsbTaH/Wn76CBwXXYg==", "01279796291", false, "17cfa146-1ce4-4a14-90a9-e8a9786c7a8a", false, "Zarif.Asamib250@example.com" },
                    { "409b225b-ed6b-11ed-bf67-105badc84798", 0, "add49b44-b853-4f98-b27c-f451fe76d8b4", "Barra.Osamaa94c@example.com", true, "Barra", "Osamaa94c", false, null, "BARRA.OSAMAA94C@EXAMPLE.COM", "BARRA.OSAMAA94C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJDQI8BRGvCRXPd4tg0arhBEYR2nO+0J5JRxXxa6KKNYGq2ehiKMEXSu7ekaXsbcug==", "01265372285", false, "5d6a64ae-de22-420d-a622-d82d9f112f95", false, "Barra.Osamaa94c@example.com" },
                    { "409b225d-ed6b-11ed-8369-105badc84798", 0, "d4c1f4d4-cd5f-4c4e-8b51-ee8b89fb19f2", "Jika.Sameh99c4@example.com", true, "Jika", "Sameh99c4", false, null, "JIKA.SAMEH99C4@EXAMPLE.COM", "JIKA.SAMEH99C4@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPvPRUnOcF3B19Laq6tLuC4fd+8y+71z8djWc4X5eXsiQXZ2JBOJDFqGqNx+PkrOZw==", "01224100592", false, "1519a914-79ce-4b98-ba9d-70a8585801a4", false, "Jika.Sameh99c4@example.com" },
                    { "409b225f-ed6b-11ed-8d6a-105badc84798", 0, "94bb97fb-ac81-464c-b8bf-43b3e2448bd2", "Wael.​​Karim9585@example.com", true, "Wael", "​​Karim9585", false, null, "WAEL.​​KARIM9585@EXAMPLE.COM", "WAEL.​​KARIM9585@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDZ3DYI3FQ+0WyJLj6TGbQV+L8CIPeh8iW2AaKt45ZQJgXxnHbA5pCtqg5353cq5Gw==", "01270034864", false, "c90b0c3c-51c3-4970-b669-12c79981b106", false, "Wael.​​Karim9585@example.com" },
                    { "409b2261-ed6b-11ed-b7f8-105badc84798", 0, "ea6aec87-9b68-4554-b26c-b650c54c0e37", "Hilal.Faisal9236@example.com", true, "Hilal", "Faisal9236", false, null, "HILAL.FAISAL9236@EXAMPLE.COM", "HILAL.FAISAL9236@EXAMPLE.COM", "AQAAAAEAACcQAAAAENaXwpGpRwQHThW1CAEHHhRbiXZMJCpo4CCGcVFqGV9YjKKvBkjJJAUCOxQWqRrTbg==", "01221565927", false, "4dc2c5ca-2969-4b05-84d8-b2b55223e5d8", false, "Hilal.Faisal9236@example.com" },
                    { "409b2263-ed6b-11ed-93b0-105badc84798", 0, "966d91cf-32ba-4f89-b5cf-73c9ca680251", "Adel.Bahir82d6@example.com", true, "Adel", "Bahir82d6", false, null, "ADEL.BAHIR82D6@EXAMPLE.COM", "ADEL.BAHIR82D6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJct4R/iJvvfH24yUTsirRclEr0TSRRskpyHhB+tXR8p0zky7tEpcbYjJLfyKDG6zQ==", "01276197853", false, "2655dd82-7754-489c-add6-f9db1c2e7c71", false, "Adel.Bahir82d6@example.com" },
                    { "409b2265-ed6b-11ed-8a51-105badc84798", 0, "6f6305f9-e259-4496-a81d-eb9e85731b0e", "Mahmoud.Daniel964c@example.com", true, "Mahmoud", "Daniel964c", false, null, "MAHMOUD.DANIEL964C@EXAMPLE.COM", "MAHMOUD.DANIEL964C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJWl1Vv7ybOzwG7L9BMBCo0N7P4HVfBubtFaW3d5dEoQsmHbD0bMgu6sANeLODAFzg==", "01244504780", false, "eb281e15-5c58-4ee9-95e3-c41623bf435a", false, "Mahmoud.Daniel964c@example.com" },
                    { "409b2267-ed6b-11ed-9ed8-105badc84798", 0, "7d72147b-1c54-4627-897e-c4ea9caac395", "Adel.Hamaki94da@example.com", true, "Adel", "Hamaki94da", false, null, "ADEL.HAMAKI94DA@EXAMPLE.COM", "ADEL.HAMAKI94DA@EXAMPLE.COM", "AQAAAAEAACcQAAAAEP5B0XUCk/c7jWMPJ9dKpzU8UFCxWU3pdVl7K3hLBAeYnmY4adFt4rsxJ+H5FQ61Lw==", "01227940951", false, "4df84e28-4c88-429c-a276-04413d377c70", false, "Adel.Hamaki94da@example.com" },
                    { "409b2269-ed6b-11ed-96a1-105badc84798", 0, "667ad154-f6ba-48c7-87b2-6ffe8550ae9b", "Adham.Basembae6@example.com", true, "Adham", "Basembae6", false, null, "ADHAM.BASEMBAE6@EXAMPLE.COM", "ADHAM.BASEMBAE6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOvadPNArPSlPx6veWEWhvR8bLKVCucaaYKsAXRz9eUsmCMTzBx/uc8KCY9KvpfZHA==", "01295804031", false, "c8b7db6c-a7c7-4f71-a3f0-89737e6a551a", false, "Adham.Basembae6@example.com" },
                    { "409b226b-ed6b-11ed-b5d0-105badc84798", 0, "cdbce200-9713-4a1e-b09e-4d52ae2c314c", "Lail.Bilalbdd5@example.com", true, "Lail", "Bilalbdd5", false, null, "LAIL.BILALBDD5@EXAMPLE.COM", "LAIL.BILALBDD5@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDojCHBvmh+3095edxZoNkxVsBQDK4phDttDmUaumLoVRjclQ/L62bYaOK5yxdnNCw==", "01264886434", false, "18ce00bd-d15b-4f77-b1ec-e4e58747bae5", false, "Lail.Bilalbdd5@example.com" },
                    { "409b226d-ed6b-11ed-9578-105badc84798", 0, "1110ebcc-f4fa-4967-8192-08932488ac91", "Bara.Badri8be3@example.com", true, "Bara", "Badri8be3", false, null, "BARA.BADRI8BE3@EXAMPLE.COM", "BARA.BADRI8BE3@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMyJzx2xBONfByv2+vm9Xit6mH0cPjtOH9Pasot4dLsd71GKWRHOjLa28xd7GKm7Qg==", "01232443399", false, "51f15e86-26fa-466d-9149-c9c1ebadbb44", false, "Bara.Badri8be3@example.com" },
                    { "409b226f-ed6b-11ed-af75-105badc84798", 0, "30e4768c-b9e5-42cd-9a14-af1048e2c97b", "Sheikh.Sheikha7a4@example.com", true, "Sheikh", "Sheikha7a4", false, null, "SHEIKH.SHEIKHA7A4@EXAMPLE.COM", "SHEIKH.SHEIKHA7A4@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJ+d6ICvOcoVCF0xGlqLInbK+jiS+yhP2JDSvzSo+joXAvlNgvapsYAzKtu3v4lqQw==", "01245074460", false, "8677dd76-b2cc-48d2-8210-7646d43d057c", false, "Sheikh.Sheikha7a4@example.com" },
                    { "409b2271-ed6b-11ed-b13a-105badc84798", 0, "439bf1f6-3d62-43ab-8e1f-95acb64cfb46", "Loay.Hamaqyaf12@example.com", true, "Loay", "Hamaqyaf12", false, null, "LOAY.HAMAQYAF12@EXAMPLE.COM", "LOAY.HAMAQYAF12@EXAMPLE.COM", "AQAAAAEAACcQAAAAEC8LwPiH3LpT3VnZkJFZe7jbc+4j6O/BeoZ3uVCcE7pwgFYoP7Tsc7e+n/qPw2ibFg==", "01295630957", false, "f02d0c9b-fc0a-4fda-8ff1-da6eeb318d59", false, "Loay.Hamaqyaf12@example.com" },
                    { "409b2273-ed6b-11ed-984c-105badc84798", 0, "037e46fe-4d2f-450b-8e36-6db432643208", "Maher.Good90c5@example.com", true, "Maher", "Good90c5", false, null, "MAHER.GOOD90C5@EXAMPLE.COM", "MAHER.GOOD90C5@EXAMPLE.COM", "AQAAAAEAACcQAAAAELgCLcqGHHlpk6u8CRKDmu/aRVV5LlCsJi9t51DeuxZVUZepLHc9n4Jt1ijAXgNJhg==", "01211245634", false, "295d9d5a-9ca0-4967-b66b-301343191da4", false, "Maher.Good90c5@example.com" },
                    { "409b2275-ed6b-11ed-8ea0-105badc84798", 0, "94526937-1c8e-4098-a1f1-5be9a47eec60", "Bassam.Russella913@example.com", true, "Bassam", "Russella913", false, null, "BASSAM.RUSSELLA913@EXAMPLE.COM", "BASSAM.RUSSELLA913@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEwXg+Y/nYqRkw39x8aWhwwphJg9yTNf20mQE8UX9ewpYd3/iOjVNkWh382r+nBKCg==", "01277681415", false, "246eacf8-5175-4c47-be4d-d428d72d41ef", false, "Bassam.Russella913@example.com" },
                    { "409b2277-ed6b-11ed-a519-105badc84798", 0, "b38c96d7-0ea7-4d25-a1ad-40d78e2d22d3", "Sheikhy.Jawada4e1@example.com", true, "Sheikhy", "Jawada4e1", false, null, "SHEIKHY.JAWADA4E1@EXAMPLE.COM", "SHEIKHY.JAWADA4E1@EXAMPLE.COM", "AQAAAAEAACcQAAAAELTiztWkrV1ZQh6sKiG1xsZvSIlRjgEzqwgB3gCAXv3aR9QAT//UELDSFIQ9uS2rTA==", "01249047718", false, "1967d00a-3c30-4e42-a8c9-d47690d5613f", false, "Sheikhy.Jawada4e1@example.com" },
                    { "409b2279-ed6b-11ed-a66d-105badc84798", 0, "308b1078-4372-4f7a-946e-454affd08923", "Hassan.Hosni80b2@example.com", true, "Hassan", "Hosni80b2", false, null, "HASSAN.HOSNI80B2@EXAMPLE.COM", "HASSAN.HOSNI80B2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEiPSK8r3ALvH+XQ9Vs3aPq+r87v4pNzX47yyOaXRBPgzKzpf4zpPI1VfcgQ0Gir7g==", "01247655370", false, "844d4556-2adc-48fc-950a-3bfe1d0dfc6d", false, "Hassan.Hosni80b2@example.com" },
                    { "409b227b-ed6b-11ed-a6a6-105badc84798", 0, "4a351c58-530f-4356-b8ab-602961eb45ae", "Minali.Yamen9b11@example.com", true, "Minali", "Yamen9b11", false, null, "MINALI.YAMEN9B11@EXAMPLE.COM", "MINALI.YAMEN9B11@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPfGmIS4VrYMSaCYVTOYKKeFFZs+KbUstLcRkpvGYjK0o1AYLyWesiXM+b/6M72RiQ==", "01244701551", false, "37a9083a-2419-4aa2-8320-6f3cde924e10", false, "Minali.Yamen9b11@example.com" },
                    { "409b227d-ed6b-11ed-b8fd-105badc84798", 0, "1a7cfb1e-c3b6-41e1-bfc6-d51c3414b9dc", "Battari.Ghanema3e1@example.com", true, "Battari", "Ghanema3e1", false, null, "BATTARI.GHANEMA3E1@EXAMPLE.COM", "BATTARI.GHANEMA3E1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDS1ncfOcwLg0pbzsTIkX/YkEsSc4h0muQOxMAGUSoZwqimybyRI6pn0jPgJyozB9A==", "01261605249", false, "65b5dac5-a3ba-40a8-af1c-62eab20485f0", false, "Battari.Ghanema3e1@example.com" },
                    { "409b227f-ed6b-11ed-9609-105badc84798", 0, "c59ae4f8-cb71-4472-81b2-8167e8b5cab0", "Yusuf.Maherac9c@example.com", true, "Yusuf", "Maherac9c", false, null, "YUSUF.MAHERAC9C@EXAMPLE.COM", "YUSUF.MAHERAC9C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFnkCdTDgs9u5lI9264zRfhADbaK3N+3khE9AgcMjjWANpDnjo+DW/VFUosqLqa6hg==", "01293092536", false, "fc2144bc-2f1e-4dc5-a62c-70568e1c1b46", false, "Yusuf.Maherac9c@example.com" },
                    { "409b2281-ed6b-11ed-968e-105badc84798", 0, "c4a5b4ab-7485-49d8-866b-9dd74745365d", "Saree.Idrisb0ef@example.com", true, "Saree", "Idrisb0ef", false, null, "SAREE.IDRISB0EF@EXAMPLE.COM", "SAREE.IDRISB0EF@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOp0dpmR7Ace746ILbQOztgDPmrH24whcBoXRr4cq6z63WkwJfnXZ+Wqu385ZB4qvw==", "01220329770", false, "8e98a38b-5c40-4668-a84f-aacffb5f8f2b", false, "Saree.Idrisb0ef@example.com" },
                    { "409b2283-ed6b-11ed-90f7-105badc84798", 0, "371895a2-ea91-4b08-b247-1f358c07e30b", "Adham.Bahiraf53@example.com", true, "Adham", "Bahiraf53", false, null, "ADHAM.BAHIRAF53@EXAMPLE.COM", "ADHAM.BAHIRAF53@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBMh9s0YJ61mAcnFvJEH7GceT2pW6GchCTYgAia0JQXGicjCvNHRcpU8qJs5wcQikA==", "01259225260", false, "42fe4e9b-195f-4e23-9ded-5b0f2abcc599", false, "Adham.Bahiraf53@example.com" },
                    { "409b2285-ed6b-11ed-945d-105badc84798", 0, "70644eee-71c2-4ac2-8fd6-33f4281e9610", "Saden.Salim9973@example.com", true, "Saden", "Salim9973", false, null, "SADEN.SALIM9973@EXAMPLE.COM", "SADEN.SALIM9973@EXAMPLE.COM", "AQAAAAEAACcQAAAAEI6KmIZG8nyDUi6wMI9lyNlqH/hB5UP9ruWNFaXpZd9/KjqmGpb2O9NVfvRm2VdtyA==", "01251768428", false, "99400dec-7ae9-4dd2-95de-a0f70eda8e01", false, "Saden.Salim9973@example.com" },
                    { "409b2287-ed6b-11ed-bdd8-105badc84798", 0, "dd3a7783-d7c9-4af8-ace8-9c5aae0af887", "Sameh.Hassana203@example.com", true, "Sameh", "Hassana203", false, null, "SAMEH.HASSANA203@EXAMPLE.COM", "SAMEH.HASSANA203@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDAhOpJllnUutFBSkeCihGxT8YFWVymZkwx+L7ZuNXvL7wCPhNy/PLou0BwirOqD2w==", "01212703009", false, "2745f9a1-f092-48a4-ac9e-44a107c24cb7", false, "Sameh.Hassana203@example.com" },
                    { "409b2289-ed6b-11ed-8a33-105badc84798", 0, "5f889bd0-c2cf-4d81-b88a-17901960a547", "Yusuf.Fidaa92d2@example.com", true, "Yusuf", "Fidaa92d2", false, null, "YUSUF.FIDAA92D2@EXAMPLE.COM", "YUSUF.FIDAA92D2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOUrtDPF2Uyn2YC05cSeoNlfoOQtVDL1WOLVwvYRrQ7tzGt7dVmPNE5uqWTm1Cpj0Q==", "01216037425", false, "3c91e69d-a5a7-4a79-b7b1-7de028456a84", false, "Yusuf.Fidaa92d2@example.com" },
                    { "409b228b-ed6b-11ed-82cb-105badc84798", 0, "168a9d48-da45-48a5-a497-a3c72e1fce7e", "Dagher.Baraa698@example.com", true, "Dagher", "Baraa698", false, null, "DAGHER.BARAA698@EXAMPLE.COM", "DAGHER.BARAA698@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJyhS/2cnbUZJKB56qkpNz+Z7k10rkyhRP8iGgD2uK9VETXfAIH5q/Q5JMzM6y7kdg==", "01228632027", false, "e85e5c67-295f-42bc-b269-a74ca8166751", false, "Dagher.Baraa698@example.com" },
                    { "409b228d-ed6b-11ed-9862-105badc84798", 0, "ae2c39a0-5548-4772-af1e-14581e2e83ed", "Bassel.Ibrahima080@example.com", true, "Bassel", "Ibrahima080", false, null, "BASSEL.IBRAHIMA080@EXAMPLE.COM", "BASSEL.IBRAHIMA080@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFPhsbq9PGGJcr4ZWMru3MaQSIFGjZ7zaeg2ZvjldkRS+jbOVCIJ/Zszjtb4rbr6Ew==", "01299705532", false, "fc50d843-eca6-46d6-9903-32f1bf3921c3", false, "Bassel.Ibrahima080@example.com" },
                    { "409b228f-ed6b-11ed-bba0-105badc84798", 0, "6f7dcbfb-5376-47dc-937e-18949df3ffaa", "Kamel.Samhi885f@example.com", true, "Kamel", "Samhi885f", false, null, "KAMEL.SAMHI885F@EXAMPLE.COM", "KAMEL.SAMHI885F@EXAMPLE.COM", "AQAAAAEAACcQAAAAECGeC7okDDOauQpa2//kd1RbArKpDJ9x0Wh+SCqgouYaHG4qjUAMeAisRjP7dgnvHQ==", "01280062716", false, "49ababa0-33ad-487c-a460-0d8995fc5a53", false, "Kamel.Samhi885f@example.com" },
                    { "409b2291-ed6b-11ed-82b0-105badc84798", 0, "8958e839-62df-4f02-a00a-bc4e6eac65e8", "Bara.Fahedb92d@example.com", true, "Bara", "Fahedb92d", false, null, "BARA.FAHEDB92D@EXAMPLE.COM", "BARA.FAHEDB92D@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAOa3kCOfy99xFVgejylZIDT0RRIdgbbkYM7Ek+U1MQqTLK9x+y5G3ZqeKrlIS4/vg==", "01272696536", false, "aa8b49e6-3b3a-45c0-93f5-8542df43019b", false, "Bara.Fahedb92d@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "409b2293-ed6b-11ed-a281-105badc84798", 0, "223d46cf-58ba-452a-88ca-c7938af1984d", "Samhi.Hilal8bd1@example.com", true, "Samhi", "Hilal8bd1", false, null, "SAMHI.HILAL8BD1@EXAMPLE.COM", "SAMHI.HILAL8BD1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOcrd6v5vdZgsWG7Be77QpRR0LCdHGWbcjFg1LnOH9wfcrUZ1cTT7VAwXEXGCDtOlg==", "01278276213", false, "367ac9b2-ceed-445b-ab84-cbd0ee804f58", false, "Samhi.Hilal8bd1@example.com" },
                    { "409b2295-ed6b-11ed-a03f-105badc84798", 0, "f1b848da-72dd-4c6a-868a-89f48dda2cb1", "Faisal.Samirbd6b@example.com", true, "Faisal", "Samirbd6b", false, null, "FAISAL.SAMIRBD6B@EXAMPLE.COM", "FAISAL.SAMIRBD6B@EXAMPLE.COM", "AQAAAAEAACcQAAAAELvc6dDzUrwNDQrLqYKh2lfw5FGdJQyB/gLpnTAH6BQcSFnPF2qyQ1oz1h3KXBzSDw==", "01296553303", false, "36491dc6-4714-4036-818b-57101e1ec7eb", false, "Faisal.Samirbd6b@example.com" },
                    { "409b2297-ed6b-11ed-9620-105badc84798", 0, "94ae0690-992d-497a-9d70-db6d596dd8be", "Wael.Sahami86d0@example.com", true, "Wael", "Sahami86d0", false, null, "WAEL.SAHAMI86D0@EXAMPLE.COM", "WAEL.SAHAMI86D0@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJ2eZaULks8vH6j/lwqpSKmnk6SNWSMvZZpMH9cv8Y/wZ2EPicMZaGCrH0G/yRZtDw==", "01283688266", false, "d7ddbf03-2e25-4b15-9b7a-47093f5bba9e", false, "Wael.Sahami86d0@example.com" },
                    { "409b2299-ed6b-11ed-8cd7-105badc84798", 0, "516ff7dd-2811-4be5-8026-091285162fca", "Muhammad.Yad826b@example.com", true, "Muhammad", "Yad826b", false, null, "MUHAMMAD.YAD826B@EXAMPLE.COM", "MUHAMMAD.YAD826B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJD94L9HBw3UnDaZTBa9IApesbOS/zosW9Yd+4mBibZmq918VOQU+gTLhrU1scgyrg==", "01241209071", false, "ffd0d989-099e-4835-94a3-294da2fb7bbd", false, "Muhammad.Yad826b@example.com" },
                    { "409b229b-ed6b-11ed-b5e4-105badc84798", 0, "f6a9586e-eb59-480b-a123-4e96d8dea7fe", "Wael.Bahi97f5@example.com", true, "Wael", "Bahi97f5", false, null, "WAEL.BAHI97F5@EXAMPLE.COM", "WAEL.BAHI97F5@EXAMPLE.COM", "AQAAAAEAACcQAAAAELy+SrCq0KGoibfPuzp/cc/catmxOn3rngpRDUzm0i68BFl9T4QIX7ADBC1axDoBYQ==", "01280616076", false, "f9f47673-b134-433f-aa70-bd96335a3b4e", false, "Wael.Bahi97f5@example.com" },
                    { "409c5ba9-ed6b-11ed-a9f0-105badc84798", 0, "3579142d-2716-4e8e-9302-2c81f4aeb043", "Sameh.Osama98c7@example.com", true, "Sameh", "Osama98c7", false, null, "SAMEH.OSAMA98C7@EXAMPLE.COM", "SAMEH.OSAMA98C7@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGXZMpLlkljX2kKb0D4/hKFDULoiMIrozWMmP2Aq2wTn4ddGskPE1F2l+X9WV3q9CQ==", "01242267999", false, "cb174665-e0e5-45d8-81b1-313789be1c81", false, "Sameh.Osama98c7@example.com" },
                    { "409c5bab-ed6b-11ed-9ebb-105badc84798", 0, "10ebe815-a594-4427-b38b-d74b9e6dd30c", "Dagher.Sareead13@example.com", true, "Dagher", "Sareead13", false, null, "DAGHER.SAREEAD13@EXAMPLE.COM", "DAGHER.SAREEAD13@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJn+bbc5YMe465qm1HnKsi+bo7NSS4GwFZIU8WmVYqtuqO+Y5vzd9seIJg+7D9WhdA==", "01280522970", false, "6cdfd4e6-076d-4e30-bd73-652288aa4643", false, "Dagher.Sareead13@example.com" },
                    { "409c5bad-ed6b-11ed-b06e-105badc84798", 0, "7ad823c0-91ef-4d03-9be9-644e263fbb76", "Yad.Hamaqy909a@example.com", true, "Yad", "Hamaqy909a", false, null, "YAD.HAMAQY909A@EXAMPLE.COM", "YAD.HAMAQY909A@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAz1RnrUJgIw/aPDyKvEsANAOmjpWBQsvGPeBT78K91mLGqVd0OxaBPFAMF+fv6qJg==", "01268125360", false, "00660ad3-00a8-4cdd-9b1e-a5e7359f07f2", false, "Yad.Hamaqy909a@example.com" },
                    { "409c5baf-ed6b-11ed-b43f-105badc84798", 0, "d2a8a61c-e5f0-4b85-9278-07b1bb13ce6f", "Bassel.Kamelaef1@example.com", true, "Bassel", "Kamelaef1", false, null, "BASSEL.KAMELAEF1@EXAMPLE.COM", "BASSEL.KAMELAEF1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEADVTqreuqPeCUHjbYDsbKw53/MsKUTLGZdxengD85AlgHznQ830+jzU+o7ZjiYxAQ==", "01281713510", false, "89a0a778-ff5a-46e8-b3a4-cad845c61fcd", false, "Bassel.Kamelaef1@example.com" },
                    { "409c5bb1-ed6b-11ed-b22e-105badc84798", 0, "c3b44f75-61d3-4ea3-b390-a2c91c664507", "Lail.Minali8f58@example.com", true, "Lail", "Minali8f58", false, null, "LAIL.MINALI8F58@EXAMPLE.COM", "LAIL.MINALI8F58@EXAMPLE.COM", "AQAAAAEAACcQAAAAEN/OBmdk/smVGsPUHK71cn+kuriWtPOy9y8ZlfT2vOjUQrg5LWsQXga0+kjI4o8UVQ==", "01211017057", false, "544bec61-af77-4bed-8a42-78ac0a878790", false, "Lail.Minali8f58@example.com" },
                    { "409c5bb3-ed6b-11ed-8aea-105badc84798", 0, "9d0953d6-c6ac-4cbf-a397-3c1c03897886", "Majid.Adlia9c6@example.com", true, "Majid", "Adlia9c6", false, null, "MAJID.ADLIA9C6@EXAMPLE.COM", "MAJID.ADLIA9C6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJpDI3VdJIwDZ3kXqQSKCC30xC5xQQuErEOK3jUq8oKDXYl9X5UvG08EspwHljpWjg==", "01276042209", false, "826de11f-4edb-4c96-9c23-34957e80f3ca", false, "Majid.Adlia9c6@example.com" },
                    { "409c5bb5-ed6b-11ed-81ec-105badc84798", 0, "e1ce52f9-6c28-4e72-ade3-32b5048bbef4", "Firas.Yakonaf22@example.com", true, "Firas", "Yakonaf22", false, null, "FIRAS.YAKONAF22@EXAMPLE.COM", "FIRAS.YAKONAF22@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHo72ZkovtcjELlXjzFivlpYMzbT/wW6ce00EAMEMF6ZS94xQTbBTP9xagoeU2fk1w==", "01248361000", false, "212d19c5-516b-43cd-aca0-f72e7a50a0d1", false, "Firas.Yakonaf22@example.com" },
                    { "409c5bb7-ed6b-11ed-a54a-105badc84798", 0, "a156f337-a9f2-4455-86eb-b1fac52b05c2", "Saden.Hassanaf93@example.com", true, "Saden", "Hassanaf93", false, null, "SADEN.HASSANAF93@EXAMPLE.COM", "SADEN.HASSANAF93@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPfeg5irEpyWO5+WkUxTuV6WU5wpIyKV+DFBBsF6Hg1hSmlRE1KMgOdXUl6oA/JrYQ==", "01252473730", false, "7e6d7ef7-b98c-41ce-9c11-da8711b3bfae", false, "Saden.Hassanaf93@example.com" },
                    { "409c5bb9-ed6b-11ed-a374-105badc84798", 0, "371b2e4b-1e45-48fa-b619-c8e22feb0f63", "Helsey.Noor82e8@example.com", true, "Helsey", "Noor82e8", false, null, "HELSEY.NOOR82E8@EXAMPLE.COM", "HELSEY.NOOR82E8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBZ5BkdpTby+CVDwYavkR6z4qLSNA3QUcFrWWK2BEjGE1WK7nIIVZVRMMHrFFICKQw==", "01293212396", false, "d84dbdfc-c275-4f83-99d6-6de65244caf2", false, "Helsey.Noor82e8@example.com" },
                    { "409c5bbb-ed6b-11ed-a145-105badc84798", 0, "dd2c2bea-8e1d-4335-bf85-4f5e03336177", "Ali.Ryan921d@example.com", true, "Ali", "Ryan921d", false, null, "ALI.RYAN921D@EXAMPLE.COM", "ALI.RYAN921D@EXAMPLE.COM", "AQAAAAEAACcQAAAAENlZLG+ZECt6yba6qaslc2vdF7ZGSWssPJNOCPOWzqOCx6r7LSBOwSmdtxXiGUkzsA==", "01240558815", false, "fafce4d6-cc83-4269-b6e8-d8670574b106", false, "Ali.Ryan921d@example.com" },
                    { "409c5bbd-ed6b-11ed-a7f3-105badc84798", 0, "38865db3-513a-425b-b7cc-468f114d7a9f", "Yad.Najm91d8@example.com", true, "Yad", "Najm91d8", false, null, "YAD.NAJM91D8@EXAMPLE.COM", "YAD.NAJM91D8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFYKglkWL9cOO2QkcK2U8dvraWNqRri3vnJ/h84Nh53k4qZWtfb+/fPR+nAkIXhLSQ==", "01256088190", false, "8727506e-2a75-4de7-a81e-79ed6215e231", false, "Yad.Najm91d8@example.com" },
                    { "409c5bbf-ed6b-11ed-afcf-105badc84798", 0, "39cda60c-b2fc-4821-8340-53759f4cae76", "Good.Hilal8ebc@example.com", true, "Good", "Hilal8ebc", false, null, "GOOD.HILAL8EBC@EXAMPLE.COM", "GOOD.HILAL8EBC@EXAMPLE.COM", "AQAAAAEAACcQAAAAEASyISthDLesTD7qLaAlrjeFqCXGLbGYCmq59LR//+jYA3BmRWj1VSxoCmDfhiaFkw==", "01233135538", false, "86e5ed5d-edd0-400c-b925-4aae75016444", false, "Good.Hilal8ebc@example.com" },
                    { "409c5bc1-ed6b-11ed-880d-105badc84798", 0, "d9404c42-00b3-454f-a80c-34778ad2db36", "Bara.Omar96e5@example.com", true, "Bara", "Omar96e5", false, null, "BARA.OMAR96E5@EXAMPLE.COM", "BARA.OMAR96E5@EXAMPLE.COM", "AQAAAAEAACcQAAAAECHjEUs2IlI31oGfTUvPBEmz+QcymYxHpE9WSqCYdLUd49fiQctsn6zcLdezykLfbg==", "01253668931", false, "1399f534-1234-4f6b-bfa7-0f448e61e59e", false, "Bara.Omar96e5@example.com" },
                    { "409c5bc3-ed6b-11ed-b2b0-105badc84798", 0, "5c32f83b-acc9-4084-9410-5992a4997312", "Jika.Faisal9ca6@example.com", true, "Jika", "Faisal9ca6", false, null, "JIKA.FAISAL9CA6@EXAMPLE.COM", "JIKA.FAISAL9CA6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEcRwFsy4AG34TI4ys88X0mw0WsSHSTG9YAUEHr6K1VV2ve6KEYzw+EvJp48S6bIwg==", "01270653239", false, "693fad4d-3309-4e64-b0fe-39f5c212939e", false, "Jika.Faisal9ca6@example.com" },
                    { "409c5bc5-ed6b-11ed-9c33-105badc84798", 0, "f6e7abbe-a0ff-4c47-baa2-f940822ba048", "Fares.Turkib5c8@example.com", true, "Fares", "Turkib5c8", false, null, "FARES.TURKIB5C8@EXAMPLE.COM", "FARES.TURKIB5C8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOyeEAJbfqXwG5Nnkvv67Q0JxrTSmJttZkcR44l9+KzwKhG/MbeX8VhtN5mIbCH+0w==", "01298016974", false, "1c7b892e-e7b4-4c5f-8210-f2ec11dd3ef9", false, "Fares.Turkib5c8@example.com" },
                    { "409c5bc7-ed6b-11ed-a584-105badc84798", 0, "b9f33121-c5e4-4e56-b8f4-9d8492fdb161", "Waseem.Zachariah8b80@example.com", true, "Waseem", "Zachariah8b80", false, null, "WASEEM.ZACHARIAH8B80@EXAMPLE.COM", "WASEEM.ZACHARIAH8B80@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPhx0vAadKWkm68/MbefS12v4MPdHjeOK5gqmx9h9nyPnnGlo9zY3gLl+Pes5zwgIQ==", "01233473594", false, "da1e1a2b-f549-4059-aca2-81b84f91b1b9", false, "Waseem.Zachariah8b80@example.com" },
                    { "409c5bc9-ed6b-11ed-94df-105badc84798", 0, "6909f5da-e2a6-4e19-8cad-f9dbaf009693", "Basem.Zaki9209@example.com", true, "Basem", "Zaki9209", false, null, "BASEM.ZAKI9209@EXAMPLE.COM", "BASEM.ZAKI9209@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJMbXu0RDvwwxTkSMZL1+caBANPKLCXQ5XZgJydJ9TRqp8+/I/XiiQy3p97LNpAy9Q==", "01247188081", false, "56609d44-f480-45f1-bb9f-5862ebe9843f", false, "Basem.Zaki9209@example.com" },
                    { "409c5bcb-ed6b-11ed-ae48-105badc84798", 0, "158a4ab1-e4d6-4966-95be-4d1861bc6540", "Firas.Fahedb115@example.com", true, "Firas", "Fahedb115", false, null, "FIRAS.FAHEDB115@EXAMPLE.COM", "FIRAS.FAHEDB115@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPKWwdcZcujJAdZ0rycSGOKQLN/EIHqP3z+N5JTQiMMOGhmMXyDjWRqlSKWqeLMR/A==", "01238482001", false, "0ac9bb29-fce6-490e-a969-dff205449309", false, "Firas.Fahedb115@example.com" },
                    { "409c5bcd-ed6b-11ed-82bc-105badc84798", 0, "01d0b3e3-b54a-4e14-bdba-e477714e8c64", "Hilal.Asim8263@example.com", true, "Hilal", "Asim8263", false, null, "HILAL.ASIM8263@EXAMPLE.COM", "HILAL.ASIM8263@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEpTBQIDjgAk6hOPApUd6RcI+UFghsKD52Xg204vZkXS0izlaDrkz10Fqd2BpsTlvw==", "01225838899", false, "b8868365-d91b-46fb-a56c-894e3ee25377", false, "Hilal.Asim8263@example.com" },
                    { "409c5bcf-ed6b-11ed-a53b-105badc84798", 0, "f61b4b82-18ae-4d27-8f90-5ac38ed415f8", "Kamel.Ghanema74f@example.com", true, "Kamel", "Ghanema74f", false, null, "KAMEL.GHANEMA74F@EXAMPLE.COM", "KAMEL.GHANEMA74F@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAP0ZnpD5I+zvmPcRiMUNMjfTgJ+Hl8IN9BSqUGmmc697dcdttUb8ABkSWciOPPQ8g==", "01267168944", false, "58cccdf4-662e-4188-85ce-783f41548437", false, "Kamel.Ghanema74f@example.com" },
                    { "409c5bd1-ed6b-11ed-8709-105badc84798", 0, "8cc7a92d-48ea-455c-b69e-0903b469d529", "Firas.Adelac4e@example.com", true, "Firas", "Adelac4e", false, null, "FIRAS.ADELAC4E@EXAMPLE.COM", "FIRAS.ADELAC4E@EXAMPLE.COM", "AQAAAAEAACcQAAAAENhh4aFgv26rktAhpvNsVyfOpC7o01Eb2+7NIJe/aFJgyAQ+efj/h/4JdRU9Ii0I4w==", "01274387720", false, "99885a2d-69c9-4d29-a531-29cb0ca70197", false, "Firas.Adelac4e@example.com" },
                    { "409c5bd3-ed6b-11ed-b60d-105badc84798", 0, "bc5d938a-a9a9-4058-a5cb-fc5100a7ca13", "Shehabi.Asamib745@example.com", true, "Shehabi", "Asamib745", false, null, "SHEHABI.ASAMIB745@EXAMPLE.COM", "SHEHABI.ASAMIB745@EXAMPLE.COM", "AQAAAAEAACcQAAAAEF6KyzqGUQtUGySEgADumk9kCa0JJilvSx5CC5oo3w6I6n+MJKHDjUfDQZUdFmV1ig==", "01265107277", false, "07a09024-8f90-4049-9007-dc47529978e3", false, "Shehabi.Asamib745@example.com" },
                    { "409c5bd5-ed6b-11ed-92ef-105badc84798", 0, "a4e95cf3-85fa-4ba0-a932-b6009d31f710", "Adam.Ryanbb23@example.com", true, "Adam", "Ryanbb23", false, null, "ADAM.RYANBB23@EXAMPLE.COM", "ADAM.RYANBB23@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBqouFHd7UHF322rkn9RtJKXwwr+hx0koiUo96plqbuEjZ6PLPX+sqTy4MLplttXbQ==", "01230210003", false, "86361619-9ed6-4a2b-b0e6-131926a5666f", false, "Adam.Ryanbb23@example.com" },
                    { "409c5bd7-ed6b-11ed-8e67-105badc84798", 0, "71432196-a5fe-4f17-8e47-c69f61358b9e", "Yunus.Ahmed90cb@example.com", true, "Yunus", "Ahmed90cb", false, null, "YUNUS.AHMED90CB@EXAMPLE.COM", "YUNUS.AHMED90CB@EXAMPLE.COM", "AQAAAAEAACcQAAAAENoi9/fh8boOFPzMXoNFg6INIrQ9ZgdMNuVrfxdhE43wYdk5v/aI3QgR074mJsTLAw==", "01235122474", false, "0e8d3082-aff5-437a-9dd9-a65b8f190719", false, "Yunus.Ahmed90cb@example.com" },
                    { "409c5bd9-ed6b-11ed-aac6-105badc84798", 0, "77c36f81-15df-4f18-9dba-8d7ec15449b1", "Kamel.Hassan8f33@example.com", true, "Kamel", "Hassan8f33", false, null, "KAMEL.HASSAN8F33@EXAMPLE.COM", "KAMEL.HASSAN8F33@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFS1nN3dNhkPaliza00l7e45r7rSEHol6DITqAVgde8Rk6IEyLXnwyJ0ngn3u+1RJQ==", "01243061369", false, "df3b407b-8a99-4846-b010-ac4023db642f", false, "Kamel.Hassan8f33@example.com" },
                    { "409c5bdb-ed6b-11ed-9c54-105badc84798", 0, "f1080045-b1e2-4263-b4aa-d6dc090b48c3", "Sharm.Haor9abe@example.com", true, "Sharm", "Haor9abe", false, null, "SHARM.HAOR9ABE@EXAMPLE.COM", "SHARM.HAOR9ABE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBXCLOqfjQqTQyV5s64cKBY3qWuDEUINJwv2M9bwqA5JSllqTW7nVTmDUNujz+9HEA==", "01256605664", false, "00b32797-3180-4b56-90c4-a8aff9393081", false, "Sharm.Haor9abe@example.com" },
                    { "409c5bdd-ed6b-11ed-9d5b-105badc84798", 0, "141e07e7-8c8a-49f8-b8c1-03fac8a4e184", "Shehabi.Radwanaea9@example.com", true, "Shehabi", "Radwanaea9", false, null, "SHEHABI.RADWANAEA9@EXAMPLE.COM", "SHEHABI.RADWANAEA9@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOI7PulpjNFspi4KTwkEbMsgmoYEe7cZ42NYt2H2khJdDNRTCsFhcQVQM549a9QyCw==", "01247779098", false, "5ea592dd-8f00-4ba5-a22d-11770fb334d4", false, "Shehabi.Radwanaea9@example.com" },
                    { "409c5bdf-ed6b-11ed-8964-105badc84798", 0, "b07a2eab-5138-4a33-b50a-db9b69ecbe87", "Sandsi.Sareea2bb@example.com", true, "Sandsi", "Sareea2bb", false, null, "SANDSI.SAREEA2BB@EXAMPLE.COM", "SANDSI.SAREEA2BB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGa5FioSe3A0mmuMhQgofH+Dnl1xY+CQGPCRdStoUVVUsdcjG3YpDbI2EK+KZcDLZw==", "01295119441", false, "2ebffab0-0519-4ad7-a440-4a6a129b7238", false, "Sandsi.Sareea2bb@example.com" },
                    { "409c5be1-ed6b-11ed-858f-105badc84798", 0, "f7ccf25f-0dc8-4286-99cd-cbc1e8772ea2", "Ryan.Ahmed92cc@example.com", true, "Ryan", "Ahmed92cc", false, null, "RYAN.AHMED92CC@EXAMPLE.COM", "RYAN.AHMED92CC@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOT9asvN3XBYfouYVwJ3qlk3OyjmOX73vtjnZ3gADUWETtD6p3SiOFd8WLcWOAZUQQ==", "01280497409", false, "ca6fe08c-9393-4d6e-ab10-7aeebaddbe4d", false, "Ryan.Ahmed92cc@example.com" },
                    { "409c5be3-ed6b-11ed-a6f1-105badc84798", 0, "c803db25-bdb5-4db3-aa57-55ccf19fcbac", "Jika.Yakon99b9@example.com", true, "Jika", "Yakon99b9", false, null, "JIKA.YAKON99B9@EXAMPLE.COM", "JIKA.YAKON99B9@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAhh2Z5s3BE8etuIA4I2E2/W1Bpm7ZA+n3fIU9HwO9brf4sh96tEqgRpTJDiFjPduA==", "01264045710", false, "0053f168-bd71-47bb-bc5c-cf7d609ce255", false, "Jika.Yakon99b9@example.com" },
                    { "409c5be5-ed6b-11ed-b9bc-105badc84798", 0, "67baf00e-fb7f-41c0-adb3-8c77dc243194", "Salim.Barrab361@example.com", true, "Salim", "Barrab361", false, null, "SALIM.BARRAB361@EXAMPLE.COM", "SALIM.BARRAB361@EXAMPLE.COM", "AQAAAAEAACcQAAAAEI8NA4ikKOp5ChS+TtyfcpCOgeH2K5SLX74CG4h6delRaAsPn2ABAp6v9v1MMXDOeg==", "01249320959", false, "e9002bea-8545-4cf4-8ecd-c79eddd1fc98", false, "Salim.Barrab361@example.com" },
                    { "409c5be7-ed6b-11ed-a4c2-105badc84798", 0, "26303fd1-d7dc-48a4-9071-e94e52234050", "Sajid.Ghanemb2c7@example.com", true, "Sajid", "Ghanemb2c7", false, null, "SAJID.GHANEMB2C7@EXAMPLE.COM", "SAJID.GHANEMB2C7@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOzBzGsAkrzMwvFFlXgWYPBQiMP4hBSkmAbnBXo/qv5QkbKKlC0JLigcJfNECjmKvA==", "01277246579", false, "3568599f-7984-4eeb-a92a-987df69293c5", false, "Sajid.Ghanemb2c7@example.com" },
                    { "409c5be9-ed6b-11ed-84f0-105badc84798", 0, "6dd1a743-b91f-4353-8e16-5ca31f8ab7fa", "Abi.Naharbab5@example.com", true, "Abi", "Naharbab5", false, null, "ABI.NAHARBAB5@EXAMPLE.COM", "ABI.NAHARBAB5@EXAMPLE.COM", "AQAAAAEAACcQAAAAENrlYPrW9urEBatK8LpREb9MovA+K0xsCjPdqzltL6ZE+ibfeAkMtg/nSaZNmm6+CA==", "01229234023", false, "d6aa596d-1f68-42b7-aee5-5d9ebd081970", false, "Abi.Naharbab5@example.com" },
                    { "409c5beb-ed6b-11ed-9119-105badc84798", 0, "681c3c35-5356-4eca-aefa-2fdd26a04200", "Sheikhy.Bahib9c1@example.com", true, "Sheikhy", "Bahib9c1", false, null, "SHEIKHY.BAHIB9C1@EXAMPLE.COM", "SHEIKHY.BAHIB9C1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEbdpknfwYa+rT95PBYS0TmSRRTSLeoPESHBMkK2OTBLbHIlUtl16tL6I7/h7Rp6bw==", "01253380211", false, "846e8d75-01a6-495a-bdaa-cee6f05f4d36", false, "Sheikhy.Bahib9c1@example.com" },
                    { "409c5bed-ed6b-11ed-b13d-105badc84798", 0, "7755f695-f7d2-44f9-83e6-999a58ad309a", "Russell.Noor98e2@example.com", true, "Russell", "Noor98e2", false, null, "RUSSELL.NOOR98E2@EXAMPLE.COM", "RUSSELL.NOOR98E2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKPpfy2EW3Plhe602DEWLhw5IFLkavTrXcGo7vajpPSVqQ+BUnaYBJyVlZTfRMV2ow==", "01270799028", false, "0b5d2cfc-cb22-457d-b97e-5ea65276757f", false, "Russell.Noor98e2@example.com" },
                    { "409c5bef-ed6b-11ed-a904-105badc84798", 0, "b3a797bd-4a9e-4d4a-af10-00dcb620d147", "Kamel.Turkiac4a@example.com", true, "Kamel", "Turkiac4a", false, null, "KAMEL.TURKIAC4A@EXAMPLE.COM", "KAMEL.TURKIAC4A@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJxXfphssWBVP6X62xBufZzylGhBriDvK50VFoTP6jlEJY/kDpuexLaqSr8dzfCPaw==", "01241657516", false, "f56338a2-f753-4701-86cf-90780028c1e8", false, "Kamel.Turkiac4a@example.com" },
                    { "409c5bf1-ed6b-11ed-88f4-105badc84798", 0, "f8fae9a3-6d2c-4aab-979c-234998bb3297", "Nahar.Ghanemae00@example.com", true, "Nahar", "Ghanemae00", false, null, "NAHAR.GHANEMAE00@EXAMPLE.COM", "NAHAR.GHANEMAE00@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJGg7xv8HzROWedJmn1TqINY1mMjvtlNslPLT5l3Sp9bJKIHsdmtrvhx7gVtT4tc6g==", "01298809343", false, "a9047244-613e-4353-a163-d5d83f2ff0ed", false, "Nahar.Ghanemae00@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "409c5bf3-ed6b-11ed-b6f9-105badc84798", 0, "96c51378-7d31-4958-ada3-f5fe81ad2ba1", "Jawad.Hosni8716@example.com", true, "Jawad", "Hosni8716", false, null, "JAWAD.HOSNI8716@EXAMPLE.COM", "JAWAD.HOSNI8716@EXAMPLE.COM", "AQAAAAEAACcQAAAAEM/bgYkYnt2uRPXneNHh1i6mSsP4j9+KgJp1SuMDnH6lzKgLkhXGcjYS3zZGtTdx2A==", "01234781463", false, "a21347bf-0b27-4a40-baed-df149e312db0", false, "Jawad.Hosni8716@example.com" },
                    { "409c5bf5-ed6b-11ed-b0e0-105badc84798", 0, "c6e1f35f-f1b6-4b24-8aa1-8a2ad9cb7322", "Zaki.Maher89ed@example.com", true, "Zaki", "Maher89ed", false, null, "ZAKI.MAHER89ED@EXAMPLE.COM", "ZAKI.MAHER89ED@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKSf/5p1F/lteahXDtuqq2piOjOiFURDfJFO9cJ3KF1A0QxjOyuYbZBmG3iLwm6VKg==", "01218202776", false, "08443ade-57ce-43b9-9feb-27c45c2349b3", false, "Zaki.Maher89ed@example.com" },
                    { "409d97e6-ed6b-11ed-8b4d-105badc84798", 0, "2e8fa996-9658-4726-ad58-fe68a0274aa0", "Ramzy.Sadenb6a1@example.com", true, "Ramzy", "Sadenb6a1", false, null, "RAMZY.SADENB6A1@EXAMPLE.COM", "RAMZY.SADENB6A1@EXAMPLE.COM", "AQAAAAEAACcQAAAAELQQF/A7v+ygoEWwtxumSkSBsblB4rSzIHgw/KYh9/EjMzPsgluCDfUks9FIZFpoBQ==", "01241175282", false, "1c1bd3ac-a2ca-4f66-8bab-da5276653a9c", false, "Ramzy.Sadenb6a1@example.com" },
                    { "409d97e8-ed6b-11ed-94e7-105badc84798", 0, "7ff40ce3-7947-4617-82ba-63512fbb9564", "Basem.Ryan8fc1@example.com", true, "Basem", "Ryan8fc1", false, null, "BASEM.RYAN8FC1@EXAMPLE.COM", "BASEM.RYAN8FC1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKN7BECY2BwOB3/F+4QCkGKc+o48RZAilIKOL5iIbLPgbpfPi9YIcY8Oc7YNkgzoww==", "01250561427", false, "3cd157b7-9578-453c-8451-a33cffef42d4", false, "Basem.Ryan8fc1@example.com" },
                    { "409d97ea-ed6b-11ed-8bcf-105badc84798", 0, "2a45e566-0296-439f-bf95-3c71c2496502", "Yunus.Latfi8cca@example.com", true, "Yunus", "Latfi8cca", false, null, "YUNUS.LATFI8CCA@EXAMPLE.COM", "YUNUS.LATFI8CCA@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPPmrah2FWcCfJ8r44xQK5dfmsoqBMJXHsR7DkzNSaGgnezdW7KEO1VbcCL6dHYUFw==", "01249864317", false, "603e023a-7b9b-4d02-ab3a-648f11aafb19", false, "Yunus.Latfi8cca@example.com" },
                    { "409d97ec-ed6b-11ed-b463-105badc84798", 0, "4cd3a333-3fbb-4db9-b5c7-d1a3d7b2fb36", "Moses.Idrisb202@example.com", true, "Moses", "Idrisb202", false, null, "MOSES.IDRISB202@EXAMPLE.COM", "MOSES.IDRISB202@EXAMPLE.COM", "AQAAAAEAACcQAAAAECPtU1vdzkGDupQGQ45MZcCLdMR/MAbul5FKrmXcg+Qk0OOKBZyFzehtDOxD9AIPvQ==", "01230711192", false, "3d25cb74-e426-4bb4-9c6e-4cf78c5e9fcb", false, "Moses.Idrisb202@example.com" },
                    { "409d97ee-ed6b-11ed-bbdf-105badc84798", 0, "5bfb5456-7727-4e9c-80ff-b9387fed86a7", "Sheikhy.Ahmedb0a5@example.com", true, "Sheikhy", "Ahmedb0a5", false, null, "SHEIKHY.AHMEDB0A5@EXAMPLE.COM", "SHEIKHY.AHMEDB0A5@EXAMPLE.COM", "AQAAAAEAACcQAAAAENNzJX/WfjZwrFnqhaifjc1v46ARrpFKALkyTzsxfl+08Z4+BWuOaeDNQqhd7XxSPw==", "01231051799", false, "ddb98e1a-1ac2-4e60-a807-f56926b46b77", false, "Sheikhy.Ahmedb0a5@example.com" },
                    { "409d97f0-ed6b-11ed-90bb-105badc84798", 0, "a4290604-8c99-4d62-8536-65064d621af4", "Kafar.Barra8ef2@example.com", true, "Kafar", "Barra8ef2", false, null, "KAFAR.BARRA8EF2@EXAMPLE.COM", "KAFAR.BARRA8EF2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOwksU4BS/1lc+qnDpYKTcpXRicqwtopDOWYVmRzxStlLrMLTuhl8zyJgPvFlxLa7w==", "01239050976", false, "63dcfe29-435c-40da-a8eb-c375eade79a4", false, "Kafar.Barra8ef2@example.com" },
                    { "409d97f2-ed6b-11ed-a6cf-105badc84798", 0, "3b0b01d4-0935-4aca-a083-646a2fbf34e4", "Hamaki.Fahedadad@example.com", true, "Hamaki", "Fahedadad", false, null, "HAMAKI.FAHEDADAD@EXAMPLE.COM", "HAMAKI.FAHEDADAD@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEQ+/EOiZWahly42jO60AKW1OkJe6te6FQZRhQYP+ZiXOwqqlQRIJYF5EAePkEE2JQ==", "01259193188", false, "ac8c743e-93e9-4490-a7d5-9dfb03c4895b", false, "Hamaki.Fahedadad@example.com" },
                    { "409d97f4-ed6b-11ed-bb0c-105badc84798", 0, "e7165091-0859-4b5f-84ac-8afd555b544d", "Hilal.Yamen95c6@example.com", true, "Hilal", "Yamen95c6", false, null, "HILAL.YAMEN95C6@EXAMPLE.COM", "HILAL.YAMEN95C6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEM6DgHhCLm1Osb6kf5M40Go0m5zqr+Rl3oXO2C9X61PJz0CXU0Rrtp/AH6B7cw/img==", "01242866984", false, "8f2e8901-4bd6-4a41-993e-c99b0af042dd", false, "Hilal.Yamen95c6@example.com" },
                    { "409d97f6-ed6b-11ed-a3b6-105badc84798", 0, "8fd8a23b-46d9-423a-becc-baaa1c2812cf", "Hilali.Saree8dd1@example.com", true, "Hilali", "Saree8dd1", false, null, "HILALI.SAREE8DD1@EXAMPLE.COM", "HILALI.SAREE8DD1@EXAMPLE.COM", "AQAAAAEAACcQAAAAECiaT6Z/CKIQHwVd4O7lT7gtLgutnEyRHor0h1PBrDddeJdGXUxuZ/XlfgXrNLj6PQ==", "01223988031", false, "65428991-5fc7-4004-8e27-e1aee016e5b2", false, "Hilali.Saree8dd1@example.com" },
                    { "409d97f8-ed6b-11ed-9814-105badc84798", 0, "b48287f0-195b-45df-a7c2-732438283983", "Idris.Radwan8d0d@example.com", true, "Idris", "Radwan8d0d", false, null, "IDRIS.RADWAN8D0D@EXAMPLE.COM", "IDRIS.RADWAN8D0D@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHqRd+uNigkPdJJx3u4pHaeeiY35Aq3WaGarMbgP8HsH2uGZiWzZkp5RWuvyVjCN0w==", "01271365326", false, "45b237b6-4104-4ae8-9324-e57f172b1edc", false, "Idris.Radwan8d0d@example.com" },
                    { "409d97fa-ed6b-11ed-962d-105badc84798", 0, "5a2524fd-b59a-465c-915b-24e7f1bfc6a6", "Shehabi.Saden97b5@example.com", true, "Shehabi", "Saden97b5", false, null, "SHEHABI.SADEN97B5@EXAMPLE.COM", "SHEHABI.SADEN97B5@EXAMPLE.COM", "AQAAAAEAACcQAAAAEExO8azzcDSixwA5OzzwjFDwGn/AxC8a3NMStmVUDDNdLXGw1/cbCrk+IbKgRrSgrw==", "01273988971", false, "6422b3dc-dc5d-49c1-b67d-67b77771adac", false, "Shehabi.Saden97b5@example.com" },
                    { "409d97fc-ed6b-11ed-aad6-105badc84798", 0, "80add4dd-4b1e-4f6d-806c-b1309bb7f12f", "Wael.Hilal86a3@example.com", true, "Wael", "Hilal86a3", false, null, "WAEL.HILAL86A3@EXAMPLE.COM", "WAEL.HILAL86A3@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFoxAyz/Jkh7whB46lEL9HcGH2awoiRGdxZJezf0UaP6l+3CYvQYyTfVqgrCZpsKIA==", "01251588288", false, "3dee3512-381a-45cc-9d2a-d5d76070e893", false, "Wael.Hilal86a3@example.com" },
                    { "409d97fe-ed6b-11ed-9246-105badc84798", 0, "dd747ef9-9ec1-446c-b03e-b553be0cc0b8", "Baqi.Medhatbcea@example.com", true, "Baqi", "Medhatbcea", false, null, "BAQI.MEDHATBCEA@EXAMPLE.COM", "BAQI.MEDHATBCEA@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAmwNxGJbrvf6I5aqJhlfkQQZRWRDROsn5/658Ib59fu/IlvGgr9529h9ZINKJIttQ==", "01257768133", false, "01a134a9-be87-4365-981a-2613adf99ae9", false, "Baqi.Medhatbcea@example.com" },
                    { "409d9800-ed6b-11ed-a52b-105badc84798", 0, "06cf75a5-fbde-43e7-8709-a70517de5640", "Adli.Mahmoud846c@example.com", true, "Adli", "Mahmoud846c", false, null, "ADLI.MAHMOUD846C@EXAMPLE.COM", "ADLI.MAHMOUD846C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEALU6E5h5SdKrtcNiWSKp7Mwu6rdrUmCVHL5bdZUjg6B1zdxB7esbVH5FzMpISydVw==", "01217209345", false, "9191fba6-12de-4bdc-bfcb-f24625f07142", false, "Adli.Mahmoud846c@example.com" },
                    { "409d9802-ed6b-11ed-bc09-105badc84798", 0, "a42c5ed3-a4b0-4be1-a76c-8b03b61fcdd8", "Yusuf.Asima639@example.com", true, "Yusuf", "Asima639", false, null, "YUSUF.ASIMA639@EXAMPLE.COM", "YUSUF.ASIMA639@EXAMPLE.COM", "AQAAAAEAACcQAAAAECR51hX/68pD3Kbl1v9QqxNJlswrz+N2xKovareoDWsl5IkfZ6iSTUZUQOH9PhnhzQ==", "01296814946", false, "788dcc57-7cf7-4eab-8568-78760c6ce490", false, "Yusuf.Asima639@example.com" },
                    { "409d9804-ed6b-11ed-acac-105badc84798", 0, "d55c19ac-b7bd-421f-872f-57f3a3915675", "Sheila.Horr81d8@example.com", true, "Sheila", "Horr81d8", false, null, "SHEILA.HORR81D8@EXAMPLE.COM", "SHEILA.HORR81D8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEB89pP4wOg5/4wwd7Ag2ppmWmyZFXVInox6zS9mqijLwWik3ZnYwGqNopaghEOz7zg==", "01292085322", false, "668d58fb-6c48-485a-9e41-0ea97bf26877", false, "Sheila.Horr81d8@example.com" },
                    { "409d9806-ed6b-11ed-bd30-105badc84798", 0, "92c442a9-c973-426b-8591-92a47681fda8", "Hamza.Horr8273@example.com", true, "Hamza", "Horr8273", false, null, "HAMZA.HORR8273@EXAMPLE.COM", "HAMZA.HORR8273@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAjJluZipAtGxv58GBud0gcVqhlE3DOu10SilrinXBuMsiBqxkgcj60uOlV/8zH3BA==", "01228938716", false, "8a460b09-1d49-44cd-b41d-39e5e46afce5", false, "Hamza.Horr8273@example.com" },
                    { "409d9808-ed6b-11ed-ad60-105badc84798", 0, "4371fcd4-262a-4889-9262-99b845dab6ec", "Hamaqy.Kamel9d6c@example.com", true, "Hamaqy", "Kamel9d6c", false, null, "HAMAQY.KAMEL9D6C@EXAMPLE.COM", "HAMAQY.KAMEL9D6C@EXAMPLE.COM", "AQAAAAEAACcQAAAAECoUQRfoSpqEpt8JfbMCNFVUyXFf+/VDmmfNV4RNXoWJdVtnMpBLIONGwWooet5LJw==", "01299940571", false, "550794cf-9de8-4a51-be79-571c6884ee95", false, "Hamaqy.Kamel9d6c@example.com" },
                    { "409d980a-ed6b-11ed-8f53-105badc84798", 0, "ba3e352f-7e2e-42ff-9739-b20218eda761", "Sameh.Bacari9f4c@example.com", true, "Sameh", "Bacari9f4c", false, null, "SAMEH.BACARI9F4C@EXAMPLE.COM", "SAMEH.BACARI9F4C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDZkvsBFec5pWTF4QIb+VwiQlHBRpHuH8qlL793XcvmQgIKyOukC3Ei6QvWT8ccZGQ==", "01236833834", false, "b6804553-1aed-4135-9f65-3a42d0eedf7b", false, "Sameh.Bacari9f4c@example.com" },
                    { "409d980c-ed6b-11ed-ab6a-105badc84798", 0, "8f945600-744c-4ea8-88f7-9e20bcc09ae7", "Zachariah.Yusufbeab@example.com", true, "Zachariah", "Yusufbeab", false, null, "ZACHARIAH.YUSUFBEAB@EXAMPLE.COM", "ZACHARIAH.YUSUFBEAB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKJFOydopT3+i56Dhl9Js/qbgORTym47SbvPJHqeeci2HMEX5xoTgMXGw6wXXQak9Q==", "01229346313", false, "8f7252a5-86d5-4013-94e4-195fc8e1efd2", false, "Zachariah.Yusufbeab@example.com" },
                    { "409d980e-ed6b-11ed-a002-105badc84798", 0, "3d5b5188-3260-4358-acf9-88ff546b6ee1", "Russell.Fadiba6b@example.com", true, "Russell", "Fadiba6b", false, null, "RUSSELL.FADIBA6B@EXAMPLE.COM", "RUSSELL.FADIBA6B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKYFtDQvnyZwPpSn2R2UK0yg/ytNWVCSXCV0ufNr3fngHyEPn+w1WExf8izWXzjzkQ==", "01258205230", false, "e9733d11-8920-4ef9-ba08-c1390a2cd692", false, "Russell.Fadiba6b@example.com" },
                    { "409d9810-ed6b-11ed-8ef2-105badc84798", 0, "db794009-f356-476a-b469-e5e5d2639ca4", "Marawan.Hamaki922c@example.com", true, "Marawan", "Hamaki922c", false, null, "MARAWAN.HAMAKI922C@EXAMPLE.COM", "MARAWAN.HAMAKI922C@EXAMPLE.COM", "AQAAAAEAACcQAAAAELn16fs/UyLOagdaY+FNC26yiOBSvWXQ9LwRJlFUA26o3DczzftfDk9LsXMpgRBM2g==", "01226919350", false, "e8cec2d2-8f90-4831-a2a9-aabedfdaed2b", false, "Marawan.Hamaki922c@example.com" },
                    { "409d9812-ed6b-11ed-9c48-105badc84798", 0, "eca581a1-c590-45a6-9bdc-d7a688cdb3de", "Halsi.Yisria65f@example.com", true, "Halsi", "Yisria65f", false, null, "HALSI.YISRIA65F@EXAMPLE.COM", "HALSI.YISRIA65F@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGCyBhaeTbZlHDz1U1QCYdn71uT/Bpazw+/tH9syj8jxNxELRFdCzc+4qK/8nT2yGQ==", "01270619764", false, "d054ac21-afbd-4359-a172-2b7cac1efa99", false, "Halsi.Yisria65f@example.com" },
                    { "409d9814-ed6b-11ed-b1a5-105badc84798", 0, "578b6cb7-5848-47f7-8626-bd60a800be4e", "Ghaith.Saber952b@example.com", true, "Ghaith", "Saber952b", false, null, "GHAITH.SABER952B@EXAMPLE.COM", "GHAITH.SABER952B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEA0rDSiEXaiOisTqY401huHph7Gtm1IfvOhEOIcdy+hwNRtX2U8pn6W+IO/CiaEjhQ==", "01252978322", false, "920c835d-4ef4-4ebb-b8ed-4d554e6df775", false, "Ghaith.Saber952b@example.com" },
                    { "409d9816-ed6b-11ed-a024-105badc84798", 0, "1d101a69-d3a3-4b47-bd91-a16400ecefbd", "Ramzy.Sheikhy9b83@example.com", true, "Ramzy", "Sheikhy9b83", false, null, "RAMZY.SHEIKHY9B83@EXAMPLE.COM", "RAMZY.SHEIKHY9B83@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBAiQWlm3KC42rlU4RMCNHk1vQU0z92BzL6n4YS4npwWpGeFXJzuXVOxyy0UFgyabw==", "01214168755", false, "a5904df0-6f66-486b-98be-9da97f13de23", false, "Ramzy.Sheikhy9b83@example.com" },
                    { "409d9818-ed6b-11ed-a744-105badc84798", 0, "b993e56e-29fd-40c2-b91c-a48d51e294d1", "Loay.Zaki8b60@example.com", true, "Loay", "Zaki8b60", false, null, "LOAY.ZAKI8B60@EXAMPLE.COM", "LOAY.ZAKI8B60@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJ1dk5PxDPW5ohP/zGt6ObYRthEEUYqDKb3ITi7r1a9Aovs2oW2ryKBtDtIG4yvJGA==", "01235082209", false, "872b4945-00a9-4ebd-83c7-e096a7ef525f", false, "Loay.Zaki8b60@example.com" },
                    { "409d981a-ed6b-11ed-8cc2-105badc84798", 0, "7b0a4b0b-4b91-4504-8935-31d00559d595", "Sharm.Saber98d6@example.com", true, "Sharm", "Saber98d6", false, null, "SHARM.SABER98D6@EXAMPLE.COM", "SHARM.SABER98D6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJae+i2h1MDwjyF2z9EMycB5CehMUdKsn5/X6D1A0FAkHTKJeEIOI0IS2cMQm3Mmkg==", "01286278436", false, "0166148a-a78d-45a6-ba62-38bbca1c15e0", false, "Sharm.Saber98d6@example.com" },
                    { "409d981c-ed6b-11ed-a136-105badc84798", 0, "de54c9d6-0aa7-486b-b64e-6968c59f91e1", "Faisal.Hilal8943@example.com", true, "Faisal", "Hilal8943", false, null, "FAISAL.HILAL8943@EXAMPLE.COM", "FAISAL.HILAL8943@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJKfoCPQR0mejPEV01MZYi3ZeKnfdIP6EmPbBVkVdQ+zeY+js1mCuloM34ydR/ic4A==", "01240227176", false, "a51ba914-a78e-4e22-9d6d-b103e56d346b", false, "Faisal.Hilal8943@example.com" },
                    { "409d981e-ed6b-11ed-b364-105badc84798", 0, "11017b6a-ab46-4dee-a4b0-8d655c487da7", "Dagher.Dagher9fe6@example.com", true, "Dagher", "Dagher9fe6", false, null, "DAGHER.DAGHER9FE6@EXAMPLE.COM", "DAGHER.DAGHER9FE6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEB7xDxyjJ1Q09hOBg8QGhwEDmZbbFEFivRI9kePZWUB8+7QLxFISmPTyhnGZjriBGg==", "01217001819", false, "276dfe25-993e-4d69-9132-ed2504169e29", false, "Dagher.Dagher9fe6@example.com" },
                    { "409d9820-ed6b-11ed-b8a4-105badc84798", 0, "ea024779-c1de-4c2f-8384-588fa796b1b8", "Kahter.Kafarb2a1@example.com", true, "Kahter", "Kafarb2a1", false, null, "KAHTER.KAFARB2A1@EXAMPLE.COM", "KAHTER.KAFARB2A1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOztmHv8J9oIARIM5rdKDWqhHVzOpvaO8W5WBvlNMo4GoxvMk0EFtmkB36LzhZextg==", "01271704772", false, "17507a1a-953c-443f-b642-effc6c9493e6", false, "Kahter.Kafarb2a1@example.com" },
                    { "409d9822-ed6b-11ed-b007-105badc84798", 0, "5202da93-d66c-4232-b1aa-745bb96aeb7d", "Russell.Barra8660@example.com", true, "Russell", "Barra8660", false, null, "RUSSELL.BARRA8660@EXAMPLE.COM", "RUSSELL.BARRA8660@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBtyB57WNXGWCjM7zhnFFNvWOsdGmtXu/u1JDpd0XPpH9toZIBRlpS74sBqHHQr13A==", "01278117140", false, "b77bd875-dc9a-408d-86c5-a18bbb8ab15b", false, "Russell.Barra8660@example.com" },
                    { "409d9824-ed6b-11ed-b245-105badc84798", 0, "f9c9f305-8029-4cae-afe0-96a30f7a5785", "Samher.Sharmb774@example.com", true, "Samher", "Sharmb774", false, null, "SAMHER.SHARMB774@EXAMPLE.COM", "SAMHER.SHARMB774@EXAMPLE.COM", "AQAAAAEAACcQAAAAEK7AkehcuvTJeTsY/UkRVw6d/S9gW0WsLDHT0JUvfu2Y9X8f7wBhCvatfku5p9fSLw==", "01253529119", false, "68c59973-1a6d-4e17-bbef-9a8319345d56", false, "Samher.Sharmb774@example.com" },
                    { "409d9826-ed6b-11ed-903e-105badc84798", 0, "a8641340-35c2-4aca-a6a7-d3fc39f246db", "Asim.Sadenb632@example.com", true, "Asim", "Sadenb632", false, null, "ASIM.SADENB632@EXAMPLE.COM", "ASIM.SADENB632@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKvR0yLxQvQxaotzllzuKopaFsly2S7NESa3wPFvVnHjyCavxJIB31P+9Ge01PNhpA==", "01214486306", false, "f457ef16-4527-4c4b-af62-e5d90647cb73", false, "Asim.Sadenb632@example.com" },
                    { "409d9828-ed6b-11ed-8629-105badc84798", 0, "471c8450-35e1-4b83-8d60-f457d98f5523", "Halsi.Maherbb85@example.com", true, "Halsi", "Maherbb85", false, null, "HALSI.MAHERBB85@EXAMPLE.COM", "HALSI.MAHERBB85@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFaF9mf7lRfhBJfWrkZHoCgBU8+Rdd3tsIRm4mrKF9MEShhwB/Ox0F1cxE8iZRZ0xg==", "01287150961", false, "4b1de0a5-5b77-4431-ba7c-34f49ed85912", false, "Halsi.Maherbb85@example.com" },
                    { "409d982a-ed6b-11ed-b3f7-105badc84798", 0, "69f94eab-1792-4add-8da1-a1a1c3facaf2", "Jawad.Fahedb924@example.com", true, "Jawad", "Fahedb924", false, null, "JAWAD.FAHEDB924@EXAMPLE.COM", "JAWAD.FAHEDB924@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMr+yfHei4y3jVvb2DkwJ116XTFWd49OEHkn9I6psWuhpFqT1bGFGVBj2JCokvbT+w==", "01287718327", false, "0fce2511-e4de-4b8d-8be6-0a9085ef987f", false, "Jawad.Fahedb924@example.com" },
                    { "409d982c-ed6b-11ed-9084-105badc84798", 0, "9baa0a3e-a6ed-4439-9503-af2096367307", "Dagher.Sameh899e@example.com", true, "Dagher", "Sameh899e", false, null, "DAGHER.SAMEH899E@EXAMPLE.COM", "DAGHER.SAMEH899E@EXAMPLE.COM", "AQAAAAEAACcQAAAAEE0N7w68Y46icwSwJluFML/2Wk1hlwY92pvNjiT3nXKNFXaFQpq3/x9ONdFLDruS5A==", "01229621962", false, "7857e4f3-d342-4c0b-b1b9-059b869edc37", false, "Dagher.Sameh899e@example.com" },
                    { "409d982e-ed6b-11ed-8e42-105badc84798", 0, "dc734f52-c8b1-401c-9c10-4b64376067c4", "Fidaa.Faisalaef2@example.com", true, "Fidaa", "Faisalaef2", false, null, "FIDAA.FAISALAEF2@EXAMPLE.COM", "FIDAA.FAISALAEF2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEB6drwXmMHDtFa1uBoWVRZYW+ThGFa2teihAMOcrHRP2Z4ZGA7hX/n2oir4MVOoJLQ==", "01239399918", false, "335dd73c-4e7e-45b0-8645-266abd00d19f", false, "Fidaa.Faisalaef2@example.com" },
                    { "409d9830-ed6b-11ed-abc8-105badc84798", 0, "43baa155-302d-47ad-9dd8-f424d07b0755", "Yad.Jika853c@example.com", true, "Yad", "Jika853c", false, null, "YAD.JIKA853C@EXAMPLE.COM", "YAD.JIKA853C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEcssEFpmYBHjovbs9mlIp8yT/RMBmP4tj0hcxjgb9fR/Y4WSvcG/b532Psg6+WTdg==", "01273014929", false, "caf291a1-5c3e-4810-a5b5-863132a8ab00", false, "Yad.Jika853c@example.com" },
                    { "409d9832-ed6b-11ed-8176-105badc84798", 0, "b4963bb6-8a85-4982-a119-43275d2a781d", "Dagher.Sheilaaa3b@example.com", true, "Dagher", "Sheilaaa3b", false, null, "DAGHER.SHEILAAA3B@EXAMPLE.COM", "DAGHER.SHEILAAA3B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMqRR6UZFX9KUCQ//ydVc8ku4OFQ1vTpR6xF24RDYcVSwjVHA/tYDSol/SXsJ+p96g==", "01271168271", false, "0567297f-0c26-4231-b674-f12a114bea70", false, "Dagher.Sheilaaa3b@example.com" },
                    { "409d9834-ed6b-11ed-883a-105badc84798", 0, "57b73f26-422f-4cae-a923-813058feafb4", "Ghaith.Adela089@example.com", true, "Ghaith", "Adela089", false, null, "GHAITH.ADELA089@EXAMPLE.COM", "GHAITH.ADELA089@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPuDHOeXh+ZEwdfj67GQQyfdxRvW8mm//DJuPwa2/3fi92uVCoinyRPj2bkNgl25Qw==", "01240257375", false, "f7c085ad-3702-42ad-8bef-6b985baf6aa2", false, "Ghaith.Adela089@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "409d9836-ed6b-11ed-8979-105badc84798", 0, "a1860f2b-2493-4cf5-b6ef-c82ce22d3216", "Ryan.Ramzybdbf@example.com", true, "Ryan", "Ramzybdbf", false, null, "RYAN.RAMZYBDBF@EXAMPLE.COM", "RYAN.RAMZYBDBF@EXAMPLE.COM", "AQAAAAEAACcQAAAAENX1FHFenLifYkN/P91pD4K4gxsMffje1MV0IYSeRKswgBpTey1na6DlvTXetV5GPw==", "01282509863", false, "222dab10-cd49-495b-aaaf-e2e8dc938509", false, "Ryan.Ramzybdbf@example.com" },
                    { "409d9838-ed6b-11ed-ac79-105badc84798", 0, "0f5b8cef-ab62-4c21-bb1d-6dfebe527874", "Bacari.Firasa5e7@example.com", true, "Bacari", "Firasa5e7", false, null, "BACARI.FIRASA5E7@EXAMPLE.COM", "BACARI.FIRASA5E7@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPqyQnBf5uXtJjsCTfbReUjw2fF87z4MYLnIBU2dGDz+vTdc0IGgq+CJdwuSMD4EBQ==", "01265289814", false, "5a74a566-4320-43a3-9861-b3a7778e7f73", false, "Bacari.Firasa5e7@example.com" },
                    { "409d983a-ed6b-11ed-890c-105badc84798", 0, "606ee0e7-e7f0-4a60-95af-738f69428a39", "Fares.Radwana0b0@example.com", true, "Fares", "Radwana0b0", false, null, "FARES.RADWANA0B0@EXAMPLE.COM", "FARES.RADWANA0B0@EXAMPLE.COM", "AQAAAAEAACcQAAAAEExaL9fhQMpO6dO5H9TSa9sIAe+rUMPtGyX8uNEzlGc+qUtJFbPvDqMa80wEpsRcEg==", "01231166131", false, "92aae360-9cd4-44e0-a567-5f618f67ae7a", false, "Fares.Radwana0b0@example.com" },
                    { "4A8CA884-C093-43C4-A019-EE6D804BF85E", 0, "bd34050f-230d-43d5-8c9c-1a0f6bab6875", "mosad53@gmail.com", true, "Mossad", "Gomaa", false, null, "MOSAD53@GMAIL.COM", "MOSAD53@GMAIL.COM", "AQAAAAEAACcQAAAAEC65pq3LOTUbvtuY+tyeaKabxis8J6fT0tRpGuCosUF2RHjszEFbsn3gatKD7okRlw==", "+201211820083", false, "48dd0bce-227a-4ab5-a3e6-40114797c2d2", false, "mosad53@gmail.com" },
                    { "5AAFE5DF-CB75-4DFA-898A-9A1C4E9BB5A5", 0, "fbc24499-a067-4dd2-8716-8b9182923dce", "mosad5@gmail.com", true, "Mossad", "Ahmed", false, null, "MOSAD5@GMAIL.COM", "MOSAD5@GMAIL.COM", "AQAAAAEAACcQAAAAECLCWH+Le1AejkFsDzheOk30ugWsDOzKFdQBX7iZuchl0uNb4DGJCzppsabikgOpYg==", "+201211820083", false, "ee6921ad-f5a2-4df7-aa06-816016538538", false, "mosad5@gmail.com" },
                    { "69E0E900-6DE2-45E8-85CA-583B32C5C5AA", 0, "8f51e100-24d4-49b1-a1b8-5563d6e255bf", "jane.doe@example.com", true, "Jane", "Doe", false, null, "JANE.DOE@EXAMPLE.COM", "JANE.DOE@EXAMPLE.COM", "AQAAAAEAACcQAAAAECt48kYUz18hYQwfSZ21OyXdGSYLU52ni5AbcyAyCV0FtFHTUibSME8HeCHmXroerA==", "01203993009", false, "c0eb622d-49ef-4f65-a8fd-5ca163d0b553", false, "jane.doe@example.com" },
                    { "706870e9-e373-11ed-b719-105badc84798", 0, "040fbf7e-d80e-43b4-b366-87f749c41347", "Mo.Zi@example.com", true, "Mo", "Zi", false, null, "MO.ZI@EXAMPLE.COM", "MO.ZI@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJGL8iLVq+s6xrkJID3poiBTaJDKQ6WHaPGGaeza433PwBgyeNkffZGYAMt6nePMdg==", "01279426209", false, "32a6bfaa-20f7-465f-aa36-6789fb0fcbbe", false, "Mo.Zi@example.com" },
                    { "706b3236-e373-11ed-a003-105badc84798", 0, "cc902ebe-f469-41ad-ab59-ac75256f33eb", "Majdi.Fares@example.com", true, "Majdi", "Fares", false, null, "MAJDI.FARES@EXAMPLE.COM", "MAJDI.FARES@EXAMPLE.COM", "AQAAAAEAACcQAAAAENbHvdyV6BQYJQ6O82ZfUirCw7AMwjH3P/KuWgfxDEx8TUdnP0PkzyEq9Dsexw8pyQ==", "01270867190", false, "ef623ad7-b590-4e5e-954e-625a1f61a139", false, "Majdi.Fares@example.com" },
                    { "706b3237-e373-11ed-988f-105badc84798", 0, "b2a0c34e-c75c-4644-ac36-5086bea5f126", "Hamza.Yisri@example.com", true, "Hamza", "Yisri", false, null, "HAMZA.YISRI@EXAMPLE.COM", "HAMZA.YISRI@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDNwpNMF/DEwoIrlKkw8TZIYpOvK+cAgnbk6Y8Rd4Wcntbxt16kWdOoK60hGuY5TLQ==", "01256543256", false, "11d9f57d-ef38-4825-8c83-f5a6abb6fac7", false, "Hamza.Yisri@example.com" },
                    { "7A369173-1E2F-491F-874F-7B324C034BC2", 0, "51d1428f-eafc-4c43-87d2-530dee953595", "bob.smith@example.com", true, "Bob", "Smith", false, null, "BOB.SMITH@EXAMPLE.COM", "BOB.SMITH@EXAMPLE.COM", "AQAAAAEAACcQAAAAEH73W80ITUlprelFN9tUMqo2ixQZehC+ksseGUSsFQCnD5HqsX2YLwy8iM67tEus2w==", "011234356789", false, "3f7e26b4-c7c4-4bc8-a715-34dee35c9c24", false, "bob.smith@example.com" },
                    { "99328045-8ECF-40A1-9F0B-0DEA6398F09A", 0, "be0c4096-c604-4891-be83-f642a4c28a81", "john.doe@example.com", true, "John", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEK6s0xqUkAUc1nStEYrVphw60ZSq3CsSUgvMelaE10z+TqgkXZ4XClHfU5KYAJqIg==", "01239931230", false, "b7f5c169-21d0-4a88-9634-81d6989a42e4", false, "john.doe@example.com" },
                    { "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2", 0, "6ba3c70d-1d77-457f-9cb7-6c447b783192", "sara.jones@example.com", true, "Sara", "Jones", false, null, "SARA.JONES@EXAMPLE.COM", "SARA.JONES@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKDGxyDGvAO2SYgOKGHwrUC1Az9px9ZbKkzKC0hpeQsmspiwJk20WBllxJ7tCak3dQ==", "010765432231", false, "a4395723-2371-43e2-817d-21d957db4584", false, "sara.jones@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4093fa25-ed6b-11ed-a6df-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4093fa27-ed6b-11ed-8922-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4093fa29-ed6b-11ed-85ba-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4093fa2b-ed6b-11ed-9be9-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4093fa2d-ed6b-11ed-a65f-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676b0-ed6b-11ed-9fd6-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676b2-ed6b-11ed-b62e-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676b4-ed6b-11ed-b886-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676b6-ed6b-11ed-b477-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676b8-ed6b-11ed-9c16-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676ba-ed6b-11ed-adbf-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676bc-ed6b-11ed-9b21-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676be-ed6b-11ed-902b-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676c0-ed6b-11ed-a990-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676c2-ed6b-11ed-a696-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676c4-ed6b-11ed-a637-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "40977647-ed6b-11ed-aad8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "40977649-ed6b-11ed-973e-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097764b-ed6b-11ed-b259-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097973c-ed6b-11ed-9913-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097973e-ed6b-11ed-929c-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "40979740-ed6b-11ed-8c11-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "40979742-ed6b-11ed-b3de-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "40979744-ed6b-11ed-8abc-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097c4fc-ed6b-11ed-84e8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097c4fe-ed6b-11ed-b56a-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097c500-ed6b-11ed-b1ae-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8e5-ed6b-11ed-8a0f-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8e7-ed6b-11ed-b377-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8e9-ed6b-11ed-83d1-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8eb-ed6b-11ed-8f98-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8ed-ed6b-11ed-9f99-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8ef-ed6b-11ed-8cd4-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8f1-ed6b-11ed-aa86-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8f3-ed6b-11ed-9479-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8f5-ed6b-11ed-aca2-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8f7-ed6b-11ed-98e4-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8f9-ed6b-11ed-8f23-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8fb-ed6b-11ed-b285-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8fd-ed6b-11ed-b6a3-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8ff-ed6b-11ed-85f9-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d901-ed6b-11ed-9297-105badc84798" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d903-ed6b-11ed-855f-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d905-ed6b-11ed-b302-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d907-ed6b-11ed-b6b6-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d909-ed6b-11ed-93d8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d90b-ed6b-11ed-a99b-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d90d-ed6b-11ed-956f-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d90f-ed6b-11ed-a0cc-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d911-ed6b-11ed-b614-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d913-ed6b-11ed-816e-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d915-ed6b-11ed-a890-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b15b-ed6b-11ed-9dc2-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b15d-ed6b-11ed-8903-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b15f-ed6b-11ed-a7e2-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b161-ed6b-11ed-b0d0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b163-ed6b-11ed-b901-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b165-ed6b-11ed-a2fd-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b167-ed6b-11ed-9dcf-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b169-ed6b-11ed-9b69-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b16b-ed6b-11ed-bc54-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b16d-ed6b-11ed-abd9-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b16f-ed6b-11ed-ae81-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b171-ed6b-11ed-bd08-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b173-ed6b-11ed-9e0c-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b175-ed6b-11ed-a3d4-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b177-ed6b-11ed-b8db-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b179-ed6b-11ed-acd6-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b17b-ed6b-11ed-bfb2-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b17d-ed6b-11ed-a36b-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b17f-ed6b-11ed-9639-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b181-ed6b-11ed-84ef-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b183-ed6b-11ed-91ba-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b185-ed6b-11ed-a00a-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b187-ed6b-11ed-911e-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b189-ed6b-11ed-97ff-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b18b-ed6b-11ed-9c96-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b18d-ed6b-11ed-86a0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b18f-ed6b-11ed-9b38-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b191-ed6b-11ed-87ba-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b193-ed6b-11ed-b6af-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b195-ed6b-11ed-a317-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b197-ed6b-11ed-a380-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b199-ed6b-11ed-bf11-105badc84798" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b19b-ed6b-11ed-9acc-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b19d-ed6b-11ed-9edb-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b19f-ed6b-11ed-8419-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b1a1-ed6b-11ed-abac-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b1a3-ed6b-11ed-a583-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b1a5-ed6b-11ed-bf0d-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b1a7-ed6b-11ed-bd68-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9d3-ed6b-11ed-b4e8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9d5-ed6b-11ed-8061-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9d7-ed6b-11ed-976d-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9d9-ed6b-11ed-bca8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9db-ed6b-11ed-9009-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9dd-ed6b-11ed-8e81-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9df-ed6b-11ed-bb40-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9e1-ed6b-11ed-b492-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9e3-ed6b-11ed-92d1-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9e5-ed6b-11ed-b38a-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9e7-ed6b-11ed-9432-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9e9-ed6b-11ed-af1e-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9eb-ed6b-11ed-8d45-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9ed-ed6b-11ed-8755-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9ef-ed6b-11ed-a4a1-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9f1-ed6b-11ed-b017-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9f3-ed6b-11ed-92c8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9f5-ed6b-11ed-9bbb-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9f7-ed6b-11ed-aa9d-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9f9-ed6b-11ed-8af4-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9fb-ed6b-11ed-88c6-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9fd-ed6b-11ed-a891-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9ff-ed6b-11ed-a802-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea01-ed6b-11ed-a7d5-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea03-ed6b-11ed-9ac8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea05-ed6b-11ed-b96b-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea07-ed6b-11ed-9c9b-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea09-ed6b-11ed-9690-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea0b-ed6b-11ed-b0ef-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea0d-ed6b-11ed-aa2b-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea0f-ed6b-11ed-9d4e-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea11-ed6b-11ed-8a4f-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea13-ed6b-11ed-839a-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea15-ed6b-11ed-8dbe-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea17-ed6b-11ed-bb52-105badc84798" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea19-ed6b-11ed-85c8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea1b-ed6b-11ed-b4c0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea1d-ed6b-11ed-a4c6-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea1f-ed6b-11ed-9f62-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2251-ed6b-11ed-9a82-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2253-ed6b-11ed-b650-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2255-ed6b-11ed-87ce-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2257-ed6b-11ed-8f44-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2259-ed6b-11ed-ac78-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b225b-ed6b-11ed-bf67-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b225d-ed6b-11ed-8369-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b225f-ed6b-11ed-8d6a-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2261-ed6b-11ed-b7f8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2263-ed6b-11ed-93b0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2265-ed6b-11ed-8a51-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2267-ed6b-11ed-9ed8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2269-ed6b-11ed-96a1-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b226b-ed6b-11ed-b5d0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b226d-ed6b-11ed-9578-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b226f-ed6b-11ed-af75-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2271-ed6b-11ed-b13a-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2273-ed6b-11ed-984c-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2275-ed6b-11ed-8ea0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2277-ed6b-11ed-a519-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2279-ed6b-11ed-a66d-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b227b-ed6b-11ed-a6a6-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b227d-ed6b-11ed-b8fd-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b227f-ed6b-11ed-9609-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2281-ed6b-11ed-968e-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2283-ed6b-11ed-90f7-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2285-ed6b-11ed-945d-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2287-ed6b-11ed-bdd8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2289-ed6b-11ed-8a33-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b228b-ed6b-11ed-82cb-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b228d-ed6b-11ed-9862-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b228f-ed6b-11ed-bba0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2291-ed6b-11ed-82b0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2293-ed6b-11ed-a281-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2295-ed6b-11ed-a03f-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2297-ed6b-11ed-9620-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2299-ed6b-11ed-8cd7-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b229b-ed6b-11ed-b5e4-105badc84798" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5ba9-ed6b-11ed-a9f0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bab-ed6b-11ed-9ebb-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bad-ed6b-11ed-b06e-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5baf-ed6b-11ed-b43f-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bb1-ed6b-11ed-b22e-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bb3-ed6b-11ed-8aea-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bb5-ed6b-11ed-81ec-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bb7-ed6b-11ed-a54a-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bb9-ed6b-11ed-a374-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bbb-ed6b-11ed-a145-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bbd-ed6b-11ed-a7f3-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bbf-ed6b-11ed-afcf-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bc1-ed6b-11ed-880d-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bc3-ed6b-11ed-b2b0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bc5-ed6b-11ed-9c33-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bc7-ed6b-11ed-a584-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bc9-ed6b-11ed-94df-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bcb-ed6b-11ed-ae48-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bcd-ed6b-11ed-82bc-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bcf-ed6b-11ed-a53b-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bd1-ed6b-11ed-8709-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bd3-ed6b-11ed-b60d-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bd5-ed6b-11ed-92ef-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bd7-ed6b-11ed-8e67-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bd9-ed6b-11ed-aac6-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bdb-ed6b-11ed-9c54-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bdd-ed6b-11ed-9d5b-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bdf-ed6b-11ed-8964-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5be1-ed6b-11ed-858f-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5be3-ed6b-11ed-a6f1-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5be5-ed6b-11ed-b9bc-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5be7-ed6b-11ed-a4c2-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5be9-ed6b-11ed-84f0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5beb-ed6b-11ed-9119-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bed-ed6b-11ed-b13d-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bef-ed6b-11ed-a904-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bf1-ed6b-11ed-88f4-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bf3-ed6b-11ed-b6f9-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bf5-ed6b-11ed-b0e0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97e6-ed6b-11ed-8b4d-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97e8-ed6b-11ed-94e7-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97ea-ed6b-11ed-8bcf-105badc84798" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97ec-ed6b-11ed-b463-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97ee-ed6b-11ed-bbdf-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97f0-ed6b-11ed-90bb-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97f2-ed6b-11ed-a6cf-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97f4-ed6b-11ed-bb0c-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97f6-ed6b-11ed-a3b6-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97f8-ed6b-11ed-9814-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97fa-ed6b-11ed-962d-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97fc-ed6b-11ed-aad6-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97fe-ed6b-11ed-9246-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9800-ed6b-11ed-a52b-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9802-ed6b-11ed-bc09-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9804-ed6b-11ed-acac-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9806-ed6b-11ed-bd30-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9808-ed6b-11ed-ad60-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d980a-ed6b-11ed-8f53-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d980c-ed6b-11ed-ab6a-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d980e-ed6b-11ed-a002-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9810-ed6b-11ed-8ef2-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9812-ed6b-11ed-9c48-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9814-ed6b-11ed-b1a5-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9816-ed6b-11ed-a024-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9818-ed6b-11ed-a744-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d981a-ed6b-11ed-8cc2-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d981c-ed6b-11ed-a136-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d981e-ed6b-11ed-b364-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9820-ed6b-11ed-b8a4-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9822-ed6b-11ed-b007-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9824-ed6b-11ed-b245-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9826-ed6b-11ed-903e-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9828-ed6b-11ed-8629-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d982a-ed6b-11ed-b3f7-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d982c-ed6b-11ed-9084-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d982e-ed6b-11ed-8e42-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9830-ed6b-11ed-abc8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9832-ed6b-11ed-8176-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9834-ed6b-11ed-883a-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9836-ed6b-11ed-8979-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9838-ed6b-11ed-ac79-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d983a-ed6b-11ed-890c-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4A8CA884-C093-43C4-A019-EE6D804BF85E" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "5AAFE5DF-CB75-4DFA-898A-9A1C4E9BB5A5" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "A2523A70-57E3-4B69-A405-F9752517ED62", "69E0E900-6DE2-45E8-85CA-583B32C5C5AA" },
                    { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "706870e9-e373-11ed-b719-105badc84798" },
                    { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "706b3236-e373-11ed-a003-105badc84798" },
                    { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "706b3237-e373-11ed-988f-105badc84798" },
                    { "64F2143D-B896-4355-90D2-AFD22424B234", "7A369173-1E2F-491F-874F-7B324C034BC2" },
                    { "BEA713C7-93D2-4F39-8DC8-18F2F3070779", "99328045-8ECF-40A1-9F0B-0DEA6398F09A" },
                    { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
