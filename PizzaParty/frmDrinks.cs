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
            cboSize.SelectedIndex = 0;
            cboType.SelectedIndex = 0;
        }

       
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAddDrinks_Click(object sender, EventArgs e)
        {
            //converting selected items from comboboxes to string
            string drinkSize = this.cboSize.GetItemText(this.cboSize.SelectedItem);
            string drinkType = this.cboType.GetItemText(this.cboType.SelectedItem);
            string drinkSelected = "Drink: ";
            if (cboType.SelectedIndex !=0 && cboSize.SelectedIndex!=0)
            {
                drinkSelected += string.Join(",", drinkSize.Split('-')[0] +","+ drinkType+"," + 
                drinkSize.Split('-')[1]);
                this.Tag = drinkSelected;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please select both a size and type");
            }

            //Result to show on txtRunningTotal on Main Form
            
        }
    }
}
