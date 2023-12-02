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
using System.Windows.Forms.DataVisualization.Charting;

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
            VeriEkleOlustur();


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



                    var encokTuketilen = dbContext.MealFoods.Where(x => x.MealId == meals.Id).OrderByDescending(x => x.Portion).FirstOrDefault();

                    Food food = new Food()
                    {
                        Id = encokTuketilen.FoodId
                    };





                    var food2 = dbContext.Foods.FirstOrDefault(x => x.Id == food.Id);
                    lblEnCokTuketilenYiyecek.Text = $"{encokTuketilen.Food.Name}";
                }
                else
                {
                    lblEnCokTuketilenYiyecek.Text = "liste boş";
                }



                lblAdSoyad.Text = $"{user.FirstName} {user.LastName}";
                txtBoxGoalType.Text = user.Goal?.ToString();
                txtBoxDietType.Text = user.Diet?.ToString();
                txtBoxBoy.Text = user.Height?.ToString();
                txtBoxKilo.Text = user.Weight?.ToString();
                lblHedefKcal.Text = user.HedefKalori.ToString();
                decimal? kalanKalori = user.HedefKalori - mealService.GetTodaysCalories(user.Id);
                if (kalanKalori < 0)
                {
                    lblKalanKcal.Text = "0";
                }
                else
                {
                    lblKalanKcal.Text = kalanKalori.ToString();
                }



            }
        }

        private void VeriEkleOlustur()
        {

            this.Controls.Add(chartFavoriBesin);
            chartFavoriBesin.Titles.Add("Favori Besin İçeriği");
            var meals = mealService.GetMealByUser(user.Id);
            var encokTuketilen = dbContext.MealFoods.Where(x => x.MealId == meals.Id).OrderByDescending(x => x.Portion).FirstOrDefault();
            Food food = new Food()
            {
                Id = encokTuketilen.FoodId
            };


            // Chart kontrolüne seriyi ekle

            var food2 = dbContext.Foods.FirstOrDefault(x => x.Id == food.Id);

            // Verileri seriyi ekleyerek göster
            // Series1 serisine verileri ekleyerek göster

            chartFavoriBesin.Series["Series1"].Points.AddXY("Karbonhidrat", encokTuketilen.Food.CarbRate);
            chartFavoriBesin.Series["Series1"].Points.AddXY("Yağ", encokTuketilen.Food.FatRate);
            chartFavoriBesin.Series["Series1"].Points.AddXY("Protein", encokTuketilen.Food.ProteinRate);

            chartFavoriBesin.Series["Series1"]["PieLabelStyle"] = "Disabled";

        }

        private void lnkLblSifreDegistir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            PasswordChangeScreen passwordChangeScreen = new PasswordChangeScreen(user);
            passwordChangeScreen.ShowDialog();
            this.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

        }

        private void lLabelGrafikler_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Graph graph = new Graph(user);
            graph.ShowDialog();
        }
    }


}
