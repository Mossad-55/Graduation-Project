using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class AppliedFacultyConfigurationFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: new Guid("fafbc1d0-d161-4f1e-9ef6-f7cfd23d97f5"));
        }
    }
}
