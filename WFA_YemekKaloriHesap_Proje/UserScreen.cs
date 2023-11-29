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
using YemekKalori.Domain.Entities;

namespace YemekKalori.UI
{
    public partial class UserScreen : Form
    {
        public UserScreen()
        {
            InitializeComponent();


        }

        public UserScreen(User user)
        {
            InitializeComponent();
            this.user = user;

        }

        User user;
        UserService userService;
        FoodService foodService;
        MealFoodService mealfoodService;

        private void UserScreen_Load(object sender, EventArgs e)
        {
            userService = new UserService();
            foodService = new FoodService();
            mealfoodService = new MealFoodService();

            lstYemekler.AllowDrop = true;
            lstSecimler.AllowDrop = true;

            if (user.Diet == Domain.Enums.DietType.Classic)
            {
                lstYemekler.DisplayMember = null;
                lstYemekler.DataSource = foodService.GetClassicFood();

                //lstYemekler.ValueMember = "Id";
            }
            else if (user.Diet == Domain.Enums.DietType.Vegan)
            {
                lstYemekler.DisplayMember = null;
                lstYemekler.DataSource = foodService.GetVeganFoods();

                //lstYemekler.ValueMember= "Id";
            }
            else if (user.Diet == Domain.Enums.DietType.Vegetarian)
            {
                lstYemekler.DisplayMember = null;
                lstYemekler.DataSource = foodService.GetVegetarianFood();

                //lstYemekler.ValueMember = "Id";
            }
            else if (user.Diet == Domain.Enums.DietType.Carnivor)
            {
                lstYemekler.DisplayMember = null;
                lstYemekler.DataSource = foodService.GetCarnivoreFoods();

                //lstYemekler.ValueMember = "Id";
            }
            lstYemekler.Refresh();
        }

        private void lstSecimler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //int index = lstYemekler.IndexFromPoint(e.Location);
            //if (index != ListBox.NoMatches)
            //{
            //    Food secilenFood = lstYemekler.SelectedItem as Food;

            //    if (secilenFood != null)
            //    {
            //        txtFoodDetay.Text = $"{secilenFood.Name} Yağ Oranı: {secilenFood.FatRate}% Karbonhidrat Oranı {secilenFood.CarbRate}% Protein Oranı: {secilenFood.ProteinRate}%";
            //    }
            //}



        }

        private void lstYemekler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstSecimler.SelectedIndex > -1)
            {
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MealFood mealFood = lstSecimler.SelectedItem as MealFood;
                    mealfoodService.DeleteByStatus(mealFood);


                }

            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {


        }

        private void lstYemekler_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstYemekler.SelectedItem != null)
            {
                Food secilenFood = lstYemekler.SelectedItem as Food;
                txtFoodDetay.Text = $"{secilenFood.Name} Yağ Oranı: {secilenFood.FatRate}% Karbonhidrat Oranı {secilenFood.CarbRate}% Protein Oranı: {secilenFood.ProteinRate}%";

                DoDragDrop(lstYemekler.SelectedItem, DragDropEffects.Copy);
            }
        }

        private void lstSecimler_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Food)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lstSecimler_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Food)))
            {
                Food food = (Food)e.Data.GetData(typeof(Food));

                PortionScreen portionScreen = new PortionScreen(food.Id, this);
                this.Hide();
                portionScreen.ShowDialog();
                this.Show();
            }
        }

        public void RetrieveMealFood(MealFood mealFood)
        {
            mealfoodService.SetNutrientsAndCalories(mealFood);

            lstSecimler.Items.Add(mealFood);
        }

        private void lstSecimler_DoubleClick(object sender, EventArgs e)
        {
            
        }

        
    }
}
