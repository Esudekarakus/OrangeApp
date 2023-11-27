using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YemekKalori.DAL.Migrations
{
    public partial class InitDietAppDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calorie = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FatRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CarbRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProteinRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Diet = table.Column<int>(type: "int", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Goal = table.Column<int>(type: "int", nullable: true),
                    BMI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    MealTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserRefId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meals_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MealFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    FoodRefId = table.Column<int>(type: "int", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    Portion = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealFood", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MealFood_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealFood_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calorie", "CarbRate", "CreatedDate", "DeletedDate", "FatRate", "ModifiedDate", "Name", "ProteinRate", "Type" },
                values: new object[,]
                {
                    { 1, 155m, 1.1m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7595), null, 10.6m, null, "Haşlanmış Yumurta", 12.6m, 5 },
                    { 2, 264m, 1.4m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7605), null, 21m, null, "Peynir", 18m, 4 },
                    { 3, 115m, 6m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7607), null, 11m, null, "Siyah Zeytin", 0.8m, 2 },
                    { 4, 145m, 3.8m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7608), null, 15.3m, null, "Yeşil Zeytin", 1m, 2 },
                    { 5, 196m, 1.1m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7610), null, 15m, null, "Sahanda Yumurta", 14m, 5 },
                    { 6, 106m, 10m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7611), null, 4.9m, null, "Menemen", 6.4m, 5 },
                    { 7, 266m, 67m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7612), null, 0.2m, null, "Reçel", 0.3m, 1 },
                    { 8, 304m, 82m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7613), null, 0m, null, "Bal", 0.3m, 8 },
                    { 9, 336m, 1.4m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7614), null, 30m, null, "Salam", 13m, 3 },
                    { 10, 1m, 0.3m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7615), null, 0m, null, "Çay", 0m, 9 },
                    { 11, 1m, 0m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7616), null, 0m, null, "Yeşil Çay", 0m, 9 },
                    { 12, 45m, 10.4m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7617), null, 0.2m, null, "Portakal Suyu", 0.7m, 10 },
                    { 13, 42m, 5m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7618), null, 1m, null, "Süt", 3.4m, 4 },
                    { 14, 66m, 9.2m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7619), null, 2.2m, null, "Mercimek Çorbası", 4.1m, 2 },
                    { 15, 39m, 3.9m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7620), null, 1.5m, null, "Tavuk Çorbası", 2.9m, 3 },
                    { 16, 32m, 4.3m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7621), null, 1.6m, null, "Domates Çorbası", 1.2m, 2 },
                    { 17, 40m, 5.3m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7622), null, 1.5m, null, "Sebze Çorbası", 1.4m, 2 },
                    { 18, 130m, 28.2m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7623), null, 0.3m, null, "Pirinç Pilavı", 2.7m, 6 },
                    { 19, 83m, 18.6m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7625), null, 0.2m, null, "Bulgur Pilavı", 3.1m, 6 },
                    { 20, 131m, 25m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7626), null, 1.1m, null, "Makarna", 5m, 7 },
                    { 21, 180m, 2m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7627), null, 8m, null, "Kebap", 25m, 3 },
                    { 22, 225m, 2.2m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7629), null, 12m, null, "Döner", 26m, 3 },
                    { 23, 333m, 31.8m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7630), null, 17.8m, null, "Falafel", 13.3m, 2 },
                    { 24, 254m, 30m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7631), null, 10m, null, "Hamburger", 12m, 3 },
                    { 25, 20m, 4m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7632), null, 0.2m, null, "Mevsim Salata", 1m, 2 },
                    { 26, 23m, 4.3m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7633), null, 0.4m, null, "Çoban Salata", 1.1m, 2 },
                    { 27, 265m, 49m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7634), null, 3.2m, null, "Beyaz Ekmek", 9m, 7 },
                    { 28, 247m, 41m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7635), null, 4.2m, null, "Keepekli Ekmek", 13m, 7 },
                    { 29, 259m, 48.3m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7636), null, 3.3m, null, "Çavdar Ekmeği", 8.5m, 7 },
                    { 30, 247m, 43.4m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7637), null, 4.4m, null, "Tam Tahıllı Ekmek", 13m, 7 },
                    { 31, 0.5m, 0m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7638), null, 0m, null, "Light Cola", 0m, 11 },
                    { 32, 48m, 12m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7639), null, 0m, null, "Fanta", 0m, 11 },
                    { 33, 30m, 7.5m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7640), null, 0m, null, "Ice Tea", 0m, 11 },
                    { 34, 37m, 3.5m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7641), null, 2m, null, "Ayran", 1.7m, 4 },
                    { 35, 299m, 79.2m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7643), null, 0.5m, null, "Kuru Üzüm", 3.1m, 1 },
                    { 36, 241m, 62.6m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7644), null, 0.5m, null, "Kuru Kayısı", 3.4m, 1 },
                    { 37, 654m, 13.7m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7645), null, 65.2m, null, "Ceviz", 15.2m, 12 },
                    { 38, 628m, 16.7m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7646), null, 60.8m, null, "Fındık", 15m, 12 },
                    { 39, 567m, 16.1m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7647), null, 49.2m, null, "Fıstık", 25.8m, 12 },
                    { 40, 52m, 13.8m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7691), null, 0.2m, null, "Yeşil Elma", 0.3m, 1 },
                    { 41, 546m, 45m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7693), null, 31m, null, "Bitter Çikolata", 5m, 13 },
                    { 42, 2m, 0m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7695), null, 0m, null, "Türk Kahvesi", 0.1m, 14 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calorie", "CarbRate", "CreatedDate", "DeletedDate", "FatRate", "ModifiedDate", "Name", "ProteinRate", "Type" },
                values: new object[] { 43, 1m, 0m, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(7696), null, 0m, null, "Filtre Kahve", 0.1m, 14 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BMI", "CreatedDate", "DeletedDate", "Diet", "FirstName", "Goal", "Height", "LastName", "ModifiedDate", "Status", "Type", "Username", "Weight" },
                values: new object[] { 1, null, new DateTime(2023, 11, 27, 11, 20, 32, 28, DateTimeKind.Local).AddTicks(5463), null, null, "Admin", null, null, "Admin", null, 1, 1, "admin", null });

            migrationBuilder.CreateIndex(
                name: "IX_MealFood_FoodId",
                table: "MealFood",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_MealFood_MealId",
                table: "MealFood",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_UserId",
                table: "Meals",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MealFood");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
