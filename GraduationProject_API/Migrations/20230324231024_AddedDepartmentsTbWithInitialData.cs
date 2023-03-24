using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class AddedDepartmentsTbWithInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
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
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_Departments_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "FacultyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Description", "FacultyId", "Name", "Rate" },
                values: new object[,]
                {
                    { new Guid("72b983a8-6386-498d-a114-0e241e7eeae0"), "The Information Systems (IS) Department at Damanhour University is a forward-thinking and innovative academic community dedicated to advancing the field of information systems through teaching, research, and service. The department offers a range of undergraduate and graduate programs that provide students with a comprehensive understanding of the theory and practice of information systems.", new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), "Information System", 0.0 },
                    { new Guid("794da9eb-b65e-45ba-a9dd-caa9a22c7d40"), "The Information Technology (IT) Department at Damanhour University is a dynamic and innovative academic community dedicated to advancing the field of information technology through teaching, research, and service. The department offers a range of undergraduate and graduate programs that provide students with a comprehensive understanding of the theory and practice of IT.", new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), "Information Technology", 0.0 },
                    { new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), "The Computer Science Department at Damanhour University is a vibrant academic community dedicated to advancing knowledge and technology in the field of computer science. The department offers a range of undergraduate and graduate programs that provide students with a solid foundation in computer science theory and practical skills.", new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), "Computer Science", 0.0 },
                    { new Guid("c65f6c7f-32f7-4797-a85b-92c9ba20ecb1"), "The Multimedia Department at Damanhour University is a dynamic and creative academic community dedicated to advancing the field of multimedia through teaching, research, and service. The department offers a range of undergraduate and graduate programs that provide students with a solid foundation in multimedia theory and practical skills.", new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), "Multimedia", 0.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_FacultyId",
                table: "Departments",
                column: "FacultyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
