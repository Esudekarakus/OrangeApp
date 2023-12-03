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
            label1.Location = new Point(22, 232);
            label1.Name = "label1";
            label1.Size = new Size(222, 25);
            label1.TabIndex = 0;
            label1.Text = "Porsiyon ne kadar olsun?";
            label1.Click += label1_Click;
            // 
            // cbPortions
            // 
            cbPortions.FormattingEnabled = true;
            cbPortions.Location = new Point(22, 338);
            cbPortions.Name = "cbPortions";
            cbPortions.Size = new Size(222, 23);
            cbPortions.TabIndex = 1;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.FromArgb(255, 128, 0);
            btnOnayla.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnOnayla.ForeColor = Color.White;
            btnOnayla.Location = new Point(56, 394);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(138, 43);
            btnOnayla.TabIndex = 2;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // pbFoodPic
            // 
            pbFoodPic.Location = new Point(12, 12);
            pbFoodPic.Name = "pbFoodPic";
            pbFoodPic.Size = new Size(232, 166);
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
            lblPorsiyonTanim.Location = new Point(163, 292);
            lblPorsiyonTanim.Name = "lblPorsiyonTanim";
            lblPorsiyonTanim.Size = new Size(52, 21);
            lblPorsiyonTanim.TabIndex = 4;
            lblPorsiyonTanim.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(22, 292);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 5;
            label2.Text = "Porsiyon Tanımı :";
            // 
            // lblYemekAd
            // 
            lblYemekAd.AutoSize = true;
            lblYemekAd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblYemekAd.ForeColor = Color.FromArgb(255, 128, 0);
            lblYemekAd.Location = new Point(66, 181);
            lblYemekAd.Name = "lblYemekAd";
            lblYemekAd.Size = new Size(52, 21);
            lblYemekAd.TabIndex = 6;
            lblYemekAd.Text = "label3";
            // 
            // PortionScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 466);
            Controls.Add(lblYemekAd);
            Controls.Add(label2);
            Controls.Add(lblPorsiyonTanim);
            Controls.Add(pbFoodPic);
            Controls.Add(btnOnayla);
            Controls.Add(cbPortions);
            Controls.Add(label1);
            Name = "PortionScreen";
            StartPosition = FormStartPosition.CenterParent;
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