using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examsystem.Migrations
{
    /// <inheritdoc />
    public partial class changenullable : Migration
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
                name: "FK_Result_students_sId",
                table: "Result");

            migrationBuilder.DropForeignKey(
                name: "FK_students_accounts_accId",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_teachers_accounts_accId",
                table: "teachers");

            migrationBuilder.DropIndex(
                name: "IX_teachers_accId",
                table: "teachers");

            migrationBuilder.DropIndex(
                name: "IX_students_accId",
                table: "students");

            migrationBuilder.AlterColumn<int>(
                name: "accId",
                table: "teachers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "accId",
                table: "students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_teachers_accId",
                table: "teachers",
                column: "accId",
                unique: true,
                filter: "[accId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_students_accId",
                table: "students",
                column: "accId",
                unique: true,
                filter: "[accId] IS NOT NULL");

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
                name: "FK_Result_students_sId",
                table: "Result",
                column: "sId",
                principalTable: "students",
                principalColumn: "studentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_students_accounts_accId",
                table: "students",
                column: "accId",
                principalTable: "accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_teachers_accounts_accId",
                table: "teachers",
                column: "accId",
                principalTable: "accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exam_teachers_teacherId",
                table: "Exam");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Exam_examId",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_Result_students_sId",
                table: "Result");

            migrationBuilder.DropForeignKey(
                name: "FK_students_accounts_accId",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_teachers_accounts_accId",
                table: "teachers");

            migrationBuilder.DropIndex(
                name: "IX_teachers_accId",
                table: "teachers");

            migrationBuilder.DropIndex(
                name: "IX_students_accId",
                table: "students");

            migrationBuilder.AlterColumn<int>(
                name: "accId",
                table: "teachers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "accId",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_teachers_accId",
                table: "teachers",
                column: "accId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_students_accId",
                table: "students",
                column: "accId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Exam_teachers_teacherId",
                table: "Exam",
                column: "teacherId",
                principalTable: "teachers",
                principalColumn: "teacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Exam_examId",
                table: "Question",
                column: "examId",
                principalTable: "Exam",
                principalColumn: "examId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Result_students_sId",
                table: "Result",
                column: "sId",
                principalTable: "students",
                principalColumn: "studentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_students_accounts_accId",
                table: "students",
                column: "accId",
                principalTable: "accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teachers_accounts_accId",
                table: "teachers",
                column: "accId",
                principalTable: "accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
