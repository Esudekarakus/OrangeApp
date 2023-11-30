using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YemekKalori.BLL.Services;
using YemekKalori.DAL.Context;
using YemekKalori.Domain.Entities;


namespace YemekKalori.UI.Properties
{
    public partial class FrmProfil : Form
    {
        public FrmProfil(Domain.Entities.User user)
        {
            InitializeComponent();
            this.user = user;
            userService = new UserService();
            mealService = new MealService();
            mealFoodService = new MealFoodService();
            
            dbContext = new AppDbContext();


        }
        
        UserService userService;
        MealService mealService;
        MealFoodService mealFoodService;
        Domain.Entities.User user;
        AppDbContext dbContext;

        private void FrmProfil_Load(object sender, EventArgs e)
        {

            if (user != null)
            {

                var meals = mealService.GetMealByUser(user.Id);
                if (meals != null)
                {



                    //List<MealFood> mealFoods = dbContext.MealFoods.Where(x => x.MealId == meals.Id).ToList();
                    //var enCokTuketilen = mealFoods.Max(x => x.Portion);

                    lblEnCokTuketilenYiyecek.Text = $"rghthth";
                }


                lblEnCokTuketilenYiyecek.Text = "liste boş";

                lblAdSoyad.Text = $"{user.FirstName} {user.LastName}";
                txtBoxGoalType.Text = user.Goal?.ToString();
                txtBoxDietType.Text = user.Diet?.ToString();
                txtBoxBoy.Text = user.Height?.ToString();
                txtBoxKilo.Text = user.Weight?.ToString();
                lblHedefKcal.Text = user.HedefKalori.ToString();
                decimal? kalanKalori = user.HedefKalori - mealService.GetTodaysCalories(user.Id);
                lblKalanKcal.Text = kalanKalori.ToString();
            }

        }

        private void lnkLblSifreDegistir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            PasswordChangeScreen passwordChangeScreen = new PasswordChangeScreen(user);
            passwordChangeScreen.Show();
        }
    }

   
}
