namespace PizzaParty
{
    partial class frmDrinks
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnAddDrinks = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type";
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "Choose a size",
            "12 oz can - $1",
            "20 oz - $2",
            "2 Liter - $3"});
            this.cboSize.Location = new System.Drawing.Point(21, 51);
            this.cboSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(92, 21);
            this.cboSize.TabIndex = 1;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Choose a type",
            "Coke",
            "Diet Coke",
            "Sprite",
            "Sprite Zero",
            "Orange Fanta",
            "A&W Root Beer"});
            this.cboType.Location = new System.Drawing.Point(133, 51);
            this.cboType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(92, 21);
            this.cboType.TabIndex = 2;
            // 
            // btnAddDrinks
            // 
            this.btnAddDrinks.Location = new System.Drawing.Point(41, 106);
            this.btnAddDrinks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddDrinks.Name = "btnAddDrinks";
            this.btnAddDrinks.Size = new System.Drawing.Size(56, 19);
            this.btnAddDrinks.TabIndex = 3;
            this.btnAddDrinks.Text = "Add Drink";
            this.btnAddDrinks.UseVisualStyleBackColor = true;
            this.btnAddDrinks.Click += new System.EventHandler(this.btnAddDrinks_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(143, 106);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 19);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 179);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddDrinks);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDrinks";
            this.Text = "Drinks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnAddDrinks;
        private System.Windows.Forms.Button btnBack;
    }
}