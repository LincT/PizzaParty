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

        private void initializeControls()
        {
            foreach (Control c in this.groupBoxAdd.Controls)
            {
                //set all check boxes in group box to false
                ((CheckBox)c).Checked = false;
            }
            txtExtraOrder.Text = ""; //clear order description
            txtExtraSubtotal.Text = 0.00m.ToString(); //reset subtotal
        }
        private void frmExtras_Load(object sender, EventArgs e)
        {
            initializeControls();
        }
        private void getExtras()
        {
            extras.Clear();
            foreach (Control c in this.groupBoxAdd.Controls)
            {
                if (c is CheckBox && ((CheckBox)c).Checked)
                {
                    extras.Add(c.Text);
                }
            }
        }
        private void chk_CheckChanged(object sender,EventArgs e)
        {
            //one event handler for all the check boxes.
            getExtras();
            updateOrderView();
            updateSubtotal();
        }
        private void updateSubtotal()
        {
            //subtotal based on items checked.
            decimal extraPrice = 0.00m;
           
            foreach (Control c in this.groupBoxAdd.Controls)
            {
                if (c is CheckBox && ((CheckBox)c).Checked)
                {
                    extraPrice += 5.00m;
                }
            }
            txtExtraSubtotal.Text = extraPrice.ToString("c");
        }

        public void updateOrderView()
        {
            try
            {
                txtExtraOrder.Text = "";
                
                if (extras.Count >= 1)
                {
                    List<string> extraDisplay = new List<string>();
                    txtExtraOrder.AppendText("Add-Ons: ");
                    foreach (string addOn in extras)
                    {
                        txtExtraOrder.AppendText("\t" + addOn + "\n");
                    }
                }
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
            //this needs to set this.tag
            List<string> extraTag = new List<string>();
            foreach (string extra in extras)
            {
                extraTag.Add(extra);
            }
            string result = "Extras: \n";

            result += string.Join(", ", extraTag);
            result += ",Subtotal: " + txtExtraSubtotal.Text;
            //MessageBox.Show(result);
            this.Tag = result;
            this.DialogResult = DialogResult.OK;
        }

        private void btnClearExtras_Click(object sender, EventArgs e)
        {
            initializeControls();
        }
    }
}
