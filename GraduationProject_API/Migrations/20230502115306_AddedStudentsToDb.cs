using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class AddedStudentsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64F2143D-B896-4355-90D2-AFD22424B234",
                column: "ConcurrencyStamp",
                value: "5dc80156-f862-45c1-8cee-d3a0593976f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A2523A70-57E3-4B69-A405-F9752517ED62",
                column: "ConcurrencyStamp",
                value: "ce444435-60a7-44a6-a9c2-ae46a6fb3db2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "BEA713C7-93D2-4F39-8DC8-18F2F3070779",
                column: "ConcurrencyStamp",
                value: "ebe90fe2-8f40-4e9d-b6c1-6ee9e6c8b1b6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E26639C4-7023-4878-A497-FC4B12CFA272",
                column: "ConcurrencyStamp",
                value: "3ece682e-c879-403c-b30c-0c1c9e51e7a4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7",
                column: "ConcurrencyStamp",
                value: "b85c3978-26d9-488e-b69a-160d6d57c241");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69E0E900-6DE2-45E8-85CA-583B32C5C5AA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd96776f-81f4-4e69-b2da-a01aaa1e7e3c", "AQAAAAEAACcQAAAAEAj5Auwj3xaU+kJ0sP3fd+1ESuf+Dqm2fNi6fMgeLRGO1Km1HrSjZCAfOo5JkJO0hQ==", "b736c30f-438d-421d-b300-0d63185bb060" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706870e9-e373-11ed-b719-105badc84798",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a959fa4a-8071-4afb-acd6-ab195113f0ce", "AQAAAAEAACcQAAAAEM+Rp705wjPkPrWfvy6jhRXtpwg3rA3DE82+u5J5DTMUwy3FCSiSkAUOo6wgd+HMmA==", "05a108d3-a964-4311-a7d9-5d5bd3514640" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706b3236-e373-11ed-a003-105badc84798",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ed1b2d3-f80c-49f1-93c8-02962aabeab5", "AQAAAAEAACcQAAAAEKF/9WcaHQcA4X8YNW+feXDGe6nkyD8VTStRE6BY+ksGDtfuenIe8nrXQPfY7GmfAw==", "43baa4b1-ea52-47ba-b439-f5f0e674beeb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706b3237-e373-11ed-988f-105badc84798",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5a951d4-d3d1-440a-8244-e2853c4dde46", "AQAAAAEAACcQAAAAEDAYkW+HwRe3H2cCZNluEtkqJLiG9xUESJG6N8mZi/g3q37y4M0xC4n9hBHZ6Aaj5g==", "b9a0a315-4cf9-4369-a17f-8293e3bd264d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7A369173-1E2F-491F-874F-7B324C034BC2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2363cbf5-90b3-464c-be94-f81c1adbb1f6", "AQAAAAEAACcQAAAAEGZNZm6FnmLOOjWwwY1LAFwPnwm7p0OHIdGUdfaSeVqx513mfSVDWgKgkd8FTD6ejg==", "c5308af9-2398-4ead-80de-8154f604a6ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99328045-8ECF-40A1-9F0B-0DEA6398F09A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3c6beb3-0a82-45c2-be07-8ec020223e36", "AQAAAAEAACcQAAAAEE9BSZWo03EGnlXLtCzaSvhLCt4PyPtwIvtOrgd97/6SJEfK7yx0hgwmm9TmNO8SSQ==", "47b5cac4-d0d8-45eb-b8b0-00e225c69d61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b27c0aeb-2a5d-48ff-a2a5-5eff70622fd0", "AQAAAAEAACcQAAAAEA9TAK2LwybyXtcmYXtH4/uzMazELpHftGDgXv5kbl60Xn7ge0t88lO4rF5knuHvCQ==", "ec41452b-ee88-4e2f-9615-54197f837a8e" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4A8CA884-C093-43C4-A019-EE6D804BF85E", 0, "f9cf58de-5438-4471-bbef-fc506cbb962e", "mosad53@gmail.com", true, "Mossad", "Gomaa", false, null, "MOSAD53@GMAIL.COM", "MOSAD53@GMAIL.COM", "AQAAAAEAACcQAAAAEDPHUGa3kDA+jT2b4wbMnYZT+zfbNUIr/SnoI0sRCavya9LghokbUDiP/F0ryUD9rw==", "+201211820083", false, "e93a590d-dab9-41b7-b123-d7ef6276da13", false, "mosad53@gmail.com" },
                    { "5AAFE5DF-CB75-4DFA-898A-9A1C4E9BB5A5", 0, "e48312a7-cd23-48ec-91dd-669c53117faf", "mosad5@gmail.com", true, "Mossad", "Ahmed", false, null, "MOSAD5@GMAIL.COM", "MOSAD5@GMAIL.COM", "AQAAAAEAACcQAAAAEN7BPMQ+vaPkr0BOWCvrZa3TIh51rdasm7vStLWYZkbgojvvyfsYSRIIH5CAy/q6nw==", "+201211820083", false, "9ebeeae5-c04c-4896-8bc8-f759eb53c492", false, "mosad5@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DepartmentId", "FacultyId", "UniveristyId" },
                values: new object[,]
                {
                    { new Guid("4a8ca884-c093-43c4-a019-ee6d804bf85e"), new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") },
                    { new Guid("5aafe5df-cb75-4dfa-898a-9a1c4e9bb5a5"), new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4A8CA884-C093-43C4-A019-EE6D804BF85E" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "5AAFE5DF-CB75-4DFA-898A-9A1C4E9BB5A5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4A8CA884-C093-43C4-A019-EE6D804BF85E" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "5AAFE5DF-CB75-4DFA-898A-9A1C4E9BB5A5" });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("4a8ca884-c093-43c4-a019-ee6d804bf85e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("5aafe5df-cb75-4dfa-898a-9a1c4e9bb5a5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4A8CA884-C093-43C4-A019-EE6D804BF85E");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5AAFE5DF-CB75-4DFA-898A-9A1C4E9BB5A5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64F2143D-B896-4355-90D2-AFD22424B234",
                column: "ConcurrencyStamp",
                value: "0f4193df-d69e-4317-8702-ea09c459d1c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A2523A70-57E3-4B69-A405-F9752517ED62",
                column: "ConcurrencyStamp",
                value: "ddcb2da9-c24b-489d-80d0-eeb99c3e0f59");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "BEA713C7-93D2-4F39-8DC8-18F2F3070779",
                column: "ConcurrencyStamp",
                value: "68ae1123-1a54-4588-9afc-0040a705b4b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E26639C4-7023-4878-A497-FC4B12CFA272",
                column: "ConcurrencyStamp",
                value: "5e0f7030-4239-46c5-a504-ceef74c1a598");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7",
                column: "ConcurrencyStamp",
                value: "2e238b41-35bf-44ab-9564-fe5a85019130");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69E0E900-6DE2-45E8-85CA-583B32C5C5AA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e56ab51b-f166-46c7-babf-c06438a92789", "AQAAAAEAACcQAAAAEOBC+L3wPlCLN4H3scbIcM1ehosXkJfG/Wk+3nDprqHls3OZWi74NvH/iek7k2jWVA==", "c3ee6e83-c731-41d0-a2e1-6383d93ef4dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706870e9-e373-11ed-b719-105badc84798",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed5176be-bded-4d91-8032-a616ff1b460e", "AQAAAAEAACcQAAAAEGrGLBvZMK1sPWSa/Boz7Z+ARVSQ0OPI41wn+N3C58rk5dk/zb2facWoT25kyzj0MQ==", "f005ae10-8955-4286-a158-fb2ab479b405" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706b3236-e373-11ed-a003-105badc84798",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc21448a-aa4f-4b35-8f60-08a851cf2b86", "AQAAAAEAACcQAAAAENZN+qdP3rh24oy2Jo6VJ6QGJpIveX1kjG4bHaHhJzLOEqiyxjeLyI35MyP6lW0S1g==", "2fed3621-53b0-4bbd-bfac-7ab7ff1bff53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706b3237-e373-11ed-988f-105badc84798",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b9ebfe7-36d9-453e-a686-28021cd96021", "AQAAAAEAACcQAAAAENE0c8aZ6u+C+ZlvA2LGObN5cigOWUtvmayaj8o25UsEpxdesPKO7UPUwUdoOXmvLA==", "62d81b09-d435-43ca-a90e-8c4e3f049de7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7A369173-1E2F-491F-874F-7B324C034BC2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d53d139-650c-42c1-9582-2dab5effa8ca", "AQAAAAEAACcQAAAAEHaHzf5wJb2IOCDaryAephsfd0biPqnhYxIZvHUBwHTj9y6FdliUzkHSOFiup4La2g==", "227b993d-b1e2-4a49-9c23-b84c31236752" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99328045-8ECF-40A1-9F0B-0DEA6398F09A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b090413e-cc35-4ce3-820c-39474af5f65c", "AQAAAAEAACcQAAAAEGX2cvdkUKcp8bImtHXn3y8gNbOBg0YQ08JlQcydpwYMZ8rO3fjlqQibpQoBjedReg==", "e85d50c2-a9d8-4d63-b707-1242f17e6e16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6de95299-d6b4-49c8-9fc7-7385dd2cfad8", "AQAAAAEAACcQAAAAEBAMQJ7pSIihY7BPg8BvpMjkaGtbGmv80t7Rnooo/ey1xfpdK8qqFnPnd5Upb18DgA==", "e518457e-21c3-4acd-a448-d62026e7de3f" });
        }
    }
}
