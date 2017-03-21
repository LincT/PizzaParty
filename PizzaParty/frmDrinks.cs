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
    public partial class frmDrinks : Form
    {
        public frmDrinks()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDrinks_Load(object sender, EventArgs e)
        {
           

        }

        private void btnAddDrinks_Click(object sender, EventArgs e)
        {
            //converting selected items from comboboxes to string
            string drinkSize = this.cboSize.GetItemText(this.cboSize.SelectedItem);
            string drinkType = this.cboType.GetItemText(this.cboType.SelectedItem);
            string drinkSelected = "Drink: ";

            drinkSelected += string.Join(",", drinkSize, drinkType);

            //Result to show on txtRunningTotal on Main Form
            this.Tag = drinkSelected;
            this.DialogResult = DialogResult.OK;
            
            //if and else if statements to determine cost to be added to total
            if (cboSize.SelectedItem.ToString() == "12 oz can - $1") ;


        }
    }
}
