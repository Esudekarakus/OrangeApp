using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekKalori.Domain.Entities
{
    public class Food:BaseClass
    {
        public string Name { get; set; }

        public string PortionType { get; set; }

        public int Calorie { get; set; }

        public decimal Portion { get; set; }

        public Meal Meal { get; set; }

        public int FatRate { get; set; }

        public int CarbRate { get; set; }

        public int ProteinRate { get; set; }
        public int MealRefID { get; set; }

        public ICollection<FoodType> FoodTypes { get; set; }
    }
}
