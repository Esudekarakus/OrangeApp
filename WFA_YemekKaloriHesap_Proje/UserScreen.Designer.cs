namespace YemekKalori.UI
{
    partial class UserScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserScreen));
            lblAksam = new Label();
            lblOglen = new Label();
            lblSu = new Label();
            btnHesaplaSabah = new Button();
            btnHesaplaOglen = new Button();
            btnHesaplaAksam = new Button();
            comboBoxSu = new ComboBox();
            btnHesaplaAraOgun = new Button();
            btnToplamKalori = new Button();
            lblToplamKalori = new Label();
            pictureBox6 = new PictureBox();
            label14 = new Label();
            label1 = new Label();
            lstYemekler = new ListBox();
            lstSecimler = new ListBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            txtFoodDetay = new TextBox();
            btnGuncelle = new Button();
            btnSil = new Button();
            gBoxSabah = new GroupBox();
            grBoxAksam = new GroupBox();
            gBoxOgle = new GroupBox();
            btnOnayla = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            gBoxSabah.SuspendLayout();
            grBoxAksam.SuspendLayout();
            gBoxOgle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAksam
            // 
            lblAksam.AutoSize = true;
            lblAksam.ForeColor = SystemColors.ButtonHighlight;
            lblAksam.Location = new Point(6, 91);
            lblAksam.Name = "lblAksam";
            lblAksam.Size = new Size(15, 20);
            lblAksam.TabIndex = 95;
            lblAksam.Text = "_";
            // 
            // lblOglen
            // 
            lblOglen.AutoSize = true;
            lblOglen.ForeColor = SystemColors.ButtonHighlight;
            lblOglen.Location = new Point(6, 91);
            lblOglen.Name = "lblOglen";
            lblOglen.Size = new Size(15, 20);
            lblOglen.TabIndex = 94;
            lblOglen.Text = "_";
            // 
            // lblSu
            // 
            lblSu.AutoSize = true;
            lblSu.ForeColor = SystemColors.ButtonHighlight;
            lblSu.Location = new Point(6, 91);
            lblSu.Name = "lblSu";
            lblSu.Size = new Size(15, 20);
            lblSu.TabIndex = 93;
            lblSu.Text = "_";
            // 
            // btnHesaplaSabah
            // 
            btnHesaplaSabah.BackColor = Color.FromArgb(255, 128, 0);
            btnHesaplaSabah.ForeColor = SystemColors.ButtonHighlight;
            btnHesaplaSabah.Location = new Point(0, 36);
            btnHesaplaSabah.Name = "btnHesaplaSabah";
            btnHesaplaSabah.Size = new Size(175, 29);
            btnHesaplaSabah.TabIndex = 92;
            btnHesaplaSabah.Text = "Kahvaltı Kalori Toplamı";
            btnHesaplaSabah.UseVisualStyleBackColor = false;
            // 
            // btnHesaplaOglen
            // 
            btnHesaplaOglen.BackColor = Color.FromArgb(255, 128, 0);
            btnHesaplaOglen.ForeColor = SystemColors.ButtonHighlight;
            btnHesaplaOglen.Location = new Point(0, 36);
            btnHesaplaOglen.Name = "btnHesaplaOglen";
            btnHesaplaOglen.Size = new Size(165, 29);
            btnHesaplaOglen.TabIndex = 91;
            btnHesaplaOglen.Text = "Öğlen Kalori Toplamı";
            btnHesaplaOglen.UseVisualStyleBackColor = false;
            // 
            // btnHesaplaAksam
            // 
            btnHesaplaAksam.BackColor = Color.FromArgb(255, 128, 0);
            btnHesaplaAksam.ForeColor = SystemColors.ButtonHighlight;
            btnHesaplaAksam.Location = new Point(0, 36);
            btnHesaplaAksam.Name = "btnHesaplaAksam";
            btnHesaplaAksam.Size = new Size(165, 29);
            btnHesaplaAksam.TabIndex = 90;
            btnHesaplaAksam.Text = "Akşam Kalori Toplamı";
            btnHesaplaAksam.UseVisualStyleBackColor = false;
            // 
            // comboBoxSu
            // 
            comboBoxSu.BackColor = Color.FromArgb(255, 128, 0);
            comboBoxSu.ForeColor = SystemColors.InactiveBorder;
            comboBoxSu.FormattingEnabled = true;
            comboBoxSu.Location = new Point(716, 327);
            comboBoxSu.Name = "comboBoxSu";
            comboBoxSu.Size = new Size(154, 28);
            comboBoxSu.TabIndex = 89;
            comboBoxSu.SelectedIndexChanged += this.comboBoxSu_SelectedIndexChanged;
            // 
            // btnHesaplaAraOgun
            // 
            btnHesaplaAraOgun.BackColor = Color.MediumAquamarine;
            btnHesaplaAraOgun.ForeColor = SystemColors.ButtonHighlight;
            btnHesaplaAraOgun.Location = new Point(491, 199);
            btnHesaplaAraOgun.Name = "btnHesaplaAraOgun";
            btnHesaplaAraOgun.Size = new Size(185, 29);
            btnHesaplaAraOgun.TabIndex = 88;
            btnHesaplaAraOgun.Text = "Ara Öğün Kalori Toplamı";
            btnHesaplaAraOgun.UseVisualStyleBackColor = false;
            btnHesaplaAraOgun.Click += this.btnHesaplaAraOgun_Click;
            // 
            // btnToplamKalori
            // 
            btnToplamKalori.BackColor = Color.FromArgb(255, 128, 0);
            btnToplamKalori.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnToplamKalori.ForeColor = SystemColors.ButtonHighlight;
            btnToplamKalori.Location = new Point(12, 554);
            btnToplamKalori.Name = "btnToplamKalori";
            btnToplamKalori.Size = new Size(219, 29);
            btnToplamKalori.TabIndex = 87;
            btnToplamKalori.Text = "Toplam Kaç Kalori Aldım";
            btnToplamKalori.UseVisualStyleBackColor = false;
            // 
            // lblToplamKalori
            // 
            lblToplamKalori.AutoSize = true;
            lblToplamKalori.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamKalori.ForeColor = SystemColors.ButtonHighlight;
            lblToplamKalori.Location = new Point(248, 558);
            lblToplamKalori.Name = "lblToplamKalori";
            lblToplamKalori.Size = new Size(21, 24);
            lblToplamKalori.TabIndex = 86;
            lblToplamKalori.Text = "0";
            // 
            // pictureBox6
            // 
            pictureBox6.Enabled = false;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(738, 246);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(73, 45);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 85;
            pictureBox6.TabStop = false;
            pictureBox6.Click += this.pictureBox6_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(255, 128, 0);
            label14.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(726, 308);
            label14.Name = "label14";
            label14.Size = new Size(120, 16);
            label14.TabIndex = 80;
            label14.Text = "Kaç Litre Su Içtim";
            label14.Click += label14_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MV Boli", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 14);
            label1.Name = "label1";
            label1.Size = new Size(234, 29);
            label1.TabIndex = 104;
            label1.Text = "BUGÜN NE YEDİM";
            // 
            // lstYemekler
            // 
            lstYemekler.Font = new Font("MV Boli", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lstYemekler.FormattingEnabled = true;
            lstYemekler.ItemHeight = 17;
            lstYemekler.Location = new Point(11, 113);
            lstYemekler.Name = "lstYemekler";
            lstYemekler.Size = new Size(336, 242);
            lstYemekler.TabIndex = 105;
            lstYemekler.SelectedIndexChanged += lstYemekler_SelectedIndexChanged;
            // 
            // lstSecimler
            // 
            lstSecimler.Font = new Font("MV Boli", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lstSecimler.FormattingEnabled = true;
            lstSecimler.ItemHeight = 17;
            lstSecimler.Location = new Point(353, 113);
            lstSecimler.Name = "lstSecimler";
            lstSecimler.Size = new Size(341, 242);
            lstSecimler.TabIndex = 106;
            lstSecimler.SelectedIndexChanged += this.lstSecimler_SelectedIndexChanged;
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // txtFoodDetay
            // 
            txtFoodDetay.Location = new Point(11, 80);
            txtFoodDetay.Name = "txtFoodDetay";
            txtFoodDetay.Size = new Size(683, 27);
            txtFoodDetay.TabIndex = 107;
            txtFoodDetay.TextChanged += this.txtFoodDetay_TextChanged;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(255, 128, 0);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(726, 113);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 108;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(255, 128, 0);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(726, 162);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 108;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // gBoxSabah
            // 
            gBoxSabah.Controls.Add(btnHesaplaSabah);
            gBoxSabah.Controls.Add(lblSu);
            gBoxSabah.Location = new Point(18, 363);
            gBoxSabah.Name = "gBoxSabah";
            gBoxSabah.Size = new Size(251, 101);
            gBoxSabah.TabIndex = 109;
            gBoxSabah.TabStop = false;
            gBoxSabah.Text = "Sabah";
            gBoxSabah.Enter += this.gBoxSabah_Enter;
            // 
            // grBoxAksam
            // 
            grBoxAksam.Controls.Add(btnHesaplaAksam);
            grBoxAksam.Controls.Add(lblAksam);
            grBoxAksam.Location = new Point(596, 363);
            grBoxAksam.Name = "grBoxAksam";
            grBoxAksam.Size = new Size(250, 101);
            grBoxAksam.TabIndex = 109;
            grBoxAksam.TabStop = false;
            grBoxAksam.Text = "Akşam";
            grBoxAksam.Enter += this.grBoxAksam_Enter;
            // 
            // gBoxOgle
            // 
            gBoxOgle.Controls.Add(btnHesaplaOglen);
            gBoxOgle.Controls.Add(lblOglen);
            gBoxOgle.Location = new Point(300, 363);
            gBoxOgle.Name = "gBoxOgle";
            gBoxOgle.Size = new Size(251, 101);
            gBoxOgle.TabIndex = 109;
            gBoxOgle.TabStop = false;
            gBoxOgle.Text = "Öğle";
            gBoxOgle.Enter += this.gBoxOgle_Enter;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.FromArgb(255, 128, 0);
            btnOnayla.ForeColor = Color.White;
            btnOnayla.Location = new Point(726, 211);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(94, 29);
            btnOnayla.TabIndex = 110;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += this.btnOnayla_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(802, 508);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 111;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-15, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1005, 51);
            panel1.TabIndex = 112;
            // 
            // UserScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(977, 638);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnOnayla);
            Controls.Add(gBoxOgle);
            Controls.Add(grBoxAksam);
            Controls.Add(gBoxSabah);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(txtFoodDetay);
            Controls.Add(lstSecimler);
            Controls.Add(lstYemekler);
            Controls.Add(comboBoxSu);
            Controls.Add(btnHesaplaAraOgun);
            Controls.Add(btnToplamKalori);
            Controls.Add(lblToplamKalori);
            Controls.Add(pictureBox6);
            Controls.Add(label14);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserScreen";
            Text = "UserScreen";
            Load += UserScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            gBoxSabah.ResumeLayout(false);
            gBoxSabah.PerformLayout();
            grBoxAksam.ResumeLayout(false);
            grBoxAksam.PerformLayout();
            gBoxOgle.ResumeLayout(false);
            gBoxOgle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAksam;
        private Label lblOglen;
        private Label lblSu;
        private Button btnHesaplaSabah;
        private Button btnHesaplaOglen;
        private Button btnHesaplaAksam;
        private ComboBox comboBoxSu;
        private Button btnHesaplaAraOgun;
        private Button btnToplamKalori;
        private Label lblToplamKalori;
        private PictureBox pictureBox6;
        private Label label14;
        private Label label1;
        private ListBox lstYemekler;
        private ListBox lstSecimler;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private TextBox txtFoodDetay;
        private Button btnGuncelle;
        private Button btnSil;
        private GroupBox gBoxSabah;
        private GroupBox grBoxAksam;
        private GroupBox gBoxOgle;
        private Button btnOnayla;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}