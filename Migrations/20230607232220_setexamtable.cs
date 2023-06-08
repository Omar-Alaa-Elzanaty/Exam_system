using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examsystem.Migrations
{
    /// <inheritdoc />
    public partial class setexamtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exam_teachers_teacherId",
                table: "Exam");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Exam_examId",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_results_Exam_examId",
                table: "results");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exam",
                table: "Exam");

            migrationBuilder.RenameTable(
                name: "Exam",
                newName: "exams");

            migrationBuilder.RenameIndex(
                name: "IX_Exam_teacherId",
                table: "exams",
                newName: "IX_exams_teacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_exams",
                table: "exams",
                column: "examId");

            migrationBuilder.AddForeignKey(
                name: "FK_exams_teachers_teacherId",
                table: "exams",
                column: "teacherId",
                principalTable: "teachers",
                principalColumn: "teacherId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_exams_examId",
                table: "Question",
                column: "examId",
                principalTable: "exams",
                principalColumn: "examId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_results_exams_examId",
                table: "results",
                column: "examId",
                principalTable: "exams",
                principalColumn: "examId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_exams_teachers_teacherId",
                table: "exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_exams_examId",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_results_exams_examId",
                table: "results");

            migrationBuilder.DropPrimaryKey(
                name: "PK_exams",
                table: "exams");

            migrationBuilder.RenameTable(
                name: "exams",
                newName: "Exam");

            migrationBuilder.RenameIndex(
                name: "IX_exams_teacherId",
                table: "Exam",
                newName: "IX_Exam_teacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exam",
                table: "Exam",
                column: "examId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exam_teachers_teacherId",
                table: "Exam",
                column: "teacherId",
                principalTable: "teachers",
                principalColumn: "teacherId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Exam_examId",
                table: "Question",
                column: "examId",
                principalTable: "Exam",
                principalColumn: "examId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_results_Exam_examId",
                table: "results",
                column: "examId",
                principalTable: "Exam",
                principalColumn: "examId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
