using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class AddedRolesWithInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "64F2143D-B896-4355-90D2-AFD22424B234", "4829917c-596c-4d57-a7fc-ad6f635d8628", "Department Admin", "DEPARTMENT ADMIN" },
                    { "A2523A70-57E3-4B69-A405-F9752517ED62", "93adb965-dfdc-407b-ae45-2fea65598926", "Faculty Admin", "FACULTY ADMIN" },
                    { "BEA713C7-93D2-4F39-8DC8-18F2F3070779", "3a4263a0-d6e6-4e75-8d1e-faf89141c362", "University Admin", "UNIVERSITY ADMIN" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "7339b32c-d293-4d0e-8c34-baf4f78f845d", "Student", "STUDENT" },
                    { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "00eac70a-b410-42cb-91ac-1fc07372dc3b", "Professor", "PROFESSOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64F2143D-B896-4355-90D2-AFD22424B234");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A2523A70-57E3-4B69-A405-F9752517ED62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "BEA713C7-93D2-4F39-8DC8-18F2F3070779");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E26639C4-7023-4878-A497-FC4B12CFA272");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7");
        }
    }
}
