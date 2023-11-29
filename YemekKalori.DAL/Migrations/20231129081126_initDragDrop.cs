using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YemekKalori.DAL.Migrations
{
    public partial class initDragDrop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealFood_Meals_MealId",
                table: "MealFood");

            migrationBuilder.AlterColumn<int>(
                name: "MealId",
                table: "MealFood",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                values: new object[] { new DateTime(2023, 11, 29, 11, 11, 25, 452, DateTimeKind.Local).AddTicks(6823), null });

            migrationBuilder.AddForeignKey(
                name: "FK_MealFood_Meals_MealId",
                table: "MealFood",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealFood_Meals_MealId",
                table: "MealFood");

            migrationBuilder.AlterColumn<int>(
                name: "MealId",
                table: "MealFood",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Height" },
                values: new object[] { new DateTime(2023, 11, 28, 12, 17, 4, 18, DateTimeKind.Local).AddTicks(2474), 0m });

            migrationBuilder.AddForeignKey(
                name: "FK_MealFood_Meals_MealId",
                table: "MealFood",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
