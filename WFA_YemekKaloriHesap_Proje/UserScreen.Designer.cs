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
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            gBoxSabah.SuspendLayout();
            grBoxAksam.SuspendLayout();
            gBoxOgle.SuspendLayout();
            SuspendLayout();
            // 
            // lblAksam
            // 
            lblAksam.AutoSize = true;
            lblAksam.ForeColor = SystemColors.ButtonHighlight;
            lblAksam.Location = new Point(5, 68);
            lblAksam.Name = "lblAksam";
            lblAksam.Size = new Size(12, 15);
            lblAksam.TabIndex = 95;
            lblAksam.Text = "_";
            // 
            // lblOglen
            // 
            lblOglen.AutoSize = true;
            lblOglen.ForeColor = SystemColors.ButtonHighlight;
            lblOglen.Location = new Point(5, 68);
            lblOglen.Name = "lblOglen";
            lblOglen.Size = new Size(12, 15);
            lblOglen.TabIndex = 94;
            lblOglen.Text = "_";
            // 
            // lblSu
            // 
            lblSu.AutoSize = true;
            lblSu.ForeColor = SystemColors.ButtonHighlight;
            lblSu.Location = new Point(5, 68);
            lblSu.Name = "lblSu";
            lblSu.Size = new Size(12, 15);
            lblSu.TabIndex = 93;
            lblSu.Text = "_";
            // 
            // btnHesaplaSabah
            // 
            btnHesaplaSabah.BackColor = Color.MediumAquamarine;
            btnHesaplaSabah.ForeColor = SystemColors.ButtonHighlight;
            btnHesaplaSabah.Location = new Point(0, 27);
            btnHesaplaSabah.Margin = new Padding(3, 2, 3, 2);
            btnHesaplaSabah.Name = "btnHesaplaSabah";
            btnHesaplaSabah.Size = new Size(153, 22);
            btnHesaplaSabah.TabIndex = 92;
            btnHesaplaSabah.Text = "Kahvaltı Kalori Toplamı";
            btnHesaplaSabah.UseVisualStyleBackColor = false;
            // 
            // btnHesaplaOglen
            // 
            btnHesaplaOglen.BackColor = Color.MediumAquamarine;
            btnHesaplaOglen.ForeColor = SystemColors.ButtonHighlight;
            btnHesaplaOglen.Location = new Point(0, 27);
            btnHesaplaOglen.Margin = new Padding(3, 2, 3, 2);
            btnHesaplaOglen.Name = "btnHesaplaOglen";
            btnHesaplaOglen.Size = new Size(144, 22);
            btnHesaplaOglen.TabIndex = 91;
            btnHesaplaOglen.Text = "Öğlen Kalori Toplamı";
            btnHesaplaOglen.UseVisualStyleBackColor = false;
            // 
            // btnHesaplaAksam
            // 
            btnHesaplaAksam.BackColor = Color.MediumAquamarine;
            btnHesaplaAksam.ForeColor = SystemColors.ButtonHighlight;
            btnHesaplaAksam.Location = new Point(0, 27);
            btnHesaplaAksam.Margin = new Padding(3, 2, 3, 2);
            btnHesaplaAksam.Name = "btnHesaplaAksam";
            btnHesaplaAksam.Size = new Size(144, 22);
            btnHesaplaAksam.TabIndex = 90;
            btnHesaplaAksam.Text = "Akşam Kalori Toplamı";
            btnHesaplaAksam.UseVisualStyleBackColor = false;
            // 
            // comboBoxSu
            // 
            comboBoxSu.BackColor = Color.MediumAquamarine;
            comboBoxSu.ForeColor = SystemColors.InactiveBorder;
            comboBoxSu.FormattingEnabled = true;
            comboBoxSu.Location = new Point(626, 224);
            comboBoxSu.Margin = new Padding(3, 2, 3, 2);
            comboBoxSu.Name = "comboBoxSu";
            comboBoxSu.Size = new Size(135, 23);
            comboBoxSu.TabIndex = 89;
            // 
            // btnHesaplaAraOgun
            // 
            btnHesaplaAraOgun.BackColor = Color.MediumAquamarine;
            btnHesaplaAraOgun.ForeColor = SystemColors.ButtonHighlight;
            btnHesaplaAraOgun.Location = new Point(430, 149);
            btnHesaplaAraOgun.Margin = new Padding(3, 2, 3, 2);
            btnHesaplaAraOgun.Name = "btnHesaplaAraOgun";
            btnHesaplaAraOgun.Size = new Size(162, 22);
            btnHesaplaAraOgun.TabIndex = 88;
            btnHesaplaAraOgun.Text = "Ara Öğün Kalori Toplamı";
            btnHesaplaAraOgun.UseVisualStyleBackColor = false;
            // 
            // btnToplamKalori
            // 
            btnToplamKalori.BackColor = Color.MediumAquamarine;
            btnToplamKalori.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnToplamKalori.ForeColor = SystemColors.ButtonHighlight;
            btnToplamKalori.Location = new Point(10, 397);
            btnToplamKalori.Margin = new Padding(3, 2, 3, 2);
            btnToplamKalori.Name = "btnToplamKalori";
            btnToplamKalori.Size = new Size(192, 22);
            btnToplamKalori.TabIndex = 87;
            btnToplamKalori.Text = "Toplam Kaç Kalori Aldım";
            btnToplamKalori.UseVisualStyleBackColor = false;
            // 
            // lblToplamKalori
            // 
            lblToplamKalori.AutoSize = true;
            lblToplamKalori.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamKalori.ForeColor = SystemColors.ButtonHighlight;
            lblToplamKalori.Location = new Point(216, 400);
            lblToplamKalori.Name = "lblToplamKalori";
            lblToplamKalori.Size = new Size(18, 19);
            lblToplamKalori.TabIndex = 86;
            lblToplamKalori.Text = "0";
            // 
            // pictureBox6
            // 
            pictureBox6.Enabled = false;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(646, 174);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(64, 34);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 85;
            pictureBox6.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.MediumAquamarine;
            label14.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(635, 210);
            label14.Name = "label14";
            label14.Size = new Size(102, 14);
            label14.TabIndex = 80;
            label14.Text = "Kaç Litre Su Içtim";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumAquamarine;
            label1.Location = new Point(-4, 7);
            label1.Name = "label1";
            label1.Size = new Size(176, 22);
            label1.TabIndex = 104;
            label1.Text = "BUGÜN NE YEDİM";
            // 
            // lstYemekler
            // 
            lstYemekler.FormattingEnabled = true;
            lstYemekler.ItemHeight = 15;
            lstYemekler.Location = new Point(10, 62);
            lstYemekler.Margin = new Padding(3, 2, 3, 2);
            lstYemekler.Name = "lstYemekler";
            lstYemekler.Size = new Size(294, 184);
            lstYemekler.TabIndex = 105;
            lstYemekler.SelectedIndexChanged += lstYemekler_SelectedIndexChanged;
            lstYemekler.MouseDown += lstYemekler_MouseDown;
            // 
            // lstSecimler
            // 
            lstSecimler.FormattingEnabled = true;
            lstSecimler.ItemHeight = 15;
            lstSecimler.Location = new Point(309, 62);
            lstSecimler.Margin = new Padding(3, 2, 3, 2);
            lstSecimler.Name = "lstSecimler";
            lstSecimler.Size = new Size(299, 184);
            lstSecimler.TabIndex = 106;
            lstSecimler.DragDrop += lstSecimler_DragDrop;
            lstSecimler.DragEnter += lstSecimler_DragEnter;
            lstSecimler.DoubleClick += lstSecimler_DoubleClick;
            lstSecimler.MouseDoubleClick += lstSecimler_MouseDoubleClick;
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // txtFoodDetay
            // 
            txtFoodDetay.Location = new Point(10, 38);
            txtFoodDetay.Margin = new Padding(3, 2, 3, 2);
            txtFoodDetay.Name = "txtFoodDetay";
            txtFoodDetay.Size = new Size(598, 23);
            txtFoodDetay.TabIndex = 107;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(635, 74);
            btnGuncelle.Margin = new Padding(3, 2, 3, 2);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(82, 22);
            btnGuncelle.TabIndex = 108;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(635, 111);
            btnSil.Margin = new Padding(3, 2, 3, 2);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(82, 22);
            btnSil.TabIndex = 108;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // gBoxSabah
            // 
            gBoxSabah.Controls.Add(btnHesaplaSabah);
            gBoxSabah.Controls.Add(lblSu);
            gBoxSabah.Location = new Point(16, 254);
            gBoxSabah.Margin = new Padding(3, 2, 3, 2);
            gBoxSabah.Name = "gBoxSabah";
            gBoxSabah.Padding = new Padding(3, 2, 3, 2);
            gBoxSabah.Size = new Size(219, 94);
            gBoxSabah.TabIndex = 109;
            gBoxSabah.TabStop = false;
            gBoxSabah.Text = "Sabah";
            // 
            // grBoxAksam
            // 
            grBoxAksam.Controls.Add(btnHesaplaAksam);
            grBoxAksam.Controls.Add(lblAksam);
            grBoxAksam.Location = new Point(522, 254);
            grBoxAksam.Margin = new Padding(3, 2, 3, 2);
            grBoxAksam.Name = "grBoxAksam";
            grBoxAksam.Padding = new Padding(3, 2, 3, 2);
            grBoxAksam.Size = new Size(219, 94);
            grBoxAksam.TabIndex = 109;
            grBoxAksam.TabStop = false;
            grBoxAksam.Text = "Akşam";
            // 
            // gBoxOgle
            // 
            gBoxOgle.Controls.Add(btnHesaplaOglen);
            gBoxOgle.Controls.Add(lblOglen);
            gBoxOgle.Location = new Point(262, 254);
            gBoxOgle.Margin = new Padding(3, 2, 3, 2);
            gBoxOgle.Name = "gBoxOgle";
            gBoxOgle.Padding = new Padding(3, 2, 3, 2);
            gBoxOgle.Size = new Size(219, 94);
            gBoxOgle.TabIndex = 109;
            gBoxOgle.TabStop = false;
            gBoxOgle.Text = "Öğle";
            // 
            // btnOnayla
            // 
            btnOnayla.Location = new Point(635, 148);
            btnOnayla.Margin = new Padding(3, 2, 3, 2);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(82, 22);
            btnOnayla.TabIndex = 110;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = true;
            // 
            // UserScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(800, 428);
            Controls.Add(btnOnayla);
            Controls.Add(gBoxOgle);
            Controls.Add(grBoxAksam);
            Controls.Add(gBoxSabah);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(txtFoodDetay);
            Controls.Add(lstSecimler);
            Controls.Add(lstYemekler);
            Controls.Add(label1);
            Controls.Add(comboBoxSu);
            Controls.Add(btnHesaplaAraOgun);
            Controls.Add(btnToplamKalori);
            Controls.Add(lblToplamKalori);
            Controls.Add(pictureBox6);
            Controls.Add(label14);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}