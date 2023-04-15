using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class AddedUniversityAdminsTb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "UniversityAdmins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniversityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityAdmins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UniversityAdmins_Universities_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "Universities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18614495-87e8-4efa-870d-0985ad067da7", "2f24418f-ec70-4992-96a3-00be69ee8afc", "Faculty Admin", "FACULTY ADMIN" },
                    { "6414b22c-8b53-4ab6-9808-11a084b699f2", "94ac1709-8727-4d02-b72d-60433be609fb", "University Admin", "UNIVERSITY ADMIN" },
                    { "84636786-be1e-4310-98f2-1ba1ef07deeb", "eb5858d0-f9fa-4560-9748-6fc2718fd6d5", "Student", "STUDENT" },
                    { "90e81236-c6d4-462e-8ea8-a80fec5422bc", "95e5ff69-f1aa-4107-8a51-1343e8d97bd5", "Department Admin", "DEPARTMENT ADMIN" },
                    { "a9b5b8c2-2168-4025-b534-0a8852daf75f", "bb990c34-c803-4315-abf1-276de6664285", "Professor", "PROFESSOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UniversityAdmins_UniversityId",
                table: "UniversityAdmins",
                column: "UniversityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UniversityAdmins");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18614495-87e8-4efa-870d-0985ad067da7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6414b22c-8b53-4ab6-9808-11a084b699f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84636786-be1e-4310-98f2-1ba1ef07deeb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90e81236-c6d4-462e-8ea8-a80fec5422bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9b5b8c2-2168-4025-b534-0a8852daf75f");

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
    }
}
