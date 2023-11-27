using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekKalori.DAL.Context;
using YemekKalori.Domain.Entities;

namespace YemekKalori.DAL.Repositories
{
    public class FoodRepository
    {
        public FoodRepository() 
        {
            dbContext=new AppDbContext();
        }
        AppDbContext dbContext;

        //food eklemek için
        public void Add(Food food)
        {
            dbContext.Foods.Add(food);
            dbContext.SaveChanges();

        }
        //food update
        public void Update(Food food) 
        {
            dbContext.Foods.Update(food);
            food.Status = Domain.Enums.Status.Modified;
            dbContext.SaveChanges();
        }
        //food sil
        public void Delete(int foodID)
        {
            Food food= dbContext.Foods.Find(foodID);
            dbContext.Foods.Remove(food);
            dbContext.SaveChanges();
        }

        //food status deleted olsun

        public void DeleteFoodByStatus(int foodID)
        {
            Food food = dbContext.Foods.Find(foodID);
            food.Status = Domain.Enums.Status.Deleted;
            dbContext.SaveChanges();

        }

        //tüm food ları listele

        public List<Food> GetAllFood() 
        {
            return dbContext.Foods.ToList();
        }

        // food ları foodtype a göre listle

        //sebzeleri listele
        public List<Food> GetVegetables()
        {
            return dbContext.Foods.Where(x => x.Type == Domain.Enums.FoodType.Vegetables).ToList();
        }
        //işlenmiş gıdaları listele
        public List <Food> GetProcessedFood()
        {
            return dbContext.Foods.Where(x=>x.Type==Domain.Enums.FoodType.ProcessedFood).ToList();
        }
        //kahveleri listele
        public List <Food> GetCoffee()
        {
            return dbContext.Foods.Where(x=>x.Type==Domain.Enums.FoodType.Coffee).ToList();
        }
        //meyveleri listele
        public List <Food> GetFruit()
        {
            return dbContext.Foods.Where(x=>x.Type==Domain.Enums.FoodType.Fruits).ToList();
        }

        //meat productd

        public List <Food>GetMeatProducts()
        {
            return dbContext.Foods.Where(x=>x.Type==Domain.Enums.FoodType.MeatProducts).ToList();
        }
        //dairy product
        public List <Food> GetDairyProducts()
        {
            return dbContext.Foods.Where(x=>x.Type==Domain.Enums.FoodType.DairyProducts).ToList();
        }

        //yumurta 

        public List <Food> GetEgg()
        {
            return dbContext.Foods.Where(x=>x.Type==Domain.Enums.FoodType.Eggs).ToList();
        }
        //bal 
        public List <Food> GetHoney() 
        {
            return dbContext.Foods.Where(x=>x.Type==Domain.Enums.FoodType.Honey).ToList();
        }
        //legume
        public List<Food> GetLegume()
        {
            return dbContext.Foods.Where(x=>x.Type==Domain.Enums.FoodType.Legumes).ToList();
        }

        //GRAIN

        public List <Food >GetGrainProducts()
        {
            return dbContext.Foods.Where(x=>x.Type==Domain.Enums.FoodType.GrainProducts).ToList();
        }
        //çay
        public List <Food>GetTea()
        {
            return dbContext.Foods.Where(x=>x.Type==Domain.Enums.FoodType.Tea).ToList();
        }
        //juice
        public List <Food>GetJuice()
        {
            return dbContext.Foods.Where(x=>x.Type==Domain.Enums.FoodType.Juice).ToList();
        }
        //beverages
        public List <Food>GetSugaryDrink()
        {
            return dbContext.Foods.Where(x=>x.Type==Domain.Enums.FoodType.SugaryDrinks).ToList();
        }
        //kuruyemiş
        public List<Food>GetNuts()
        {
            return dbContext.Foods.Where(x=>x.Type==Domain.Enums.FoodType.Nuts).ToList();
        }
    }
}
