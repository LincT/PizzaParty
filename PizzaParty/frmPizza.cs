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
        public frmPizza()
        {
            InitializeComponent();
        }

        //global variable to pass to other forms
        List<string> pizza = new List<string>();

        public List<string> addPizza
        {
            get { return pizza; }
        }
        

        private void FormPizza_Load(object sender, EventArgs e)
        {
            initialize();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {

            //get selection from radio buttons in form
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
            //Debug.Write("Size: " + size + ", Crust: " + crust + ", Sauce: " + sauce);
        }

        public void initialize()
        {
            /*
            List<string> options = new List<string>
            { "Chicken", "Hamburger", "Pepperoni", "Black Olives", "Green Olives",
                "Spinach", "Mushrooms", "Garlic", "Anchovies", "Bell Pepper",
                "Onions" };
                */
            /*
            cboSize.SelectedIndex = 0;
            cboCrust.SelectedIndex = 0;
            cboSauce.SelectedIndex = 0;
            clbToppings.ClearSelected();
            clbToppings.Items.Clear();
            foreach (string newItem in options)
            {
                clbToppings.Items.Add(newItem);
            }
            

            foreach (int i in clbToppings.CheckedIndices)
            {
                clbToppings.SetItemCheckState(i, CheckState.Unchecked);
            }
            */
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            initialize();
        }

        private void clbToppings_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int toppingCount = clbToppings.CheckedIndices.Count;

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
