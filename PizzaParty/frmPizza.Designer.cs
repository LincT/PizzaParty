﻿namespace PizzaParty
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
            this.txtOrderView = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.rdoCrustDeepDish.Location = new System.Drawing.Point(241, 20);
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
            this.rdoCrustHandTossed.Location = new System.Drawing.Point(62, 20);
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
            this.rdoCrustStuffed.Location = new System.Drawing.Point(152, 20);
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
            this.rdoCrustThin.Location = new System.Drawing.Point(15, 20);
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
            // chkCheeseOnly
            // 
            this.chkCheeseOnly.AutoSize = true;
            this.chkCheeseOnly.Location = new System.Drawing.Point(105, 187);
            this.chkCheeseOnly.Margin = new System.Windows.Forms.Padding(2);
            this.chkCheeseOnly.Name = "chkCheeseOnly";
            this.chkCheeseOnly.Size = new System.Drawing.Size(84, 17);
            this.chkCheeseOnly.TabIndex = 12;
            this.chkCheeseOnly.Text = "Just Cheese";
            this.chkCheeseOnly.UseVisualStyleBackColor = true;
            // 
            // chkOlive
            // 
            this.chkOlive.AutoSize = true;
            this.chkOlive.Location = new System.Drawing.Point(185, 130);
            this.chkOlive.Margin = new System.Windows.Forms.Padding(2);
            this.chkOlive.Name = "chkOlive";
            this.chkOlive.Size = new System.Drawing.Size(85, 17);
            this.chkOlive.TabIndex = 11;
            this.chkOlive.Text = "Black Olives";
            this.chkOlive.UseVisualStyleBackColor = true;
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(20, 130);
            this.chkBacon.Margin = new System.Windows.Forms.Padding(2);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(57, 17);
            this.chkBacon.TabIndex = 10;
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Location = new System.Drawing.Point(185, 152);
            this.chkPineapple.Margin = new System.Windows.Forms.Padding(2);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(73, 17);
            this.chkPineapple.TabIndex = 9;
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            // 
            // chkShroom
            // 
            this.chkShroom.AutoSize = true;
            this.chkShroom.Location = new System.Drawing.Point(185, 108);
            this.chkShroom.Margin = new System.Windows.Forms.Padding(2);
            this.chkShroom.Name = "chkShroom";
            this.chkShroom.Size = new System.Drawing.Size(75, 17);
            this.chkShroom.TabIndex = 8;
            this.chkShroom.Text = "Mushroom";
            this.chkShroom.UseVisualStyleBackColor = true;
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(185, 86);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(2);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(54, 17);
            this.chkOnion.TabIndex = 7;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            // 
            // chkPeppers
            // 
            this.chkPeppers.AutoSize = true;
            this.chkPeppers.Location = new System.Drawing.Point(185, 64);
            this.chkPeppers.Margin = new System.Windows.Forms.Padding(2);
            this.chkPeppers.Name = "chkPeppers";
            this.chkPeppers.Size = new System.Drawing.Size(65, 17);
            this.chkPeppers.TabIndex = 6;
            this.chkPeppers.Text = "Peppers";
            this.chkPeppers.UseVisualStyleBackColor = true;
            // 
            // chkSpin
            // 
            this.chkSpin.AutoSize = true;
            this.chkSpin.Location = new System.Drawing.Point(185, 42);
            this.chkSpin.Margin = new System.Windows.Forms.Padding(2);
            this.chkSpin.Name = "chkSpin";
            this.chkSpin.Size = new System.Drawing.Size(65, 17);
            this.chkSpin.TabIndex = 5;
            this.chkSpin.Text = "Spinach";
            this.chkSpin.UseVisualStyleBackColor = true;
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Location = new System.Drawing.Point(20, 152);
            this.chkHam.Margin = new System.Windows.Forms.Padding(2);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(48, 17);
            this.chkHam.TabIndex = 4;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            // 
            // chkBurger
            // 
            this.chkBurger.AutoSize = true;
            this.chkBurger.Location = new System.Drawing.Point(20, 108);
            this.chkBurger.Margin = new System.Windows.Forms.Padding(2);
            this.chkBurger.Name = "chkBurger";
            this.chkBurger.Size = new System.Drawing.Size(78, 17);
            this.chkBurger.TabIndex = 3;
            this.chkBurger.Text = "Hamburger";
            this.chkBurger.UseVisualStyleBackColor = true;
            // 
            // chkChix
            // 
            this.chkChix.AutoSize = true;
            this.chkChix.Location = new System.Drawing.Point(20, 86);
            this.chkChix.Margin = new System.Windows.Forms.Padding(2);
            this.chkChix.Name = "chkChix";
            this.chkChix.Size = new System.Drawing.Size(65, 17);
            this.chkChix.TabIndex = 2;
            this.chkChix.Text = "Chicken";
            this.chkChix.UseVisualStyleBackColor = true;
            // 
            // chkSaus
            // 
            this.chkSaus.AutoSize = true;
            this.chkSaus.Location = new System.Drawing.Point(20, 64);
            this.chkSaus.Margin = new System.Windows.Forms.Padding(2);
            this.chkSaus.Name = "chkSaus";
            this.chkSaus.Size = new System.Drawing.Size(68, 17);
            this.chkSaus.TabIndex = 1;
            this.chkSaus.Text = "Sausage";
            this.chkSaus.UseVisualStyleBackColor = true;
            // 
            // chkPep
            // 
            this.chkPep.AutoSize = true;
            this.chkPep.Location = new System.Drawing.Point(20, 42);
            this.chkPep.Margin = new System.Windows.Forms.Padding(2);
            this.chkPep.Name = "chkPep";
            this.chkPep.Size = new System.Drawing.Size(74, 17);
            this.chkPep.TabIndex = 0;
            this.chkPep.Text = "Pepperoni";
            this.chkPep.UseVisualStyleBackColor = true;
            // 
            // txtOrderView
            // 
            this.txtOrderView.Enabled = false;
            this.txtOrderView.Location = new System.Drawing.Point(404, 54);
            this.txtOrderView.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderView.Multiline = true;
            this.txtOrderView.Name = "txtOrderView";
            this.txtOrderView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrderView.Size = new System.Drawing.Size(254, 319);
            this.txtOrderView.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 408);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear Options";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 408);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "Accept";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(278, 408);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 24);
            this.button3.TabIndex = 7;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
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
            this.label2.TabIndex = 9;
            this.label2.Text = "Subtotal:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(550, 401);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 20);
            this.textBox1.TabIndex = 10;
            // 
            // frmPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 448);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOrderView);
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
        private System.Windows.Forms.TextBox txtOrderView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}