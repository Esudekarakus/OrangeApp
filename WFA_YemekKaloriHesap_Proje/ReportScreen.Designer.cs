namespace YemekKalori.UI
{
    partial class ReportScreen
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(240, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 23);
            label1.TabIndex = 0;
            label1.Text = "SIK TÜKETİLENLER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(56, 62);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 1;
            label2.Text = "HAFTALIK";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(314, 62);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 2;
            label3.Text = "AYLIK";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(529, 62);
            label4.Name = "label4";
            label4.Size = new Size(142, 23);
            label4.TabIndex = 3;
            label4.Text = "TÜM ZAMANLAR";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.PaleTurquoise;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(25, 103);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 304);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.PaleTurquoise;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(269, 103);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(180, 304);
            listBox2.TabIndex = 5;
            // 
            // listBox3
            // 
            listBox3.BackColor = Color.PaleTurquoise;
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(529, 103);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(180, 304);
            listBox3.TabIndex = 6;
            // 
            // ReportScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(784, 559);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportScreen";
            Text = "ReportScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
    }
}