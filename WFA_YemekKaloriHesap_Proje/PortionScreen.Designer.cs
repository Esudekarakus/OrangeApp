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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 49);
            label1.Name = "label1";
            label1.Size = new Size(222, 25);
            label1.TabIndex = 0;
            label1.Text = "Porsiyon ne kadar olsun?";
            // 
            // cbPortions
            // 
            cbPortions.FormattingEnabled = true;
            cbPortions.Location = new Point(30, 100);
            cbPortions.Name = "cbPortions";
            cbPortions.Size = new Size(222, 23);
            cbPortions.TabIndex = 1;
            // 
            // btnOnayla
            // 
            btnOnayla.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnOnayla.Location = new Point(61, 147);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(138, 43);
            btnOnayla.TabIndex = 2;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = true;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // PortionScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 213);
            Controls.Add(btnOnayla);
            Controls.Add(cbPortions);
            Controls.Add(label1);
            Name = "PortionScreen";
            Text = "PortionScreen";
            Load += PortionScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbPortions;
        private Button btnOnayla;
    }
}