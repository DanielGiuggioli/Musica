using Microsoft.EntityFrameworkCore.Migrations;

namespace Musica.Migrations
{
    public partial class userartists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersArtist",
                table: "UsersArtist");

            migrationBuilder.RenameTable(
                name: "UsersArtist",
                newName: "UsersArtists");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersArtists",
                table: "UsersArtists",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersArtists",
                table: "UsersArtists");

            migrationBuilder.RenameTable(
                name: "UsersArtists",
                newName: "UsersArtist");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersArtist",
                table: "UsersArtist",
                column: "Id");
        }
    }
}
