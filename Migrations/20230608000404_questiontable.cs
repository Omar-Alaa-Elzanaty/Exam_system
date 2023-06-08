using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examsystem.Migrations
{
    /// <inheritdoc />
    public partial class questiontable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_exams_examId",
                table: "Question");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Question",
                table: "Question");

            migrationBuilder.RenameTable(
                name: "Question",
                newName: "questions");

            migrationBuilder.RenameIndex(
                name: "IX_Question_examId",
                table: "questions",
                newName: "IX_questions_examId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_questions",
                table: "questions",
                column: "questionId");

            migrationBuilder.AddForeignKey(
                name: "FK_questions_exams_examId",
                table: "questions",
                column: "examId",
                principalTable: "exams",
                principalColumn: "examId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_questions_exams_examId",
                table: "questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_questions",
                table: "questions");

            migrationBuilder.RenameTable(
                name: "questions",
                newName: "Question");

            migrationBuilder.RenameIndex(
                name: "IX_questions_examId",
                table: "Question",
                newName: "IX_Question_examId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Question",
                table: "Question",
                column: "questionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Question_exams_examId",
                table: "Question",
                column: "examId",
                principalTable: "exams",
                principalColumn: "examId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
