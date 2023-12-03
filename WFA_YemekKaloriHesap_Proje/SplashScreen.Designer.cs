namespace YemekKalori.UI
{
    partial class SplashScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(294, -5);
            label1.Name = "label1";
            label1.Size = new Size(184, 43);
            label1.TabIndex = 0;
            label1.Text = "ORANGE";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(-1, 12);
            button1.Name = "button1";
            button1.Size = new Size(802, 10);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Location = new Point(-1, 69);
            button2.Name = "button2";
            button2.Size = new Size(802, 10);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(-1, 426);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 27);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Location = new Point(-1, 426);
            panel2.Name = "panel2";
            panel2.Size = new Size(69, 24);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(-1, 379);
            label2.Name = "label2";
            label2.Size = new Size(89, 24);
            label2.TabIndex = 6;
            label2.Text = "Loading...";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 17;
            timer1.Tick += timer1_Tick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(-1, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(802, 35);
            panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(94, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(633, 335);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            Load += SplashScreen_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}