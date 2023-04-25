using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class AddedFaculititesAndDepartmentsTbs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Faculty_FacultyId",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Faculty_Universities_UniversityId",
                table: "Faculty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Faculty",
                table: "Faculty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.RenameTable(
                name: "Faculty",
                newName: "Faculties");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameIndex(
                name: "IX_Faculty_UniversityId",
                table: "Faculties",
                newName: "IX_Faculties_UniversityId");

            migrationBuilder.RenameIndex(
                name: "IX_Department_FacultyId",
                table: "Departments",
                newName: "IX_Departments_FacultyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Faculties",
                table: "Faculties",
                column: "FacultyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "DepartmentId");

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "FacultyId", "Description", "Name", "Rate", "UniversityId" },
                values: new object[,]
                {
                    { new Guid("0f3b208b-2006-4c07-878f-27e4dd1cc99e"), "The Faculty of Engineering at Damanhour University is a prestigious academic institution located in the city of Damanhour, Egypt. The faculty is dedicated to providing students with a comprehensive education in the field of engineering, preparing them for successful careers in research, academia, and industry.", "Faculty Of Engineering", 0.0, new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") },
                    { new Guid("2694c80b-f092-4975-9688-5565cf1e67fc"), "The Faculty of Science at Damanhour University is a renowned academic institution located in the city of Damanhour, Egypt. The faculty is dedicated to providing students with a comprehensive education in the field of science, preparing them for successful careers in research, academia, and industry.", "Faculty Of Science", 0.0, new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") },
                    { new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), "We believe that software and information technology is the future, hence we have recruited our knowledge in the fields of information system and automation.", "Faculty Of Computer Science and Information Technology", 0.0, new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") },
                    { new Guid("fafbc1d0-d161-4f1e-9ef6-f7cfd23d97f5"), "The Faculty of Commerce at Damanhour University is a leading academic institution located in the city of Damanhour, Egypt. The faculty is committed to providing high-quality education and training to students in the field of commerce and business.", "Faculty Of Commerce", 0.0, new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") }
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

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Faculties_FacultyId",
                table: "Departments",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "FacultyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Faculties_Universities_UniversityId",
                table: "Faculties",
                column: "UniversityId",
                principalTable: "Universities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Faculties_FacultyId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Universities_UniversityId",
                table: "Faculties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Faculties",
                table: "Faculties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("72b983a8-6386-498d-a114-0e241e7eeae0"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("794da9eb-b65e-45ba-a9dd-caa9a22c7d40"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("84796c48-d538-4954-a98a-622dc5c9325a"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("c65f6c7f-32f7-4797-a85b-92c9ba20ecb1"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: new Guid("0f3b208b-2006-4c07-878f-27e4dd1cc99e"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: new Guid("2694c80b-f092-4975-9688-5565cf1e67fc"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: new Guid("fafbc1d0-d161-4f1e-9ef6-f7cfd23d97f5"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"));

            migrationBuilder.RenameTable(
                name: "Faculties",
                newName: "Faculty");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameIndex(
                name: "IX_Faculties_UniversityId",
                table: "Faculty",
                newName: "IX_Faculty_UniversityId");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_FacultyId",
                table: "Department",
                newName: "IX_Department_FacultyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Faculty",
                table: "Faculty",
                column: "FacultyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Faculty_FacultyId",
                table: "Department",
                column: "FacultyId",
                principalTable: "Faculty",
                principalColumn: "FacultyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Faculty_Universities_UniversityId",
                table: "Faculty",
                column: "UniversityId",
                principalTable: "Universities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
