using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PracriseMigra.Migrations
{
    /// <inheritdoc />
    public partial class AboutDbs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "abouts");
        }
    }
}
