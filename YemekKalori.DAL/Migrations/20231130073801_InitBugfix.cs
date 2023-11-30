using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YemekKalori.DAL.Migrations
{
    public partial class InitBugfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "HedefKalori",
                table: "Users",
                type: "decimal(18,2)",
                nullable: true);

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
                values: new object[] { new DateTime(2023, 11, 30, 10, 38, 0, 880, DateTimeKind.Local).AddTicks(8665), null, "4f570fa8daedc357b98274a2aedd284ef3ad5e5d66b71214af534146e8afd20e", "Y1lSTSgVVxTwVWzTsn9GnC+/s5waJID6dMPH4cpGNl0=" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HedefKalori",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Height", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 55, 30, 982, DateTimeKind.Local).AddTicks(2575), 0m, "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", null });
        }
    }
}
