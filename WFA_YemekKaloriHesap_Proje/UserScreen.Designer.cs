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
            lblAksam = new Label();
            lblOglen = new Label();
            lblSabah = new Label();
            btnHesaplaSabah = new Button();
            btnHesaplaOglen = new Button();
            btnHesaplaAksam = new Button();
            btnHesaplaAraOgun = new Button();
            btnToplamKalori = new Button();
            lblToplamKalori = new Label();
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
            lLabelProfil = new LinkLabel();
            linkLabel1 = new LinkLabel();
            btnExit = new Button();
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
            // lblSabah
            // 
            lblSabah.AutoSize = true;
            lblSabah.ForeColor = SystemColors.ButtonHighlight;
            lblSabah.Location = new Point(5, 68);
            lblSabah.Name = "lblSabah";
            lblSabah.Size = new Size(12, 15);
            lblSabah.TabIndex = 93;
            lblSabah.Text = "_";
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
            gBoxSabah.Controls.Add(lblSabah);
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
            btnOnayla.Click += btnOnayla_Click;
            // 
            // lLabelProfil
            // 
            lLabelProfil.AutoSize = true;
            lLabelProfil.Location = new Point(723, 28);
            lLabelProfil.Name = "lLabelProfil";
            lLabelProfil.Size = new Size(49, 15);
            lLabelProfil.TabIndex = 112;
            lLabelProfil.TabStop = true;
            lLabelProfil.Text = "Profilim";
            lLabelProfil.LinkClicked += lLabelProfil_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(752, 400);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(85, 21);
            linkLabel1.TabIndex = 113;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Öğünlerim";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(666, 401);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 114;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // UserScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(849, 430);
            Controls.Add(btnExit);
            Controls.Add(linkLabel1);
            Controls.Add(lLabelProfil);
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
            Controls.Add(btnHesaplaAraOgun);
            Controls.Add(btnToplamKalori);
            Controls.Add(lblToplamKalori);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserScreen";
            Text = "UserScreen";
            Load += UserScreen_Load;
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
        private Label lblSabah;
        private Button btnHesaplaSabah;
        private Button btnHesaplaOglen;
        private Button btnHesaplaAksam;
        private Button btnHesaplaAraOgun;
        private Button btnToplamKalori;
        private Label lblToplamKalori;
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
        private LinkLabel lLabelProfil;
        private LinkLabel linkLabel1;
        private Button btnExit;
    }
}