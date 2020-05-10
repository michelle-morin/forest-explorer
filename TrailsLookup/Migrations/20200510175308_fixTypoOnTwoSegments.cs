using Microsoft.EntityFrameworkCore.Migrations;

namespace TrailsLookup.Migrations
{
    public partial class fixTypoOnTwoSegments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 149,
                column: "Name",
                value: "Saltzman Rd. / Powerline Area Path");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 150,
                column: "Name",
                value: "Saltzman Rd. / Powerline Area Path");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 149,
                column: "Name",
                value: "Saltzmann Rd. / Powerline Area Path");

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 150,
                column: "Name",
                value: "Saltzmann Rd. / Powerline Area Path");
        }
    }
}
