using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekKalori.DAL.Repositories;
using YemekKalori.Domain.Entities;

namespace YemekKalori.BLL.Services
{
    internal class MealFoodService
    {
        private MealFoodRepository _mealFoodRepository;

        public MealFoodService()
        {
            _mealFoodRepository = new MealFoodRepository();
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
    }
}
