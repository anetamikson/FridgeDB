namespace FridgeDB
{
    partial class Form1
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
            this.Food = new System.Windows.Forms.Label();
            this.listFood = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listFoodNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Food
            // 
            this.Food.AutoSize = true;
            this.Food.Location = new System.Drawing.Point(55, 54);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(40, 17);
            this.Food.TabIndex = 0;
            this.Food.Text = "Food";
            // 
            // listFood
            // 
            this.listFood.FormattingEnabled = true;
            this.listFood.ItemHeight = 16;
            this.listFood.Location = new System.Drawing.Point(58, 113);
            this.listFood.Name = "listFood";
            this.listFood.Size = new System.Drawing.Size(120, 84);
            this.listFood.TabIndex = 1;
            this.listFood.SelectedIndexChanged += new System.EventHandler(this.listFood_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Food Names";
            // 
            // listFoodNames
            // 
            this.listFoodNames.FormattingEnabled = true;
            this.listFoodNames.ItemHeight = 16;
            this.listFoodNames.Location = new System.Drawing.Point(335, 113);
            this.listFoodNames.Name = "listFoodNames";
            this.listFoodNames.Size = new System.Drawing.Size(120, 84);
            this.listFoodNames.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listFoodNames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listFood);
            this.Controls.Add(this.Food);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Food;
        private System.Windows.Forms.ListBox listFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listFoodNames;
    }
}

