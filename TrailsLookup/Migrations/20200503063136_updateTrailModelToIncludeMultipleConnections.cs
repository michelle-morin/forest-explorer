using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrailsLookup.Migrations
{
    public partial class updateTrailModelToIncludeMultipleConnections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trails",
                columns: table => new
                {
                    TrailId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GeoObjNumber = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Miles = table.Column<double>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Surface = table.Column<string>(nullable: true),
                    FirstAdjoiningSegment1 = table.Column<int>(nullable: false),
                    FirstAdjoiningSegment2 = table.Column<int>(nullable: true),
                    FirstAdjoiningSegment3 = table.Column<int>(nullable: true),
                    SecondAdjoiningSegment1 = table.Column<int>(nullable: false),
                    SecondAdjoiningSegment2 = table.Column<int>(nullable: true),
                    SecondAdjoiningSegment3 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trails", x => x.TrailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trails");
        }
    }
}
