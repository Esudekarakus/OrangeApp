using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekKalori.Domain.Enums;

namespace YemekKalori.Domain.Entities
{
    public class Food:BaseClass
    {

        public string Name { get; set; }

        public decimal Calorie { get; set; }

        public decimal FatRate { get; set; }

        public decimal CarbRate { get; set; }

        public decimal ProteinRate { get; set; }
        public FoodType Type { get; set; }

        public ICollection<MealFood> MealFoods { get; set; }

        public string? FoodPic {  get; set; }

        public string? PortionDesc { get; set; }

        public override string ToString()
        {
            return $"{Name} {Calorie} Kalori";
            //return base.ToString();
        }
    }
}
