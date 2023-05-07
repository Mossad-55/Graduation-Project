using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class AddedSubmitionsTb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "Submitions",
                columns: table => new
                {
                    SubmitionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubmitionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InstEffic = table.Column<int>(type: "int", nullable: false),
                    CourseUnderstand = table.Column<int>(type: "int", nullable: false),
                    IntRespect = table.Column<int>(type: "int", nullable: false),
                    InstMaterial = table.Column<int>(type: "int", nullable: false),
                    ExamContent = table.Column<int>(type: "int", nullable: false),
                    AssisTeacher = table.Column<int>(type: "int", nullable: false),
                    InstRecommend = table.Column<int>(type: "int", nullable: false),
                    CourseRecommend = table.Column<int>(type: "int", nullable: false),
                    CourseMarket = table.Column<int>(type: "int", nullable: false),
                    QuestionnaireId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submitions", x => x.SubmitionId);
                    table.ForeignKey(
                        name: "FK_Submitions_Questionnaires_QuestionnaireId",
                        column: x => x.QuestionnaireId,
                        principalTable: "Questionnaires",
                        principalColumn: "QuestionnaireId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Submitions_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64F2143D-B896-4355-90D2-AFD22424B234",
                column: "ConcurrencyStamp",
                value: "a7a30ff0-ecf3-4f81-b25b-e6590df1d575");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A2523A70-57E3-4B69-A405-F9752517ED62",
                column: "ConcurrencyStamp",
                value: "7cabdae9-5e19-44a8-abea-3f1516af46d7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "BEA713C7-93D2-4F39-8DC8-18F2F3070779",
                column: "ConcurrencyStamp",
                value: "0876ca86-d16e-4e3d-95ca-febfac3f030b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E26639C4-7023-4878-A497-FC4B12CFA272",
                column: "ConcurrencyStamp",
                value: "a558322d-1555-403a-8899-6a334c501b6c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7",
                column: "ConcurrencyStamp",
                value: "cde3caf1-1269-4e1f-84e6-8a757f2534e3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4A8CA884-C093-43C4-A019-EE6D804BF85E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b8c0c0b-83c9-48f2-bf86-6cdfa5c4cf59", "AQAAAAEAACcQAAAAEHp85FzLrdGZMW1K48yej9edoDcfXctQJp+LyIgJUUhQ3SPu+N2iSRm8RNi7d7JFqQ==", "ad2dd006-4db4-4540-8c54-24bcbbf347b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5AAFE5DF-CB75-4DFA-898A-9A1C4E9BB5A5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9143f433-d97f-4a9f-8b89-3823a4dae868", "AQAAAAEAACcQAAAAEL9rhmQN2cfimlyYnjcieE+/Rnr2peBAJmtpOFEI6EP5GGUwKD/hkEBc7d7MYNJPGg==", "bbcbf3e8-08d9-4b8e-8358-8aefc8b7fffa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69E0E900-6DE2-45E8-85CA-583B32C5C5AA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6780baa9-8a11-43e7-83e7-60ca449ea207", "AQAAAAEAACcQAAAAEAICo7jgSRSPXfNUqKtmPwvGTrkLALN9qtFq/WWIaLj0fJki9eZ+lq5TnZDOUa0zMQ==", "d0259e02-52d1-46c2-853c-38826edd81f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706870e9-e373-11ed-b719-105badc84798",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d626f1a-641c-4a2f-95bf-08afe367f569", "AQAAAAEAACcQAAAAEFfVR3xX794Vy2k8P6GXrbTuqty4e9QUXW1RRSB3AU1Is8CHr5yxFtwK6Q/RLwB+Gw==", "661227de-6d60-4481-91de-b828ddb17664" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706b3236-e373-11ed-a003-105badc84798",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4187e85b-dea5-4276-89dd-27d7a3e68c13", "AQAAAAEAACcQAAAAEIjlCWqOUAzlhcPZIf/dtABCQIp60Ayj1I1lRbMR1Pk+nJ5vjCNQhzh3xyppr90akQ==", "4eb68407-78f4-4e83-ac1a-930215135dd6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706b3237-e373-11ed-988f-105badc84798",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b3c7903-f45f-4f5e-a423-15b8bc359495", "AQAAAAEAACcQAAAAEDiJQS5T+QTBLPO7pmQ2MroguKKru6kAANQje82/f8vlWTGxyEZPt2nmQLxm6iStDw==", "9c7fb637-5979-4275-a2c3-14e145773a95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7A369173-1E2F-491F-874F-7B324C034BC2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de646027-d60c-4ba8-ab17-6f3fe0bb5729", "AQAAAAEAACcQAAAAEMhDAiBCj4mX2julbwGOkJeXZM5cOt/yToBdRcy2Cugao+eAqgHJ4rJ0E0r3J6dmRw==", "9fc0778f-a8ea-4707-88e0-241e792880e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99328045-8ECF-40A1-9F0B-0DEA6398F09A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ed2b7e8-adbe-43e2-b9ad-0aa3097946c1", "AQAAAAEAACcQAAAAEACA9L3K+JUts4r3BMDKK82+JuKSo7/WDzFzIXPNxVnfHibg3sCKafB4No4aoBAvww==", "f2b0dbcc-c190-4e09-8d84-5c40d5f789e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "229b3cd7-7817-499e-be41-820256cc4f60", "AQAAAAEAACcQAAAAEJHmHXFzE06ed2W9eYEljWyuiPC/OjXkPUjRTwSJBOtLzYb/pJ05Yyq2NRs24D8iAA==", "4256a99a-91c7-47e8-aabc-3f75abecd13e" });

            migrationBuilder.CreateIndex(
                name: "IX_Submitions_QuestionnaireId",
                table: "Submitions",
                column: "QuestionnaireId");

            migrationBuilder.CreateIndex(
                name: "IX_Submitions_StudentId",
                table: "Submitions",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Submitions");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64F2143D-B896-4355-90D2-AFD22424B234",
                column: "ConcurrencyStamp",
                value: "5dc80156-f862-45c1-8cee-d3a0593976f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A2523A70-57E3-4B69-A405-F9752517ED62",
                column: "ConcurrencyStamp",
                value: "ce444435-60a7-44a6-a9c2-ae46a6fb3db2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "BEA713C7-93D2-4F39-8DC8-18F2F3070779",
                column: "ConcurrencyStamp",
                value: "ebe90fe2-8f40-4e9d-b6c1-6ee9e6c8b1b6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E26639C4-7023-4878-A497-FC4B12CFA272",
                column: "ConcurrencyStamp",
                value: "3ece682e-c879-403c-b30c-0c1c9e51e7a4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7",
                column: "ConcurrencyStamp",
                value: "b85c3978-26d9-488e-b69a-160d6d57c241");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4A8CA884-C093-43C4-A019-EE6D804BF85E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9cf58de-5438-4471-bbef-fc506cbb962e", "AQAAAAEAACcQAAAAEDPHUGa3kDA+jT2b4wbMnYZT+zfbNUIr/SnoI0sRCavya9LghokbUDiP/F0ryUD9rw==", "e93a590d-dab9-41b7-b123-d7ef6276da13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5AAFE5DF-CB75-4DFA-898A-9A1C4E9BB5A5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e48312a7-cd23-48ec-91dd-669c53117faf", "AQAAAAEAACcQAAAAEN7BPMQ+vaPkr0BOWCvrZa3TIh51rdasm7vStLWYZkbgojvvyfsYSRIIH5CAy/q6nw==", "9ebeeae5-c04c-4896-8bc8-f759eb53c492" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69E0E900-6DE2-45E8-85CA-583B32C5C5AA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd96776f-81f4-4e69-b2da-a01aaa1e7e3c", "AQAAAAEAACcQAAAAEAj5Auwj3xaU+kJ0sP3fd+1ESuf+Dqm2fNi6fMgeLRGO1Km1HrSjZCAfOo5JkJO0hQ==", "b736c30f-438d-421d-b300-0d63185bb060" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706870e9-e373-11ed-b719-105badc84798",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a959fa4a-8071-4afb-acd6-ab195113f0ce", "AQAAAAEAACcQAAAAEM+Rp705wjPkPrWfvy6jhRXtpwg3rA3DE82+u5J5DTMUwy3FCSiSkAUOo6wgd+HMmA==", "05a108d3-a964-4311-a7d9-5d5bd3514640" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706b3236-e373-11ed-a003-105badc84798",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ed1b2d3-f80c-49f1-93c8-02962aabeab5", "AQAAAAEAACcQAAAAEKF/9WcaHQcA4X8YNW+feXDGe6nkyD8VTStRE6BY+ksGDtfuenIe8nrXQPfY7GmfAw==", "43baa4b1-ea52-47ba-b439-f5f0e674beeb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706b3237-e373-11ed-988f-105badc84798",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5a951d4-d3d1-440a-8244-e2853c4dde46", "AQAAAAEAACcQAAAAEDAYkW+HwRe3H2cCZNluEtkqJLiG9xUESJG6N8mZi/g3q37y4M0xC4n9hBHZ6Aaj5g==", "b9a0a315-4cf9-4369-a17f-8293e3bd264d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7A369173-1E2F-491F-874F-7B324C034BC2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2363cbf5-90b3-464c-be94-f81c1adbb1f6", "AQAAAAEAACcQAAAAEGZNZm6FnmLOOjWwwY1LAFwPnwm7p0OHIdGUdfaSeVqx513mfSVDWgKgkd8FTD6ejg==", "c5308af9-2398-4ead-80de-8154f604a6ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99328045-8ECF-40A1-9F0B-0DEA6398F09A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3c6beb3-0a82-45c2-be07-8ec020223e36", "AQAAAAEAACcQAAAAEE9BSZWo03EGnlXLtCzaSvhLCt4PyPtwIvtOrgd97/6SJEfK7yx0hgwmm9TmNO8SSQ==", "47b5cac4-d0d8-45eb-b8b0-00e225c69d61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b27c0aeb-2a5d-48ff-a2a5-5eff70622fd0", "AQAAAAEAACcQAAAAEA9TAK2LwybyXtcmYXtH4/uzMazELpHftGDgXv5kbl60Xn7ge0t88lO4rF5knuHvCQ==", "ec41452b-ee88-4e2f-9615-54197f837a8e" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DepartmentId", "FacultyId", "UniveristyId" },
                values: new object[,]
                {
                    { new Guid("4a8ca884-c093-43c4-a019-ee6d804bf85e"), new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") },
                    { new Guid("5aafe5df-cb75-4dfa-898a-9a1c4e9bb5a5"), new Guid("84796c48-d538-4954-a98a-622dc5c9325a"), new Guid("d0552b49-6e7d-4ced-8a30-62ce8066a2d4"), new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4") }
                });
        }
    }
}
