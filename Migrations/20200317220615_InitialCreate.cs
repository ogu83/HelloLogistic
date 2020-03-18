using Microsoft.EntityFrameworkCore.Migrations;

namespace helloLogistic.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boxes",
                columns: table => new
                {
                    BoxId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Weight = table.Column<int>(nullable: false),
                    PartCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boxes", x => x.BoxId);
                });

            migrationBuilder.CreateTable(
                name: "Parts",
                columns: table => new
                {
                    PartId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BoxId = table.Column<int>(nullable: false),
                    PartWeight = table.Column<int>(nullable: false),
                    PartCost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parts", x => x.PartId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boxes");

            migrationBuilder.DropTable(
                name: "Parts");
        }
    }
}
