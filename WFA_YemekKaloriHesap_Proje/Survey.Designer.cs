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
            label1.Font = new Font("Microsoft PhagsPa", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(94, 15);
            label1.Name = "label1";
            label1.Size = new Size(386, 29);
            label1.TabIndex = 0;
            label1.Text = "Bize kendinden biraz bahseder misin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(66, 116);
            label2.Name = "label2";
            label2.Size = new Size(429, 23);
            label2.TabIndex = 1;
            label2.Text = "1.Hangi beslenme türünü tercih ediyorsun?";
            // 
            // cBoxBeslenmeTuru
            // 
            cBoxBeslenmeTuru.FormattingEnabled = true;
            cBoxBeslenmeTuru.Location = new Point(108, 173);
            cBoxBeslenmeTuru.Name = "cBoxBeslenmeTuru";
            cBoxBeslenmeTuru.Size = new Size(356, 28);
            cBoxBeslenmeTuru.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(44, 225);
            label3.Name = "label3";
            label3.Size = new Size(482, 23);
            label3.TabIndex = 3;
            label3.Text = "2. Neden programımızı kullanmaya karar verdin?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(160, 346);
            label4.Name = "label4";
            label4.Size = new Size(277, 27);
            label4.TabIndex = 7;
            label4.Text = "O zaman başlayalım mı?";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(238, 391);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "EVET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cbGoals
            // 
            cbGoals.FormattingEnabled = true;
            cbGoals.Location = new Point(108, 275);
            cbGoals.Name = "cbGoals";
            cbGoals.Size = new Size(356, 28);
            cbGoals.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 55);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-18, 426);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(597, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Survey
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(561, 546);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(cbGoals);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cBoxBeslenmeTuru);
            Controls.Add(label2);
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