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
using YemekKalori.BLL.Services;
using YemekKalori.Domain.Entities;

namespace YemekKalori.UI
{
    public partial class Survey : Form
    {
        public Survey()
        {
            InitializeComponent();
            cBoxBeslenmeTuru.DataSource = Enum.GetValues(typeof(Domain.Enums.DietType));
            cbGoals.DataSource = Enum.GetValues(typeof (Domain.Enums.GoalType));

        }

        public Survey(User user)
        {
            InitializeComponent();
            cBoxBeslenmeTuru.DataSource = Enum.GetValues(typeof(Domain.Enums.DietType));
            cbGoals.DataSource = Enum.GetValues(typeof(Domain.Enums.GoalType));
            this.user = user;
        }
        User user;
        UserService service;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                user.Diet = (Domain.Enums.DietType)cBoxBeslenmeTuru.SelectedValue;
                user.Goal = (Domain.Enums.GoalType)cbGoals.SelectedValue;
                if (cbGoals.SelectedIndex == -1 || cBoxBeslenmeTuru.SelectedIndex == -1)
                {
                    throw new Exception("Lütfen soruları cevaplayınız.");
                }
                service.UpdateUser(user);
                MessageBox.Show("Anketi doldurduğunuz için teşekkür ederiz.");
                this.Close();
                
            }
            catch (Exception ex)  
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Survey_Load(object sender, EventArgs e)
        {
            service = new UserService();
            cbGoals.SelectedIndex = -1;
            cBoxBeslenmeTuru.SelectedIndex = -1;
        }
    }
}
