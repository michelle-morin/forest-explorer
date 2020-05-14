using Microsoft.EntityFrameworkCore.Migrations;

namespace TrailsLookup.Migrations
{
    public partial class updateSaltzmanConnections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 118,
                column: "SecondAdjoiningSegment3",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 119,
                column: "FirstAdjoiningSegment3",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 122,
                column: "FirstAdjoiningSegment3",
                value: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 118,
                column: "SecondAdjoiningSegment3",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 119,
                column: "FirstAdjoiningSegment3",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 122,
                column: "FirstAdjoiningSegment3",
                value: null);
        }
    }
}
