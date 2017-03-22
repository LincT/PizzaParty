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
            this.txtRunningTotal = new System.Windows.Forms.TextBox();
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnExtras = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCancelAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubtotalMain = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRunningTotal
            // 
            this.txtRunningTotal.BackColor = System.Drawing.Color.White;
            this.txtRunningTotal.Location = new System.Drawing.Point(288, 32);
            this.txtRunningTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtRunningTotal.Multiline = true;
            this.txtRunningTotal.Name = "txtRunningTotal";
            this.txtRunningTotal.ReadOnly = true;
            this.txtRunningTotal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRunningTotal.Size = new System.Drawing.Size(222, 262);
            this.txtRunningTotal.TabIndex = 0;
            // 
            // btnPizza
            // 
            this.btnPizza.Location = new System.Drawing.Point(76, 32);
            this.btnPizza.Margin = new System.Windows.Forms.Padding(2);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(122, 30);
            this.btnPizza.TabIndex = 0;
            this.btnPizza.Text = "Pizza Selector";
            this.btnPizza.UseVisualStyleBackColor = true;
            this.btnPizza.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnDrinks
            // 
            this.btnDrinks.Location = new System.Drawing.Point(76, 92);
            this.btnDrinks.Margin = new System.Windows.Forms.Padding(2);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(122, 32);
            this.btnDrinks.TabIndex = 1;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = true;
            this.btnDrinks.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnExtras
            // 
            this.btnExtras.Location = new System.Drawing.Point(76, 152);
            this.btnExtras.Margin = new System.Windows.Forms.Padding(2);
            this.btnExtras.Name = "btnExtras";
            this.btnExtras.Size = new System.Drawing.Size(122, 30);
            this.btnExtras.TabIndex = 2;
            this.btnExtras.Text = "Extras";
            this.btnExtras.UseVisualStyleBackColor = true;
            this.btnExtras.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(28, 249);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(98, 27);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCancelAll
            // 
            this.btnCancelAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelAll.Location = new System.Drawing.Point(150, 250);
            this.btnCancelAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelAll.Name = "btnCancelAll";
            this.btnCancelAll.Size = new System.Drawing.Size(98, 26);
            this.btnCancelAll.TabIndex = 4;
            this.btnCancelAll.Text = "Cancel";
            this.btnCancelAll.UseVisualStyleBackColor = true;
            this.btnCancelAll.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order:";
            // 
            // txtSubtotalMain
            // 
            this.txtSubtotalMain.BackColor = System.Drawing.Color.White;
            this.txtSubtotalMain.Location = new System.Drawing.Point(433, 316);
            this.txtSubtotalMain.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubtotalMain.Name = "txtSubtotalMain";
            this.txtSubtotalMain.ReadOnly = true;
            this.txtSubtotalMain.Size = new System.Drawing.Size(76, 20);
            this.txtSubtotalMain.TabIndex = 7;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
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
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(88, 34);
            this.btnClearAll.TabIndex = 5;
            this.btnClearAll.Text = "Clear Order";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelAll;
            this.ClientSize = new System.Drawing.Size(548, 378);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtSubtotalMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelAll);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnExtras);
            this.Controls.Add(this.btnDrinks);
            this.Controls.Add(this.btnPizza);
            this.Controls.Add(this.txtRunningTotal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Pizza Party!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRunningTotal;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnExtras;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCancelAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubtotalMain;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnClearAll;
    }
}

