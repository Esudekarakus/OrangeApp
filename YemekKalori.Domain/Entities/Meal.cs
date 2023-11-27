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
        public DateTime MealTime { get; set; }

        public ICollection<MealFood> MealFoods { get; set; }

        public decimal MealCalorie { get; set; }
        public int UserRefId { get; set; }
        public User User { get; set; }
        



    }
}
