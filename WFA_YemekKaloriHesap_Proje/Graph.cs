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
using YemekKalori.BLL.Services;

namespace YemekKalori.UI
{
    public partial class Graph : Form
    {
        private readonly AppDbContext dbContext = new AppDbContext();

        public Graph(Domain.Entities.User user)
        {
            InitializeComponent();
            this.user = user;
            mealService = new MealService();
           
        }
        Domain.Entities.User user;
        MealService mealService;

       

        private void Graph_Load(object sender, EventArgs e)
        {
            
            
            
            
        }
    }
}