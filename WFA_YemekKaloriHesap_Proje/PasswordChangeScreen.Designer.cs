namespace YemekKalori.UI
{
    partial class PasswordChangeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordChangeScreen));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEskiSifre = new TextBox();
            txtYeniSifre = new TextBox();
            txtYeniSifreTekrar = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(191, 8);
            label1.Name = "label1";
            label1.Size = new Size(202, 45);
            label1.TabIndex = 0;
            label1.Text = "Şifre Değiştir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(101, 104);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 1;
            label2.Text = "Eski Şifre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(98, 163);
            label3.Name = "label3";
            label3.Size = new Size(113, 30);
            label3.TabIndex = 2;
            label3.Text = "Yeni Şifre :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(32, 222);
            label4.Name = "label4";
            label4.Size = new Size(179, 30);
            label4.TabIndex = 3;
            label4.Text = "Yeni Şifre Tekrar :";
            // 
            // txtEskiSifre
            // 
            txtEskiSifre.Location = new Point(217, 113);
            txtEskiSifre.Name = "txtEskiSifre";
            txtEskiSifre.PasswordChar = '*';
            txtEskiSifre.Size = new Size(307, 23);
            txtEskiSifre.TabIndex = 4;
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(217, 170);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.PasswordChar = '*';
            txtYeniSifre.Size = new Size(307, 23);
            txtYeniSifre.TabIndex = 5;
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.Location = new Point(217, 229);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.PasswordChar = '*';
            txtYeniSifreTekrar.Size = new Size(307, 23);
            txtYeniSifreTekrar.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(217, 333);
            button1.Name = "button1";
            button1.Size = new Size(227, 48);
            button1.TabIndex = 7;
            button1.Text = "Onayla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 8);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 56);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-36, 333);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // PasswordChangeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(616, 458);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(txtYeniSifreTekrar);
            Controls.Add(txtYeniSifre);
            Controls.Add(txtEskiSifre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "PasswordChangeScreen";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PasswordChangeScreen";
            Load += PasswordChangeScreen_Load;
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
        private TextBox txtEskiSifre;
        private TextBox txtYeniSifre;
        private TextBox txtYeniSifreTekrar;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}