using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class AddedMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: new Guid("fdc74ef3-1e3d-4a13-9f19-4e381ce4c3d2"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64F2143D-B896-4355-90D2-AFD22424B234",
                column: "ConcurrencyStamp",
                value: "92273346-bd6d-4962-a260-237131a2a083");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A2523A70-57E3-4B69-A405-F9752517ED62",
                column: "ConcurrencyStamp",
                value: "5c9c870c-4beb-476f-a030-c767bb7bf245");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "BEA713C7-93D2-4F39-8DC8-18F2F3070779",
                column: "ConcurrencyStamp",
                value: "a970747f-ba92-44d5-ba9b-53ecaa8355e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E26639C4-7023-4878-A497-FC4B12CFA272",
                column: "ConcurrencyStamp",
                value: "7ce626a7-e8dc-4265-8c3b-2c1462192e21");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7",
                column: "ConcurrencyStamp",
                value: "bfe594a4-4a54-498a-9b4d-00f3e46bf947");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69E0E900-6DE2-45E8-85CA-583B32C5C5AA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5aaf736-77ed-4682-b107-03299e89ce9c", "AQAAAAEAACcQAAAAEGELpbOTMQoFIK9oCWCmh0nBRdoSpclkzZPkYcTrKHlJczRd2KhRGlzpOdaEcaDHbw==", "25afd6be-7a1b-42c2-9fcb-7e7a60bed30a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7A369173-1E2F-491F-874F-7B324C034BC2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16006749-1013-44a5-8cbb-d3b0323dbde6", "AQAAAAEAACcQAAAAELYkgqgvLijgM9rk7FVcJ2wHhm0gPv/gYrvs4pJMkwfr2vuIf+f6YNnXDS6Sgqdssw==", "9f91ef98-0efe-46cf-b3c3-b5d0f83206ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99328045-8ECF-40A1-9F0B-0DEA6398F09A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb3bdcbf-4e4d-4c42-b2c0-b041c4e38506", "AQAAAAEAACcQAAAAEGljCJEuwchmgmH+KVgcpML8Z8R4OJhq4nNH0fSkBP8Un4BfDWfHJkXoL9P08o20YA==", "549fe4a6-d5ae-4db3-8a39-c1e305b4f1b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed015ae7-3864-4fbc-8d09-f2351392ce51", "AQAAAAEAACcQAAAAEN22BwbmbJSNdmMRwSPxZjal/9vTrp2cz7hovDwSO78/t2+Im9tnLH3TwtmKb1+qGw==", "fc092dae-1a30-4ffc-b98f-92580d259a93" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "706870e9-e373-11ed-b719-105badc84798", 0, "4589a96f-edb2-4477-8551-e29162649ec6", "Mo.Zi@example.com", true, "Mo", "Zi", false, null, "MO.ZI@EXAMPLE.COM", "MO.ZI@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHnL08e1Lqsn3Yj0+3wViIZb/HmufaR+YpTRTUjYZkc+9fxrqHnwC/yRJOXoQlWAmg==", "01279426209", false, "a1511914-868d-463d-b51e-fad4ed1a3bae", false, "Mo.Zi@example.com" },
                    { "706b3236-e373-11ed-a003-105badc84798", 0, "b8fa43c2-7481-413d-b995-9f27af0d2e52", "Majdi.Fares@example.com", true, "Majdi", "Fares", false, null, "MAJDI.FARES@EXAMPLE.COM", "MAJDI.FARES@EXAMPLE.COM", "AQAAAAEAACcQAAAAELbVXqqT+FMStdMJcWIS1BPdM5zQcLvJvLLRdMXZVEnJr+gQVaaG01PDPNmltQdDsg==", "01270867190", false, "19c07dd0-d24f-43d2-992b-2b4e1a7b7487", false, "Majdi.Fares@example.com" },
                    { "706b3237-e373-11ed-988f-105badc84798", 0, "6d0f4b8c-7c0f-43cc-ba31-6e84fee8a7c7", "Hamza.Yisri@example.com", true, "Hamza", "Yisri", false, null, "HAMZA.YISRI@EXAMPLE.COM", "HAMZA.YISRI@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAr8/YqSm9mNdOEfw/oikuQ3ftOYemHmysHR6t56aC5nyZ5fmD8OyONtMYbMsmj/uw==", "01256543256", false, "fcaefa98-98ca-4e04-a8f9-306306a5dbb3", false, "Hamza.Yisri@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Professors",
                columns: new[] { "Id", "DepartmentId", "FacultyId", "Rate", "UniveristyId" },
                values: new object[,]
                {
                    { new Guid("706870e9-e373-11ed-b719-105badc84798"), new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), 0.0, new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") },
                    { new Guid("706b3236-e373-11ed-a003-105badc84798"), new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), 0.0, new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") },
                    { new Guid("706b3237-e373-11ed-988f-105badc84798"), new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), 0.0, new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "706870e9-e373-11ed-b719-105badc84798" },
                    { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "706b3236-e373-11ed-a003-105badc84798" },
                    { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "706b3237-e373-11ed-988f-105badc84798" }
                });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: new Guid("40504bb7-1148-4e05-ba84-2a81ffc3b918"),
                column: "ProfessorId",
                value: new Guid("706870e9-e373-11ed-b719-105badc84798"));

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "Code", "DepartmentId", "Description", "Name", "ProfessorId", "Rate" },
                values: new object[,]
                {
                    { new Guid("15ee4163-b1d7-4ffd-9357-ae82b0cba7a0"), "CS381", new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), "Capstone Project II is a course offered in the Computer Science Department of Damanhour University's Faculty of Computer Science and Information Technology. This course is designed to provide students with an opportunity to apply the knowledge and skills they have acquired throughout their academic program to a real-world problem or project.", "Capstone Project II", new Guid("706870e9-e373-11ed-b719-105badc84798"), 2.5 },
                    { new Guid("17105397-5aa7-452e-bbb5-26a690c56553"), "CS361", new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), "Intelligent Systems is a subject offered in the Computer Science Department of Damanhour University's Faculty of Computer Science and Information Technology. This course focuses on the design, development, and application of intelligent systems, which are computer systems that can perceive and respond to their environment, learn from experience, and make decisions based on data analysis and reasoning.", "Intelligent Systems", new Guid("706870e9-e373-11ed-b719-105badc84798"), 3.5 },
                    { new Guid("1f80d7c4-3dd1-4365-9420-558e223f0ee6"), "CS352", new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), "Computer Animation is a subject offered in the Computer Science Department of Damanhour University's Faculty of Computer Science and Information Technology. This course focuses on the principles and techniques used in the creation and manipulation of digital animations using computer software.", "Computer Animation", new Guid("706b3237-e373-11ed-988f-105badc84798"), 4.0 },
                    { new Guid("5fecd989-af05-4e8f-80a3-ebda42971bb3"), "CS211", new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), "Introduction to Computer Security is a subject offered by the Computer Science Department at Damanhour University's Faculty of Computer Science and Information Technology. The course provides an overview of the fundamental concepts and principles of computer security, including the protection of computer systems, networks, and data from unauthorized access, theft, damage, and other security threats.", "Introduction to Computer Security", new Guid("706870e9-e373-11ed-b719-105badc84798"), 4.0 },
                    { new Guid("f9d69186-526f-4141-92e0-8d8b29ee347f"), "CS212", new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), "Advanced Database is a subject offered in the Computer Science Department of Damanhour University's Faculty of Computer Science and Information Technology. This course is designed to provide students with an in-depth understanding of advanced concepts and techniques used in database management systems.", "Advanced Database", new Guid("706b3236-e373-11ed-a003-105badc84798"), 3.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "706870e9-e373-11ed-b719-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "706b3236-e373-11ed-a003-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "706b3237-e373-11ed-988f-105badc84798" });

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: new Guid("15ee4163-b1d7-4ffd-9357-ae82b0cba7a0"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: new Guid("17105397-5aa7-452e-bbb5-26a690c56553"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: new Guid("1f80d7c4-3dd1-4365-9420-558e223f0ee6"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: new Guid("5fecd989-af05-4e8f-80a3-ebda42971bb3"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: new Guid("f9d69186-526f-4141-92e0-8d8b29ee347f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706870e9-e373-11ed-b719-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706b3236-e373-11ed-a003-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706b3237-e373-11ed-988f-105badc84798");

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: new Guid("706870e9-e373-11ed-b719-105badc84798"));

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: new Guid("706b3236-e373-11ed-a003-105badc84798"));

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: new Guid("706b3237-e373-11ed-988f-105badc84798"));

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69E0E900-6DE2-45E8-85CA-583B32C5C5AA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "886699f2-b0c3-48f2-ab86-b72ba22dd19e", "AQAAAAEAACcQAAAAEG8brrSWYdXl1HPtJ0joQxW1v0a28miXoGqfgARfWPac+Mqotpj9h0vb4yWC9Vc+2A==", "dc23656a-b0aa-4f61-89de-b15519f450a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7A369173-1E2F-491F-874F-7B324C034BC2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29ac8f92-99eb-455c-b7b7-7ab720e630db", "AQAAAAEAACcQAAAAEL0hmY2CJfojig4iHqPqnkKjwiZ7+mtK56ORlVRJwRTyMZf6ScXnYaUa4FIuoDrrwQ==", "3cb99e36-df81-4659-9837-7432b0470368" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99328045-8ECF-40A1-9F0B-0DEA6398F09A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75dad6c4-43ce-412c-b4f4-e3f104ecc0fb", "AQAAAAEAACcQAAAAEEKdKXIWCPaaD6QuXSqD78GbzjkObleviPj2Uug1CPGSrjolrJ0Me3seL46fyfbHiw==", "818f3563-a3f3-4fff-9cb7-437a287ebac7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ee6d756-1fba-4a69-b79e-69393d8d4d02", "AQAAAAEAACcQAAAAEFUF9OhOR8ZOwbNk+HgGbX4kvQZNWYIQM7ZxZAhIII4cRAkmTK3kul6B2uWLXpA9zA==", "59162b5c-0c13-47f4-b21d-63e140bbc396" });

            migrationBuilder.InsertData(
                table: "Professors",
                columns: new[] { "Id", "DepartmentId", "FacultyId", "Rate", "UniveristyId" },
                values: new object[] { new Guid("fdc74ef3-1e3d-4a13-9f19-4e381ce4c3d2"), new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), 0.0, new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: new Guid("40504bb7-1148-4e05-ba84-2a81ffc3b918"),
                column: "ProfessorId",
                value: new Guid("fdc74ef3-1e3d-4a13-9f19-4e381ce4c3d2"));
        }
    }
}
