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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(254, 10);
            label1.Name = "label1";
            label1.Size = new Size(219, 26);
            label1.TabIndex = 0;
            label1.Text = "SIK TÜKETİLENLER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(63, 93);
            label2.Name = "label2";
            label2.Size = new Size(119, 26);
            label2.TabIndex = 1;
            label2.Text = "HAFTALIK";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(334, 93);
            label3.Name = "label3";
            label3.Size = new Size(77, 26);
            label3.TabIndex = 2;
            label3.Text = "AYLIK";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Orange;
            label4.Location = new Point(513, 93);
            label4.Name = "label4";
            label4.Size = new Size(200, 26);
            label4.TabIndex = 3;
            label4.Text = "TÜM ZAMANLAR";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(38, 153);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 304);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.White;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(279, 153);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(180, 304);
            listBox2.TabIndex = 5;
            // 
            // listBox3
            // 
            listBox3.BackColor = Color.White;
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(517, 153);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(196, 304);
            listBox3.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(773, 50);
            panel1.TabIndex = 7;
            // 
            // ReportScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(752, 509);
            Controls.Add(panel1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportScreen";
            Text = "ReportScreen";
            Load += ReportScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
    }
}