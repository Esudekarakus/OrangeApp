﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekKalori.Domain.Entities
{
    public class MealFood : BaseClass
    {
        public string Name { get; set; }
        public Meal? Meal { get; set; }
        public int? MealId { get; set; }

        public int FoodId { get; set; }
        public Food Food { get; set; }

        public decimal Calorie { get; set; }
        public decimal FatRate { get; set; }
        public decimal CarbRate { get; set; }
        public decimal ProteinRate { get; set; }

        public decimal Portion { get; set; }


        public override string ToString()
        {
            return $"{Name} {Portion} Porsiyon {Calorie} Kalori";
            //return base.ToString();
        }
    }
}
