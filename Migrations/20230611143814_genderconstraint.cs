using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examsystem.Migrations
{
    /// <inheritdoc />
    public partial class genderconstraint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddCheckConstraint(
                name: "gender",
                table: "accounts",
                sql: "gender in ('m','M','f','F')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "gender",
                table: "accounts");
        }
    }
}
