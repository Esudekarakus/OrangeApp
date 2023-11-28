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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            userService = new UserService();
        }
        UserService userService;

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                CheckPasswords();
                User user = new User();
                user.Username = txtUserName.Text;
                user.FirstName = txtName.Text;
                user.LastName = txtSurname.Text;
                user.Height = nUpDownBoy.Value;
                user.Weight = nUpDownKilo.Value;
                user.Password = txtSifre.Text;

                if (userService.CheckUsernameExists(user.Username))
                {
                    throw new Exception("Kullanıcı adı zaten mevcut.");
                }

                userService.SignUp(user);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CheckPasswords()
        {
            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                throw new Exception("Şifreler eşleşmiyor.");
            }
        }
    }
}
