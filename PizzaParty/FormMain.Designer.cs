namespace PizzaParty
{
    partial class FormMain
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
            this.txtRuningTotal = new System.Windows.Forms.TextBox();
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnExtras = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubtotalMain = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRuningTotal
            // 
            this.txtRuningTotal.Enabled = false;
            this.txtRuningTotal.Location = new System.Drawing.Point(288, 32);
            this.txtRuningTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRuningTotal.Multiline = true;
            this.txtRuningTotal.Name = "txtRuningTotal";
            this.txtRuningTotal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRuningTotal.Size = new System.Drawing.Size(222, 262);
            this.txtRuningTotal.TabIndex = 0;
            // 
            // btnPizza
            // 
            this.btnPizza.Location = new System.Drawing.Point(76, 32);
            this.btnPizza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(122, 30);
            this.btnPizza.TabIndex = 0;
            this.btnPizza.Text = "Pizza Selector";
            this.btnPizza.UseVisualStyleBackColor = true;
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // btnDrinks
            // 
            this.btnDrinks.Location = new System.Drawing.Point(76, 92);
            this.btnDrinks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(122, 32);
            this.btnDrinks.TabIndex = 1;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = true;
            // 
            // btnExtras
            // 
            this.btnExtras.Location = new System.Drawing.Point(76, 152);
            this.btnExtras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExtras.Name = "btnExtras";
            this.btnExtras.Size = new System.Drawing.Size(122, 30);
            this.btnExtras.TabIndex = 2;
            this.btnExtras.Text = "Extras";
            this.btnExtras.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(28, 249);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(98, 27);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(150, 250);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 26);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(299, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order:";
            // 
            // txtSubtotalMain
            // 
            this.txtSubtotalMain.Enabled = false;
            this.txtSubtotalMain.Location = new System.Drawing.Point(433, 316);
            this.txtSubtotalMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSubtotalMain.Name = "txtSubtotalMain";
            this.txtSubtotalMain.Size = new System.Drawing.Size(76, 20);
            this.txtSubtotalMain.TabIndex = 7;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Enabled = false;
            this.lblSubtotal.Location = new System.Drawing.Point(374, 320);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 8;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(92, 307);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(88, 34);
            this.btnClearAll.TabIndex = 5;
            this.btnClearAll.Text = "Clear Order";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(548, 378);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtSubtotalMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnExtras);
            this.Controls.Add(this.btnDrinks);
            this.Controls.Add(this.btnPizza);
            this.Controls.Add(this.txtRuningTotal);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "Pizza Party!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRuningTotal;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnExtras;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubtotalMain;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnClearAll;
    }
}

