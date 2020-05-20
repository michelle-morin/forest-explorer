using Microsoft.EntityFrameworkCore.Migrations;

namespace TrailsLookup.Migrations
{
    public partial class updateWildwoodTrail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 1,
                columns: new[] { "FirstAdjoiningSegment1", "FirstAdjoiningSegment2" },
                values: new object[] { 934, 446 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 1,
                columns: new[] { "FirstAdjoiningSegment1", "FirstAdjoiningSegment2" },
                values: new object[] { 1, null });
        }
    }
}
