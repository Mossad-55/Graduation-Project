using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class AddedAdminsTb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FacultyAdmins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UniveristyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_FacultyAdmins_Universities_UniveristyId",
                        column: x => x.UniveristyId,
                        principalTable: "Universities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UniversityAdmins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64F2143D-B896-4355-90D2-AFD22424B234",
                column: "ConcurrencyStamp",
                value: "376e66fe-3f5e-4e63-b79a-afa28d58d597");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A2523A70-57E3-4B69-A405-F9752517ED62",
                column: "ConcurrencyStamp",
                value: "b778dba4-e839-4f03-a6a3-b61bcb0a7905");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "BEA713C7-93D2-4F39-8DC8-18F2F3070779",
                column: "ConcurrencyStamp",
                value: "92f12a14-f9d2-4bae-be42-1fb1ae2ef4e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E26639C4-7023-4878-A497-FC4B12CFA272",
                column: "ConcurrencyStamp",
                value: "661572a2-78e6-4389-8a39-5db3a8d95ecc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7",
                column: "ConcurrencyStamp",
                value: "865822e8-5b52-4214-b382-7490098b9e4f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "69E0E900-6DE2-45E8-85CA-583B32C5C5AA", 0, "6b5dd9aa-f411-4083-b050-67beb3904234", "jane.doe@example.com", true, "Jane", "Doe", false, null, "JANE.DOE@EXAMPLE.COM", "JANE.DOE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHLGcrK93SEU9Ds2CyaOl1VBVl4yV2KNOCNalSZpYO4arpOOu47iR49ZC29ihNTnSQ==", "01203993009", false, "b5836a9f-6aef-4c82-82d8-9430cde081a7", false, "jane.doe@example.com" },
                    { "99328045-8ECF-40A1-9F0B-0DEA6398F09A", 0, "2f40dcbd-948e-41e0-a4bb-cc940531ede2", "john.doe@example.com", true, "John", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGO+KbzVw1PHimhNim6ANNB867lKhSu+uLnv3l4KjZhc+qISOk65Lh/FTfGbINIy1g==", "01239931230", false, "72d1e267-68b8-4767-98e4-f98d4f1e7148", false, "john.doe@example.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FacultyAdmins_FacultyId",
                table: "FacultyAdmins",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_FacultyAdmins_UniveristyId",
                table: "FacultyAdmins",
                column: "UniveristyId");

            migrationBuilder.CreateIndex(
                name: "IX_UniversityAdmins_UniversityId",
                table: "UniversityAdmins",
                column: "UniversityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FacultyAdmins");

            migrationBuilder.DropTable(
                name: "UniversityAdmins");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69E0E900-6DE2-45E8-85CA-583B32C5C5AA");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99328045-8ECF-40A1-9F0B-0DEA6398F09A");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64F2143D-B896-4355-90D2-AFD22424B234",
                column: "ConcurrencyStamp",
                value: "4829917c-596c-4d57-a7fc-ad6f635d8628");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A2523A70-57E3-4B69-A405-F9752517ED62",
                column: "ConcurrencyStamp",
                value: "93adb965-dfdc-407b-ae45-2fea65598926");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "BEA713C7-93D2-4F39-8DC8-18F2F3070779",
                column: "ConcurrencyStamp",
                value: "3a4263a0-d6e6-4e75-8d1e-faf89141c362");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E26639C4-7023-4878-A497-FC4B12CFA272",
                column: "ConcurrencyStamp",
                value: "7339b32c-d293-4d0e-8c34-baf4f78f845d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7",
                column: "ConcurrencyStamp",
                value: "00eac70a-b410-42cb-91ac-1fc07372dc3b");
        }
    }
}
