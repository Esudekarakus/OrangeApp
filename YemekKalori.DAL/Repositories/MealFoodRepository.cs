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
        
        public void Add(MealFood entity)
        {
            dbContext.Add(entity);
            dbContext.SaveChanges();
        }

        public void Update(MealFood entity) 
        {
            dbContext.Update(entity);
            dbContext.SaveChanges();
        }

        public void Delete(MealFood entity) 
        {
            entity.Status = Domain.Enums.Status.Deleted;
            dbContext.SaveChanges();
        }

        public void PermaDelete(MealFood entity)
        {
            dbContext.Remove(entity);
            dbContext.SaveChanges();
        }

        public List<MealFood> GetMealFoodByMeal(int mealId)
        {
            List<MealFood> mealFoods = dbContext.MealFoods.Where(a => a.MealId == mealId && a.Status != Domain.Enums.Status.Deleted).ToList();
            return mealFoods;
        }

        public MealFood GetMealFoodById(int  id)
        {
            MealFood mealFood = dbContext.MealFoods.FirstOrDefault(x => x.Id == id && x.Status != Domain.Enums.Status.Deleted);
            return mealFood;
        }


    }
}
