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
            return repo.GetMeals().Where(x=>x.Type==Domain.Enums.MealType.Breakfast && x.Status != Domain.Enums.Status.Deleted).ToList();
        }
        //öğle yemeği getirme
        public List <Meal> GetLunch()
        {
            return repo.GetMeals().Where(x=>x.Type==Domain.Enums.MealType.Lunch && x.Status != Domain.Enums.Status.Deleted).ToList();
        }
        //akşam yemeği getirme

        public List <Meal> GetDinner() 
        {
            return repo.GetMeals().Where(x=>x.Type==Domain.Enums.MealType.Dinner && x.Status != Domain.Enums.Status.Deleted).ToList();
 
        }
        //usrr id ye göre kahvaltı
        public List <Meal> GetBreakfastByUser(int userID) 
        {
            return repo.GetMealsByUser(userID).Where(x => x.Type == Domain.Enums.MealType.Breakfast && x.Status != Domain.Enums.Status.Deleted).ToList();
        }
        //user id ye göre öğle yemeği
        public List <Meal> GetLunchByUser(int userID)
        {
            return repo.GetMealsByUser(userID).Where(x => x.Type == Domain.Enums.MealType.Lunch && x.Status != Domain.Enums.Status.Deleted).ToList();
        }
        //user id ye göre akşam yemeği
        public List <Meal>GetDinnerByUser(int userID)
        {
            return repo.GetMealsByUser(userID).Where(x => x.Type == Domain.Enums.MealType.Dinner && x.Status != Domain.Enums.Status.Deleted).ToList();
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

            decimal totalCalories = 0;

            foreach (var food in mealFoods)
            {
                totalCalories += food.Calorie;

                
            }

            meal.MealCalorie = totalCalories;

            repo.UpdateMeal(meal);
        }

        public void AddMeal(Meal meal)
        {
            repo.AddMeal(meal);
        }

        public void UpdateMeal(Meal meal)
        {
            repo.UpdateMeal(meal);
        }
        public List<Meal> GetMealsByUserDaily(int userId,DateTime date)
        {
            return repo.GetMealsByUser(userId).Where(x => x.MealTime.Date == date && x.Status != Domain.Enums.Status.Deleted).ToList();
        }
        public List<Meal> GetMealsByUserDaily(int userId)
        {
            return repo.GetMealsByUser(userId).Where(x => x.MealTime.Date == DateTime.Now.Date && x.Status != Domain.Enums.Status.Deleted).ToList();
        }
        public List<Meal> GetMealsByUserWeekly(int userId)
        {
            return repo.GetMealsByUser(userId).Where(x => x.MealTime >= DateTime.Now.AddDays(-7) && x.MealTime <= DateTime.Now && x.Status != Domain.Enums.Status.Deleted).ToList();
        }
        public List<Meal> GetMealsByUserMonthly(int userId)
        {
            return repo.GetMealsByUser(userId).Where(x => x.MealTime >= DateTime.Now.AddMonths(-1) && x.MealTime <= DateTime.Now && x.Status != Domain.Enums.Status.Deleted).ToList();
        }
        public List<Meal> GetMealsByUserDailyBreakfast(int userId) 
        {
            return repo.GetMealsByUser(userId).Where(x => x.MealTime.Date == DateTime.Now.Date && x.Type == Domain.Enums.MealType.Breakfast && x.Status != Domain.Enums.Status.Deleted).ToList();
        }

        public List<Meal> GetMealsByUserDailyLunch(int userId)
        {
            return repo.GetMealsByUser(userId).Where(x => x.MealTime.Date == DateTime.Now.Date && x.Type == Domain.Enums.MealType.Lunch && x.Status != Domain.Enums.Status.Deleted).ToList();
        }

        public List<Meal> GetMealsByUserDailyDinner(int userId)
        {
            return repo.GetMealsByUser(userId).Where(x => x.MealTime.Date == DateTime.Now.Date && x.Type == Domain.Enums.MealType.Dinner && x.Status != Domain.Enums.Status.Deleted).ToList();
        }

        public decimal GetMorningCalories(int userId)
        {
            decimal morningCalories = 0;
            List<Meal> morningMeals = GetMealsByUserDailyBreakfast(userId);

            foreach (var meal in morningMeals)
            {
                if (meal.MealCalorie is not null) 
                {
                    morningCalories += (decimal)meal.MealCalorie;
                }
            }

            return morningCalories;
        }

        public decimal GetLunchCalories(int userId)
        {
            decimal lunchCalories = 0;
            List<Meal> lunchMeals = GetMealsByUserDailyLunch(userId);

            foreach (var meal in lunchMeals)
            {
                if (meal.MealCalorie is not null)
                {
                    lunchCalories += (decimal)meal.MealCalorie;
                }
            }

            return lunchCalories;
        }

        public decimal GetDinnerCalories(int userId)
        {
            decimal dinnerCalories = 0;
            List<Meal> dinnerMeals = GetMealsByUserDailyDinner(userId);

            foreach (var meal in dinnerMeals)
            {
                if (meal.MealCalorie is not null)
                {
                    dinnerCalories += (decimal)meal.MealCalorie;
                }
            }

            return dinnerCalories;
        }

        public decimal GetTodaysCalories(int userId)
        {
            decimal todaysCalories = 0;
            List<Meal> todaysMeals = GetMealsByUserDaily(userId);

            foreach (var meal in todaysMeals)
            {
                if (meal.MealCalorie is not null) 
                {
                    todaysCalories += (decimal)meal.MealCalorie;
                }
                
            }

            return todaysCalories;  

        }
        //herhangi bir günün kalorisi,tarihe bağlı
        public decimal GetDailyCalories(int userId, DateTime date)
        {
            decimal dailyCalories = 0;
            List<Meal> dailyMeals = GetMealsByUserDaily(userId, date);

            foreach (var meal in dailyMeals)
            {
                if (meal.MealCalorie is not null)
                {
                    dailyCalories += (decimal)meal.MealCalorie;
                }
            }

            return dailyCalories;
        }

        public List<decimal> GetWeeklyCaloriesPerDay(int userId)
        {
            List<decimal> weeklyCaloriesList = new List<decimal>();

            // Şu andan itibaren bir hafta geriye git
            DateTime startDate = DateTime.Now.Date.AddDays(-7);

            for (int i = 0; i < 7; i++)
            {
                DateTime currentDate = startDate.AddDays(i);
                decimal dailyCalories = GetTodaysCalories(userId);
                weeklyCaloriesList.Add(dailyCalories);
            }

            return weeklyCaloriesList;
        }
        public List<decimal> GetMonthlyCaloriesPerWeek(int userId)
        {
            List<decimal> monthlyCaloriesList = new List<decimal>();

            // Şu andan itibaren bir ay geriye git
            DateTime startDate = DateTime.Now.Date.AddMonths(-1);

            for (int i = 0; i < 4; i++)
            {
                decimal weeklyCalories = GetWeeklyCalories(userId);
                monthlyCaloriesList.Add(weeklyCalories);

                // Bir hafta ileri git
                startDate = startDate.AddDays(7);
            }

            return monthlyCaloriesList;
        }

        public decimal GetWeeklyCalories(int userId)
        {
            decimal weeklyCalories = 0;
            List<Meal> weeklyMeals = GetMealsByUserWeekly(userId);

            foreach (var meal in weeklyMeals)
            {
                if (meal.MealCalorie is not null)
                {
                    weeklyCalories += (decimal)meal.MealCalorie;
                }
            }

            return weeklyCalories;
        }

        public decimal GetMonthlyCalories(int userId)
        {
            decimal monthlyCalories = 0;
            List<Meal> monthlyMeals = GetMealsByUserMonthly(userId);

            foreach (var meal in monthlyMeals)
            {
                if (meal.MealCalorie is not null)
                {
                    monthlyCalories += (decimal)meal.MealCalorie;
                }
            }

            return monthlyCalories;
        }

        public List<Meal> GetAllMealsByUser(int userId) 
        {
            return repo.GetMealsByUser(userId);
        }

        public void DeleteMealStatus(Meal meal) 
        {
            repo.DeleteMealByStatus(meal.Id);
        }
    }
}
