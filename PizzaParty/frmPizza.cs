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
        List<string> toppings = new List<string>();
        public frmPizza()
        {
            InitializeComponent();
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
            updateOrderView();
            //Debug.Write("Size: " + size + ", Crust: " + crust + ", Sauce: " + sauce);
        }

        private void chk_CheckChanged(object sender, EventArgs e)
        {
            
            getToppings();
            updateOrderView();
        }

        private void getToppings()
        {
            //List<string> toppings = new List<string> { };
            foreach (Control c in Controls)
            {
                Debug.Write(c.Name);
                
                if (c.Name.StartsWith("chk") == true)
                {
                    Debug.Write("CheckBox Found!");
                    Debug.Write((c).Name + "|");
                    if (c is CheckBox&&((CheckBox)c).Checked)
                    {
                        toppings.Add(((CheckBox)c).Text);
                        Debug.Write(((CheckBox)c).Name);
                    }
                    
                }
                return;
            }
        }

        public void updateOrderView()
        {
            try
            {
                string result = "";
                result += "Current Order:\n";
                result += "Size: " + size + "\n";
                result += "Crust: " + crust + "\n";
                result += "Sauce: " + sauce + "\n";
                if (toppings.Count >=1)
                {
                   MessageBox.Show("Toppings Count: " + toppings.Count);
                    result += "Toppings:\n";
                    foreach (string topping in toppings)
                    {
                        result += "\t" + topping;
                    }

                }

                txtOrderView.Text = result;

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
        public void initialize()
        {
            foreach(Control c in Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }
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
            /*
            pizza.Add(cboSize.Text);
            pizza.Add(cboSauce.Text);
            pizza.Add(cboCrust.Text);
            foreach (object itemChecked in clbToppings.CheckedItems)
            {
                pizza.Add(itemChecked.ToString());
            }
            string result = "Pizza: \n";

            result += string.Join(", ", pizza);
            //MessageBox.Show(result);
            this.Tag = result;
            this.DialogResult = DialogResult.OK;
            */
        }
    }
}
