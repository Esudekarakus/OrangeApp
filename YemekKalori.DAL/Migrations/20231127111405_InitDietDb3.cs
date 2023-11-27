using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YemekKalori.DAL.Migrations
{
    public partial class InitDietDb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Meals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "MealFood",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 14, 14, 4, 791, DateTimeKind.Local).AddTicks(2299));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "MealFood");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Foods");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 13, 49, 33, 649, DateTimeKind.Local).AddTicks(6548));
        }
    }
}
