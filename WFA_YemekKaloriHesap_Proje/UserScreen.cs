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
using YemekKalori.UI.Properties;

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
        MealService mealService;

        private void UserScreen_Load(object sender, EventArgs e)
        {
            if (user.Goal == Domain.Enums.GoalType.GainWeight)
            {
                user.HedefKalori = 2500;
            }
            else if (user.Goal == Domain.Enums.GoalType.LoseWeight)
            {
                user.HedefKalori = 1500;
            }
            userService = new UserService();
            foodService = new FoodService();
            mealfoodService = new MealFoodService();
            mealService = new MealService();

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

            ShowMyCalories();
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
                    lstSecimler.Items.RemoveAt(lstSecimler.SelectedIndex);


                }

            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstSecimler.SelectedIndex != -1)
            {
                MealFood mealFood = lstSecimler.SelectedItem as MealFood;

                lstSecimler.Items.RemoveAt(lstSecimler.SelectedIndex);

                if (mealFood != null)
                {
                    PortionScreen portionScreen = new PortionScreen(mealFood, this);
                    this.Hide();
                    portionScreen.ShowDialog();
                    this.Show();


                }

            }

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

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            ICollection<MealFood> mealFoods = new List<MealFood>();



            Meal meal = new Meal()
            {

                MealTime = DateTime.Now


            };

            mealService.AddMeal(meal);

            Meal meal2 = mealService.GetMealByID(meal.Id);

            foreach (MealFood food in lstSecimler.Items)
            {

                mealFoods.Add(food);


            }

            foreach (MealFood mealFood in mealFoods)
            {
                mealFood.MealId = meal2.Id;
                mealFood.Meal = meal2;


            }



            meal2.MealFoods = mealFoods;

            meal2.UserId = user.Id;
            meal2.User = userService.GetById(user.Id);

            mealService.UpdateMeal(meal2);

            mealService.SetMealCalorie(meal2);

            if (meal2.MealTime.Hour >= 6 && meal2.MealTime.Hour <= 12)
            {
                meal2.Type = Domain.Enums.MealType.Breakfast;
            }
            else if (meal2.MealTime.Hour > 12 && meal2.MealTime.Hour <= 15)
            {
                meal2.Type = Domain.Enums.MealType.Lunch;
            }
            else if (meal2.MealTime.Hour > 15 && meal2.MealTime.Hour <= 23)
            {
                meal2.Type = Domain.Enums.MealType.Dinner;
            }

            mealService.UpdateMeal(meal2);

            ClearListbox(lstSecimler);

            ShowMyCalories();


        }

        public void ClearListbox(ListBox lst)
        {
            lst.Items.Clear();
        }

        public void ShowMyCalories()
        {
            lblToplamKalori.Text = mealService.GetTodaysCalories(user.Id).ToString();

            lblSabah.Text = mealService.GetMorningCalories(user.Id).ToString();

            lblOglen.Text = mealService.GetLunchCalories(user.Id).ToString();

            lblAksam.Text = mealService.GetDinnerCalories(user.Id).ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordChangeScreen pcs = new PasswordChangeScreen(user);
            this.Hide();
            pcs.ShowDialog();
            this.Show();
        }

        private void lLabelProfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            FrmProfil frmProfil = new FrmProfil(user);
            frmProfil.Show();
            
        }
    }
}
