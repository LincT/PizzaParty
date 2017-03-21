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
    public partial class frmExtras : Form
    {
        List<string> extras = new List<string>();

        public frmExtras()
        {
            InitializeComponent();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmExtras_Load(object sender, EventArgs e)
        {

        }
        private void getExtras()
        {
            extras.Clear();
            foreach (Control c in this.groupBoxAdd.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                    {
                        extras.Add(((CheckBox)c).Text);
                    }
                }
            }
        }
        private void updateSubtotal()
        {
            //trying to get the subtotal to show based on how many selections are made
            decimal extraPrice = 0.00m;
            decimal extraSub = 0.00m;

            foreach (Control c in this.groupBoxAdd.Controls)
            {
                extraPrice += 5.00m;
            }
            extraSub += extraPrice;

            txtExtraSubtotal.Text = extraSub.ToString("c");

        }
        public void updateOrderView()
        {
            try
            {
                txtExtraOrder.Text = "";
                
                if (extras.Count >= 1)
                {
                    List<string> extraDisplay = new List<string>();
                    extraDisplay.Add(" Add-On ");
                    foreach (string addOn in extras)
                    {
                        extraDisplay.Add("\t" + extras);
                    }
                }
                txtExtraOrder.Text = string.Join("\n", extras);
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            
        }
        private void btnExtrasBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcceptExtras_Click(object sender, EventArgs e)
        {

        }

        private void btnClearExtras_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.groupBoxAdd.Controls)
            {
                if (c.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)c).Checked = false;
                }
            }
            txtExtraOrder.Text = string.Empty;
            txtExtraSubtotal.Text = string.Empty;


        }
    }
}
