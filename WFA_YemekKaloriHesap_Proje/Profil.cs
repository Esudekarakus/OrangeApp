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
using YemekKalori.Domain.Entities;


namespace YemekKalori.UI.Properties
{
    public partial class FrmProfil : Form
    {
        public FrmProfil()
        {
            InitializeComponent();

        }

        public FrmProfil(Domain.Entities.User user)
        {
            InitializeComponent();
            this.user = user;
            userService = new UserService();

        }
        
        UserService userService;
        Domain.Entities.User user;

        private void FrmProfil_Load(object sender, EventArgs e)
        {
            
            if (user != null)
            {
                lblAdSoyad.Text = $"{user.FirstName} {user.LastName}";
                txtBoxGoalType.Text = user.Goal.ToString();
                txtBoxDietType.Text = user.Diet.ToString();
                txtBoxBoy.Text = user.Height.ToString();
                txtBoxKilo.Text = user.Weight.ToString();
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
