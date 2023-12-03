namespace YemekKalori.UI
{
    partial class MealDeleteScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealDeleteScreen));
            label1 = new Label();
            lstMeals = new ListBox();
            btnDelete = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 8);
            label1.Name = "label1";
            label1.Size = new Size(343, 32);
            label1.TabIndex = 0;
            label1.Text = "Silmek istediğiniz öğünü seçin.";
            // 
            // lstMeals
            // 
            lstMeals.FormattingEnabled = true;
            lstMeals.ItemHeight = 20;
            lstMeals.Location = new Point(14, 65);
            lstMeals.Margin = new Padding(3, 4, 3, 4);
            lstMeals.Name = "lstMeals";
            lstMeals.Size = new Size(402, 424);
            lstMeals.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(278, 513);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 52);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-102, 496);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-21, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 57);
            panel1.TabIndex = 4;
            // 
            // MealDeleteScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(430, 581);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnDelete);
            Controls.Add(lstMeals);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MealDeleteScreen";
            Text = "MealDeleteScreen";
            Load += MealDeleteScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ListBox lstMeals;
        private Button btnDelete;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}