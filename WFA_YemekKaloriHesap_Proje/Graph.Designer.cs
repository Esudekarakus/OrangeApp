namespace YemekKalori.UI
{
    partial class Graph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            cGunluk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            cHaftalik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            cMonthly = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)cGunluk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cHaftalik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cMonthly).BeginInit();
            SuspendLayout();
            // 
            // cGunluk
            // 
            chartArea1.Name = "ChartArea1";
            cGunluk.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            cGunluk.Legends.Add(legend1);
            cGunluk.Location = new Point(33, 43);
            cGunluk.Name = "cGunluk";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Daily";
            cGunluk.Series.Add(series1);
            cGunluk.Size = new Size(492, 279);
            cGunluk.TabIndex = 0;
            cGunluk.Text = "chart1";
            // 
            // cHaftalik
            // 
            chartArea2.Name = "ChartArea1";
            cHaftalik.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            cHaftalik.Legends.Add(legend2);
            cHaftalik.Location = new Point(723, 43);
            cHaftalik.Name = "cHaftalik";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Weekly";
            cHaftalik.Series.Add(series2);
            cHaftalik.Size = new Size(552, 279);
            cHaftalik.TabIndex = 1;
            cHaftalik.Text = "chart1";
            // 
            // cMonthly
            // 
            chartArea3.Name = "ChartArea1";
            cMonthly.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            cMonthly.Legends.Add(legend3);
            cMonthly.Location = new Point(364, 357);
            cMonthly.Name = "cMonthly";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.Name = "Monthly";
            cMonthly.Series.Add(series3);
            cMonthly.Size = new Size(743, 375);
            cMonthly.TabIndex = 2;
            cMonthly.Text = "chart1";
            // 
            // Graph
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 769);
            Controls.Add(cMonthly);
            Controls.Add(cHaftalik);
            Controls.Add(cGunluk);
            Name = "Graph";
            Text = "Graph";
            Load += Graph_Load;
            ((System.ComponentModel.ISupportInitialize)cGunluk).EndInit();
            ((System.ComponentModel.ISupportInitialize)cHaftalik).EndInit();
            ((System.ComponentModel.ISupportInitialize)cMonthly).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cGunluk;
        private System.Windows.Forms.DataVisualization.Charting.Chart cHaftalik;
        private System.Windows.Forms.DataVisualization.Charting.Chart cMonthly;
    }
}