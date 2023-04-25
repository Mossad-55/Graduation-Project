using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class AddedUniversitiesTb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Universities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    FacultyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    UniversityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.FacultyId);
                    table.ForeignKey(
                        name: "FK_Faculty_Universities_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "Universities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    FacultyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_Department_Faculty_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculty",
                        principalColumn: "FacultyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Universities",
                columns: new[] { "Id", "Description", "Name", "Rate" },
                values: new object[,]
                {
                    { new Guid("0102ff47-f01d-4614-8300-e9b9e1aad19b"), "Kafr El Sheikh University is an Egyptian university established in 2006, located at Kafr El Sheikh, in the middle of the Nile Delta.", "Kafr El Sheikh University", 0.0 },
                    { new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4"), "Damanhour University is a competitive institution in the domain of learning and pure scientific research which aims to build a learning society and to create knowledge.", "Damanhour University", 0.0 },
                    { new Guid("de1307a8-d751-402a-b649-4ffeabb70ac2"), "Tanta University is an Egyptian university in the city of Tanta, Al Gharbiyah governorate, Egypt. The university is under the direct scientific supervision of the Ministry of Higher Education.", "Tanta University", 0.0 },
                    { new Guid("e8c82519-d0c8-4c34-8cc7-a2e819644537"), "Alexandria University is a public university in Alexandria, Egypt. It was established in 1938 as a satellite of Fouad University, becoming an independent entity in 1942. It was known as Farouk University until after the Egyptian Revolution of 1952, when its name was changed to the University of Alexandria.", "Alexandria University", 0.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Department_FacultyId",
                table: "Department",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_UniversityId",
                table: "Faculty",
                column: "UniversityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "Universities");
        }
    }
}
