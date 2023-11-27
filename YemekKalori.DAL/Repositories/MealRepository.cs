using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekKalori.DAL.Context;
using YemekKalori.Domain.Entities;

namespace YemekKalori.DAL.Repositories
{
    public class MealRepository
    {
        public MealRepository() 
        {
            dbContext=new AppDbContext();
        }
        AppDbContext dbContext;

        //meal ekle
        public void AddMeal(Meal meal)
        {
            dbContext.Meals.Add(meal);
            dbContext.SaveChanges();

        }
        //update meal
        public void UpdateMeal(Meal meal)
        {
            dbContext.Meals.Update(meal);
            meal.Status = Domain.Enums.Status.Modified;
            dbContext.SaveChanges();
        

        }
        //meal i sil
        public void DeleteMeal(int mealID)
        {
            Meal meal=dbContext.Meals.Where(m => m.Id==mealID).FirstOrDefault();
            dbContext.Meals.Remove(meal);
            dbContext.SaveChanges();
        }
        // status deleted 
        public void DeleteMealByStatus(int mealID)
        {
            Meal meal= dbContext.Meals.FirstOrDefault(x => x.Id == mealID);
            meal.Status = Domain.Enums.Status.Deleted;
            dbContext.SaveChanges();
        }


        //meal id ye göre meal
        public Meal GetMealByMealID(int mealID)
        {
           return dbContext.Meals.FirstOrDefault(x => x.Id == mealID);
        }

        //user ın meallerini getir
        public List<Meal> GetMealsByUser(int userId)
        {
            return dbContext.Meals.Where(x => x.UserId == userId).ToList();
        }

        //tüm meall leri getir

        public List<Meal> GetMeals()
        {
            return dbContext.Meals.ToList();
        }
    

        

        //kahvaltılıkları getir

        //public List <Meal>GetBreakfast()
        //{
        //    return dbContext.Meals.Where(x=>x.Type==Domain.Enums.MealType.Breakfast).ToList();
        //}

        ////öğle  yemeği

        //public List<Meal> GetLunch()
        //{
        //    return dbContext.Meals.Where(x=>x.Type==Domain.Enums.MealType.Lunch).ToList();
        //}
        ////dinner 
        //public List <Meal>GetDinner()
        //{
        //    return dbContext.Meals.Where(x=>x.Type==Domain.Enums.MealType.Dinner).ToList();
        //}
    }
}
