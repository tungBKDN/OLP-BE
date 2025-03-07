using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OLPServer.Migrations
{
    /// <inheritdoc />
    public partial class FIX_NullProblemMediaLink_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MediaLink",
                table: "KDQuestions",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KDQuestions",
                keyColumn: "MediaLink",
                keyValue: null,
                column: "MediaLink",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "MediaLink",
                table: "KDQuestions",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
