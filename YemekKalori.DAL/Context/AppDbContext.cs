using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekKalori.DAL.Configurations;
using YemekKalori.Domain.Entities;

namespace YemekKalori.DAL.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealFood> MealFoods { get; set; }
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=LAPTOP-6B0RV21O;initial catalog=DietAppProjectDb;integrated security=true");
            //base.OnConfiguring(optionsBuilder);

            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserConfiguration().Configure(modelBuilder.Entity<User>());
            new FoodConfiguration().Configure(modelBuilder.Entity<Food>());
            new MealConfiguration().Configure(modelBuilder.Entity<Meal>());
            new MealFoodConfiguration().Configure(modelBuilder.Entity<MealFood>());
            //base.OnModelCreating(modelBuilder);
        }
    }
}
