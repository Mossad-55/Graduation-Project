using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class AppliedDepartmentConfigurationFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
