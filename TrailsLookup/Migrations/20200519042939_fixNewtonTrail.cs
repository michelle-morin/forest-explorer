using Microsoft.EntityFrameworkCore.Migrations;

namespace TrailsLookup.Migrations
{
    public partial class fixNewtonTrail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 254,
                columns: new[] { "Surface", "Type" },
                values: new object[] { "soil", "Trail/Path (6-12 ft.)" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 254,
                columns: new[] { "Surface", "Type" },
                values: new object[] { "Trail/Path (6-12 ft.)", "soil" });
        }
    }
}
