﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaParty
{
    public partial class FormMain : Form
    {
        //Eric Holmboe
        //Joseph Martin
        //Rhandee Livingston
        /*
         * Still need to define prices for items, done in sorted list.
         * output from pizza form can either be returned as a list or a string
         */
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            try
            {

                string pizzaTag;

                Form pizzaForm = new frmPizza();
                pizzaForm.ShowDialog();
                if (pizzaForm.DialogResult == DialogResult.OK)
                {
                    pizzaTag = pizzaForm.Tag.ToString();
                    /*
                     //commented out list handling
                    foreach (string item in pizzatag)
                    {
                        message += item;
                    }
                    */

                    //MessageBox.Show(pizzaTag);
                    //pizzaTag = pizzaForm.Tag.ToString();
                    //addItem(pizzaTag);
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void addItem(string itemTag)
        {
            //add the item to the text box, also add a new 
            //line with an item total maybe?
            //txtItems.Text += itemTag;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}