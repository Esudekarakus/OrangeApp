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
            userService = new UserService();
            foodService = new FoodService();
        }

        public UserScreen(User user)
        {
            InitializeComponent();
            this.user = user;
            userService = new UserService();
            foodService = new FoodService();
        }

        User user;
        UserService userService;
        FoodService foodService;
        

        private void UserScreen_Load(object sender, EventArgs e)
        {
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

      
    }
}
