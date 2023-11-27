namespace YemekKalori.UI
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
            label1 = new Label();
            label2 = new Label();
            lLabelEvet = new LinkLabel();
            lLabelHayir = new LinkLabel();
            lLabelEveet = new LinkLabel();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Nova Cond", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(196, 99);
            label1.Name = "label1";
            label1.Size = new Size(331, 33);
            label1.TabIndex = 0;
            label1.Text = "Merhaba, aramıza hoşgeldin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Nova Cond", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(165, 189);
            label2.Name = "label2";
            label2.Size = new Size(406, 28);
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
            groupBox1.Location = new Point(134, 297);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(437, 125);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // StartingScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(721, 523);
            Controls.Add(groupBox1);
            Controls.Add(lLabelEvet);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartingScreen";
            Text = "StartingScreen";
            Load += StartingScreen_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}