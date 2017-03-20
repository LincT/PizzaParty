using System;
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
       
        public FormMain()
        {
            InitializeComponent();
            decimal initCost = 0.00m;
            txtSubtotalMain.Text = (initCost).ToString("c");
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            try
            {
                string pizzaTag;
                decimal itemprice = 0.00m;
                Form pizzaForm = new frmPizza();
                pizzaForm.ShowDialog();
                if (pizzaForm.DialogResult == DialogResult.OK)
                {
                    pizzaTag = pizzaForm.Tag.ToString();
                    decimal.TryParse(pizzaTag.Split('$').Last(), out itemprice);
                    addItem(pizzaTag);
                }
                txtSubtotalMain.Text = ((Convert.ToDecimal(txtSubtotalMain.Text.Remove(0,1))) + 
                    itemprice).ToString("c");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public void addItem(string itemTag)
        {
            txtRunningTotal.AppendText(itemTag+"\n");
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtRunningTotal.Text = "";
            txtSubtotalMain.Text = (0.00m).ToString("c");
        }
    }
}
