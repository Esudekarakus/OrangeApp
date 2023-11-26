using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekKalori.Domain.Enums;

namespace YemekKalori.Domain.Entities
{
    public class Meal:BaseClass
    {
        public MealType Type { get; set; }

        public int Calorie { get; set; } // Total calorie of the foods included in this meal.

        public ICollection<Food> Foods { get; set; } // Collection of foods that this meal contains.
        public int UserRefId { get; set; } // Foreign key for the user that ate this meal.
        public User User { get; set; } // The user that ate this meal.

    }
}
