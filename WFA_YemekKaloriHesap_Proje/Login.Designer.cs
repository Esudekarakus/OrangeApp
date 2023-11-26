namespace WFA_YemekKaloriHesap_Proje
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblKayitOl = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(160, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 39);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(37, 116);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(43, 177);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(160, 121);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(220, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(160, 182);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(220, 23);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkOrange;
            btnLogin.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(160, 253);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(220, 56);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblKayitOl
            // 
            lblKayitOl.AutoSize = true;
            lblKayitOl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblKayitOl.LinkColor = Color.Cyan;
            lblKayitOl.Location = new Point(388, 360);
            lblKayitOl.Name = "lblKayitOl";
            lblKayitOl.Size = new Size(70, 25);
            lblKayitOl.TabIndex = 6;
            lblKayitOl.TabStop = true;
            lblKayitOl.Text = "Sign In";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(477, 394);
            Controls.Add(lblKayitOl);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel lblKayitOl;
    }
}