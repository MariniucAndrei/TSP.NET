using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZoneId = table.Column<string>(nullable: true),
                    PeopleGroupsId = table.Column<string>(nullable: true),
                    EventsId = table.Column<string>(nullable: true),
                    NamePhoto = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    isDeleted = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medias");
        }
    }
}
