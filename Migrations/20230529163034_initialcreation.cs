using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examsystem.Migrations
{
    /// <inheritdoc />
    public partial class initialcreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    studentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    level = table.Column<int>(type: "int", nullable: false),
                    accId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.studentId);
                    table.ForeignKey(
                        name: "FK_students_accounts_accId",
                        column: x => x.accId,
                        principalTable: "accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "teachers",
                columns: table => new
                {
                    teacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    accId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teachers", x => x.teacherId);
                    table.ForeignKey(
                        name: "FK_teachers_accounts_accId",
                        column: x => x.accId,
                        principalTable: "accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    examId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    grade = table.Column<int>(type: "int", nullable: false),
                    durationInMinute = table.Column<int>(type: "int", nullable: false),
                    teacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.examId);
                    table.ForeignKey(
                        name: "FK_Exam_teachers_teacherId",
                        column: x => x.teacherId,
                        principalTable: "teachers",
                        principalColumn: "teacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    questionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    choicA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    choicB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    choicC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    choicD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    examId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.questionId);
                    table.ForeignKey(
                        name: "FK_Question_Exam_examId",
                        column: x => x.examId,
                        principalTable: "Exam",
                        principalColumn: "examId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Result",
                columns: table => new
                {
                    sId = table.Column<int>(type: "int", nullable: false),
                    examId = table.Column<int>(type: "int", nullable: false),
                    result = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Result", x => new { x.sId, x.examId });
                    table.ForeignKey(
                        name: "FK_Result_Exam_examId",
                        column: x => x.examId,
                        principalTable: "Exam",
                        principalColumn: "examId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Result_students_sId",
                        column: x => x.sId,
                        principalTable: "students",
                        principalColumn: "studentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_accounts_userName",
                table: "accounts",
                column: "userName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Exam_teacherId",
                table: "Exam",
                column: "teacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_examId",
                table: "Question",
                column: "examId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_examId",
                table: "Result",
                column: "examId");

            migrationBuilder.CreateIndex(
                name: "IX_students_accId",
                table: "students",
                column: "accId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_teachers_accId",
                table: "teachers",
                column: "accId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Result");

            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "teachers");

            migrationBuilder.DropTable(
                name: "accounts");
        }
    }
}
