using Microsoft.EntityFrameworkCore.Migrations;

namespace TrailsLookup.Migrations
{
    public partial class addFourthPossibleConnectingSegmentToModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FirstAdjoiningSegment4",
                table: "Trails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecondAdjoiningSegment4",
                table: "Trails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstAdjoiningSegment4",
                table: "Trails");

            migrationBuilder.DropColumn(
                name: "SecondAdjoiningSegment4",
                table: "Trails");
        }
    }
}
