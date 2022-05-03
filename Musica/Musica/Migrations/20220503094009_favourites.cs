using Microsoft.EntityFrameworkCore.Migrations;

namespace Musica.Migrations
{
    public partial class favourites : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFavourite",
                table: "UsersSongs",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFavourite",
                table: "UsersArtists",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "dynDescription",
                table: "Artists",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFavourite",
                table: "UsersSongs");

            migrationBuilder.DropColumn(
                name: "IsFavourite",
                table: "UsersArtists");

            migrationBuilder.DropColumn(
                name: "dynDescription",
                table: "Artists");
        }
    }
}
