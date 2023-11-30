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
            label1 = new Label();
            lstMeals = new ListBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(270, 25);
            label1.TabIndex = 0;
            label1.Text = "Silmek istediğiniz öğünü seçin.";
            // 
            // lstMeals
            // 
            lstMeals.FormattingEnabled = true;
            lstMeals.ItemHeight = 15;
            lstMeals.Location = new Point(12, 49);
            lstMeals.Name = "lstMeals";
            lstMeals.Size = new Size(352, 319);
            lstMeals.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(243, 385);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 39);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // MealDeleteScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 436);
            Controls.Add(btnDelete);
            Controls.Add(lstMeals);
            Controls.Add(label1);
            Name = "MealDeleteScreen";
            Text = "MealDeleteScreen";
            Load += MealDeleteScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstMeals;
        private Button btnDelete;
    }
}