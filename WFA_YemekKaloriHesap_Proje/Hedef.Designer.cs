namespace YemekKalori.UI
{
    partial class Hedef
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(160, 19);
            label1.Name = "label1";
            label1.Size = new Size(77, 27);
            label1.TabIndex = 0;
            label1.Text = "HEDEF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(34, 78);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 1;
            label2.Text = "Hedef kcal.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(242, 78);
            label3.Name = "label3";
            label3.Size = new Size(120, 22);
            label3.TabIndex = 2;
            label3.Text = "Kalan kcal.";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 192, 128);
            textBox1.Location = new Point(29, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 192, 128);
            textBox2.Location = new Point(242, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // Hedef
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(441, 244);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Hedef";
            Text = "Hedef";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}