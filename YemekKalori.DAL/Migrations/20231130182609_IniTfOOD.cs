using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YemekKalori.DAL.Migrations
{
    public partial class IniTfOOD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MealFood",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Height", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(185), null, "58baaad7621b8a0cb23d3bfb98721cc6d1521b1a9832bdaac29b5d2493026173", "/GJBwxJ3Dw6msTo6v0Oq1oy9FJwDKOZzw5t6P0D/0yM=" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "MealFood");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Height", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(8665), 0m, "4f570fa8daedc357b98274a2aedd284ef3ad5e5d66b71214af534146e8afd20e", "Y1lSTSgVVxTwVWzTsn9GnC+/s5waJID6dMPH4cpGNl0=" });
        }
    }
}
