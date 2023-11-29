using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using YemekKalori.DAL.Context;
using YemekKalori.Domain.Entities;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace YemekKalori.UI
{
    public partial class Graph : Form
    {
        private readonly AppDbContext dbContext = new AppDbContext();

        public Graph()
        {
            InitializeComponent();
           
        }

       

        private void Graph_Load(object sender, EventArgs e)
        {
            
            var allUsers = dbContext.Users.ToList();

            chart1.Series["Series1"].Points.Clear();

            
            foreach (var user in allUsers)
            {
                chart1.Series["Series1"].Points.AddXY(user.Id, user.BMI);
            }

            
            chart1.Invalidate();
        }
    }
}