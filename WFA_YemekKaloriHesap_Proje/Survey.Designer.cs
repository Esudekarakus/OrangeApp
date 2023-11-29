namespace YemekKalori.UI
{
    partial class Survey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Survey));
            label1 = new Label();
            label2 = new Label();
            cBoxBeslenmeTuru = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            cbGoals = new ComboBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MV Boli", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(89, 14);
            label1.Name = "label1";
            label1.Size = new Size(462, 29);
            label1.TabIndex = 0;
            label1.Text = "Bize kendinden biraz bahseder misin ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(80, 172);
            label2.Name = "label2";
            label2.Size = new Size(440, 26);
            label2.TabIndex = 1;
            label2.Text = "Hangi beslenme türünü tercih ediyorsun?";
            // 
            // cBoxBeslenmeTuru
            // 
            cBoxBeslenmeTuru.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxBeslenmeTuru.FormattingEnabled = true;
            cBoxBeslenmeTuru.Location = new Point(83, 216);
            cBoxBeslenmeTuru.Name = "cBoxBeslenmeTuru";
            cBoxBeslenmeTuru.Size = new Size(437, 28);
            cBoxBeslenmeTuru.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(83, 271);
            label3.Name = "label3";
            label3.Size = new Size(486, 26);
            label3.TabIndex = 3;
            label3.Text = "Neden programımızı kullanmaya karar verdin?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(182, 378);
            label4.Name = "label4";
            label4.Size = new Size(263, 26);
            label4.TabIndex = 7;
            label4.Text = "O zaman başlayalım mı?";
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.Font = new Font("MV Boli", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(242, 417);
            button1.Name = "button1";
            button1.Size = new Size(134, 47);
            button1.TabIndex = 8;
            button1.Text = "EVET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cbGoals
            // 
            cbGoals.FormattingEnabled = true;
            cbGoals.Location = new Point(83, 321);
            cbGoals.Name = "cbGoals";
            cbGoals.Size = new Size(437, 28);
            cbGoals.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-9, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 53);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-9, 484);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(670, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Survey
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(630, 623);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(cbGoals);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cBoxBeslenmeTuru);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Survey";
            Text = "Survey";
            Load += Survey_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cBoxBeslenmeTuru;
        private Label label3;
        private Label label4;
        private Button button1;
        private ComboBox cbGoals;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}