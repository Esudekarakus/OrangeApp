using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using YemekKalori.DAL.Context;
using YemekKalori.Domain.Entities;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using YemekKalori.BLL.Services;

namespace YemekKalori.UI
{
    public partial class Graph : Form
    {
        private readonly AppDbContext dbContext = new AppDbContext();

        public Graph(Domain.Entities.User user)
        {
            InitializeComponent();
            this.user = user;
            mealService = new MealService();
           
        }
        Domain.Entities.User user;
        MealService mealService;

       

        private void Graph_Load(object sender, EventArgs e)
        {
            Aylik();
            //gunluk kalori takibi
            var dailyMeals=mealService.GetMealsByUserDaily(user.Id);
            
            this.Controls.Add(cGunluk);
            cGunluk.Titles.Add($"Günlük Kalori Takibi");
            
            

            foreach (var meal in dailyMeals)
            {
                cGunluk.Series["Daily"].Points.AddXY(meal.Id, meal.MealCalorie);
            }

            
            cGunluk.Invalidate();

            //haftalık kalori takibi

            var weeklyMealsPerday=mealService.GetWeeklyCaloriesPerDay(user.Id);
            this.Controls.Add(cHaftalik);
            cHaftalik.Titles.Add($"Haftalık Kalori Takibi");
            DateTime startDate=DateTime.Now.AddDays(-7);
            
            int i = 0;
           foreach (var calorie in  weeklyMealsPerday)
            {

                DateTime date=startDate.AddDays(i);
                cHaftalik.Series["Weekly"].Points.AddXY(date, calorie);
                i++;
            }
           
           cHaftalik.Invalidate();

            

            

        }
        public void Aylik()
        {
            //aylık kalori takibi

            var monthlyMealsPerWeek = mealService.GetMonthlyCaloriesPerWeek(user.Id);
            this.Controls.Add(cMonthly);
            cMonthly.Titles.Add($" Aylık Kalori Takibi");
            DateTime startdate2 = DateTime.Now.AddMonths(-1);
            
            int j = 0;

            foreach (var calories in monthlyMealsPerWeek)
            {
                DateTime dateTime = startdate2.AddDays(j);
                cMonthly.Series["Monthly"].Points.AddXY(dateTime, calories);
                j=j+7;
            }
           
            cMonthly.Invalidate();
        }
    }
}