namespace PizzaParty
{
    partial class frmExtras
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
            this.chkWings = new System.Windows.Forms.CheckBox();
            this.chkStix = new System.Windows.Forms.CheckBox();
            this.chkChzStix = new System.Windows.Forms.CheckBox();
            this.chkDessert = new System.Windows.Forms.CheckBox();
            this.txtExtraOrder = new System.Windows.Forms.TextBox();
            this.txtExtraSubtotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearExtras = new System.Windows.Forms.Button();
            this.btnAcceptExtras = new System.Windows.Forms.Button();
            this.btnExtrasBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkWings
            // 
            this.chkWings.AutoSize = true;
            this.chkWings.Location = new System.Drawing.Point(67, 110);
            this.chkWings.Name = "chkWings";
            this.chkWings.Size = new System.Drawing.Size(117, 21);
            this.chkWings.TabIndex = 0;
            this.chkWings.Text = "Buffalo Wings";
            this.chkWings.UseVisualStyleBackColor = true;
            // 
            // chkStix
            // 
            this.chkStix.AutoSize = true;
            this.chkStix.Location = new System.Drawing.Point(68, 150);
            this.chkStix.Name = "chkStix";
            this.chkStix.Size = new System.Drawing.Size(109, 21);
            this.chkStix.TabIndex = 1;
            this.chkStix.Text = "Bread Sticks";
            this.chkStix.UseVisualStyleBackColor = true;
            this.chkStix.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkChzStix
            // 
            this.chkChzStix.AutoSize = true;
            this.chkChzStix.Location = new System.Drawing.Point(67, 186);
            this.chkChzStix.Name = "chkChzStix";
            this.chkChzStix.Size = new System.Drawing.Size(119, 21);
            this.chkChzStix.TabIndex = 2;
            this.chkChzStix.Text = "Cheese Sticks";
            this.chkChzStix.UseVisualStyleBackColor = true;
            // 
            // chkDessert
            // 
            this.chkDessert.AutoSize = true;
            this.chkDessert.Location = new System.Drawing.Point(68, 222);
            this.chkDessert.Name = "chkDessert";
            this.chkDessert.Size = new System.Drawing.Size(117, 21);
            this.chkDessert.TabIndex = 3;
            this.chkDessert.Text = "Dessert Pizza";
            this.chkDessert.UseVisualStyleBackColor = true;
            // 
            // txtExtraOrder
            // 
            this.txtExtraOrder.Enabled = false;
            this.txtExtraOrder.Location = new System.Drawing.Point(211, 87);
            this.txtExtraOrder.Multiline = true;
            this.txtExtraOrder.Name = "txtExtraOrder";
            this.txtExtraOrder.Size = new System.Drawing.Size(175, 178);
            this.txtExtraOrder.TabIndex = 4;
            // 
            // txtExtraSubtotal
            // 
            this.txtExtraSubtotal.Enabled = false;
            this.txtExtraSubtotal.Location = new System.Drawing.Point(286, 283);
            this.txtExtraSubtotal.Name = "txtExtraSubtotal";
            this.txtExtraSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtExtraSubtotal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Subtotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "$5 Add-on options:";
            // 
            // btnClearExtras
            // 
            this.btnClearExtras.Location = new System.Drawing.Point(51, 325);
            this.btnClearExtras.Name = "btnClearExtras";
            this.btnClearExtras.Size = new System.Drawing.Size(75, 23);
            this.btnClearExtras.TabIndex = 8;
            this.btnClearExtras.Text = "Clear Options";
            this.btnClearExtras.UseVisualStyleBackColor = true;
            // 
            // btnAcceptExtras
            // 
            this.btnAcceptExtras.Location = new System.Drawing.Point(190, 325);
            this.btnAcceptExtras.Name = "btnAcceptExtras";
            this.btnAcceptExtras.Size = new System.Drawing.Size(75, 23);
            this.btnAcceptExtras.TabIndex = 9;
            this.btnAcceptExtras.Text = "Accept";
            this.btnAcceptExtras.UseVisualStyleBackColor = true;
            // 
            // btnExtrasBack
            // 
            this.btnExtrasBack.Location = new System.Drawing.Point(333, 325);
            this.btnExtrasBack.Name = "btnExtrasBack";
            this.btnExtrasBack.Size = new System.Drawing.Size(75, 23);
            this.btnExtrasBack.TabIndex = 10;
            this.btnExtrasBack.Text = "Back";
            this.btnExtrasBack.UseVisualStyleBackColor = true;
            // 
            // frmExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 386);
            this.Controls.Add(this.btnExtrasBack);
            this.Controls.Add(this.btnAcceptExtras);
            this.Controls.Add(this.btnClearExtras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExtraSubtotal);
            this.Controls.Add(this.txtExtraOrder);
            this.Controls.Add(this.chkDessert);
            this.Controls.Add(this.chkChzStix);
            this.Controls.Add(this.chkStix);
            this.Controls.Add(this.chkWings);
            this.Name = "frmExtras";
            this.Text = "Extras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkWings;
        private System.Windows.Forms.CheckBox chkStix;
        private System.Windows.Forms.CheckBox chkChzStix;
        private System.Windows.Forms.CheckBox chkDessert;
        private System.Windows.Forms.TextBox txtExtraOrder;
        private System.Windows.Forms.TextBox txtExtraSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearExtras;
        private System.Windows.Forms.Button btnAcceptExtras;
        private System.Windows.Forms.Button btnExtrasBack;
    }
}