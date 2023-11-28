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
            ((System.ComponentModel.ISupportInitialize)nUpDownKilo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUpDownBoy).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 61);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 107);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 0;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 148);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 1;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 188);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 2;
            label4.Text = "Şifre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 228);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 3;
            label5.Text = "Şifre Tekrar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 268);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 4;
            label6.Text = "Kilo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 304);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 5;
            label7.Text = "Boy";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(116, 99);
            txtSurname.Margin = new Padding(3, 2, 3, 2);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(210, 23);
            txtSurname.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(116, 58);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(210, 23);
            txtName.TabIndex = 6;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(116, 140);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(210, 23);
            txtUserName.TabIndex = 7;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(116, 180);
            txtSifre.Margin = new Padding(3, 2, 3, 2);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(210, 23);
            txtSifre.TabIndex = 8;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(116, 220);
            txtSifreTekrar.Margin = new Padding(3, 2, 3, 2);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.PasswordChar = '*';
            txtSifreTekrar.Size = new Size(209, 23);
            txtSifreTekrar.TabIndex = 9;
            // 
            // nUpDownKilo
            // 
            nUpDownKilo.Location = new Point(116, 261);
            nUpDownKilo.Margin = new Padding(3, 2, 3, 2);
            nUpDownKilo.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nUpDownKilo.Name = "nUpDownKilo";
            nUpDownKilo.Size = new Size(210, 23);
            nUpDownKilo.TabIndex = 10;
            // 
            // nUpDownBoy
            // 
            nUpDownBoy.Location = new Point(116, 302);
            nUpDownBoy.Margin = new Padding(3, 2, 3, 2);
            nUpDownBoy.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nUpDownBoy.Name = "nUpDownBoy";
            nUpDownBoy.Size = new Size(210, 23);
            nUpDownBoy.TabIndex = 11;
            // 
            // btnKayitOl
            // 
            btnKayitOl.ForeColor = SystemColors.Highlight;
            btnKayitOl.Location = new Point(116, 348);
            btnKayitOl.Margin = new Padding(3, 2, 3, 2);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(210, 22);
            btnKayitOl.TabIndex = 12;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(407, 417);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ((System.ComponentModel.ISupportInitialize)nUpDownKilo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUpDownBoy).EndInit();
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
    }
}