using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class AddedDepartmentAdminsTb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64F2143D-B896-4355-90D2-AFD22424B234",
                column: "ConcurrencyStamp",
                value: "50e6500f-9a4f-49b0-9c30-c24d163fdf22");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A2523A70-57E3-4B69-A405-F9752517ED62",
                column: "ConcurrencyStamp",
                value: "ca684568-bb15-48f9-a151-b249a410933f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "BEA713C7-93D2-4F39-8DC8-18F2F3070779",
                column: "ConcurrencyStamp",
                value: "8fd75486-fde9-42db-b7a6-c75c6b11777e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E26639C4-7023-4878-A497-FC4B12CFA272",
                column: "ConcurrencyStamp",
                value: "41dca87f-a647-4935-bdd5-f2f40a5cbc9f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7",
                column: "ConcurrencyStamp",
                value: "899cc57e-d55f-470b-ad09-f907bbbde81e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69E0E900-6DE2-45E8-85CA-583B32C5C5AA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "775b7259-f088-4b62-9d92-eb47801aa0e6", "AQAAAAEAACcQAAAAEJ8kCswB45oXkGplbo4UQSVeQOkP7tckykIx/hfHq+rf7hd+PAtXP1qXYoT2NnKPQg==", "26db48b2-0f68-4282-9d32-dbd362cb6276" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99328045-8ECF-40A1-9F0B-0DEA6398F09A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6c85e30-4c8b-445d-9d67-772cf05a8885", "AQAAAAEAACcQAAAAEIGSho/Ae5ByR4CjaJ+F+TJM2nTEYzDyxt0PkzKMdojtf7emVUE714PxS3bebGqFvA==", "d4959f7f-7449-40be-9558-b530807c3bf1" });

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69E0E900-6DE2-45E8-85CA-583B32C5C5AA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b5dd9aa-f411-4083-b050-67beb3904234", "AQAAAAEAACcQAAAAEHLGcrK93SEU9Ds2CyaOl1VBVl4yV2KNOCNalSZpYO4arpOOu47iR49ZC29ihNTnSQ==", "b5836a9f-6aef-4c82-82d8-9430cde081a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99328045-8ECF-40A1-9F0B-0DEA6398F09A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f40dcbd-948e-41e0-a4bb-cc940531ede2", "AQAAAAEAACcQAAAAEGO+KbzVw1PHimhNim6ANNB867lKhSu+uLnv3l4KjZhc+qISOk65Lh/FTfGbINIy1g==", "72d1e267-68b8-4767-98e4-f98d4f1e7148" });
        }
    }
}
