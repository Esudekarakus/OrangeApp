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
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-EVCENE1; Initial Catalog = DBName; User Id = sa; Password = Anyela123");
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
