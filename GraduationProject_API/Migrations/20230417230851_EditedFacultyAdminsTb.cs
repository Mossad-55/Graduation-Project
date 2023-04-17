using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class EditedFacultyAdminsTb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "UniveristyId",
                table: "FacultyAdmins",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "513c3d9b-d23b-4929-9b7a-5ff1c2ee34d9", "18293d20-ec7c-4aca-970e-f75cfe8ff8b2", "Student", "STUDENT" },
                    { "5d3e5560-99a9-4e1e-850c-871d6c3aafcb", "f0cfd533-602a-4c11-bea4-3dba3c78f860", "Professor", "PROFESSOR" },
                    { "754176ea-e0f2-4c3a-9bc2-45d2e2da0a8a", "c45fde80-68a9-41ba-addc-fc0d84bbc27c", "Faculty Admin", "FACULTY ADMIN" },
                    { "abdb99d5-e073-4dfb-9802-3a475f3041e8", "8a1918da-d6a4-4301-8e77-740e83fd04ca", "Department Admin", "DEPARTMENT ADMIN" },
                    { "bda0c218-5cce-4b25-8a7c-842bc798dba8", "080edc6c-7eba-4996-bb95-7122df5f987f", "University Admin", "UNIVERSITY ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FacultyAdmins_UniveristyId",
                table: "FacultyAdmins",
                column: "UniveristyId");

            migrationBuilder.AddForeignKey(
                name: "FK_FacultyAdmins_Universities_UniveristyId",
                table: "FacultyAdmins",
                column: "UniveristyId",
                principalTable: "Universities",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FacultyAdmins_Universities_UniveristyId",
                table: "FacultyAdmins");

            migrationBuilder.DropIndex(
                name: "IX_FacultyAdmins_UniveristyId",
                table: "FacultyAdmins");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "513c3d9b-d23b-4929-9b7a-5ff1c2ee34d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d3e5560-99a9-4e1e-850c-871d6c3aafcb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "754176ea-e0f2-4c3a-9bc2-45d2e2da0a8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abdb99d5-e073-4dfb-9802-3a475f3041e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bda0c218-5cce-4b25-8a7c-842bc798dba8");

            migrationBuilder.DropColumn(
                name: "UniveristyId",
                table: "FacultyAdmins");

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
        }
    }
}
