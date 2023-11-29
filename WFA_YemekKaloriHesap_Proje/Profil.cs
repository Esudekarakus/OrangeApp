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
using User = Microsoft.VisualBasic.ApplicationServices.User;

namespace YemekKalori.UI.Properties
{
    public partial class FrmProfil : Form
    {
        public FrmProfil()
        {
            InitializeComponent();
           
        }

        public FrmProfil(User user)
        {
            InitializeComponent();
            this.user=user;

        }
        User user;
        UserService userService;


        private void FrmProfil_Load(object sender, EventArgs e)
        {
            userService = new UserService();
            FillUserInfo();
        }
        private void FillUserInfo() 
        {
        
           
        }
    }
}
