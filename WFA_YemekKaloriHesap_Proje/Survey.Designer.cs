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
            label4 = new Label();
            button1 = new Button();
            cbGoals = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(103, 74);
            label1.Name = "label1";
            label1.Size = new Size(319, 24);
            label1.TabIndex = 0;
            label1.Text = "Bize kendinden biraz bahseder misin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(58, 130);
            label2.Name = "label2";
            label2.Size = new Size(308, 21);
            label2.TabIndex = 1;
            label2.Text = "1.Hangi beslenme türünü tercih ediyorsun?";
            // 
            // cBoxBeslenmeTuru
            // 
            cBoxBeslenmeTuru.FormattingEnabled = true;
            cBoxBeslenmeTuru.Location = new Point(82, 167);
            cBoxBeslenmeTuru.Margin = new Padding(3, 2, 3, 2);
            cBoxBeslenmeTuru.Name = "cBoxBeslenmeTuru";
            cBoxBeslenmeTuru.Size = new Size(312, 23);
            cBoxBeslenmeTuru.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(60, 204);
            label3.Name = "label3";
            label3.Size = new Size(349, 21);
            label3.TabIndex = 3;
            label3.Text = "2. Neden programımızı kullanmaya karar verdin?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft PhagsPa", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(166, 340);
            label4.Name = "label4";
            label4.Size = new Size(214, 24);
            label4.TabIndex = 7;
            label4.Text = "O zaman başlayalım mı?";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(217, 372);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 8;
            button1.Text = "EVET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbGoals
            // 
            cbGoals.FormattingEnabled = true;
            cbGoals.Location = new Point(82, 244);
            cbGoals.Margin = new Padding(3, 2, 3, 2);
            cbGoals.Name = "cbGoals";
            cbGoals.Size = new Size(312, 23);
            cbGoals.TabIndex = 9;
            // 
            // Survey
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(654, 420);
            Controls.Add(cbGoals);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cBoxBeslenmeTuru);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Survey";
            Text = "Survey";
            Load += Survey_Load;
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
    }
}