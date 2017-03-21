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
            this.btnClearExtras = new System.Windows.Forms.Button();
            this.btnAcceptExtras = new System.Windows.Forms.Button();
            this.btnExtrasBack = new System.Windows.Forms.Button();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.groupBoxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkWings
            // 
            this.chkWings.AutoSize = true;
            this.chkWings.Location = new System.Drawing.Point(30, 21);
            this.chkWings.Name = "chkWings";
            this.chkWings.Size = new System.Drawing.Size(117, 21);
            this.chkWings.TabIndex = 0;
            this.chkWings.Text = "Buffalo Wings";
            this.chkWings.UseVisualStyleBackColor = true;
            // 
            // chkStix
            // 
            this.chkStix.AutoSize = true;
            this.chkStix.Location = new System.Drawing.Point(31, 61);
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
            this.chkChzStix.Location = new System.Drawing.Point(30, 97);
            this.chkChzStix.Name = "chkChzStix";
            this.chkChzStix.Size = new System.Drawing.Size(119, 21);
            this.chkChzStix.TabIndex = 2;
            this.chkChzStix.Text = "Cheese Sticks";
            this.chkChzStix.UseVisualStyleBackColor = true;
            // 
            // chkDessert
            // 
            this.chkDessert.AutoSize = true;
            this.chkDessert.Location = new System.Drawing.Point(31, 133);
            this.chkDessert.Name = "chkDessert";
            this.chkDessert.Size = new System.Drawing.Size(117, 21);
            this.chkDessert.TabIndex = 3;
            this.chkDessert.Text = "Dessert Pizza";
            this.chkDessert.UseVisualStyleBackColor = true;
            // 
            // txtExtraOrder
            // 
            this.txtExtraOrder.Enabled = false;
            this.txtExtraOrder.Location = new System.Drawing.Point(221, 57);
            this.txtExtraOrder.Multiline = true;
            this.txtExtraOrder.Name = "txtExtraOrder";
            this.txtExtraOrder.Size = new System.Drawing.Size(175, 178);
            this.txtExtraOrder.TabIndex = 4;
            // 
            // txtExtraSubtotal
            // 
            this.txtExtraSubtotal.Enabled = false;
            this.txtExtraSubtotal.Location = new System.Drawing.Point(296, 253);
            this.txtExtraSubtotal.Name = "txtExtraSubtotal";
            this.txtExtraSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtExtraSubtotal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Subtotal:";
            // 
            // btnClearExtras
            // 
            this.btnClearExtras.Location = new System.Drawing.Point(61, 295);
            this.btnClearExtras.Name = "btnClearExtras";
            this.btnClearExtras.Size = new System.Drawing.Size(75, 23);
            this.btnClearExtras.TabIndex = 8;
            this.btnClearExtras.Text = "Clear Options";
            this.btnClearExtras.UseVisualStyleBackColor = true;
            this.btnClearExtras.Click += new System.EventHandler(this.btnClearExtras_Click);
            // 
            // btnAcceptExtras
            // 
            this.btnAcceptExtras.Location = new System.Drawing.Point(186, 295);
            this.btnAcceptExtras.Name = "btnAcceptExtras";
            this.btnAcceptExtras.Size = new System.Drawing.Size(75, 23);
            this.btnAcceptExtras.TabIndex = 9;
            this.btnAcceptExtras.Text = "Accept";
            this.btnAcceptExtras.UseVisualStyleBackColor = true;
            this.btnAcceptExtras.Click += new System.EventHandler(this.btnAcceptExtras_Click);
            // 
            // btnExtrasBack
            // 
            this.btnExtrasBack.Location = new System.Drawing.Point(308, 295);
            this.btnExtrasBack.Name = "btnExtrasBack";
            this.btnExtrasBack.Size = new System.Drawing.Size(75, 23);
            this.btnExtrasBack.TabIndex = 10;
            this.btnExtrasBack.Text = "Back";
            this.btnExtrasBack.UseVisualStyleBackColor = true;
            this.btnExtrasBack.Click += new System.EventHandler(this.btnExtrasBack_Click);
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.chkDessert);
            this.groupBoxAdd.Controls.Add(this.chkChzStix);
            this.groupBoxAdd.Controls.Add(this.chkStix);
            this.groupBoxAdd.Controls.Add(this.chkWings);
            this.groupBoxAdd.Location = new System.Drawing.Point(47, 59);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(155, 175);
            this.groupBoxAdd.TabIndex = 11;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "$5 Add-On Options";
            // 
            // frmExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 386);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.btnExtrasBack);
            this.Controls.Add(this.btnAcceptExtras);
            this.Controls.Add(this.btnClearExtras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExtraSubtotal);
            this.Controls.Add(this.txtExtraOrder);
            this.Name = "frmExtras";
            this.Text = "Extras";
            this.Load += new System.EventHandler(this.frmExtras_Load);
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
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
        private System.Windows.Forms.Button btnClearExtras;
        private System.Windows.Forms.Button btnAcceptExtras;
        private System.Windows.Forms.Button btnExtrasBack;
        private System.Windows.Forms.GroupBox groupBoxAdd;
    }
}