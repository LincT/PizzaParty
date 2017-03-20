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
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnAddDrinks = new System.Windows.Forms.Button();
            this.btnClearDrinks = new System.Windows.Forms.Button();
            this.btnFinished = new System.Windows.Forms.Button();
            this.txtDrinkOrder = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(29, 63);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(56, 22);
            this.txtQuantity.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "Choose a size",
            "12 oz can - $1",
            "20 oz - $2",
            "2 Liter - $3"});
            this.cboSize.Location = new System.Drawing.Point(107, 63);
            this.cboSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(121, 24);
            this.cboSize.TabIndex = 1;
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.cboSize_SelectedIndexChanged);
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
            this.cboType.Location = new System.Drawing.Point(256, 63);
            this.cboType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 24);
            this.cboType.TabIndex = 2;
            // 
            // btnAddDrinks
            // 
            this.btnAddDrinks.Location = new System.Drawing.Point(301, 130);
            this.btnAddDrinks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDrinks.Name = "btnAddDrinks";
            this.btnAddDrinks.Size = new System.Drawing.Size(75, 23);
            this.btnAddDrinks.TabIndex = 3;
            this.btnAddDrinks.Text = "Add Drink";
            this.btnAddDrinks.UseVisualStyleBackColor = true;
            // 
            // btnClearDrinks
            // 
            this.btnClearDrinks.Location = new System.Drawing.Point(301, 172);
            this.btnClearDrinks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearDrinks.Name = "btnClearDrinks";
            this.btnClearDrinks.Size = new System.Drawing.Size(75, 23);
            this.btnClearDrinks.TabIndex = 4;
            this.btnClearDrinks.Text = "Clear";
            this.btnClearDrinks.UseVisualStyleBackColor = true;
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(301, 212);
            this.btnFinished.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(75, 23);
            this.btnFinished.TabIndex = 5;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtDrinkOrder
            // 
            this.txtDrinkOrder.Enabled = false;
            this.txtDrinkOrder.Location = new System.Drawing.Point(27, 130);
            this.txtDrinkOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDrinkOrder.Multiline = true;
            this.txtDrinkOrder.Name = "txtDrinkOrder";
            this.txtDrinkOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDrinkOrder.Size = new System.Drawing.Size(229, 146);
            this.txtDrinkOrder.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(301, 254);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // frmDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 316);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtDrinkOrder);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.btnClearDrinks);
            this.Controls.Add(this.btnAddDrinks);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantity);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDrinks";
            this.Text = "Drinks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnAddDrinks;
        private System.Windows.Forms.Button btnClearDrinks;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.TextBox txtDrinkOrder;
        private System.Windows.Forms.Button btnBack;
    }
}