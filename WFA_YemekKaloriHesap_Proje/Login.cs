

using YemekKalori.BLL.Services;
using YemekKalori.Domain.Entities;
using YemekKalori.UI;

namespace WFA_YemekKaloriHesap_Proje
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        UserService service;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User user = service.UserLogin(txtUsername.Text, txtPassword.Text);
                UserScreen userScreen = new UserScreen(user);
                this.Hide();
                userScreen.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            service = new UserService();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.ShowDialog();
            this.Show();
            ClearFields();
            
        }

        public void ClearFields()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}