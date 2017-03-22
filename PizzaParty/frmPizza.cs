using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace PizzaParty
{
    public partial class frmPizza : Form
    {
        string size;
        string crust;
        string sauce;
        List<string> pizzaToppings = new List<string>();
        public frmPizza()
        {
            InitializeComponent();
            initialize();
        }

        private void FormPizza_Load(object sender, EventArgs e)
        {
            initialize();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            //get selection from radio buttons in form
            //apply to appropriate variable
            if (((RadioButton)sender).Checked)
                if (((RadioButton)sender).Name.StartsWith("rdoSize"))
                {
                    size = (((RadioButton)sender).Text);
                }
            else if (((RadioButton)sender).Name.StartsWith("rdoCrust"))
                {
                    crust = (((RadioButton)sender).Text);
                }
            else if (((RadioButton)sender).Name.StartsWith("rdoSauce"))
                {
                    sauce = (((RadioButton)sender).Text);
                }
            getToppings();
            updateOrderView();
            updateSubtotal();
        }

        private void chk_CheckChanged(object sender, EventArgs e)
        {
            if (chkCheeseOnly.Checked)
            {
                pizzaToppings.Clear();
                foreach (Control c in this.groupBoxToppings.Controls)
                {
                    if (c is CheckBox && !c.Name.Contains("CheeseOnly"))
                    {
                        ((CheckBox)c).Checked = false;
                    }

                    getToppings();
                    updateOrderView();
                    updateSubtotal();
                }

            }
            else
            {
                getToppings();
                updateOrderView();
                updateSubtotal();
            }
            
        }

        private void getToppings()
        {
            pizzaToppings.Clear();
            foreach (Control c in this.groupBoxToppings.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                    {
                        pizzaToppings.Add(((CheckBox)c).Text);
                    }  
                }
            }
        }

        public void updateOrderView()
        {
            try
            {
                lblOrderView.Text = "";
                List<string> result = new List<string> ();
                result.Add("Size: \t" + size);
                result.Add("Crust: \t" + crust);
                result.Add("Sauce: \t" + sauce);
                if (pizzaToppings.Count >=1)
                {
                    result.Add("\nToppings:\n");
                    foreach (string topping in pizzaToppings)
                    {
                        result.Add("\t" + topping);
                    }
                }
                    lblOrderView.Text = "Pizza Order:\n" + string.Join("\n",result);
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch(Exception ex)
            {
                Debug.Write(ex.Message);
                throw;
            }
        }

        private void updateSubtotal()
        {
            decimal price = 0.00m;
            decimal sizePrice = 0.00m;
            decimal crustPrice = 0.00m;
            decimal toppingPrice = 0.00m;
            if (size != null)
            {
                if(size.Split('$')[1] != null)
                {
                    sizePrice = Convert.ToDecimal(size.Split('$')[1]);
                    //if tryparse returns false. put in default amount
                    //sizePrice = 0.00m;
                }
                else
                {
                    sizePrice = 0.00m;
                }

               

            }
            
            price += sizePrice;

            if (crust != null)
            {
                if (crust.Contains("$"))
                {
                    Decimal.TryParse((crust.Split('$')[1]).Replace(")", ""), out crustPrice);
                }
            }
            else
            {
                crustPrice = 0.00m;
            }
            price += crustPrice;

            if(pizzaToppings.Contains("Just Cheese"))
            {
                toppingPrice += 0.25m;
            }
            else
            {
                foreach (string topping in pizzaToppings)
                {
                    toppingPrice += 0.25m;
                }
            }
            
            price += toppingPrice;
            txtSubtotal.Text = price.ToString("c");
        }
        public void initialize()
        {
            foreach(Control c in this.groupBoxToppings.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }
            rdoSize8.Checked = true;
            rdoSauceRed.Checked = true;
            rdoCrustThin.Checked = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            initialize();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //comment
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            List<string> pizza = new List<string>();
            pizza.Add(size);
            pizza.Add(sauce);
            pizza.Add(crust);
            foreach (string topping in pizzaToppings)
            {
                pizza.Add(topping);
            }
            string result = "Pizza: \n";

            result += string.Join(", ", pizza);
            result += ",Subtotal: " + txtSubtotal.Text;
            //MessageBox.Show(result);
            this.Tag = result;
            this.DialogResult = DialogResult.OK;
            
        }
    }
}
