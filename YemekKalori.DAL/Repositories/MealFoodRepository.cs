using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekKalori.DAL.Context;
using YemekKalori.Domain.Entities;

namespace YemekKalori.DAL.Repositories
{
    public class MealFoodRepository
    {
        public MealFoodRepository()
        {
            dbContext = new AppDbContext();
        }
        AppDbContext dbContext;
        
        
    }
}
