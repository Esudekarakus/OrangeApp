using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YemekKalori.DAL.Migrations
{
    public partial class InitDietDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "MealCalorie",
                table: "Meals",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Calorie",
                table: "MealFood",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CarbRate",
                table: "MealFood",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FatRate",
                table: "MealFood",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProteinRate",
                table: "MealFood",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MealCalorie",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "Calorie",
                table: "MealFood");

            migrationBuilder.DropColumn(
                name: "CarbRate",
                table: "MealFood");

            migrationBuilder.DropColumn(
                name: "FatRate",
                table: "MealFood");

            migrationBuilder.DropColumn(
                name: "ProteinRate",
                table: "MealFood");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(5463));
        }
    }
}
