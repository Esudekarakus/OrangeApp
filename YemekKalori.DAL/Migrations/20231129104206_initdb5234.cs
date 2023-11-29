using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YemekKalori.DAL.Migrations
{
    public partial class initdb5234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_Users_UserId",
                table: "Meals");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Meals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Height" },
                values: new object[] { new DateTime(2023, 11, 29, 13, 42, 6, 297, DateTimeKind.Local).AddTicks(3973), null });

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_Users_UserId",
                table: "Meals",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_Users_UserId",
                table: "Meals");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Meals",
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
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Height" },
                values: new object[] { new DateTime(2023, 11, 29, 13, 18, 5, 743, DateTimeKind.Local).AddTicks(2655), 0m });

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_Users_UserId",
                table: "Meals",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
