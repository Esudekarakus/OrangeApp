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
    public partial class PasswordChangeScreen : Form
    {
        public PasswordChangeScreen(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        UserService service;
        User user;
        private void PasswordChangeScreen_Load(object sender, EventArgs e)
        {
            service = new UserService();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (!service.CheckPassword(txtEskiSifre.Text, user))
                {
                    MessageBox.Show("Yanlış şifre.");
                }
                else
                {
                    if (!(txtYeniSifre.Text == txtYeniSifreTekrar.Text))
                    {
                        MessageBox.Show("Şifreler uyuşmuyor.");
                    }
                    else
                    {
                        service.PasswordChange(user, txtYeniSifre.Text);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
