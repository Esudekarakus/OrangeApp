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

        public int FatRate { get; set; }

        public int CarbRate { get; set; }

        public int ProteinRate { get; set; }
        public FoodType Type { get; set; }

        public ICollection<MealFood> MealFoods { get; set; }
    }
}
