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
            meal.Status = Domain.Enums.Status.Modified;
            meal.ModifiedDate = DateTime.Now;
            dbContext.Meals.Update(meal);
            
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
            meal.DeletedDate = DateTime.Now;
            dbContext.Meals.Update(meal);
            dbContext.SaveChanges();
        }


        //meal id ye göre meal
        public Meal GetMealByMealID(int mealID)
        {
           return dbContext.Meals.FirstOrDefault(x => x.Id == mealID && x.Status != Domain.Enums.Status.Deleted);
        }

        //user ın meallerini getir
        public List<Meal> GetMealsByUser(int userId)
        {
            return dbContext.Meals.Where(x => x.UserId == userId && x.Status != Domain.Enums.Status.Deleted).ToList();
        }

        public Meal GetMealByUser(int userId) 
        {
            Meal meal = dbContext.Meals.FirstOrDefault(m => m.UserId == userId && m.Status != Domain.Enums.Status.Deleted);
            return meal;
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
