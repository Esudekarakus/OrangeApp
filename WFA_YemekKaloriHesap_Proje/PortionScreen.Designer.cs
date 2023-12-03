namespace YemekKalori.UI
{
    partial class PortionScreen
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
            cbPortions = new ComboBox();
            btnOnayla = new Button();
            pbFoodPic = new PictureBox();
            lblPorsiyonTanim = new Label();
            label2 = new Label();
            lblYemekAd = new Label();
            ((System.ComponentModel.ISupportInitialize)pbFoodPic).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(25, 309);
            label1.Name = "label1";
            label1.Size = new Size(279, 32);
            label1.TabIndex = 0;
            label1.Text = "Porsiyon ne kadar olsun?";
            label1.Click += label1_Click;
            // 
            // cbPortions
            // 
            cbPortions.FormattingEnabled = true;
            cbPortions.Location = new Point(25, 451);
            cbPortions.Margin = new Padding(3, 4, 3, 4);
            cbPortions.Name = "cbPortions";
            cbPortions.Size = new Size(253, 28);
            cbPortions.TabIndex = 1;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.FromArgb(255, 128, 0);
            btnOnayla.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnOnayla.ForeColor = Color.White;
            btnOnayla.Location = new Point(64, 525);
            btnOnayla.Margin = new Padding(3, 4, 3, 4);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(158, 57);
            btnOnayla.TabIndex = 2;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // pbFoodPic
            // 
            pbFoodPic.Location = new Point(14, 16);
            pbFoodPic.Margin = new Padding(3, 4, 3, 4);
            pbFoodPic.Name = "pbFoodPic";
            pbFoodPic.Size = new Size(265, 221);
            pbFoodPic.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoodPic.TabIndex = 3;
            pbFoodPic.TabStop = false;
            // 
            // lblPorsiyonTanim
            // 
            lblPorsiyonTanim.AutoSize = true;
            lblPorsiyonTanim.BackColor = SystemColors.ActiveCaption;
            lblPorsiyonTanim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPorsiyonTanim.ForeColor = Color.FromArgb(255, 128, 0);
            lblPorsiyonTanim.Location = new Point(186, 389);
            lblPorsiyonTanim.Name = "lblPorsiyonTanim";
            lblPorsiyonTanim.Size = new Size(65, 28);
            lblPorsiyonTanim.TabIndex = 4;
            lblPorsiyonTanim.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(25, 389);
            label2.Name = "label2";
            label2.Size = new Size(157, 28);
            label2.TabIndex = 5;
            label2.Text = "Porsiyon Tanımı :";
            // 
            // lblYemekAd
            // 
            lblYemekAd.AutoSize = true;
            lblYemekAd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblYemekAd.ForeColor = Color.FromArgb(255, 128, 0);
            lblYemekAd.Location = new Point(75, 241);
            lblYemekAd.Name = "lblYemekAd";
            lblYemekAd.Size = new Size(65, 28);
            lblYemekAd.TabIndex = 6;
            lblYemekAd.Text = "label3";
            // 
            // PortionScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 621);
            Controls.Add(lblYemekAd);
            Controls.Add(label2);
            Controls.Add(lblPorsiyonTanim);
            Controls.Add(pbFoodPic);
            Controls.Add(btnOnayla);
            Controls.Add(cbPortions);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PortionScreen";
            Text = "PortionScreen";
            Load += PortionScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pbFoodPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbPortions;
        private Button btnOnayla;
        private PictureBox pbFoodPic;
        private Label lblPorsiyonTanim;
        private Label label2;
        private Label lblYemekAd;
    }
}