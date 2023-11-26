using YemekKalori.Domain.Entities;

namespace WFA_YemekKaloriHesap_Proje
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        User user = new User()
        {
            Username = "admin",
            Password = "admin"
        };
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == user.Username && user.VerifyPassword(txtPassword.Text)) 
            {
                MessageBox.Show("Giriþ baþarýlý.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}