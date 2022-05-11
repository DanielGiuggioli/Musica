using Microsoft.EntityFrameworkCore.Migrations;

namespace Musica.Migrations
{
    public partial class primaryartist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "primary_artist",
                table: "Songs",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "primary_artist",
                table: "Songs");
        }
    }
}
