using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class AddedSubjectsAndQuestionnairesTbs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectId);
                    table.ForeignKey(
                        name: "FK_Subjects_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questionnaires",
                columns: table => new
                {
                    QuestionnaireId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaires", x => x.QuestionnaireId);
                    table.ForeignKey(
                        name: "FK_Questionnaires_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "Code", "DepartmentId", "Description", "Name", "Rate" },
                values: new object[,]
                {
                    { new Guid("15ee4163-b1d7-4ffd-9357-ae82b0cba7a0"), "CS381", new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), "Capstone Project II is a course offered in the Computer Science Department of Damanhour University's Faculty of Computer Science and Information Technology. This course is designed to provide students with an opportunity to apply the knowledge and skills they have acquired throughout their academic program to a real-world problem or project.", "Capstone Project II", 0.0 },
                    { new Guid("17105397-5aa7-452e-bbb5-26a690c56553"), "CS361", new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), "Intelligent Systems is a subject offered in the Computer Science Department of Damanhour University's Faculty of Computer Science and Information Technology. This course focuses on the design, development, and application of intelligent systems, which are computer systems that can perceive and respond to their environment, learn from experience, and make decisions based on data analysis and reasoning.", "Intelligent Systems", 0.0 },
                    { new Guid("1f80d7c4-3dd1-4365-9420-558e223f0ee6"), "CS352", new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), "Computer Animation is a subject offered in the Computer Science Department of Damanhour University's Faculty of Computer Science and Information Technology. This course focuses on the principles and techniques used in the creation and manipulation of digital animations using computer software.", "Computer Animation", 0.0 },
                    { new Guid("40504bb7-1148-4e05-ba84-2a81ffc3b918"), "CS311", new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), "Parallel computing is a subject that focuses on the design and implementation of computing systems that are capable of performing multiple tasks simultaneously. This subject is offered in Damanhour University's Faculty of Computer Science and Information Technology, specifically within the Computer Science Department.", "Parallel Computing", 0.0 },
                    { new Guid("5fecd989-af05-4e8f-80a3-ebda42971bb3"), "CS211", new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), "Introduction to Computer Security is a subject offered by the Computer Science Department at Damanhour University's Faculty of Computer Science and Information Technology. The course provides an overview of the fundamental concepts and principles of computer security, including the protection of computer systems, networks, and data from unauthorized access, theft, damage, and other security threats.", "Introduction to Computer Security", 0.0 },
                    { new Guid("f9d69186-526f-4141-92e0-8d8b29ee347f"), "CS212", new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), "Advanced Database is a subject offered in the Computer Science Department of Damanhour University's Faculty of Computer Science and Information Technology. This course is designed to provide students with an in-depth understanding of advanced concepts and techniques used in database management systems.", "Advanced Database", 0.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires_SubjectId",
                table: "Questionnaires",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_DepartmentId",
                table: "Subjects",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questionnaires");

            migrationBuilder.DropTable(
                name: "Subjects");
        }
    }
}
