using Microsoft.EntityFrameworkCore.Migrations;

namespace GasStationMs.Dal.Migrations
{
    public partial class FuelsPreset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Fuels",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "Fuels",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "АИ-92", 42.299999999999997 },
                    { 2, "АИ-92+", 43.299999999999997 },
                    { 3, "АИ-95", 45.899999999999999 },
                    { 4, "АИ-95+", 46.899999999999999 },
                    { 5, "АИ-98", 48.100000000000001 },
                    { 6, "АИ-100", 51.799999999999997 },
                    { 7, "ДТ", 46.299999999999997 },
                    { 8, "Пропан", 20.899999999999999 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fuels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fuels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fuels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fuels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fuels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Fuels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Fuels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Fuels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Fuels",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
