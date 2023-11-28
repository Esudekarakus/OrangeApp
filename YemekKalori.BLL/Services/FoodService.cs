using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekKalori.DAL.Repositories;
using YemekKalori.Domain.Entities;

namespace YemekKalori.BLL.Services
{
    public class FoodService
    {
        public FoodService()
        {
            repo = new FoodRepository();
        }
        FoodRepository repo;

        public void Add(Food food)
        {
            repo.AddFood(food);
        }
        public void Update(Food food)
        {
            repo.UpdateFood(food);
        }
        public void Delete(int foodId) 
        {
            repo.DeleteFood(foodId);
        }
        public void DeleteFoodByStatus(int foodId)
        {
            repo.DeleteFoodByStatus(foodId);
        }
        //tüm foodları listlele
        public List<Food> GetAll()
        {
            return repo.GetAllFood();
        }

        // food ları foodtype a göre listle

        //sebzeleri listele

        public List<Food> GetVegetables()
        {
            return repo.GetAllFood().Where(x => x.Type == Domain.Enums.FoodType.Vegetables).ToList();
        }

        //işlenmiş gıdaları listele
        public List<Food> GetProcessedFood()
        {
            return repo.GetAllFood().Where(x => x.Type == Domain.Enums.FoodType.ProcessedFood).ToList();
        }
        //kahveleri listele
        public List<Food> GetCoffee()
        {
            return repo.GetAllFood().Where(x => x.Type == Domain.Enums.FoodType.Coffee).ToList();
        }
        //meyveleri listele
        public List<Food> GetFruit()
        {
            return repo.GetAllFood().Where(x => x.Type == Domain.Enums.FoodType.Fruits).ToList();
        }

        //meat productd

        public List<Food> GetMeatProducts()
        {
            return repo.GetAllFood().Where(x => x.Type == Domain.Enums.FoodType.MeatProducts).ToList();
        }
        //dairy product
        public List<Food> GetDairyProducts()
        {
            return repo.GetAllFood().Where(x => x.Type == Domain.Enums.FoodType.DairyProducts).ToList();
        }

        //yumurta 

        public List<Food> GetEgg()
        {
            return repo.GetAllFood().Where(x => x.Type == Domain.Enums.FoodType.Eggs).ToList();
        }
        //bal 
        public List<Food> GetHoney()
        {
            return repo.GetAllFood().Where(x => x.Type == Domain.Enums.FoodType.Honey).ToList();
        }
        //legume
        public List<Food> GetLegume()
        {
            return repo.GetAllFood().Where(x => x.Type == Domain.Enums.FoodType.Legumes).ToList();
        }
        //GRAIN

        public List<Food> GetGrainProducts()
        {
            return repo.GetAllFood().Where(x => x.Type == Domain.Enums.FoodType.GrainProducts).ToList();
        }
        //çay
        public List<Food> GetTea()
        {
            return repo.GetAllFood().Where(x => x.Type == Domain.Enums.FoodType.Tea).ToList();
        }
        //juice
        public List<Food> GetJuice()
        {
            return repo.GetAllFood().Where(x => x.Type == Domain.Enums.FoodType.Juice).ToList();
        }
        //beverages
        public List<Food> GetSugaryDrink()
        {
            return repo.GetAllFood().Where(x => x.Type == Domain.Enums.FoodType.SugaryDrinks).ToList();
        }
        //kuruyemiş
        public List<Food> GetNuts()
        {
            return repo.GetAllFood().Where(x => x.Type == Domain.Enums.FoodType.Nuts).ToList();
        }
    }
}
