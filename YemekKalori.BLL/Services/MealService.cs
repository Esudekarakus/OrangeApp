using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekKalori.DAL.Repositories;
using YemekKalori.Domain.Entities;

namespace YemekKalori.BLL.Services
{
    public class MealService
    {

        public MealService() 
        {
            repo=new MealRepository();
            mealFoodRepository = new MealFoodRepository();
        }

        MealRepository repo;
        //meal id ye göre meal getirme
        public Meal GetMealByID(int mealID)
        {
            return repo.GetMealByMealID(mealID);

        }
        //user id ye göre meal getirme
        public Meal GetMealByUser(int userId)
        {
            return repo.GetMealByUser(userId);
        }
        //kahvaltı getirme
        public List <Meal> GetBreakfast()
        {
            return repo.GetMeals().Where(x=>x.Type==Domain.Enums.MealType.Breakfast).ToList();
        }
        //öğle yemeği getirme
        public List <Meal> GetLunch()
        {
            return repo.GetMeals().Where(x=>x.Type==Domain.Enums.MealType.Lunch).ToList();
        }
        //akşam yemeği getirme

        public List <Meal> GetDinner() 
        {
            return repo.GetMeals().Where(x=>x.Type==Domain.Enums.MealType.Dinner).ToList();
 
        }
        //usrr id ye göre kahvaltı
        public List <Meal> GetBreakfastByUser(int userID) 
        {
            return repo.GetMealsByUser(userID).Where(x => x.Type == Domain.Enums.MealType.Breakfast).ToList();
        }
        //user id ye göre öğle yemeği
        public List <Meal> GetLunchByUser(int userID)
        {
            return repo.GetMealsByUser(userID).Where(x => x.Type == Domain.Enums.MealType.Lunch).ToList();
        }
        //user id ye göre akşam yemeği
        public List <Meal>GetDinnerByUser(int userID)
        {
            return repo.GetMealsByUser(userID).Where(x => x.Type == Domain.Enums.MealType.Dinner).ToList();
        }

        MealFoodRepository mealFoodRepository;

        //kaloriye göre meal getirme

        public List <Meal>GetMealByCalorie(decimal kalori)
        {
            return repo.GetMeals().Where(x=>x.MealCalorie==kalori).ToList();
        }

        public void SetMealCalorie(Meal meal) 
        {
            List<MealFood> mealFoods = mealFoodRepository.GetMealFoodByMeal(meal.Id);

            foreach (var food in mealFoods)
            {
                meal.MealCalorie += food.Calorie;
            }

            repo.UpdateMeal(meal);
        }
    }
}
