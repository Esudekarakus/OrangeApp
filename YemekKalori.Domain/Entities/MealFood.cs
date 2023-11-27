using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekKalori.Domain.Entities
{
    public class MealFood : BaseClass
    {
        public Meal Meal { get; set; }

        public int FoodRefId { get; set; }
        public Food Food { get; set; }

        public decimal Portion { get; set; }
    }
}
