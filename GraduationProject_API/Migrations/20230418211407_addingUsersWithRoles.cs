using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class addingUsersWithRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "DepartmentAdmins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UniveristyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FacultyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentAdmins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartmentAdmins_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentAdmins_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "FacultyId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DepartmentAdmins_Universities_UniveristyId",
                        column: x => x.UniveristyId,
                        principalTable: "Universities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "64F2143D-B896-4355-90D2-AFD22424B234", "863be5dc-fdcb-4c4a-a5a5-14be0aa826ea", "Department Admin", "DEPARTMENT ADMIN" },
                    { "A2523A70-57E3-4B69-A405-F9752517ED62", "85c7246f-ad5c-46c7-b8ed-6c8f65519210", "Faculty Admin", "FACULTY ADMIN" },
                    { "BEA713C7-93D2-4F39-8DC8-18F2F3070779", "98b8a5d5-aac0-4513-ab1c-c574d3a40af0", "University Admin", "UNIVERSITY ADMIN" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "a3f6acbc-43e2-49f9-acc0-cb56364d5f18", "Student", "STUDENT" },
                    { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "96539e9d-ecef-4cb1-b8a6-adffbfcb88f5", "Professor", "PROFESSOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "69E0E900-6DE2-45E8-85CA-583B32C5C5AA", 0, "c6cb1b07-bf27-4fcb-a4b6-4f003027fb4b", "jane.doe@example.com", true, "Jane", "Doe", false, null, "JANE.DOE@EXAMPLE.COM", "JANE.DOE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJlleSWjyeCNA/rUalE0HcaTFdsSgQzxtZ9wgPvdDHF+R3mdpqZQUFPJbnWS1Zm+zA==", null, false, "65787b64-9dd4-4524-8fd1-31e139de6744", false, "jane.doe@example.com" },
                    { "99328045-8ECF-40A1-9F0B-0DEA6398F09A", 0, "cc08909f-8a44-427f-92c5-02712115968f", "john.doe@example.com", true, "John", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEvPyK64vbdjm1zW0MYU2ZLxAn+AZHHhZv46UBSZ8Gb45wIU6D4CkaPDhWsxopZ/wA==", null, false, "d4c7ce1f-5fab-495a-8dd7-f75881a4d7be", false, "john.doe@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "BEA713C7-93D2-4F39-8DC8-18F2F3070779", "69E0E900-6DE2-45E8-85CA-583B32C5C5AA" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "BEA713C7-93D2-4F39-8DC8-18F2F3070779", "99328045-8ECF-40A1-9F0B-0DEA6398F09A" });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentAdmins_DepartmentId",
                table: "DepartmentAdmins",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentAdmins_FacultyId",
                table: "DepartmentAdmins",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentAdmins_UniveristyId",
                table: "DepartmentAdmins",
                column: "UniveristyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentAdmins");

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
                keyValue: "E26639C4-7023-4878-A497-FC4B12CFA272");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "BEA713C7-93D2-4F39-8DC8-18F2F3070779", "69E0E900-6DE2-45E8-85CA-583B32C5C5AA" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "BEA713C7-93D2-4F39-8DC8-18F2F3070779", "99328045-8ECF-40A1-9F0B-0DEA6398F09A" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "BEA713C7-93D2-4F39-8DC8-18F2F3070779");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69E0E900-6DE2-45E8-85CA-583B32C5C5AA");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99328045-8ECF-40A1-9F0B-0DEA6398F09A");

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
        }
    }
}
