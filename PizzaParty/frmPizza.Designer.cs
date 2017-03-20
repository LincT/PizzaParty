namespace PizzaParty
{
    partial class frmPizza
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
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.rdoSize14 = new System.Windows.Forms.RadioButton();
            this.rdoSize12 = new System.Windows.Forms.RadioButton();
            this.rdoSize10 = new System.Windows.Forms.RadioButton();
            this.rdoSize8 = new System.Windows.Forms.RadioButton();
            this.groupBoxCrust = new System.Windows.Forms.GroupBox();
            this.rdoCrustDeepDish = new System.Windows.Forms.RadioButton();
            this.rdoCrustHandTossed = new System.Windows.Forms.RadioButton();
            this.rdoCrustStuffed = new System.Windows.Forms.RadioButton();
            this.rdoCrustThin = new System.Windows.Forms.RadioButton();
            this.groupBoxSauce = new System.Windows.Forms.GroupBox();
            this.rdoSauceNone = new System.Windows.Forms.RadioButton();
            this.rdoSauceSpecial = new System.Windows.Forms.RadioButton();
            this.rdoSauceAlfredo = new System.Windows.Forms.RadioButton();
            this.rdoSauceRed = new System.Windows.Forms.RadioButton();
            this.groupBoxToppings = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.chkCheeseOnly = new System.Windows.Forms.CheckBox();
            this.chkOlive = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkShroom = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkPeppers = new System.Windows.Forms.CheckBox();
            this.chkSpin = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkBurger = new System.Windows.Forms.CheckBox();
            this.chkChix = new System.Windows.Forms.CheckBox();
            this.chkSaus = new System.Windows.Forms.CheckBox();
            this.chkPep = new System.Windows.Forms.CheckBox();
            this.lblOrderView = new System.Windows.Forms.Label();
            this.groupBoxSize.SuspendLayout();
            this.groupBoxCrust.SuspendLayout();
            this.groupBoxSauce.SuspendLayout();
            this.groupBoxToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Controls.Add(this.rdoSize14);
            this.groupBoxSize.Controls.Add(this.rdoSize12);
            this.groupBoxSize.Controls.Add(this.rdoSize10);
            this.groupBoxSize.Controls.Add(this.rdoSize8);
            this.groupBoxSize.Location = new System.Drawing.Point(21, 10);
            this.groupBoxSize.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSize.Size = new System.Drawing.Size(364, 40);
            this.groupBoxSize.TabIndex = 0;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Size";
            // 
            // rdoSize14
            // 
            this.rdoSize14.AutoSize = true;
            this.rdoSize14.Location = new System.Drawing.Point(187, 17);
            this.rdoSize14.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSize14.Name = "rdoSize14";
            this.rdoSize14.Size = new System.Drawing.Size(63, 17);
            this.rdoSize14.TabIndex = 3;
            this.rdoSize14.TabStop = true;
            this.rdoSize14.Text = "14\"-$16";
            this.rdoSize14.UseVisualStyleBackColor = true;
            this.rdoSize14.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdoSize12
            // 
            this.rdoSize12.AutoSize = true;
            this.rdoSize12.Location = new System.Drawing.Point(128, 17);
            this.rdoSize12.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSize12.Name = "rdoSize12";
            this.rdoSize12.Size = new System.Drawing.Size(63, 17);
            this.rdoSize12.TabIndex = 2;
            this.rdoSize12.TabStop = true;
            this.rdoSize12.Text = "12\"-$14";
            this.rdoSize12.UseVisualStyleBackColor = true;
            this.rdoSize12.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdoSize10
            // 
            this.rdoSize10.AutoSize = true;
            this.rdoSize10.Location = new System.Drawing.Point(70, 18);
            this.rdoSize10.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSize10.Name = "rdoSize10";
            this.rdoSize10.Size = new System.Drawing.Size(63, 17);
            this.rdoSize10.TabIndex = 1;
            this.rdoSize10.TabStop = true;
            this.rdoSize10.Text = "10\"-$12";
            this.rdoSize10.UseVisualStyleBackColor = true;
            this.rdoSize10.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdoSize8
            // 
            this.rdoSize8.AutoSize = true;
            this.rdoSize8.Location = new System.Drawing.Point(15, 18);
            this.rdoSize8.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSize8.Name = "rdoSize8";
            this.rdoSize8.Size = new System.Drawing.Size(57, 17);
            this.rdoSize8.TabIndex = 0;
            this.rdoSize8.TabStop = true;
            this.rdoSize8.Text = "8\"-$10";
            this.rdoSize8.UseVisualStyleBackColor = true;
            this.rdoSize8.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBoxCrust
            // 
            this.groupBoxCrust.Controls.Add(this.rdoCrustDeepDish);
            this.groupBoxCrust.Controls.Add(this.rdoCrustHandTossed);
            this.groupBoxCrust.Controls.Add(this.rdoCrustStuffed);
            this.groupBoxCrust.Controls.Add(this.rdoCrustThin);
            this.groupBoxCrust.Location = new System.Drawing.Point(21, 54);
            this.groupBoxCrust.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxCrust.Name = "groupBoxCrust";
            this.groupBoxCrust.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxCrust.Size = new System.Drawing.Size(364, 41);
            this.groupBoxCrust.TabIndex = 1;
            this.groupBoxCrust.TabStop = false;
            this.groupBoxCrust.Text = "Crust";
            // 
            // rdoCrustDeepDish
            // 
            this.rdoCrustDeepDish.AutoSize = true;
            this.rdoCrustDeepDish.Location = new System.Drawing.Point(241, 17);
            this.rdoCrustDeepDish.Margin = new System.Windows.Forms.Padding(2);
            this.rdoCrustDeepDish.Name = "rdoCrustDeepDish";
            this.rdoCrustDeepDish.Size = new System.Drawing.Size(117, 17);
            this.rdoCrustDeepDish.TabIndex = 3;
            this.rdoCrustDeepDish.TabStop = true;
            this.rdoCrustDeepDish.Text = "Deep Dish (+$1.50)";
            this.rdoCrustDeepDish.UseVisualStyleBackColor = true;
            this.rdoCrustDeepDish.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdoCrustHandTossed
            // 
            this.rdoCrustHandTossed.AutoSize = true;
            this.rdoCrustHandTossed.Location = new System.Drawing.Point(62, 17);
            this.rdoCrustHandTossed.Margin = new System.Windows.Forms.Padding(2);
            this.rdoCrustHandTossed.Name = "rdoCrustHandTossed";
            this.rdoCrustHandTossed.Size = new System.Drawing.Size(89, 17);
            this.rdoCrustHandTossed.TabIndex = 1;
            this.rdoCrustHandTossed.TabStop = true;
            this.rdoCrustHandTossed.Text = "Hand Tossed";
            this.rdoCrustHandTossed.UseVisualStyleBackColor = true;
            this.rdoCrustHandTossed.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdoCrustStuffed
            // 
            this.rdoCrustStuffed.AutoSize = true;
            this.rdoCrustStuffed.Location = new System.Drawing.Point(152, 17);
            this.rdoCrustStuffed.Margin = new System.Windows.Forms.Padding(2);
            this.rdoCrustStuffed.Name = "rdoCrustStuffed";
            this.rdoCrustStuffed.Size = new System.Drawing.Size(86, 17);
            this.rdoCrustStuffed.TabIndex = 2;
            this.rdoCrustStuffed.TabStop = true;
            this.rdoCrustStuffed.Text = "Stuffed (+$2)";
            this.rdoCrustStuffed.UseVisualStyleBackColor = true;
            this.rdoCrustStuffed.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdoCrustThin
            // 
            this.rdoCrustThin.AutoSize = true;
            this.rdoCrustThin.Location = new System.Drawing.Point(15, 17);
            this.rdoCrustThin.Margin = new System.Windows.Forms.Padding(2);
            this.rdoCrustThin.Name = "rdoCrustThin";
            this.rdoCrustThin.Size = new System.Drawing.Size(46, 17);
            this.rdoCrustThin.TabIndex = 0;
            this.rdoCrustThin.TabStop = true;
            this.rdoCrustThin.Text = "Thin";
            this.rdoCrustThin.UseVisualStyleBackColor = true;
            this.rdoCrustThin.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBoxSauce
            // 
            this.groupBoxSauce.Controls.Add(this.rdoSauceNone);
            this.groupBoxSauce.Controls.Add(this.rdoSauceSpecial);
            this.groupBoxSauce.Controls.Add(this.rdoSauceAlfredo);
            this.groupBoxSauce.Controls.Add(this.rdoSauceRed);
            this.groupBoxSauce.Location = new System.Drawing.Point(21, 105);
            this.groupBoxSauce.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSauce.Name = "groupBoxSauce";
            this.groupBoxSauce.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSauce.Size = new System.Drawing.Size(364, 50);
            this.groupBoxSauce.TabIndex = 2;
            this.groupBoxSauce.TabStop = false;
            this.groupBoxSauce.Text = "Sauce";
            // 
            // rdoSauceNone
            // 
            this.rdoSauceNone.AutoSize = true;
            this.rdoSauceNone.Location = new System.Drawing.Point(281, 24);
            this.rdoSauceNone.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSauceNone.Name = "rdoSauceNone";
            this.rdoSauceNone.Size = new System.Drawing.Size(73, 17);
            this.rdoSauceNone.TabIndex = 3;
            this.rdoSauceNone.TabStop = true;
            this.rdoSauceNone.Text = "No Sauce";
            this.rdoSauceNone.UseVisualStyleBackColor = true;
            this.rdoSauceNone.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdoSauceSpecial
            // 
            this.rdoSauceSpecial.AutoSize = true;
            this.rdoSauceSpecial.Location = new System.Drawing.Point(187, 24);
            this.rdoSauceSpecial.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSauceSpecial.Name = "rdoSauceSpecial";
            this.rdoSauceSpecial.Size = new System.Drawing.Size(94, 17);
            this.rdoSauceSpecial.TabIndex = 2;
            this.rdoSauceSpecial.TabStop = true;
            this.rdoSauceSpecial.Text = "House Special";
            this.rdoSauceSpecial.UseVisualStyleBackColor = true;
            this.rdoSauceSpecial.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdoSauceAlfredo
            // 
            this.rdoSauceAlfredo.AutoSize = true;
            this.rdoSauceAlfredo.Location = new System.Drawing.Point(94, 24);
            this.rdoSauceAlfredo.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSauceAlfredo.Name = "rdoSauceAlfredo";
            this.rdoSauceAlfredo.Size = new System.Drawing.Size(92, 17);
            this.rdoSauceAlfredo.TabIndex = 1;
            this.rdoSauceAlfredo.TabStop = true;
            this.rdoSauceAlfredo.Text = "Alfredo Sauce";
            this.rdoSauceAlfredo.UseVisualStyleBackColor = true;
            this.rdoSauceAlfredo.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdoSauceRed
            // 
            this.rdoSauceRed.AutoSize = true;
            this.rdoSauceRed.Location = new System.Drawing.Point(15, 24);
            this.rdoSauceRed.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSauceRed.Name = "rdoSauceRed";
            this.rdoSauceRed.Size = new System.Drawing.Size(79, 17);
            this.rdoSauceRed.TabIndex = 0;
            this.rdoSauceRed.TabStop = true;
            this.rdoSauceRed.Text = "Red Sauce";
            this.rdoSauceRed.UseVisualStyleBackColor = true;
            this.rdoSauceRed.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBoxToppings
            // 
            this.groupBoxToppings.Controls.Add(this.chkCheeseOnly);
            this.groupBoxToppings.Controls.Add(this.chkOlive);
            this.groupBoxToppings.Controls.Add(this.chkBacon);
            this.groupBoxToppings.Controls.Add(this.chkPineapple);
            this.groupBoxToppings.Controls.Add(this.chkShroom);
            this.groupBoxToppings.Controls.Add(this.chkOnion);
            this.groupBoxToppings.Controls.Add(this.chkPeppers);
            this.groupBoxToppings.Controls.Add(this.chkSpin);
            this.groupBoxToppings.Controls.Add(this.chkHam);
            this.groupBoxToppings.Controls.Add(this.chkBurger);
            this.groupBoxToppings.Controls.Add(this.chkChix);
            this.groupBoxToppings.Controls.Add(this.chkSaus);
            this.groupBoxToppings.Controls.Add(this.chkPep);
            this.groupBoxToppings.Location = new System.Drawing.Point(22, 169);
            this.groupBoxToppings.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxToppings.Name = "groupBoxToppings";
            this.groupBoxToppings.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxToppings.Size = new System.Drawing.Size(362, 219);
            this.groupBoxToppings.TabIndex = 3;
            this.groupBoxToppings.TabStop = false;
            this.groupBoxToppings.Text = "Toppings";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(36, 408);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 24);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear Options";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(158, 408);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(92, 24);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(278, 408);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 24);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Back";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Order:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 403);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(550, 401);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(102, 20);
            this.txtSubtotal.TabIndex = 99;
            // 
            // chkCheeseOnly
            // 
            this.chkCheeseOnly.AutoSize = true;
            this.chkCheeseOnly.Location = new System.Drawing.Point(141, 173);
            this.chkCheeseOnly.Margin = new System.Windows.Forms.Padding(2);
            this.chkCheeseOnly.Name = "chkCheeseOnly";
            this.chkCheeseOnly.Size = new System.Drawing.Size(84, 17);
            this.chkCheeseOnly.TabIndex = 25;
            this.chkCheeseOnly.TabStop = false;
            this.chkCheeseOnly.Text = "Just Cheese";
            this.chkCheeseOnly.UseVisualStyleBackColor = true;
            this.chkCheeseOnly.CheckedChanged += new System.EventHandler(this.chk_CheckChanged);
            // 
            // chkOlive
            // 
            this.chkOlive.AutoSize = true;
            this.chkOlive.Location = new System.Drawing.Point(221, 116);
            this.chkOlive.Margin = new System.Windows.Forms.Padding(2);
            this.chkOlive.Name = "chkOlive";
            this.chkOlive.Size = new System.Drawing.Size(85, 17);
            this.chkOlive.TabIndex = 24;
            this.chkOlive.TabStop = false;
            this.chkOlive.Text = "Black Olives";
            this.chkOlive.UseVisualStyleBackColor = true;
            this.chkOlive.CheckedChanged += new System.EventHandler(this.chk_CheckChanged);
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(56, 116);
            this.chkBacon.Margin = new System.Windows.Forms.Padding(2);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(57, 17);
            this.chkBacon.TabIndex = 23;
            this.chkBacon.TabStop = false;
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            this.chkBacon.CheckedChanged += new System.EventHandler(this.chk_CheckChanged);
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Location = new System.Drawing.Point(221, 138);
            this.chkPineapple.Margin = new System.Windows.Forms.Padding(2);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(73, 17);
            this.chkPineapple.TabIndex = 22;
            this.chkPineapple.TabStop = false;
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            this.chkPineapple.CheckedChanged += new System.EventHandler(this.chk_CheckChanged);
            // 
            // chkShroom
            // 
            this.chkShroom.AutoSize = true;
            this.chkShroom.Location = new System.Drawing.Point(221, 94);
            this.chkShroom.Margin = new System.Windows.Forms.Padding(2);
            this.chkShroom.Name = "chkShroom";
            this.chkShroom.Size = new System.Drawing.Size(75, 17);
            this.chkShroom.TabIndex = 21;
            this.chkShroom.TabStop = false;
            this.chkShroom.Text = "Mushroom";
            this.chkShroom.UseVisualStyleBackColor = true;
            this.chkShroom.CheckedChanged += new System.EventHandler(this.chk_CheckChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(221, 72);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(2);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(54, 17);
            this.chkOnion.TabIndex = 20;
            this.chkOnion.TabStop = false;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chk_CheckChanged);
            // 
            // chkPeppers
            // 
            this.chkPeppers.AutoSize = true;
            this.chkPeppers.Location = new System.Drawing.Point(221, 50);
            this.chkPeppers.Margin = new System.Windows.Forms.Padding(2);
            this.chkPeppers.Name = "chkPeppers";
            this.chkPeppers.Size = new System.Drawing.Size(65, 17);
            this.chkPeppers.TabIndex = 19;
            this.chkPeppers.TabStop = false;
            this.chkPeppers.Text = "Peppers";
            this.chkPeppers.UseVisualStyleBackColor = true;
            this.chkPeppers.CheckedChanged += new System.EventHandler(this.chk_CheckChanged);
            // 
            // chkSpin
            // 
            this.chkSpin.AutoSize = true;
            this.chkSpin.Location = new System.Drawing.Point(221, 28);
            this.chkSpin.Margin = new System.Windows.Forms.Padding(2);
            this.chkSpin.Name = "chkSpin";
            this.chkSpin.Size = new System.Drawing.Size(65, 17);
            this.chkSpin.TabIndex = 18;
            this.chkSpin.TabStop = false;
            this.chkSpin.Text = "Spinach";
            this.chkSpin.UseVisualStyleBackColor = true;
            this.chkSpin.CheckedChanged += new System.EventHandler(this.chk_CheckChanged);
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Location = new System.Drawing.Point(56, 138);
            this.chkHam.Margin = new System.Windows.Forms.Padding(2);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(48, 17);
            this.chkHam.TabIndex = 17;
            this.chkHam.TabStop = false;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            this.chkHam.CheckedChanged += new System.EventHandler(this.chk_CheckChanged);
            // 
            // chkBurger
            // 
            this.chkBurger.AutoSize = true;
            this.chkBurger.Location = new System.Drawing.Point(56, 94);
            this.chkBurger.Margin = new System.Windows.Forms.Padding(2);
            this.chkBurger.Name = "chkBurger";
            this.chkBurger.Size = new System.Drawing.Size(78, 17);
            this.chkBurger.TabIndex = 16;
            this.chkBurger.TabStop = false;
            this.chkBurger.Text = "Hamburger";
            this.chkBurger.UseVisualStyleBackColor = true;
            this.chkBurger.CheckedChanged += new System.EventHandler(this.chk_CheckChanged);
            // 
            // chkChix
            // 
            this.chkChix.AutoSize = true;
            this.chkChix.Location = new System.Drawing.Point(56, 72);
            this.chkChix.Margin = new System.Windows.Forms.Padding(2);
            this.chkChix.Name = "chkChix";
            this.chkChix.Size = new System.Drawing.Size(65, 17);
            this.chkChix.TabIndex = 15;
            this.chkChix.TabStop = false;
            this.chkChix.Text = "Chicken";
            this.chkChix.UseVisualStyleBackColor = true;
            this.chkChix.CheckedChanged += new System.EventHandler(this.chk_CheckChanged);
            // 
            // chkSaus
            // 
            this.chkSaus.AutoSize = true;
            this.chkSaus.Location = new System.Drawing.Point(56, 50);
            this.chkSaus.Margin = new System.Windows.Forms.Padding(2);
            this.chkSaus.Name = "chkSaus";
            this.chkSaus.Size = new System.Drawing.Size(68, 17);
            this.chkSaus.TabIndex = 14;
            this.chkSaus.TabStop = false;
            this.chkSaus.Text = "Sausage";
            this.chkSaus.UseVisualStyleBackColor = true;
            this.chkSaus.CheckedChanged += new System.EventHandler(this.chk_CheckChanged);
            // 
            // chkPep
            // 
            this.chkPep.AutoSize = true;
            this.chkPep.Location = new System.Drawing.Point(56, 28);
            this.chkPep.Margin = new System.Windows.Forms.Padding(2);
            this.chkPep.Name = "chkPep";
            this.chkPep.Size = new System.Drawing.Size(74, 17);
            this.chkPep.TabIndex = 13;
            this.chkPep.TabStop = false;
            this.chkPep.Text = "Pepperoni";
            this.chkPep.UseVisualStyleBackColor = true;
            this.chkPep.CheckedChanged += new System.EventHandler(this.chk_CheckChanged);
            // 
            // lblOrderView
            // 
            this.lblOrderView.BackColor = System.Drawing.Color.White;
            this.lblOrderView.Location = new System.Drawing.Point(402, 54);
            this.lblOrderView.Name = "lblOrderView";
            this.lblOrderView.Size = new System.Drawing.Size(280, 334);
            this.lblOrderView.TabIndex = 100;
            // 
            // frmPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 448);
            this.Controls.Add(this.lblOrderView);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBoxToppings);
            this.Controls.Add(this.groupBoxSauce);
            this.Controls.Add(this.groupBoxCrust);
            this.Controls.Add(this.groupBoxSize);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPizza";
            this.Text = "Pizza Selector";
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            this.groupBoxCrust.ResumeLayout(false);
            this.groupBoxCrust.PerformLayout();
            this.groupBoxSauce.ResumeLayout(false);
            this.groupBoxSauce.PerformLayout();
            this.groupBoxToppings.ResumeLayout(false);
            this.groupBoxToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.RadioButton rdoSize14;
        private System.Windows.Forms.RadioButton rdoSize12;
        private System.Windows.Forms.RadioButton rdoSize10;
        private System.Windows.Forms.RadioButton rdoSize8;
        private System.Windows.Forms.GroupBox groupBoxCrust;
        private System.Windows.Forms.RadioButton rdoCrustHandTossed;
        private System.Windows.Forms.RadioButton rdoCrustThin;
        private System.Windows.Forms.RadioButton rdoCrustStuffed;
        private System.Windows.Forms.RadioButton rdoCrustDeepDish;
        private System.Windows.Forms.GroupBox groupBoxSauce;
        private System.Windows.Forms.RadioButton rdoSauceNone;
        private System.Windows.Forms.RadioButton rdoSauceSpecial;
        private System.Windows.Forms.RadioButton rdoSauceAlfredo;
        private System.Windows.Forms.RadioButton rdoSauceRed;
        private System.Windows.Forms.GroupBox groupBoxToppings;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.CheckBox chkCheeseOnly;
        private System.Windows.Forms.CheckBox chkOlive;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.CheckBox chkShroom;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkPeppers;
        private System.Windows.Forms.CheckBox chkSpin;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkBurger;
        private System.Windows.Forms.CheckBox chkChix;
        private System.Windows.Forms.CheckBox chkSaus;
        private System.Windows.Forms.CheckBox chkPep;
        private System.Windows.Forms.Label lblOrderView;
    }
}