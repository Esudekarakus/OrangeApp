using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YemekKalori.DAL.Migrations
{
    public partial class InitPics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FoodPic",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5153), "Images/HaşlanmışYumurta.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5157), "Images/BeyazPeynir.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5159), "Images/siya-zeytin.jpeg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5161), "Images/YesilZeytin.png", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5163), "Images/SahandaYumurta.png", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5164), "Images/Menemen.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5166), "Images/Reçel.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5167), "Images/bal.png", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5168), "Images/salam.png", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5171), "Images/Çay.png", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5172), "Images/YesilCay.png", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5173), "Images/Portakal-suyu.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5175), "Images/Süt.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5177), "Images/MercimekCorbası.png", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5178), "Images/Tavuk Çorbası.png", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5179), "Images/domatesÇorbası.png", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5181), "Images/SebzeÇorbası.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5183), "Images/PirinçPilavı.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5185), "Images/BulgurPilavı.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5186), "Images/Makarna.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5187), "Images/Kebap.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5189), "Images/Döner.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5190), "Images/Falafel.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5191), "Images/Hamburger.png", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5194), "Images/MevsimSalata.png", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5195), "Images/coban_salatasi.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5196), "Images/beyaz_ekmek.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "FoodPic", "Name", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5198), "Images/kepek_ekmegi.jpg", "Kepekli Ekmek", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5199), "Images/cavdar_ekmegi.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5201), "Images/tam_tahilli_ekmek.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5202), "Images/light_kola.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5203), "Images/fanta.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5207), "Images/icetea.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5208), "Images/ayran.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5209), "kuru_uzum.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5211), "Images/kuru_kayisi.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5212), "Images/ceviz.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5213), "Images/findik.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5215), "Images/fistik.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5216), "yesil_elma.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5245), "bitter_cikolata.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5247), "Images/turk_kahve.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "FoodPic", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5248), "Images/filtre_kahve.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Height", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(4405), null, "a400467bedede01a08c86c6b11ce7b6d97fe6e702df76c6b5364ce6a04d86d0b", "OLXx4jI5mjJQQem+RBVrGmkwrKx/TljK3xYothYCcMY=" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoodPic",
                table: "Foods");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(852), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(857), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(859), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(860), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(863), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(864), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(865), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(867), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(868), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(869), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(871), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(872), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(873), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(874), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(877), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(878), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(879), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(881), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(882), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(883), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(885), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(886), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(888), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(889), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(891), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(892), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(893), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Name", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(895), "Keepekli Ekmek", 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(896), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(897), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(900), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(902), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(903), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(904), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(905), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(907), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(908), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(909), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(911), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(912), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(913), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(915), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(916), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Height", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(185), 0m, "58baaad7621b8a0cb23d3bfb98721cc6d1521b1a9832bdaac29b5d2493026173", "/GJBwxJ3Dw6msTo6v0Oq1oy9FJwDKOZzw5t6P0D/0yM=" });
        }
    }
}
