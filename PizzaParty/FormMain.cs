using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                string formTag;
                decimal itemprice = 0.00m;
                if (((Button)sender).Name.Contains("Pizza"))
                {
                    Form pizzaForm = new frmPizza();
                    pizzaForm.ShowDialog();
                    if (pizzaForm.DialogResult == DialogResult.OK)
                    {
                        formTag = pizzaForm.Tag.ToString();
                        decimal.TryParse(formTag.Split('$').Last(), out itemprice);
                        addItem(formTag);
                    }
                }
                else if(((Button)sender).Name.Contains("Drinks"))
                {
                    Form Form = new frmDrinks();
                    Form.ShowDialog();
                    if (Form.DialogResult == DialogResult.OK)
                    {
                        formTag = Form.Tag.ToString();
                        MessageBox.Show(formTag);
                        decimal.TryParse(formTag.Split('$').Last(), out itemprice);
                        addItem(formTag);
                    }
                }
                else if (((Button)sender).Name.Contains("Extras"))
                {
                    Form Form = new frmExtras();
                    Form.ShowDialog();
                    if (Form.DialogResult == DialogResult.OK)
                    {
                        formTag = Form.Tag.ToString();
                        decimal.TryParse(formTag.Split('$').Last(), out itemprice);
                        addItem(formTag);
                    }
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

        private void btnOrder_Click(object sender, EventArgs e)
        {
            bool checkorder = (txtRunningTotal.Text != "");

            if (txtRunningTotal.Text != "") {
                if (MessageBox.Show("Do you wish to submit this order?",
                       "Confirm Order",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                   
                    MessageBox.Show("Thanks for your order!", "Order Submitted");
                    Debug.Write("Order Desc: \n" + txtRunningTotal +
                        "\nTotal:\n" + txtSubtotalMain);
                    txtRunningTotal.Text = "";
                    txtSubtotalMain.Text = (0.00m).ToString("c");
                }
            }
            else
            {
                MessageBox.Show("No Data to Submit", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void txtRunningTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSubtotalMain_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
