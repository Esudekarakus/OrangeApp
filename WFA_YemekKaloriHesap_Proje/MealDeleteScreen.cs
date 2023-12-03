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
    public partial class MealDeleteScreen : Form
    {
        public MealDeleteScreen()
        {
            InitializeComponent();
        }

        public MealDeleteScreen(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        User user;
        MealService service;
        private void MealDeleteScreen_Load(object sender, EventArgs e)
        {
            service = new MealService();

            List<Meal> meals = service.GetAllMealsByUser(user.Id).OrderBy(x => x.MealTime).ToList();

            foreach (Meal meal in meals)
            {
                lstMeals.Items.Add(meal);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (lstMeals.SelectedIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Öğünü silmek istediğinizden emin misiniz?", "Delete confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Meal meal = lstMeals.SelectedItem as Meal;
                    service.DeleteMealStatus(meal);

                    lstMeals.Items.RemoveAt(lstMeals.SelectedIndex);
                }

            }
        }
    }
}
