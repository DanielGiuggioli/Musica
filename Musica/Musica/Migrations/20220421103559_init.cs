using Microsoft.EntityFrameworkCore.Migrations;

namespace Musica.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    image_url = table.Column<string>(type: "TEXT", nullable: true),
                    url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    title = table.Column<string>(type: "TEXT", nullable: true),
                    artist_names = table.Column<string>(type: "TEXT", nullable: true),
                    full_title = table.Column<string>(type: "TEXT", nullable: true),
                    recording_location = table.Column<string>(type: "TEXT", nullable: true),
                    release_date_for_display = table.Column<string>(type: "TEXT", nullable: true),
                    header_image_url = table.Column<string>(type: "TEXT", nullable: true),
                    url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsersArtist",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    IdUser = table.Column<string>(type: "TEXT", nullable: true),
                    IdArtist = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersArtist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsersSongs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    IdUser = table.Column<string>(type: "TEXT", nullable: true),
                    IdSong = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersSongs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UsersArtist");

            migrationBuilder.DropTable(
                name: "UsersSongs");
        }
    }
}
