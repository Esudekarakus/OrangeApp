using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekKalori.Domain.Entities
{
    public class FoodType:BaseClass
    {
        public string Name { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}
