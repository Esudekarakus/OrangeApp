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
            btnGuncelle = new Button();
            lnkLblSifreDegistir = new LinkLabel();
            label1 = new Label();
            lblAdSoyad = new Label();
            lblYaş = new Label();
            txtBoxGoalType = new TextBox();
            txtBoxDietType = new TextBox();
            txtBoxBoy = new TextBox();
            txtBoxKilo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            lblHedefKcal = new Label();
            lblKalanKcal = new Label();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(176, 376);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 2;
            label1.Text = "BEN";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(46, 41);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(50, 20);
            lblAdSoyad.TabIndex = 3;
            lblAdSoyad.Text = "label2";
            // 
            // lblYaş
            // 
            lblYaş.AutoSize = true;
            lblYaş.Location = new Point(46, 91);
            lblYaş.Name = "lblYaş";
            lblYaş.Size = new Size(50, 20);
            lblYaş.TabIndex = 4;
            lblYaş.Text = "label3";
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
            // FrmProfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 450);
            Controls.Add(lblKalanKcal);
            Controls.Add(lblHedefKcal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(txtBoxBoy);
            Controls.Add(txtBoxKilo);
            Controls.Add(txtBoxDietType);
            Controls.Add(txtBoxGoalType);
            Controls.Add(lblYaş);
            Controls.Add(lblAdSoyad);
            Controls.Add(label1);
            Controls.Add(lnkLblSifreDegistir);
            Controls.Add(btnGuncelle);
            Name = "FrmProfil";
            Text = "Profil";
            Load += FrmProfil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuncelle;
        private LinkLabel lnkLblSifreDegistir;
        private Label label1;
        private Label lblAdSoyad;
        private Label lblYaş;
        private TextBox txtBoxGoalType;
        private TextBox txtBoxDietType;
        private TextBox txtBoxBoy;
        private TextBox txtBoxKilo;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label lblHedefKcal;
        private Label lblKalanKcal;
    }
}