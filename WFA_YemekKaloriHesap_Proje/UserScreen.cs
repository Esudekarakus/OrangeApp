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

        

        private void UserScreen_Load(object sender, EventArgs e)
        {

        }

      
    }
}
