namespace YemekKalori.UI.Properties
{
    partial class FrmProfil
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            lnkLblSifreDegistir = new LinkLabel();
            label1 = new Label();
            lblAdSoyad = new Label();
            txtBoxGoalType = new TextBox();
            txtBoxDietType = new TextBox();
            txtBoxBoy = new TextBox();
            txtBoxKilo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lblHedefKcal = new Label();
            lblKalanKcal = new Label();
            chartFavoriBesin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lLabelGrafikler = new LinkLabel();
            label4 = new Label();
            lblEnCokTuketilenYiyecek = new Label();
            ((System.ComponentModel.ISupportInitialize)chartFavoriBesin).BeginInit();
            SuspendLayout();
            // 
            // lnkLblSifreDegistir
            // 
            lnkLblSifreDegistir.AutoSize = true;
            lnkLblSifreDegistir.Location = new Point(74, 440);
            lnkLblSifreDegistir.Name = "lnkLblSifreDegistir";
            lnkLblSifreDegistir.Size = new Size(95, 20);
            lnkLblSifreDegistir.TabIndex = 1;
            lnkLblSifreDegistir.TabStop = true;
            lnkLblSifreDegistir.Text = "Şifre Değiştir";
            lnkLblSifreDegistir.LinkClicked += lnkLblSifreDegistir_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(520, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 31);
            label1.TabIndex = 2;
            label1.Text = "Profilim";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(46, 91);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(50, 20);
            lblAdSoyad.TabIndex = 3;
            lblAdSoyad.Text = "label2";
            // 
            // txtBoxGoalType
            // 
            txtBoxGoalType.Location = new Point(137, 132);
            txtBoxGoalType.Name = "txtBoxGoalType";
            txtBoxGoalType.Size = new Size(155, 27);
            txtBoxGoalType.TabIndex = 5;
            // 
            // txtBoxDietType
            // 
            txtBoxDietType.Location = new Point(137, 193);
            txtBoxDietType.Name = "txtBoxDietType";
            txtBoxDietType.Size = new Size(155, 27);
            txtBoxDietType.TabIndex = 6;
            // 
            // txtBoxBoy
            // 
            txtBoxBoy.Location = new Point(383, 193);
            txtBoxBoy.Name = "txtBoxBoy";
            txtBoxBoy.Size = new Size(155, 27);
            txtBoxBoy.TabIndex = 8;
            // 
            // txtBoxKilo
            // 
            txtBoxKilo.Location = new Point(383, 128);
            txtBoxKilo.Name = "txtBoxKilo";
            txtBoxKilo.Size = new Size(155, 27);
            txtBoxKilo.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(418, 283);
            label3.Name = "label3";
            label3.Size = new Size(120, 22);
            label3.TabIndex = 11;
            label3.Text = "Kalan kcal.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(50, 283);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 10;
            label2.Text = "Hedef kcal.";
            // 
            // lblHedefKcal
            // 
            lblHedefKcal.AutoSize = true;
            lblHedefKcal.Location = new Point(74, 353);
            lblHedefKcal.Name = "lblHedefKcal";
            lblHedefKcal.Size = new Size(50, 20);
            lblHedefKcal.TabIndex = 12;
            lblHedefKcal.Text = "label5";
            // 
            // lblKalanKcal
            // 
            lblKalanKcal.AutoSize = true;
            lblKalanKcal.Location = new Point(460, 353);
            lblKalanKcal.Name = "lblKalanKcal";
            lblKalanKcal.Size = new Size(50, 20);
            lblKalanKcal.TabIndex = 13;
            lblKalanKcal.Text = "label6";
            // 
            // chartFavoriBesin
            // 
            chartArea2.Name = "ChartArea1";
            chartFavoriBesin.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFavoriBesin.Legends.Add(legend2);
            chartFavoriBesin.Location = new Point(713, 91);
            chartFavoriBesin.Name = "chartFavoriBesin";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFavoriBesin.Series.Add(series2);
            chartFavoriBesin.Size = new Size(350, 328);
            chartFavoriBesin.TabIndex = 16;
            chartFavoriBesin.Text = "chart2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(326, 135);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 18;
            label5.Text = "Kilo :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 135);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 19;
            label6.Text = "Hedef :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(331, 199);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 20;
            label7.Text = "Boy :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 200);
            label8.Name = "label8";
            label8.Size = new Size(113, 20);
            label8.TabIndex = 21;
            label8.Text = "Beslenme Türü :";
            // 
            // lLabelGrafikler
            // 
            lLabelGrafikler.AutoSize = true;
            lLabelGrafikler.Location = new Point(449, 440);
            lLabelGrafikler.Name = "lLabelGrafikler";
            lLabelGrafikler.Size = new Size(103, 20);
            lLabelGrafikler.TabIndex = 22;
            lLabelGrafikler.TabStop = true;
            lLabelGrafikler.Text = "Kalori Takibim";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.IndianRed;
            label4.Location = new Point(182, 283);
            label4.Name = "label4";
            label4.Size = new Size(230, 22);
            label4.TabIndex = 23;
            label4.Text = "En Çok Tüketilen Besin";
            // 
            // lblEnCokTuketilenYiyecek
            // 
            lblEnCokTuketilenYiyecek.AutoSize = true;
            lblEnCokTuketilenYiyecek.Location = new Point(255, 353);
            lblEnCokTuketilenYiyecek.Name = "lblEnCokTuketilenYiyecek";
            lblEnCokTuketilenYiyecek.Size = new Size(50, 20);
            lblEnCokTuketilenYiyecek.TabIndex = 24;
            lblEnCokTuketilenYiyecek.Text = "label9";
            // 
            // FrmProfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 519);
            Controls.Add(lblEnCokTuketilenYiyecek);
            Controls.Add(label4);
            Controls.Add(lLabelGrafikler);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(chartFavoriBesin);
            Controls.Add(lblKalanKcal);
            Controls.Add(lblHedefKcal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBoxBoy);
            Controls.Add(txtBoxKilo);
            Controls.Add(txtBoxDietType);
            Controls.Add(txtBoxGoalType);
            Controls.Add(lblAdSoyad);
            Controls.Add(label1);
            Controls.Add(lnkLblSifreDegistir);
            Name = "FrmProfil";
            Text = "Profil";
            Load += FrmProfil_Load;
            ((System.ComponentModel.ISupportInitialize)chartFavoriBesin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel lnkLblSifreDegistir;
        private Label label1;
        private Label lblAdSoyad;
        private TextBox txtBoxGoalType;
        private TextBox txtBoxDietType;
        private TextBox txtBoxBoy;
        private TextBox txtBoxKilo;
        private Label label3;
        private Label label2;
        private Label lblHedefKcal;
        private Label lblKalanKcal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFavoriBesin;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private LinkLabel lLabelGrafikler;
        private Label label4;
        private Label lblEnCokTuketilenYiyecek;
    }
}