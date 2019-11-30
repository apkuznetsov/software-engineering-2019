using Microsoft.EntityFrameworkCore.Migrations;

namespace GasStationMs.Dal.Migrations
{
    public partial class FuelsPriveToDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Fuels",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Fuels",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
