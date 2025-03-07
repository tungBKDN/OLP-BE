using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OLPServer.Migrations
{
    /// <inheritdoc />
    public partial class FIX_NullProblemMediaLink_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAnswered",
                table: "KDQuestions",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAnswered",
                table: "KDQuestions");
        }
    }
}
