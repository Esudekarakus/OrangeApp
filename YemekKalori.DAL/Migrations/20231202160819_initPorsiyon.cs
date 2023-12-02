using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YemekKalori.DAL.Migrations
{
    public partial class initPorsiyon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PortionDesc",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1199), "Adet" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1205), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1207), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1209), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1211), "Adet" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1213), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1214), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1216), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1217), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1219), "Bardak" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1253), "Bardak" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1256), "Bardak" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1257), "Bardak" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1259), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1261), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1262), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1264), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1265), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1267), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1269), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1271), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1272), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1273), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1275), "Adet" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1276), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1278), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1280), "2 dilim" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1282), "2 dilim" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1283), "2 dilim" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1284), "2 dilim" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1286), "Bardak" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1288), "Bardak" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1289), "Bardak" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1290), "Bardak" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1292), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1293), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1295), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1296), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1297), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1299), "Adet" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1300), "100 gram" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1302), "Bardak" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "PortionDesc" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(1303), "Bardak" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Height", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 12, 2, 19, 8, 18, 307, DateTimeKind.Local).AddTicks(461), null, "bb45fec7df187f3093140a513b6583e87afdfe0acb21cbcaa407801dab9ad9ac", "0jPAgQnflJYNLtvYExEiZ6FVEDgA8RFY6dXqNbHh/PU=" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PortionDesc",
                table: "Foods");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Height", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 17, 20, 210, DateTimeKind.Local).AddTicks(3352), 0m, "5da1aea6bba64ffb86f95352c7774dd45806cbdf58d4011f1a271c203419f1d3", "gBjF6dQP1Dt56B/8dqPko3hrEWzLCldfQgtEsWe1Fv4=" });
        }
    }
}
