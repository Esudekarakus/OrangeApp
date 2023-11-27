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
            label1 = new Label();
            label2 = new Label();
            cBoxBeslenmeTuru = new ComboBox();
            label3 = new Label();
            cb = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(118, 99);
            label1.Name = "label1";
            label1.Size = new Size(386, 29);
            label1.TabIndex = 0;
            label1.Text = "Bize kendinden biraz bahseder misin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(66, 174);
            label2.Name = "label2";
            label2.Size = new Size(384, 26);
            label2.TabIndex = 1;
            label2.Text = "1.Hangi beslenme türünü tercih ediyorsun?";
            // 
            // cBoxBeslenmeTuru
            // 
            cBoxBeslenmeTuru.FormattingEnabled = true;
            cBoxBeslenmeTuru.Location = new Point(94, 223);
            cBoxBeslenmeTuru.Name = "cBoxBeslenmeTuru";
            cBoxBeslenmeTuru.Size = new Size(356, 28);
            cBoxBeslenmeTuru.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(69, 272);
            label3.Name = "label3";
            label3.Size = new Size(435, 26);
            label3.TabIndex = 3;
            label3.Text = "2. Neden programımızı kullanmaya karar verdin?";
            // 
            // cb
            // 
            cb.AutoSize = true;
            cb.ForeColor = SystemColors.Info;
            cb.Location = new Point(94, 320);
            cb.Name = "cb";
            cb.Size = new Size(174, 24);
            cb.TabIndex = 4;
            cb.Text = "Kilo vermek istiyorum";
            cb.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.ForeColor = SystemColors.Info;
            checkBox2.Location = new Point(94, 366);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(166, 24);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Kilo almak istiyorum";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.ForeColor = SystemColors.Info;
            checkBox3.Location = new Point(94, 413);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(486, 24);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Kilomdan memnumum,sağlıklı bir yaşam tarzı benimsemek istiyorum";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft PhagsPa", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(190, 454);
            label4.Name = "label4";
            label4.Size = new Size(260, 29);
            label4.TabIndex = 7;
            label4.Text = "O zaman başlayalım mı?";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(248, 496);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "EVET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Survey
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(748, 560);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(cb);
            Controls.Add(label3);
            Controls.Add(cBoxBeslenmeTuru);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Survey";
            Text = "Survey";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cBoxBeslenmeTuru;
        private Label label3;
        private CheckBox cb;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label4;
        private Button button1;
    }
}