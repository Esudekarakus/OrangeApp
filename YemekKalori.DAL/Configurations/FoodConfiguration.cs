using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekKalori.Domain.Entities;

namespace YemekKalori.DAL.Configurations
{
    public class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.ToTable("Foods");

            builder.HasData
                (
                    new Food
                    {
                        Id = 1,
                        CreatedDate = DateTime.Now,
                        Name = "Haşlanmış Yumurta",
                        Calorie = 155,
                        CarbRate = 1.1m,
                        FatRate = 10.6m,
                        ProteinRate = 12.6m,
                        Type = Domain.Enums.FoodType.Eggs,
                        FoodPic = "Images/HaşlanmışYumurta.jpg",
                        PortionDesc = "Adet"
                    },
                    new Food
                    {
                        Id = 2,
                        CreatedDate = DateTime.Now,
                        Name = "Peynir",
                        Calorie = 264,
                        CarbRate = 1.4m,
                        FatRate = 21,
                        ProteinRate = 18,
                        Type = Domain.Enums.FoodType.DairyProducts,
                        FoodPic = "Images/BeyazPeynir.jpg",
                        PortionDesc = "100 gram"

                    },
                    new Food
                    {
                        Id = 3,
                        CreatedDate = DateTime.Now,
                        Name = "Siyah Zeytin",
                        Calorie = 115,
                        CarbRate = 6,
                        FatRate = 11,
                        ProteinRate = 0.8m,
                        Type = Domain.Enums.FoodType.Vegetables,
                        FoodPic = "Images/siyah-zeytin.jpeg",
                        PortionDesc = "100 gram"
                    },
                    new Food
                    {
                        Id = 4,
                        CreatedDate = DateTime.Now,
                        Name = "Yeşil Zeytin",
                        Calorie = 145,
                        CarbRate = 3.8m,
                        FatRate = 15.3m,
                        ProteinRate = 1,
                        Type = Domain.Enums.FoodType.Vegetables,
                        FoodPic = "Images/YesilZeytin.png",
                        PortionDesc = "100 gram"
                    },
                    new Food
                    {
                        Id = 5,
                        CreatedDate = DateTime.Now,
                        Name = "Sahanda Yumurta",
                        Calorie = 196,
                        CarbRate = 1.1m,
                        FatRate = 15,
                        ProteinRate = 14,
                        Type = Domain.Enums.FoodType.Eggs,
                        FoodPic = "Images/SahandaYumurta.png",
                        PortionDesc = "Adet"
                    },

                    new Food
                    {
                        Id = 6,
                        CreatedDate = DateTime.Now,
                        Name = "Menemen",
                        Calorie = 106,
                        CarbRate = 10,
                        FatRate = 4.9m,
                        ProteinRate = 6.4m,
                        Type = Domain.Enums.FoodType.Eggs,
                        FoodPic = "Images/Menemen.jpg",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 7,
                        CreatedDate = DateTime.Now,
                        Name = "Reçel",
                        Calorie = 266,
                        CarbRate = 67,
                        FatRate = 0.2m,
                        ProteinRate = 0.3m,
                        Type = Domain.Enums.FoodType.Fruits,
                        FoodPic = "Images/Reçel.jpg",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 8,
                        CreatedDate = DateTime.Now,
                        Name = "Bal",
                        Calorie = 304,
                        CarbRate = 82,
                        FatRate = 0,
                        ProteinRate = 0.3m,
                        Type = Domain.Enums.FoodType.Honey,
                        FoodPic = "Images/bal.png",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 9,
                        CreatedDate = DateTime.Now,
                        Name = "Salam",
                        Calorie = 336,
                        CarbRate = 1.4m,
                        FatRate = 30,
                        ProteinRate = 13m,
                        Type = Domain.Enums.FoodType.MeatProducts,
                        FoodPic = "Images/salam.png",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 10,
                        CreatedDate = DateTime.Now,
                        Name = "Çay",
                        Calorie = 1,
                        CarbRate = 0.3m,
                        FatRate = 0,
                        ProteinRate = 0,
                        Type = Domain.Enums.FoodType.Tea,
                        FoodPic = "Images/Çay.png",
                        PortionDesc = "Bardak"
                    },

                    new Food
                    {
                        Id = 11,
                        CreatedDate = DateTime.Now,
                        Name = "Yeşil Çay",
                        Calorie = 1,
                        CarbRate = 0,
                        FatRate = 0,
                        ProteinRate = 0,
                        Type = Domain.Enums.FoodType.Tea,
                        FoodPic = "Images/YesilCay.png",
                        PortionDesc = "Bardak"
                    },

                    new Food
                    {
                        Id = 12,
                        CreatedDate = DateTime.Now,
                        Name = "Portakal Suyu",
                        Calorie = 45,
                        CarbRate = 10.4m,
                        FatRate = 0.2m,
                        ProteinRate = 0.7m,
                        Type = Domain.Enums.FoodType.Juice,
                        FoodPic = "Images/Portakal-suyu.jpg",
                        PortionDesc = "Bardak"
                    },

                    new Food
                    {
                        Id = 13,
                        CreatedDate = DateTime.Now,
                        Name = "Süt",
                        Calorie = 42,
                        CarbRate = 5,
                        FatRate = 1,
                        ProteinRate = 3.4m,
                        Type = Domain.Enums.FoodType.DairyProducts,
                        FoodPic = "Images/Süt.jpg",
                        PortionDesc = "Bardak"
                    },

                    new Food
                    {
                        Id = 14,
                        CreatedDate = DateTime.Now,
                        Name = "Mercimek Çorbası",
                        Calorie = 66,
                        CarbRate = 9.2m,
                        FatRate = 2.2m,
                        ProteinRate = 4.1m,
                        Type = Domain.Enums.FoodType.Vegetables,
                        FoodPic = "Images/MercimekCorbası.png",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 15,
                        CreatedDate = DateTime.Now,
                        Name = "Tavuk Çorbası",
                        Calorie = 39,
                        CarbRate = 3.9m,
                        FatRate = 1.5m,
                        ProteinRate = 2.9m,
                        Type = Domain.Enums.FoodType.MeatProducts,
                        FoodPic = "Images/Tavuk Çorbası.png",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 16,
                        CreatedDate = DateTime.Now,
                        Name = "Domates Çorbası",
                        Calorie = 32,
                        CarbRate = 4.3m,
                        FatRate = 1.6m,
                        ProteinRate = 1.2m,
                        Type = Domain.Enums.FoodType.Vegetables,
                        FoodPic = "Images/domatesÇorbası.png",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 17,
                        CreatedDate = DateTime.Now,
                        Name = "Sebze Çorbası",
                        Calorie = 40,
                        CarbRate = 5.3m,
                        FatRate = 1.5m,
                        ProteinRate = 1.4m,
                        Type = Domain.Enums.FoodType.Vegetables,
                        FoodPic = "Images/SebzeÇorbası.jpg",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 18,
                        CreatedDate = DateTime.Now,
                        Name = "Pirinç Pilavı",
                        Calorie = 130,
                        CarbRate = 28.2m,
                        FatRate = 0.3m,
                        ProteinRate = 2.7m,
                        Type = Domain.Enums.FoodType.Legumes,
                        FoodPic = "Images/PirinçPilavı.jpg",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 19,
                        CreatedDate = DateTime.Now,
                        Name = "Bulgur Pilavı",
                        Calorie = 83,
                        CarbRate = 18.6m,
                        FatRate = 0.2m,
                        ProteinRate = 3.1m,
                        Type = Domain.Enums.FoodType.Legumes,
                        FoodPic = "Images/BulgurPilavı.jpg",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 20,
                        CreatedDate = DateTime.Now,
                        Name = "Makarna",
                        Calorie = 131,
                        CarbRate = 25,
                        FatRate = 1.1m,
                        ProteinRate = 5,
                        Type = Domain.Enums.FoodType.GrainProducts,
                        FoodPic = "Images/Makarna.jpg",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 21,
                        CreatedDate = DateTime.Now,
                        Name = "Kebap",
                        Calorie = 180,
                        CarbRate = 2,
                        FatRate = 8,
                        ProteinRate = 25,
                        Type = Domain.Enums.FoodType.MeatProducts,
                        FoodPic = "Images/Kebap.jpg",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 22,
                        CreatedDate = DateTime.Now,
                        Name = "Döner",
                        Calorie = 225,
                        CarbRate = 2.2m,
                        FatRate = 12,
                        ProteinRate = 26,
                        Type = Domain.Enums.FoodType.MeatProducts,
                        FoodPic = "Images/Döner.jpg",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 23,
                        CreatedDate = DateTime.Now,
                        Name = "Falafel",
                        Calorie = 333,
                        CarbRate = 31.8m,
                        FatRate = 17.8m,
                        ProteinRate = 13.3m,
                        Type = Domain.Enums.FoodType.Vegetables,
                        FoodPic = "Images/Falafel.jpg",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 24,
                        CreatedDate = DateTime.Now,
                        Name = "Hamburger",
                        Calorie = 254,
                        CarbRate = 30,
                        FatRate = 10,
                        ProteinRate = 12,
                        Type = Domain.Enums.FoodType.MeatProducts,
                        FoodPic = "Images/Hamburger.png",
                        PortionDesc = "Adet"
                    },

                    new Food
                    {
                        Id = 25,
                        CreatedDate = DateTime.Now,
                        Name = "Mevsim Salata",
                        Calorie = 20,
                        CarbRate = 4,
                        FatRate = 0.2m,
                        ProteinRate = 1,
                        Type = Domain.Enums.FoodType.Vegetables,
                        FoodPic = "Images/MevsimSalata.png",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 26,
                        CreatedDate = DateTime.Now,
                        Name = "Çoban Salata",
                        Calorie = 23,
                        CarbRate = 4.3m,
                        FatRate = 0.4m,
                        ProteinRate = 1.1m,
                        Type = Domain.Enums.FoodType.Vegetables,
                        FoodPic = "Images/coban_salatasi.jpg",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 27,
                        CreatedDate = DateTime.Now,
                        Name = "Beyaz Ekmek",
                        Calorie = 265,
                        CarbRate = 49,
                        FatRate = 3.2m,
                        ProteinRate = 9,
                        Type = Domain.Enums.FoodType.GrainProducts,
                        FoodPic = "Images/beyaz_ekmek.jpg",
                        PortionDesc = "2 dilim"
                    },

                    new Food
                    {
                        Id = 28,
                        CreatedDate = DateTime.Now,
                        Name = "Kepekli Ekmek",
                        Calorie = 247,
                        CarbRate = 41,
                        FatRate = 4.2m,
                        ProteinRate = 13,
                        Type = Domain.Enums.FoodType.GrainProducts,
                        FoodPic = "Images/kepek_ekmegi.jpg",
                        PortionDesc = "2 dilim"
                    },

                    new Food
                    {
                        Id = 29,
                        CreatedDate = DateTime.Now,
                        Name = "Çavdar Ekmeği",
                        Calorie = 259,
                        CarbRate = 48.3m,
                        FatRate = 3.3m,
                        ProteinRate = 8.5m,
                        Type = Domain.Enums.FoodType.GrainProducts,
                        FoodPic = "Images/cavdar_ekmegi.jpg",
                        PortionDesc = "2 dilim"
                    },

                    new Food
                    {
                        Id = 30,
                        CreatedDate = DateTime.Now,
                        Name = "Tam Tahıllı Ekmek",
                        Calorie = 247,
                        CarbRate = 43.4m,
                        FatRate = 4.4m,
                        ProteinRate = 13,
                        Type = Domain.Enums.FoodType.GrainProducts,
                        FoodPic = "Images/tam_tahilli_ekmek.jpg",
                        PortionDesc = "2 dilim"
                    },

                    new Food
                    {
                        Id = 31,
                        CreatedDate = DateTime.Now,
                        Name = "Light Cola",
                        Calorie = 0.5m,
                        CarbRate = 0,
                        FatRate = 0,
                        ProteinRate = 0,
                        Type = Domain.Enums.FoodType.SugaryDrinks,
                        FoodPic = "Images/light_kola.jpg",
                        PortionDesc = "Bardak"
                    },

                    new Food
                    {
                        Id = 32,
                        CreatedDate = DateTime.Now,
                        Name = "Fanta",
                        Calorie = 48,
                        CarbRate = 12,
                        FatRate = 0,
                        ProteinRate = 0,
                        Type = Domain.Enums.FoodType.SugaryDrinks,
                        FoodPic = "Images/fanta.jpg",
                        PortionDesc = "Bardak"
                    },

                    new Food
                    {
                        Id = 33,
                        CreatedDate = DateTime.Now,
                        Name = "Ice Tea",
                        Calorie = 30,
                        CarbRate = 7.5m,
                        FatRate = 0,
                        ProteinRate = 0,
                        Type = Domain.Enums.FoodType.SugaryDrinks,
                        FoodPic = "Images/icetea.jpg",
                        PortionDesc = "Bardak"
                    },

                    new Food
                    {
                        Id = 34,
                        CreatedDate = DateTime.Now,
                        Name = "Ayran",
                        Calorie = 37,
                        CarbRate = 3.5m,
                        FatRate = 2,
                        ProteinRate = 1.7m,
                        Type = Domain.Enums.FoodType.DairyProducts,
                        FoodPic = "Images/ayran.jpg",
                        PortionDesc = "Bardak"
                    },

                    new Food
                    {
                        Id = 35,
                        CreatedDate = DateTime.Now,
                        Name = "Kuru Üzüm",
                        Calorie = 299,
                        CarbRate = 79.2m,
                        FatRate = 0.5m,
                        ProteinRate = 3.1m,
                        Type = Domain.Enums.FoodType.Fruits,
                        FoodPic = "Images/kuru_uzum.jpg",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 36,
                        CreatedDate = DateTime.Now,
                        Name = "Kuru Kayısı",
                        Calorie = 241,
                        CarbRate = 62.6m,
                        FatRate = 0.5m,
                        ProteinRate = 3.4m,
                        Type = Domain.Enums.FoodType.Fruits,
                        FoodPic = "Images/kuru_kayisi.jpg",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 37,
                        CreatedDate = DateTime.Now,
                        Name = "Ceviz",
                        Calorie = 654,
                        CarbRate = 13.7m,
                        FatRate = 65.2m,
                        ProteinRate = 15.2m,
                        Type = Domain.Enums.FoodType.Nuts,
                        FoodPic = "Images/ceviz.jpg",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 38,
                        CreatedDate = DateTime.Now,
                        Name = "Fındık",
                        Calorie = 628,
                        CarbRate = 16.7m,
                        FatRate = 60.8m,
                        ProteinRate = 15,
                        Type = Domain.Enums.FoodType.Nuts,
                        FoodPic = "Images/findik.jpg",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 39,
                        CreatedDate = DateTime.Now,
                        Name = "Fıstık",
                        Calorie = 567,
                        CarbRate = 16.1m,
                        FatRate = 49.2m,
                        ProteinRate = 25.8m,
                        Type = Domain.Enums.FoodType.Nuts,
                        FoodPic = "Images/fistik.jpg",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 40,
                        CreatedDate = DateTime.Now,
                        Name = "Yeşil Elma",
                        Calorie = 52,
                        CarbRate = 13.8m,
                        FatRate = 0.2m,
                        ProteinRate = 0.3m,
                        Type = Domain.Enums.FoodType.Fruits,
                        FoodPic = "Images/yesil_elma.jpg",
                        PortionDesc = "Adet"
                    },

                    new Food
                    {
                        Id = 41,
                        CreatedDate = DateTime.Now,
                        Name = "Bitter Çikolata",
                        Calorie = 546,
                        CarbRate = 45,
                        FatRate = 31,
                        ProteinRate = 5,
                        Type = Domain.Enums.FoodType.ProcessedFood,
                        FoodPic = "Images/bitter_cikolata.jpg",
                        PortionDesc = "100 gram"
                    },

                    new Food
                    {
                        Id = 42,
                        CreatedDate = DateTime.Now,
                        Name = "Türk Kahvesi",
                        Calorie = 2,
                        CarbRate = 0,
                        FatRate = 0,
                        ProteinRate = 0.1m,
                        Type = Domain.Enums.FoodType.Coffee,
                        FoodPic = "Images/turk_kahve.jpg",
                        PortionDesc = "Bardak"
                    },

                    new Food
                    {
                        Id = 43,
                        CreatedDate = DateTime.Now,
                        Name = "Filtre Kahve",
                        Calorie = 1,
                        CarbRate = 0,
                        FatRate = 0,
                        ProteinRate = 0.1m,
                        Type = Domain.Enums.FoodType.Coffee,
                        FoodPic = "Images/filtre_kahve.jpg",
                        PortionDesc = "Bardak"
                    }

                    


                );
        }
    }
}
