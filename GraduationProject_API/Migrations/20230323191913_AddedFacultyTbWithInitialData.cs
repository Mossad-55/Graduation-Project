using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class AddedFacultyTbWithInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    FacultyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniversityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.FacultyId);
                    table.ForeignKey(
                        name: "FK_Faculties_Universities_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "Universities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "FacultyId", "Description", "Name", "UniversityId" },
                values: new object[,]
                {
                    { new Guid("0f3b208b-2006-4c07-878f-27e4dd1cc99e"), "The Faculty of Engineering at Damanhour University is a prestigious academic institution located in the city of Damanhour, Egypt. The faculty is dedicated to providing students with a comprehensive education in the field of engineering, preparing them for successful careers in research, academia, and industry.", "Faculty Of Engineering", new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") },
                    { new Guid("2694c80b-f092-4975-9688-5565cf1e67fc"), "The Faculty of Science at Damanhour University is a renowned academic institution located in the city of Damanhour, Egypt. The faculty is dedicated to providing students with a comprehensive education in the field of science, preparing them for successful careers in research, academia, and industry.", "Faculty Of Science", new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") },
                    { new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), "We believe that software and information technology is the future, hence we have recruited our knowledge in the fields of information system and automation.", "Faculty Of Computer Science and Information Technology", new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") },
                    { new Guid("fafbc1d0-d161-4f1e-9ef6-f7cfd23d97f5"), "The Faculty of Commerce at Damanhour University is a leading academic institution located in the city of Damanhour, Egypt. The faculty is committed to providing high-quality education and training to students in the field of commerce and business.", "Faculty Of Commerce", new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Faculties_UniversityId",
                table: "Faculties",
                column: "UniversityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faculties");
        }
    }
}
