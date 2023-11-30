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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            btnKapat = new Button();
            lnkLblSifreDegistir = new LinkLabel();
            label1 = new Label();
            lblAdSoyad = new Label();
            txtBoxGoalType = new TextBox();
            txtBoxDietType = new TextBox();
            txtBoxBoy = new TextBox();
            txtBoxKilo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            lblHedefKcal = new Label();
            lblKalanKcal = new Label();
            cKaloriTakipHaftalik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartFavoriBesin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblEnCokTuketilenYiyecek = new Label();
            ((System.ComponentModel.ISupportInitialize)cKaloriTakipHaftalik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFavoriBesin).BeginInit();
            SuspendLayout();
            // 
            // btnKapat
            // 
            btnKapat.Location = new Point(176, 376);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(94, 29);
            btnKapat.TabIndex = 0;
            btnKapat.Text = "Çıkış";
            btnKapat.UseVisualStyleBackColor = true;
            // 
            // lnkLblSifreDegistir
            // 
            lnkLblSifreDegistir.AutoSize = true;
            lnkLblSifreDegistir.Location = new Point(312, 407);
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
            label1.Location = new Point(192, 41);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
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
            txtBoxGoalType.Location = new Point(46, 138);
            txtBoxGoalType.Name = "txtBoxGoalType";
            txtBoxGoalType.Size = new Size(155, 27);
            txtBoxGoalType.TabIndex = 5;
            // 
            // txtBoxDietType
            // 
            txtBoxDietType.Location = new Point(46, 193);
            txtBoxDietType.Name = "txtBoxDietType";
            txtBoxDietType.Size = new Size(155, 27);
            txtBoxDietType.TabIndex = 6;
            // 
            // txtBoxBoy
            // 
            txtBoxBoy.Location = new Point(252, 196);
            txtBoxBoy.Name = "txtBoxBoy";
            txtBoxBoy.Size = new Size(155, 27);
            txtBoxBoy.TabIndex = 8;
            // 
            // txtBoxKilo
            // 
            txtBoxKilo.Location = new Point(252, 138);
            txtBoxKilo.Name = "txtBoxKilo";
            txtBoxKilo.Size = new Size(155, 27);
            txtBoxKilo.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(258, 282);
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
            label2.Location = new Point(50, 282);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 10;
            label2.Text = "Hedef kcal.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(176, 249);
            label4.Name = "label4";
            label4.Size = new Size(77, 27);
            label4.TabIndex = 9;
            label4.Text = "HEDEF";
            // 
            // lblHedefKcal
            // 
            lblHedefKcal.AutoSize = true;
            lblHedefKcal.Location = new Point(50, 325);
            lblHedefKcal.Name = "lblHedefKcal";
            lblHedefKcal.Size = new Size(50, 20);
            lblHedefKcal.TabIndex = 12;
            lblHedefKcal.Text = "label5";
            // 
            // lblKalanKcal
            // 
            lblKalanKcal.AutoSize = true;
            lblKalanKcal.Location = new Point(258, 325);
            lblKalanKcal.Name = "lblKalanKcal";
            lblKalanKcal.Size = new Size(50, 20);
            lblKalanKcal.TabIndex = 13;
            lblKalanKcal.Text = "label6";
            // 
            // cKaloriTakipHaftalik
            // 
            chartArea4.Name = "ChartArea1";
            cKaloriTakipHaftalik.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            cKaloriTakipHaftalik.Legends.Add(legend4);
            cKaloriTakipHaftalik.Location = new Point(777, 12);
            cKaloriTakipHaftalik.Name = "cKaloriTakipHaftalik";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            cKaloriTakipHaftalik.Series.Add(series4);
            cKaloriTakipHaftalik.Size = new Size(359, 228);
            cKaloriTakipHaftalik.TabIndex = 14;
            cKaloriTakipHaftalik.Text = "cKaloriTakipHaftalik";
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            chart1.Legends.Add(legend5);
            chart1.Location = new Point(777, 268);
            chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            chart1.Series.Add(series5);
            chart1.Size = new Size(359, 214);
            chart1.TabIndex = 15;
            chart1.Text = "chart1";
            // 
            // chartFavoriBesin
            // 
            chartArea6.Name = "ChartArea1";
            chartFavoriBesin.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            chartFavoriBesin.Legends.Add(legend6);
            chartFavoriBesin.Location = new Point(465, 125);
            chartFavoriBesin.Name = "chartFavoriBesin";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            chartFavoriBesin.Series.Add(series6);
            chartFavoriBesin.Size = new Size(261, 246);
            chartFavoriBesin.TabIndex = 16;
            chartFavoriBesin.Text = "chart2";
            // 
            // lblEnCokTuketilenYiyecek
            // 
            lblEnCokTuketilenYiyecek.AutoSize = true;
            lblEnCokTuketilenYiyecek.Location = new Point(497, 60);
            lblEnCokTuketilenYiyecek.Name = "lblEnCokTuketilenYiyecek";
            lblEnCokTuketilenYiyecek.Size = new Size(50, 20);
            lblEnCokTuketilenYiyecek.TabIndex = 17;
            lblEnCokTuketilenYiyecek.Text = "label5";
            // 
            // FrmProfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 519);
            Controls.Add(lblEnCokTuketilenYiyecek);
            Controls.Add(chartFavoriBesin);
            Controls.Add(chart1);
            Controls.Add(cKaloriTakipHaftalik);
            Controls.Add(lblKalanKcal);
            Controls.Add(lblHedefKcal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(txtBoxBoy);
            Controls.Add(txtBoxKilo);
            Controls.Add(txtBoxDietType);
            Controls.Add(txtBoxGoalType);
            Controls.Add(lblAdSoyad);
            Controls.Add(label1);
            Controls.Add(lnkLblSifreDegistir);
            Controls.Add(btnKapat);
            Name = "FrmProfil";
            Text = "Profil";
            Load += FrmProfil_Load;
            ((System.ComponentModel.ISupportInitialize)cKaloriTakipHaftalik).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFavoriBesin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKapat;
        private LinkLabel lnkLblSifreDegistir;
        private Label label1;
        private Label lblAdSoyad;
        private TextBox txtBoxGoalType;
        private TextBox txtBoxDietType;
        private TextBox txtBoxBoy;
        private TextBox txtBoxKilo;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label lblHedefKcal;
        private Label lblKalanKcal;
        private System.Windows.Forms.DataVisualization.Charting.Chart cKaloriTakipHaftalik;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFavoriBesin;
        private Label lblEnCokTuketilenYiyecek;
    }
}