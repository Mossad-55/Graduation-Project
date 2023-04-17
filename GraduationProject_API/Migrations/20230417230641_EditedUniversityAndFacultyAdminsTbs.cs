using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class EditedUniversityAndFacultyAdminsTbs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "UniversityAdmins");

            migrationBuilder.CreateTable(
                name: "FacultyAdmins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FacultyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacultyAdmins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FacultyAdmins_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "FacultyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2203cce6-d616-40e4-a75b-24e3aeb03f33", "056b8d31-68b0-49bb-9831-fc5f5e34e961", "Department Admin", "DEPARTMENT ADMIN" },
                    { "6d7998ce-f9ce-408a-99ab-6f8e48bd44b0", "85be79d3-1932-4ea3-90a4-247ac26d719e", "Faculty Admin", "FACULTY ADMIN" },
                    { "a82c50d1-615e-4943-97b7-9daad4022628", "03944695-5ee6-44df-a212-ab99878affdc", "University Admin", "UNIVERSITY ADMIN" },
                    { "d9a63c8d-7e8f-4a5b-93a6-f5a292a381fd", "e2ac14c7-ef51-4f47-b62e-6366e1d5a60d", "Student", "STUDENT" },
                    { "fe595817-f883-491d-8413-d676d8ab489f", "2f288d02-3ae6-430b-a2ac-df7578619b95", "Professor", "PROFESSOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FacultyAdmins_FacultyId",
                table: "FacultyAdmins",
                column: "FacultyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FacultyAdmins");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2203cce6-d616-40e4-a75b-24e3aeb03f33");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d7998ce-f9ce-408a-99ab-6f8e48bd44b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a82c50d1-615e-4943-97b7-9daad4022628");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9a63c8d-7e8f-4a5b-93a6-f5a292a381fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe595817-f883-491d-8413-d676d8ab489f");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "UniversityAdmins",
                type: "nvarchar(max)",
                nullable: true);

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
        }
    }
}
