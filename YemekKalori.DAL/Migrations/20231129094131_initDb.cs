using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YemekKalori.DAL.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Meals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "MealCalorie",
                table: "Meals",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Height" },
                values: new object[] { new DateTime(2023, 11, 29, 12, 41, 30, 668, DateTimeKind.Local).AddTicks(5302), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Meals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "MealCalorie",
                table: "Meals",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Height" },
                values: new object[] { new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(6823), 0m });
        }
    }
}
