using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class AddedStudentsTb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UniveristyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FacultyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "FacultyId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Students_Universities_UniveristyId",
                        column: x => x.UniveristyId,
                        principalTable: "Universities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "StudentSubject",
                columns: table => new
                {
                    StudentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubject", x => new { x.StudentsId, x.SubjectsId });
                    table.ForeignKey(
                        name: "FK_StudentSubject_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_StudentSubject_Subjects_SubjectsId",
                        column: x => x.SubjectsId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64F2143D-B896-4355-90D2-AFD22424B234",
                column: "ConcurrencyStamp",
                value: "0f4193df-d69e-4317-8702-ea09c459d1c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A2523A70-57E3-4B69-A405-F9752517ED62",
                column: "ConcurrencyStamp",
                value: "ddcb2da9-c24b-489d-80d0-eeb99c3e0f59");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "BEA713C7-93D2-4F39-8DC8-18F2F3070779",
                column: "ConcurrencyStamp",
                value: "68ae1123-1a54-4588-9afc-0040a705b4b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E26639C4-7023-4878-A497-FC4B12CFA272",
                column: "ConcurrencyStamp",
                value: "5e0f7030-4239-46c5-a504-ceef74c1a598");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7",
                column: "ConcurrencyStamp",
                value: "2e238b41-35bf-44ab-9564-fe5a85019130");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69E0E900-6DE2-45E8-85CA-583B32C5C5AA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e56ab51b-f166-46c7-babf-c06438a92789", "AQAAAAEAACcQAAAAEOBC+L3wPlCLN4H3scbIcM1ehosXkJfG/Wk+3nDprqHls3OZWi74NvH/iek7k2jWVA==", "c3ee6e83-c731-41d0-a2e1-6383d93ef4dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706870e9-e373-11ed-b719-105badc84798",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed5176be-bded-4d91-8032-a616ff1b460e", "AQAAAAEAACcQAAAAEGrGLBvZMK1sPWSa/Boz7Z+ARVSQ0OPI41wn+N3C58rk5dk/zb2facWoT25kyzj0MQ==", "f005ae10-8955-4286-a158-fb2ab479b405" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706b3236-e373-11ed-a003-105badc84798",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc21448a-aa4f-4b35-8f60-08a851cf2b86", "AQAAAAEAACcQAAAAENZN+qdP3rh24oy2Jo6VJ6QGJpIveX1kjG4bHaHhJzLOEqiyxjeLyI35MyP6lW0S1g==", "2fed3621-53b0-4bbd-bfac-7ab7ff1bff53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706b3237-e373-11ed-988f-105badc84798",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b9ebfe7-36d9-453e-a686-28021cd96021", "AQAAAAEAACcQAAAAENE0c8aZ6u+C+ZlvA2LGObN5cigOWUtvmayaj8o25UsEpxdesPKO7UPUwUdoOXmvLA==", "62d81b09-d435-43ca-a90e-8c4e3f049de7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7A369173-1E2F-491F-874F-7B324C034BC2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d53d139-650c-42c1-9582-2dab5effa8ca", "AQAAAAEAACcQAAAAEHaHzf5wJb2IOCDaryAephsfd0biPqnhYxIZvHUBwHTj9y6FdliUzkHSOFiup4La2g==", "227b993d-b1e2-4a49-9c23-b84c31236752" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99328045-8ECF-40A1-9F0B-0DEA6398F09A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b090413e-cc35-4ce3-820c-39474af5f65c", "AQAAAAEAACcQAAAAEGX2cvdkUKcp8bImtHXn3y8gNbOBg0YQ08JlQcydpwYMZ8rO3fjlqQibpQoBjedReg==", "e85d50c2-a9d8-4d63-b707-1242f17e6e16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6de95299-d6b4-49c8-9fc7-7385dd2cfad8", "AQAAAAEAACcQAAAAEBAMQJ7pSIihY7BPg8BvpMjkaGtbGmv80t7Rnooo/ey1xfpdK8qqFnPnd5Upb18DgA==", "e518457e-21c3-4acd-a448-d62026e7de3f" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentId",
                table: "Students",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_FacultyId",
                table: "Students",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UniveristyId",
                table: "Students",
                column: "UniveristyId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubject_SubjectsId",
                table: "StudentSubject",
                column: "SubjectsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentSubject");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64F2143D-B896-4355-90D2-AFD22424B234",
                column: "ConcurrencyStamp",
                value: "92273346-bd6d-4962-a260-237131a2a083");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A2523A70-57E3-4B69-A405-F9752517ED62",
                column: "ConcurrencyStamp",
                value: "5c9c870c-4beb-476f-a030-c767bb7bf245");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "BEA713C7-93D2-4F39-8DC8-18F2F3070779",
                column: "ConcurrencyStamp",
                value: "a970747f-ba92-44d5-ba9b-53ecaa8355e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E26639C4-7023-4878-A497-FC4B12CFA272",
                column: "ConcurrencyStamp",
                value: "7ce626a7-e8dc-4265-8c3b-2c1462192e21");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7",
                column: "ConcurrencyStamp",
                value: "bfe594a4-4a54-498a-9b4d-00f3e46bf947");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69E0E900-6DE2-45E8-85CA-583B32C5C5AA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5aaf736-77ed-4682-b107-03299e89ce9c", "AQAAAAEAACcQAAAAEGELpbOTMQoFIK9oCWCmh0nBRdoSpclkzZPkYcTrKHlJczRd2KhRGlzpOdaEcaDHbw==", "25afd6be-7a1b-42c2-9fcb-7e7a60bed30a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706870e9-e373-11ed-b719-105badc84798",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4589a96f-edb2-4477-8551-e29162649ec6", "AQAAAAEAACcQAAAAEHnL08e1Lqsn3Yj0+3wViIZb/HmufaR+YpTRTUjYZkc+9fxrqHnwC/yRJOXoQlWAmg==", "a1511914-868d-463d-b51e-fad4ed1a3bae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706b3236-e373-11ed-a003-105badc84798",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8fa43c2-7481-413d-b995-9f27af0d2e52", "AQAAAAEAACcQAAAAELbVXqqT+FMStdMJcWIS1BPdM5zQcLvJvLLRdMXZVEnJr+gQVaaG01PDPNmltQdDsg==", "19c07dd0-d24f-43d2-992b-2b4e1a7b7487" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706b3237-e373-11ed-988f-105badc84798",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d0f4b8c-7c0f-43cc-ba31-6e84fee8a7c7", "AQAAAAEAACcQAAAAEAr8/YqSm9mNdOEfw/oikuQ3ftOYemHmysHR6t56aC5nyZ5fmD8OyONtMYbMsmj/uw==", "fcaefa98-98ca-4e04-a8f9-306306a5dbb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7A369173-1E2F-491F-874F-7B324C034BC2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16006749-1013-44a5-8cbb-d3b0323dbde6", "AQAAAAEAACcQAAAAELYkgqgvLijgM9rk7FVcJ2wHhm0gPv/gYrvs4pJMkwfr2vuIf+f6YNnXDS6Sgqdssw==", "9f91ef98-0efe-46cf-b3c3-b5d0f83206ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99328045-8ECF-40A1-9F0B-0DEA6398F09A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb3bdcbf-4e4d-4c42-b2c0-b041c4e38506", "AQAAAAEAACcQAAAAEGljCJEuwchmgmH+KVgcpML8Z8R4OJhq4nNH0fSkBP8Un4BfDWfHJkXoL9P08o20YA==", "549fe4a6-d5ae-4db3-8a39-c1e305b4f1b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed015ae7-3864-4fbc-8d09-f2351392ce51", "AQAAAAEAACcQAAAAEN22BwbmbJSNdmMRwSPxZjal/9vTrp2cz7hovDwSO78/t2+Im9tnLH3TwtmKb1+qGw==", "fc092dae-1a30-4ffc-b98f-92580d259a93" });
        }
    }
}
