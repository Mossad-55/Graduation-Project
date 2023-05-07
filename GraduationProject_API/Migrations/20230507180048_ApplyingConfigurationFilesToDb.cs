using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class ApplyingConfigurationFilesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "64F2143D-B896-4355-90D2-AFD22424B234", "3d1e2d4a-3d25-46aa-a2b6-5230216be456", "Department Admin", "DEPARTMENT ADMIN" },
                    { "A2523A70-57E3-4B69-A405-F9752517ED62", "1ee6bac3-9c56-4ec1-8c74-9b8bb5b30a9b", "Faculty Admin", "FACULTY ADMIN" },
                    { "BEA713C7-93D2-4F39-8DC8-18F2F3070779", "37d5edb6-609a-4989-9130-879d827c0c49", "University Admin", "UNIVERSITY ADMIN" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "dff747e3-a711-4304-90a4-9cfa483de9e5", "Student", "STUDENT" },
                    { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "08c5999d-543b-4747-a02e-1d06f2d02306", "Professor", "PROFESSOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4A8CA884-C093-43C4-A019-EE6D804BF85E", 0, "b285db12-d9d8-4f79-8522-651080648c8e", "mosad53@gmail.com", true, "Mossad", "Gomaa", false, null, "MOSAD53@GMAIL.COM", "MOSAD53@GMAIL.COM", "AQAAAAEAACcQAAAAEONu0FM+bx1F+a4IT1PNopW3VAoVqk3w4HZKDOytQ4yMMj3lc0JavY+NWlcN3vFWjQ==", "+201211820083", false, "f347b42f-5577-4acf-b23c-3319b494488a", false, "mosad53@gmail.com" },
                    { "5AAFE5DF-CB75-4DFA-898A-9A1C4E9BB5A5", 0, "c09f3397-2b8f-4671-8939-5ec98cf3138c", "mosad5@gmail.com", true, "Mossad", "Ahmed", false, null, "MOSAD5@GMAIL.COM", "MOSAD5@GMAIL.COM", "AQAAAAEAACcQAAAAEBndkAZSKquHoMD1lylnmRVgxdPwpiF+wowkrrKj43GcoYHkIalgrThmYh0JIEjg6A==", "+201211820083", false, "62ba76b9-e501-40d4-88b7-fee6bfa45517", false, "mosad5@gmail.com" },
                    { "69E0E900-6DE2-45E8-85CA-583B32C5C5AA", 0, "f1fd95d3-d73b-4f57-ae21-f2568280c948", "jane.doe@example.com", true, "Jane", "Doe", false, null, "JANE.DOE@EXAMPLE.COM", "JANE.DOE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJr12H3hpaawKjV2IVxywdDPLsuXM8SNigxvtoOH864WNS1dYU0b0qZAocbWb/YYiQ==", "01203993009", false, "d02e63f0-c1c0-4003-a30f-a583e73949f8", false, "jane.doe@example.com" },
                    { "706870e9-e373-11ed-b719-105badc84798", 0, "089d941a-1f6c-4d80-b7f3-e7f98fcf003c", "Mo.Zi@example.com", true, "Mo", "Zi", false, null, "MO.ZI@EXAMPLE.COM", "MO.ZI@EXAMPLE.COM", "AQAAAAEAACcQAAAAELtqnHD0z3JLfp0MvXwfW2kgazzknJSrvpSOf7HXwaMXjjrZ/S3j2fNcTnvQwVgXQA==", "01279426209", false, "aa61cad6-6f69-42b0-b245-3304c0d196b6", false, "Mo.Zi@example.com" },
                    { "706b3236-e373-11ed-a003-105badc84798", 0, "c6f9738a-a4c2-472c-a45c-5c9ece43c3ef", "Majdi.Fares@example.com", true, "Majdi", "Fares", false, null, "MAJDI.FARES@EXAMPLE.COM", "MAJDI.FARES@EXAMPLE.COM", "AQAAAAEAACcQAAAAECAGZ7cvWmuXVxJW+yNLkRfPVcfBmUOTtnPkxJusSKBbSJJhJk4r9kzk9YLgc3DYcw==", "01270867190", false, "2a468375-4dfb-43d2-a5e5-0f05f55ca363", false, "Majdi.Fares@example.com" },
                    { "706b3237-e373-11ed-988f-105badc84798", 0, "e2996374-83aa-4f2b-8b91-959e2cad8415", "Hamza.Yisri@example.com", true, "Hamza", "Yisri", false, null, "HAMZA.YISRI@EXAMPLE.COM", "HAMZA.YISRI@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGYamRrHxDkHA+H0GyF4zsDaG8Mm09duBMEB8X5cHcgy0MwHAQ3CBKewWGZOapDewg==", "01256543256", false, "22427ddb-78e2-41cd-bcfa-e46be78ac7e0", false, "Hamza.Yisri@example.com" },
                    { "7A369173-1E2F-491F-874F-7B324C034BC2", 0, "bb0dcf8d-26b4-44fb-974b-833723e28523", "bob.smith@example.com", true, "Bob", "Smith", false, null, "BOB.SMITH@EXAMPLE.COM", "BOB.SMITH@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJXg8X5Ar3XUmRVxvJ6gdRIaN+Q1G7Z8fletVIIvSoqv/vepKWf38HCWCPwSbwcsnQ==", "011234356789", false, "2249af47-fc22-46eb-b963-306daee7fa1b", false, "bob.smith@example.com" },
                    { "99328045-8ECF-40A1-9F0B-0DEA6398F09A", 0, "459b4109-6967-4695-855c-faf0a1f71ff2", "john.doe@example.com", true, "John", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOvIRc9XO5i73w5EuAGGXl60soohyvhEYbdkwfDOU0uH6I2BzvZ8QyNELWety+qQuw==", "01239931230", false, "15c16ad3-102c-4510-9dcf-1e732fb84680", false, "john.doe@example.com" },
                    { "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2", 0, "d28c81d4-7dc2-46c4-8d37-974b2a95493d", "sara.jones@example.com", true, "Sara", "Jones", false, null, "SARA.JONES@EXAMPLE.COM", "SARA.JONES@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOwTxtpFC9uLx8Wry+/4NwVImPA4hn4KaKc4dVcWG9nrwzWcOXQSp0s+vsnfKe6qdQ==", "010765432231", false, "da1d2de5-b6bf-4d42-8b5e-c3e041adb7c5", false, "sara.jones@example.com" }
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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4A8CA884-C093-43C4-A019-EE6D804BF85E" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "5AAFE5DF-CB75-4DFA-898A-9A1C4E9BB5A5" },
                    { "A2523A70-57E3-4B69-A405-F9752517ED62", "69E0E900-6DE2-45E8-85CA-583B32C5C5AA" },
                    { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "706870e9-e373-11ed-b719-105badc84798" },
                    { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "706b3236-e373-11ed-a003-105badc84798" },
                    { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "706b3237-e373-11ed-988f-105badc84798" },
                    { "64F2143D-B896-4355-90D2-AFD22424B234", "7A369173-1E2F-491F-874F-7B324C034BC2" },
                    { "BEA713C7-93D2-4F39-8DC8-18F2F3070779", "99328045-8ECF-40A1-9F0B-0DEA6398F09A" },
                    { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2" }
                });

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
                table: "UniversityAdmins",
                columns: new[] { "Id", "UniversityId" },
                values: new object[] { new Guid("99328045-8ecf-40a1-9f0b-0dea6398f09a"), new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") });

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

            migrationBuilder.InsertData(
                table: "FacultyAdmins",
                columns: new[] { "Id", "FacultyId", "UniveristyId" },
                values: new object[] { new Guid("69e0e900-6de2-45e8-85ca-583b32c5c5aa"), new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") });

            migrationBuilder.InsertData(
                table: "DepartmentAdmins",
                columns: new[] { "Id", "DepartmentId", "FacultyId", "UniveristyId" },
                values: new object[] { new Guid("7a369173-1e2f-491f-874f-7b324c034bc2"), new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") });

            migrationBuilder.InsertData(
                table: "Professors",
                columns: new[] { "Id", "DepartmentId", "FacultyId", "Rate", "UniveristyId" },
                values: new object[,]
                {
                    { new Guid("706870e9-e373-11ed-b719-105badc84798"), new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), 0.0, new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") },
                    { new Guid("706b3236-e373-11ed-a003-105badc84798"), new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), 0.0, new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") },
                    { new Guid("706b3237-e373-11ed-988f-105badc84798"), new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), 0.0, new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "Code", "DepartmentId", "Description", "Name", "ProfessorId", "Rate" },
                values: new object[,]
                {
                    { new Guid("15ee4163-b1d7-4ffd-9357-ae82b0cba7a0"), "CS381", new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), "Capstone Project II is a course offered in the Computer Science Department of Damanhour University's Faculty of Computer Science and Information Technology. This course is designed to provide students with an opportunity to apply the knowledge and skills they have acquired throughout their academic program to a real-world problem or project.", "Capstone Project II", new Guid("706870e9-e373-11ed-b719-105badc84798"), 2.5 },
                    { new Guid("17105397-5aa7-452e-bbb5-26a690c56553"), "CS361", new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), "Intelligent Systems is a subject offered in the Computer Science Department of Damanhour University's Faculty of Computer Science and Information Technology. This course focuses on the design, development, and application of intelligent systems, which are computer systems that can perceive and respond to their environment, learn from experience, and make decisions based on data analysis and reasoning.", "Intelligent Systems", new Guid("706870e9-e373-11ed-b719-105badc84798"), 3.5 },
                    { new Guid("1f80d7c4-3dd1-4365-9420-558e223f0ee6"), "CS352", new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), "Computer Animation is a subject offered in the Computer Science Department of Damanhour University's Faculty of Computer Science and Information Technology. This course focuses on the principles and techniques used in the creation and manipulation of digital animations using computer software.", "Computer Animation", new Guid("706b3237-e373-11ed-988f-105badc84798"), 4.0 },
                    { new Guid("40504bb7-1148-4e05-ba84-2a81ffc3b918"), "CS311", new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), "Parallel computing is a subject that focuses on the design and implementation of computing systems that are capable of performing multiple tasks simultaneously. This subject is offered in Damanhour University's Faculty of Computer Science and Information Technology, specifically within the Computer Science Department.", "Parallel Computing", new Guid("706870e9-e373-11ed-b719-105badc84798"), 0.0 },
                    { new Guid("5fecd989-af05-4e8f-80a3-ebda42971bb3"), "CS211", new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), "Introduction to Computer Security is a subject offered by the Computer Science Department at Damanhour University's Faculty of Computer Science and Information Technology. The course provides an overview of the fundamental concepts and principles of computer security, including the protection of computer systems, networks, and data from unauthorized access, theft, damage, and other security threats.", "Introduction to Computer Security", new Guid("706870e9-e373-11ed-b719-105badc84798"), 4.0 },
                    { new Guid("f9d69186-526f-4141-92e0-8d8b29ee347f"), "CS212", new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), "Advanced Database is a subject offered in the Computer Science Department of Damanhour University's Faculty of Computer Science and Information Technology. This course is designed to provide students with an in-depth understanding of advanced concepts and techniques used in database management systems.", "Advanced Database", new Guid("706b3236-e373-11ed-a003-105badc84798"), 3.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4A8CA884-C093-43C4-A019-EE6D804BF85E" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "5AAFE5DF-CB75-4DFA-898A-9A1C4E9BB5A5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "A2523A70-57E3-4B69-A405-F9752517ED62", "69E0E900-6DE2-45E8-85CA-583B32C5C5AA" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "706870e9-e373-11ed-b719-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "706b3236-e373-11ed-a003-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "706b3237-e373-11ed-988f-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "64F2143D-B896-4355-90D2-AFD22424B234", "7A369173-1E2F-491F-874F-7B324C034BC2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "BEA713C7-93D2-4F39-8DC8-18F2F3070779", "99328045-8ECF-40A1-9F0B-0DEA6398F09A" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2" });

            migrationBuilder.DeleteData(
                table: "DepartmentAdmins",
                keyColumn: "Id",
                keyValue: new Guid("7a369173-1e2f-491f-874f-7b324c034bc2"));

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
                table: "FacultyAdmins",
                keyColumn: "Id",
                keyValue: new Guid("69e0e900-6de2-45e8-85ca-583b32c5c5aa"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: new Guid("15ee4163-b1d7-4ffd-9357-ae82b0cba7a0"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: new Guid("17105397-5aa7-452e-bbb5-26a690c56553"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: new Guid("1f80d7c4-3dd1-4365-9420-558e223f0ee6"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: new Guid("40504bb7-1148-4e05-ba84-2a81ffc3b918"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: new Guid("5fecd989-af05-4e8f-80a3-ebda42971bb3"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: new Guid("f9d69186-526f-4141-92e0-8d8b29ee347f"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("0102ff47-f01d-4614-8300-e9b9e1aad19b"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("de1307a8-d751-402a-b649-4ffeabb70ac2"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("e8c82519-d0c8-4c34-8cc7-a2e819644537"));

            migrationBuilder.DeleteData(
                table: "UniversityAdmins",
                keyColumn: "Id",
                keyValue: new Guid("99328045-8ecf-40a1-9f0b-0dea6398f09a"));

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
                keyValue: "BEA713C7-93D2-4F39-8DC8-18F2F3070779");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E26639C4-7023-4878-A497-FC4B12CFA272");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4A8CA884-C093-43C4-A019-EE6D804BF85E");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5AAFE5DF-CB75-4DFA-898A-9A1C4E9BB5A5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69E0E900-6DE2-45E8-85CA-583B32C5C5AA");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706870e9-e373-11ed-b719-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706b3236-e373-11ed-a003-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706b3237-e373-11ed-988f-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7A369173-1E2F-491F-874F-7B324C034BC2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99328045-8ECF-40A1-9F0B-0DEA6398F09A");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2");

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: new Guid("706870e9-e373-11ed-b719-105badc84798"));

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: new Guid("706b3236-e373-11ed-a003-105badc84798"));

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: new Guid("706b3237-e373-11ed-988f-105badc84798"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("84796c48-d538-4954-a98a-622dc5c9325a"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4"));
        }
    }
}
