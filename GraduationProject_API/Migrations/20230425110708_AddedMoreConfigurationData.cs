using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class AddedMoreConfigurationData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64F2143D-B896-4355-90D2-AFD22424B234",
                column: "ConcurrencyStamp",
                value: "77ce8e21-e632-4e15-987d-4eb14a24be3a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A2523A70-57E3-4B69-A405-F9752517ED62",
                column: "ConcurrencyStamp",
                value: "361068dc-779b-4ddf-a825-7e0667f8e597");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "BEA713C7-93D2-4F39-8DC8-18F2F3070779",
                column: "ConcurrencyStamp",
                value: "b5c81ecf-ebe4-425b-9400-0093723ee82e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E26639C4-7023-4878-A497-FC4B12CFA272",
                column: "ConcurrencyStamp",
                value: "7928ff6c-e767-4548-b8a9-1e6cde8a1134");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7",
                column: "ConcurrencyStamp",
                value: "396bb4d6-b5f5-44a5-8c6e-9d862e36806c");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "A2523A70-57E3-4B69-A405-F9752517ED62", "69E0E900-6DE2-45E8-85CA-583B32C5C5AA" },
                    { "BEA713C7-93D2-4F39-8DC8-18F2F3070779", "99328045-8ECF-40A1-9F0B-0DEA6398F09A" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69E0E900-6DE2-45E8-85CA-583B32C5C5AA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "886699f2-b0c3-48f2-ab86-b72ba22dd19e", "AQAAAAEAACcQAAAAEG8brrSWYdXl1HPtJ0joQxW1v0a28miXoGqfgARfWPac+Mqotpj9h0vb4yWC9Vc+2A==", "dc23656a-b0aa-4f61-89de-b15519f450a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99328045-8ECF-40A1-9F0B-0DEA6398F09A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75dad6c4-43ce-412c-b4f4-e3f104ecc0fb", "AQAAAAEAACcQAAAAEEKdKXIWCPaaD6QuXSqD78GbzjkObleviPj2Uug1CPGSrjolrJ0Me3seL46fyfbHiw==", "818f3563-a3f3-4fff-9cb7-437a287ebac7" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7A369173-1E2F-491F-874F-7B324C034BC2", 0, "29ac8f92-99eb-455c-b7b7-7ab720e630db", "bob.smith@example.com", true, "Bob", "Smith", false, null, "BOB.SMITH@EXAMPLE.COM", "BOB.SMITH@EXAMPLE.COM", "AQAAAAEAACcQAAAAEL0hmY2CJfojig4iHqPqnkKjwiZ7+mtK56ORlVRJwRTyMZf6ScXnYaUa4FIuoDrrwQ==", "011234356789", false, "3cb99e36-df81-4659-9837-7432b0470368", false, "bob.smith@example.com" },
                    { "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2", 0, "6ee6d756-1fba-4a69-b79e-69393d8d4d02", "sara.jones@example.com", true, "Sara", "Jones", false, null, "SARA.JONES@EXAMPLE.COM", "SARA.JONES@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFUF9OhOR8ZOwbNk+HgGbX4kvQZNWYIQM7ZxZAhIII4cRAkmTK3kul6B2uWLXpA9zA==", "010765432231", false, "59162b5c-0c13-47f4-b21d-63e140bbc396", false, "sara.jones@example.com" }
                });

            migrationBuilder.InsertData(
                table: "DepartmentAdmins",
                columns: new[] { "Id", "DepartmentId", "FacultyId", "UniveristyId" },
                values: new object[] { new Guid("7a369173-1e2f-491f-874f-7b324c034bc2"), new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") });

            migrationBuilder.InsertData(
                table: "FacultyAdmins",
                columns: new[] { "Id", "FacultyId", "UniveristyId" },
                values: new object[] { new Guid("69e0e900-6de2-45e8-85ca-583b32c5c5aa"), new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") });

            migrationBuilder.InsertData(
                table: "Professors",
                columns: new[] { "Id", "DepartmentId", "FacultyId", "Rate", "UniveristyId" },
                values: new object[] { new Guid("fdc74ef3-1e3d-4a13-9f19-4e381ce4c3d2"), new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), 0.0, new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") });

            migrationBuilder.InsertData(
                table: "UniversityAdmins",
                columns: new[] { "Id", "UniversityId" },
                values: new object[] { new Guid("99328045-8ecf-40a1-9f0b-0dea6398f09a"), new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "64F2143D-B896-4355-90D2-AFD22424B234", "7A369173-1E2F-491F-874F-7B324C034BC2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "Code", "DepartmentId", "Description", "Name", "ProfessorId", "Rate" },
                values: new object[] { new Guid("40504bb7-1148-4e05-ba84-2a81ffc3b918"), "CS311", new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), "Parallel computing is a subject that focuses on the design and implementation of computing systems that are capable of performing multiple tasks simultaneously. This subject is offered in Damanhour University's Faculty of Computer Science and Information Technology, specifically within the Computer Science Department.", "Parallel Computing", new Guid("fdc74ef3-1e3d-4a13-9f19-4e381ce4c3d2"), 0.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "A2523A70-57E3-4B69-A405-F9752517ED62", "69E0E900-6DE2-45E8-85CA-583B32C5C5AA" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "64F2143D-B896-4355-90D2-AFD22424B234", "7A369173-1E2F-491F-874F-7B324C034BC2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "BEA713C7-93D2-4F39-8DC8-18F2F3070779", "99328045-8ECF-40A1-9F0B-0DEA6398F09A" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2" });

            migrationBuilder.DeleteData(
                table: "DepartmentAdmins",
                keyColumn: "Id",
                keyValue: new Guid("7a369173-1e2f-491f-874f-7b324c034bc2"));

            migrationBuilder.DeleteData(
                table: "FacultyAdmins",
                keyColumn: "Id",
                keyValue: new Guid("69e0e900-6de2-45e8-85ca-583b32c5c5aa"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: new Guid("40504bb7-1148-4e05-ba84-2a81ffc3b918"));

            migrationBuilder.DeleteData(
                table: "UniversityAdmins",
                keyColumn: "Id",
                keyValue: new Guid("99328045-8ecf-40a1-9f0b-0dea6398f09a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7A369173-1E2F-491F-874F-7B324C034BC2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2");

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: new Guid("fdc74ef3-1e3d-4a13-9f19-4e381ce4c3d2"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64F2143D-B896-4355-90D2-AFD22424B234",
                column: "ConcurrencyStamp",
                value: "3cabb67c-566c-48e3-93e6-fcd607535b00");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A2523A70-57E3-4B69-A405-F9752517ED62",
                column: "ConcurrencyStamp",
                value: "9e225b01-cabd-4584-aee6-020ed37e380d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "BEA713C7-93D2-4F39-8DC8-18F2F3070779",
                column: "ConcurrencyStamp",
                value: "048284b9-0fff-4fd5-a2a4-fd9c9c3b44a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E26639C4-7023-4878-A497-FC4B12CFA272",
                column: "ConcurrencyStamp",
                value: "a0978bc5-a1cc-48a8-857c-213d676fb6bd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7",
                column: "ConcurrencyStamp",
                value: "7cedce6b-d70b-4934-921f-3f2e92588e24");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69E0E900-6DE2-45E8-85CA-583B32C5C5AA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "822a4c72-3299-4f2a-8146-6bc67dd179ca", "AQAAAAEAACcQAAAAEEmYBZdYPHjfy2ZpO5f7Rvk3k6tmvhXWHwNj7WwT3g74OxcXY9AZqzaEq8Z0yFPyiA==", "4a28c426-7546-4622-93e9-16f38395ad5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99328045-8ECF-40A1-9F0B-0DEA6398F09A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e17883a-0627-4960-953d-65050a12ab71", "AQAAAAEAACcQAAAAEFM3pxZ+bBL8T+kL4sPysj5IsNDgFaf9kJGqBtX8dKJ7BuPW8NCJAk1VaKkkeXHIAQ==", "a2eaaf23-730a-4915-89a5-4a2ea84d7a50" });
        }
    }
}
