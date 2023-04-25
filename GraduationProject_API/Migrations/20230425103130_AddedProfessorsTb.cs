using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class AddedProfessorsTb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "ProfessorId",
                table: "Subjects",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Professors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    UniveristyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FacultyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Professors_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Professors_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "FacultyId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Professors_Universities_UniveristyId",
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
                value: "3cabb67c-566c-48e3-93e6-fcd607535b00");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A2523A70-57E3-4B69-A405-F9752517ED62",
                column: "ConcurrencyStamp",
                value: "9e225b01-cabd-4584-aee6-020ed37e380d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "BEA713C7-93D2-4F39-8DC8-18F2F3070779",
                column: "ConcurrencyStamp",
                value: "048284b9-0fff-4fd5-a2a4-fd9c9c3b44a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E26639C4-7023-4878-A497-FC4B12CFA272",
                column: "ConcurrencyStamp",
                value: "a0978bc5-a1cc-48a8-857c-213d676fb6bd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7",
                column: "ConcurrencyStamp",
                value: "7cedce6b-d70b-4934-921f-3f2e92588e24");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69E0E900-6DE2-45E8-85CA-583B32C5C5AA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "822a4c72-3299-4f2a-8146-6bc67dd179ca", "AQAAAAEAACcQAAAAEEmYBZdYPHjfy2ZpO5f7Rvk3k6tmvhXWHwNj7WwT3g74OxcXY9AZqzaEq8Z0yFPyiA==", "4a28c426-7546-4622-93e9-16f38395ad5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99328045-8ECF-40A1-9F0B-0DEA6398F09A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e17883a-0627-4960-953d-65050a12ab71", "AQAAAAEAACcQAAAAEFM3pxZ+bBL8T+kL4sPysj5IsNDgFaf9kJGqBtX8dKJ7BuPW8NCJAk1VaKkkeXHIAQ==", "a2eaaf23-730a-4915-89a5-4a2ea84d7a50" });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_ProfessorId",
                table: "Subjects",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Professors_DepartmentId",
                table: "Professors",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Professors_FacultyId",
                table: "Professors",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Professors_UniveristyId",
                table: "Professors",
                column: "UniveristyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Professors_ProfessorId",
                table: "Subjects",
                column: "ProfessorId",
                principalTable: "Professors",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Professors_ProfessorId",
                table: "Subjects");

            migrationBuilder.DropTable(
                name: "Professors");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_ProfessorId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "ProfessorId",
                table: "Subjects");

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
        }
    }
}
