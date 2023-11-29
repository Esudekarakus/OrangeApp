using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YemekKalori.Domain.Entities;

namespace YemekKalori.UI
{
    public partial class PortionScreen : Form
    {
        public PortionScreen()
        {
            InitializeComponent();
        }

        public PortionScreen(int foodId)
        {
            InitializeComponent();
            this.foodId = foodId;
        }

        int foodId;
        List<Decimal> portions;
        private void PortionScreen_Load(object sender, EventArgs e)
        {
            portions = new List<decimal> { 0.5m, 1.0m, 1.5m, 2.0m, 2.5m, 3.0m, 3.5m, 4.0m, 4.5m, 5.0m };

            foreach (decimal value in portions)
            {
                cbPortions.Items.Add(value);
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            MealFood mealFood = new MealFood()
            {
                FoodId = foodId,
                Calorie = (decimal)cbPortions.SelectedValue
            };


        }
    }
}
