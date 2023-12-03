using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_YemekKaloriHesap_Proje;
using static System.Windows.Forms.DataFormats;

namespace YemekKalori.UI
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 5;

            if (panel2.Width >= 495)
            {
                timer1.Stop();
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
                this.Close();
                
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
