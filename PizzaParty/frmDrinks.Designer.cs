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
            this.cboQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtDrinkOrder = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboQuantity
            // 
            this.cboQuantity.Location = new System.Drawing.Point(22, 51);
            this.cboQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboQuantity.Name = "cboQuantity";
            this.cboQuantity.Size = new System.Drawing.Size(32, 20);
            this.cboQuantity.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Location = new System.Drawing.Point(80, 51);
            this.cboSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(92, 21);
            this.cboSize.TabIndex = 4;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(192, 51);
            this.cboType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(92, 21);
            this.cboType.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 106);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Drink";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 140);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 172);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 8;
            this.button3.Text = "Finished";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtDrinkOrder
            // 
            this.txtDrinkOrder.Location = new System.Drawing.Point(20, 106);
            this.txtDrinkOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDrinkOrder.Multiline = true;
            this.txtDrinkOrder.Name = "txtDrinkOrder";
            this.txtDrinkOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDrinkOrder.Size = new System.Drawing.Size(173, 119);
            this.txtDrinkOrder.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(226, 206);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 19);
            this.button4.TabIndex = 10;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 257);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtDrinkOrder);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboQuantity);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDrinks";
            this.Text = "Drinks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cboQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtDrinkOrder;
        private System.Windows.Forms.Button button4;
    }
}