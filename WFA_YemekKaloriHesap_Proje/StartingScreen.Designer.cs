﻿namespace YemekKalori.UI
{
    partial class StartingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingScreen));
            label1 = new Label();
            label2 = new Label();
            lLabelEvet = new LinkLabel();
            lLabelHayir = new LinkLabel();
            lLabelEveet = new LinkLabel();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(170, 9);
            label1.Name = "label1";
            label1.Size = new Size(403, 32);
            label1.TabIndex = 0;
            label1.Text = "Merhaba, aramıza hoşgeldin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(120, 158);
            label2.Name = "label2";
            label2.Size = new Size(487, 27);
            label2.TabIndex = 1;
            label2.Text = "Seni sanki bir yerlerden hatırlıyor gibiyim...";
            // 
            // lLabelEvet
            // 
            lLabelEvet.AutoSize = true;
            lLabelEvet.Location = new Point(165, 323);
            lLabelEvet.Name = "lLabelEvet";
            lLabelEvet.Size = new Size(0, 20);
            lLabelEvet.TabIndex = 2;
            // 
            // lLabelHayir
            // 
            lLabelHayir.AutoSize = true;
            lLabelHayir.Location = new Point(56, 81);
            lLabelHayir.Name = "lLabelHayir";
            lLabelHayir.Size = new Size(291, 20);
            lLabelHayir.TabIndex = 3;
            lLabelHayir.TabStop = true;
            lLabelHayir.Text = "Hayır,programı ilk defa deneyimleyeceğim";
            lLabelHayir.LinkClicked += lLabelHayir_LinkClicked;
            // 
            // lLabelEveet
            // 
            lLabelEveet.AutoSize = true;
            lLabelEveet.Location = new Point(56, 35);
            lLabelEveet.Name = "lLabelEveet";
            lLabelEveet.Size = new Size(284, 20);
            lLabelEveet.TabIndex = 4;
            lLabelEveet.TabStop = true;
            lLabelEveet.Text = "Evet,daha önce bu programı kullanmıştım";
            lLabelEveet.LinkClicked += lLabelEveet_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lLabelHayir);
            groupBox1.Controls.Add(lLabelEveet);
            groupBox1.Location = new Point(140, 262);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(437, 125);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-15, 444);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(728, 247);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 57);
            panel1.TabIndex = 7;
            // 
            // StartingScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(701, 582);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(lLabelEvet);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartingScreen";
            Text = "StartingScreen";
            Load += StartingScreen_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private LinkLabel lLabelEvet;
        private LinkLabel lLabelHayir;
        private LinkLabel lLabelEveet;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}