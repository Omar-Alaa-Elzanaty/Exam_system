using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examsystem.Migrations
{
    /// <inheritdoc />
    public partial class addtableResult : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Result_Exam_examId",
                table: "Result");

            migrationBuilder.DropForeignKey(
                name: "FK_Result_students_sId",
                table: "Result");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Result",
                table: "Result");

            migrationBuilder.RenameTable(
                name: "Result",
                newName: "results");

            migrationBuilder.RenameIndex(
                name: "IX_Result_examId",
                table: "results",
                newName: "IX_results_examId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_results",
                table: "results",
                columns: new[] { "sId", "examId" });

            migrationBuilder.AddForeignKey(
                name: "FK_results_Exam_examId",
                table: "results",
                column: "examId",
                principalTable: "Exam",
                principalColumn: "examId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_results_students_sId",
                table: "results",
                column: "sId",
                principalTable: "students",
                principalColumn: "studentId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_results_Exam_examId",
                table: "results");

            migrationBuilder.DropForeignKey(
                name: "FK_results_students_sId",
                table: "results");

            migrationBuilder.DropPrimaryKey(
                name: "PK_results",
                table: "results");

            migrationBuilder.RenameTable(
                name: "results",
                newName: "Result");

            migrationBuilder.RenameIndex(
                name: "IX_results_examId",
                table: "Result",
                newName: "IX_Result_examId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Result",
                table: "Result",
                columns: new[] { "sId", "examId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Exam_examId",
                table: "Result",
                column: "examId",
                principalTable: "Exam",
                principalColumn: "examId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Result_students_sId",
                table: "Result",
                column: "sId",
                principalTable: "students",
                principalColumn: "studentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
