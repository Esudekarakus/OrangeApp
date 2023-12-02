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
            //gunluk kalori takibi
            var dailyMeals=mealService.GetMealsByUserDaily(user.Id);
            
            this.Controls.Add(cGunluk);
            cGunluk.Titles.Add($"{user.Username} Günlük Kalori Takibi");
            Series Daily = new Series();

            foreach (var meal in dailyMeals)
            {
                Daily.Points.AddXY(meal.Id, meal.MealCalorie);
            }

            cGunluk.Series.Add(Daily);
            cGunluk.Invalidate();

            //haftalık kalori takibi

            var weeklyMealsPerday=mealService.GetWeeklyCaloriesPerDay(user.Id);
            this.Controls.Add(cHaftalik);
            cHaftalik.Titles.Add($"{user.Username} Haftalık Kalori Takibi");
            DateTime startDate=DateTime.Now.AddDays(-7);
            Series series =new Series();
            int i = 0;
           foreach (var calorie in  weeklyMealsPerday)
            {

                DateTime date=startDate.AddDays(i);
                series.Points.AddXY(date, calorie);
                i++;
            }
           cHaftalik.Series.Add(series);
           cHaftalik.Invalidate();

            //aylık

            

        }
        public void Aylik()
        {
            //aylık kalori takibi

            var monthlyMealsPerWeek = mealService.GetMonthlyCaloriesPerWeek(user.Id);
            this.Controls.Add(cMonthly);
            cMonthly.Titles.Add($"{user.Username} Aylık Kalori Takibi");
            DateTime startdate2 = DateTime.Now.AddMonths(-1);
            Series series1 = new Series();
            int j = 0;

            foreach (var calories in monthlyMealsPerWeek)
            {
                DateTime dateTime = startdate2.AddDays(j);
                series1.Points.AddXY(dateTime, calories);
                j++;
            }
            cMonthly.Series.Add(series1);
            cMonthly.Invalidate();
        }
    }
}