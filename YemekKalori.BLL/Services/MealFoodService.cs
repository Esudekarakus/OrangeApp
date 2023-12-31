﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekKalori.DAL.Repositories;
using YemekKalori.Domain.Entities;

namespace YemekKalori.BLL.Services
{
    public class MealFoodService
    {
        private MealFoodRepository _mealFoodRepository;

        public MealFoodService()
        {
            _mealFoodRepository = new MealFoodRepository();
            foodRepository = new FoodRepository();
        }

        public void AddMealFood(MealFood mealFood)
        {
            // Burada ek iş kurallarınızı uygulayabilirsiniz
            _mealFoodRepository.Add(mealFood);
        }

        public void UpdateMealFood(MealFood mealFood)
        {
            // Güncelleme ile ilgili iş kuralları
            _mealFoodRepository.Update(mealFood);
        }
        public void PermanentlyDeleteMealFood(MealFood mealFood)
        {
            // Kalıcı silme işlemi ile ilgili iş kuralları
            _mealFoodRepository.PermaDelete(mealFood);
        }

        public List<MealFood> GetMealFoodsByMeal(int mealId)
        {
            return _mealFoodRepository.GetMealFoodByMeal(mealId);
        }

        public MealFood GetMealFoodById(int id)
        {
            return _mealFoodRepository.GetMealFoodById(id);
        }

        FoodRepository foodRepository;

        public void SetNutrientsAndCalories(MealFood mealFood)
        {
            Food food = foodRepository.GetFoodById(mealFood.FoodId);

            mealFood.Calorie = food.Calorie * mealFood.Portion;
            mealFood.ProteinRate = food.ProteinRate * mealFood.Portion;
            mealFood.CarbRate = food.CarbRate * mealFood.Portion;
            mealFood.FatRate = food.FatRate * mealFood.Portion;

            
        }

        public void DeleteByStatus(MealFood food)
        {
            food.Status = Domain.Enums.Status.Deleted;
            _mealFoodRepository.Update(food);
        }

        public MealFood  GetTheMostConsumedMealFoodByMealId(int mealid)
        {
            List<MealFood> encoktuketilen = _mealFoodRepository.GetMealFoodByID(mealid);

            MealFood mostConsumed = encoktuketilen.OrderByDescending(food => food.Portion).FirstOrDefault();


            return mostConsumed;

        }


    }
}
