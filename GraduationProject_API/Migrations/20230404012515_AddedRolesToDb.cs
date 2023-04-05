using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d1d9040-651a-47b6-ad50-ca12c76fb0d4", "8b734f46-b971-45f6-a5ae-5c40d3994e9e", "Department Admin", "DEPARTMENT ADMIN" },
                    { "788f3586-104c-4326-9081-2bafef400f49", "010eb6f7-e792-4de2-9df5-d92dd12717d5", "University Admin", "UNIVERSITY ADMIN" },
                    { "a41eedb6-c56a-4e8a-b5f6-8548d1a6e1d7", "8e74685f-5be2-4596-a66c-ff2f0ba94e03", "Student", "STUDENT" },
                    { "ad5a75af-5a06-4a25-8230-ac73aaac718d", "10309ed5-05a0-4d2b-b5fd-4fd16a5d013b", "Professor", "PROFESSOR" },
                    { "cfa67886-9d46-451d-9fc3-889c85e73f77", "69fc9a86-f959-4d79-9642-5c365919a720", "Faculty Admin", "FACULTY ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d1d9040-651a-47b6-ad50-ca12c76fb0d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "788f3586-104c-4326-9081-2bafef400f49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a41eedb6-c56a-4e8a-b5f6-8548d1a6e1d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad5a75af-5a06-4a25-8230-ac73aaac718d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfa67886-9d46-451d-9fc3-889c85e73f77");
        }
    }
}
