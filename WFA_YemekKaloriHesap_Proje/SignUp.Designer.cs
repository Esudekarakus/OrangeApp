namespace YemekKalori.UI
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtSurname = new TextBox();
            txtName = new TextBox();
            txtUserName = new TextBox();
            txtSifre = new TextBox();
            txtSifreTekrar = new TextBox();
            nUpDownKilo = new NumericUpDown();
            nUpDownBoy = new NumericUpDown();
            btnKayitOl = new Button();
            panel1 = new Panel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nUpDownKilo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUpDownBoy).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(41, 81);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(41, 143);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 0;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(41, 197);
            label3.Name = "label3";
            label3.Size = new Size(83, 17);
            label3.TabIndex = 1;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(41, 251);
            label4.Name = "label4";
            label4.Size = new Size(40, 17);
            label4.TabIndex = 2;
            label4.Text = "Şifre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(41, 304);
            label5.Name = "label5";
            label5.Size = new Size(94, 17);
            label5.TabIndex = 3;
            label5.Text = "Şifre Tekrar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(255, 128, 0);
            label6.Location = new Point(41, 357);
            label6.Name = "label6";
            label6.Size = new Size(36, 17);
            label6.TabIndex = 4;
            label6.Text = "Kilo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(41, 405);
            label7.Name = "label7";
            label7.Size = new Size(36, 17);
            label7.TabIndex = 5;
            label7.Text = "Boy";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(133, 136);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(239, 27);
            txtSurname.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(133, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 27);
            txtName.TabIndex = 6;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(133, 187);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(239, 27);
            txtUserName.TabIndex = 7;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(133, 240);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(239, 27);
            txtSifre.TabIndex = 8;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(133, 293);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.PasswordChar = '*';
            txtSifreTekrar.Size = new Size(238, 27);
            txtSifreTekrar.TabIndex = 9;
            // 
            // nUpDownKilo
            // 
            nUpDownKilo.Location = new Point(133, 348);
            nUpDownKilo.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nUpDownKilo.Name = "nUpDownKilo";
            nUpDownKilo.Size = new Size(240, 27);
            nUpDownKilo.TabIndex = 10;
            // 
            // nUpDownBoy
            // 
            nUpDownBoy.Location = new Point(133, 403);
            nUpDownBoy.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nUpDownBoy.Name = "nUpDownBoy";
            nUpDownBoy.Size = new Size(240, 27);
            nUpDownBoy.TabIndex = 11;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.FromArgb(255, 128, 0);
            btnKayitOl.ForeColor = Color.White;
            btnKayitOl.Location = new Point(133, 464);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(240, 29);
            btnKayitOl.TabIndex = 12;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            btnKayitOl.MouseEnter += btnKayitOl_MouseEnter;
            btnKayitOl.MouseLeave += btnKayitOl_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(-3, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 52);
            panel1.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(136, 1);
            label8.Name = "label8";
            label8.Size = new Size(190, 38);
            label8.TabIndex = 0;
            label8.Text = "Orange'a Katıl";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-70, 499);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(609, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(465, 577);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(btnKayitOl);
            Controls.Add(nUpDownBoy);
            Controls.Add(nUpDownKilo);
            Controls.Add(txtSifreTekrar);
            Controls.Add(txtSifre);
            Controls.Add(txtUserName);
            Controls.Add(txtName);
            Controls.Add(txtSurname);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.Info;
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ((System.ComponentModel.ISupportInitialize)nUpDownKilo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUpDownBoy).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtSurname;
        private TextBox txtName;
        private TextBox txtUserName;
        private TextBox txtSifre;
        private TextBox txtSifreTekrar;
        private NumericUpDown nUpDownKilo;
        private NumericUpDown nUpDownBoy;
        private Button btnKayitOl;
        private Panel panel1;
        private Label label8;
        private PictureBox pictureBox1;
    }
}