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
            this.chkWings.Location = new System.Drawing.Point(22, 17);
            this.chkWings.Margin = new System.Windows.Forms.Padding(2);
            this.chkWings.Name = "chkWings";
            this.chkWings.Size = new System.Drawing.Size(92, 17);
            this.chkWings.TabIndex = 0;
            this.chkWings.Text = "Buffalo Wings";
            this.chkWings.UseVisualStyleBackColor = true;
            this.chkWings.CheckedChanged += new System.EventHandler(this.chk_CheckChanged);
            // 
            // chkStix
            // 
            this.chkStix.AutoSize = true;
            this.chkStix.Location = new System.Drawing.Point(23, 50);
            this.chkStix.Margin = new System.Windows.Forms.Padding(2);
            this.chkStix.Name = "chkStix";
            this.chkStix.Size = new System.Drawing.Size(86, 17);
            this.chkStix.TabIndex = 1;
            this.chkStix.Text = "Bread Sticks";
            this.chkStix.UseVisualStyleBackColor = true;
            this.chkStix.CheckedChanged += new System.EventHandler(this.chk_CheckChanged);
            // 
            // chkChzStix
            // 
            this.chkChzStix.AutoSize = true;
            this.chkChzStix.Location = new System.Drawing.Point(22, 79);
            this.chkChzStix.Margin = new System.Windows.Forms.Padding(2);
            this.chkChzStix.Name = "chkChzStix";
            this.chkChzStix.Size = new System.Drawing.Size(94, 17);
            this.chkChzStix.TabIndex = 2;
            this.chkChzStix.Text = "Cheese Sticks";
            this.chkChzStix.UseVisualStyleBackColor = true;
            this.chkChzStix.CheckedChanged += new System.EventHandler(this.chk_CheckChanged);
            // 
            // chkDessert
            // 
            this.chkDessert.AutoSize = true;
            this.chkDessert.Location = new System.Drawing.Point(23, 108);
            this.chkDessert.Margin = new System.Windows.Forms.Padding(2);
            this.chkDessert.Name = "chkDessert";
            this.chkDessert.Size = new System.Drawing.Size(90, 17);
            this.chkDessert.TabIndex = 3;
            this.chkDessert.Text = "Dessert Pizza";
            this.chkDessert.UseVisualStyleBackColor = true;
            this.chkDessert.CheckedChanged += new System.EventHandler(this.chk_CheckChanged);
            // 
            // txtExtraOrder
            // 
            this.txtExtraOrder.BackColor = System.Drawing.Color.White;
            this.txtExtraOrder.Location = new System.Drawing.Point(166, 46);
            this.txtExtraOrder.Margin = new System.Windows.Forms.Padding(2);
            this.txtExtraOrder.Multiline = true;
            this.txtExtraOrder.Name = "txtExtraOrder";
            this.txtExtraOrder.ReadOnly = true;
            this.txtExtraOrder.Size = new System.Drawing.Size(132, 145);
            this.txtExtraOrder.TabIndex = 4;
            // 
            // txtExtraSubtotal
            // 
            this.txtExtraSubtotal.BackColor = System.Drawing.Color.White;
            this.txtExtraSubtotal.Location = new System.Drawing.Point(222, 206);
            this.txtExtraSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtExtraSubtotal.Name = "txtExtraSubtotal";
            this.txtExtraSubtotal.ReadOnly = true;
            this.txtExtraSubtotal.Size = new System.Drawing.Size(76, 20);
            this.txtExtraSubtotal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Subtotal:";
            // 
            // btnClearExtras
            // 
            this.btnClearExtras.Location = new System.Drawing.Point(46, 240);
            this.btnClearExtras.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearExtras.Name = "btnClearExtras";
            this.btnClearExtras.Size = new System.Drawing.Size(56, 19);
            this.btnClearExtras.TabIndex = 8;
            this.btnClearExtras.Text = "Clear Options";
            this.btnClearExtras.UseVisualStyleBackColor = true;
            this.btnClearExtras.Click += new System.EventHandler(this.btnClearExtras_Click);
            // 
            // btnAcceptExtras
            // 
            this.btnAcceptExtras.Location = new System.Drawing.Point(140, 240);
            this.btnAcceptExtras.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcceptExtras.Name = "btnAcceptExtras";
            this.btnAcceptExtras.Size = new System.Drawing.Size(56, 19);
            this.btnAcceptExtras.TabIndex = 9;
            this.btnAcceptExtras.Text = "Accept";
            this.btnAcceptExtras.UseVisualStyleBackColor = true;
            this.btnAcceptExtras.Click += new System.EventHandler(this.btnAcceptExtras_Click);
            // 
            // btnExtrasBack
            // 
            this.btnExtrasBack.Location = new System.Drawing.Point(231, 240);
            this.btnExtrasBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnExtrasBack.Name = "btnExtrasBack";
            this.btnExtrasBack.Size = new System.Drawing.Size(56, 19);
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
            this.groupBoxAdd.Location = new System.Drawing.Point(35, 48);
            this.groupBoxAdd.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAdd.Size = new System.Drawing.Size(116, 142);
            this.groupBoxAdd.TabIndex = 11;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "$5 Add-On Options";
            // 
            // frmExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 314);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.btnExtrasBack);
            this.Controls.Add(this.btnAcceptExtras);
            this.Controls.Add(this.btnClearExtras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExtraSubtotal);
            this.Controls.Add(this.txtExtraOrder);
            this.Margin = new System.Windows.Forms.Padding(2);
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