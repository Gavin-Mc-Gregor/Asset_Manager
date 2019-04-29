using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManager
{
    public partial class frmNewAddress : Form
    {
        public static int iAddressID;
        string sAddress;
        public frmNewAddress()
        {
            InitializeComponent();
        }

        private void btnValidateAddress_Click(object sender, EventArgs e)
        {
            if (ValidateAddressTextBoxes())
            {
                try
                {
                    CAddress address = new CAddress();
                    List<string> latlng = address.GetLatLongFromAddress(txtStreetNyumber.Text, txtAddressLine1.Text, txtCity.Text, txtPostalCode.Text);
                    if (latlng[3] == "Ambiguous")
                    {
                        MessageBox.Show("The address entered is too ambiguous, please enter a more specific address", "Address to ambiguous", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DialogResult dr = new DialogResult();
                        dr = MessageBox.Show("Is this the address you want to add?" + Environment.NewLine + latlng[2], "Addrress", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        sAddress = latlng[2];
                        if (dr == DialogResult.Yes)
                        {
                            
                            try
                            {
                                CConnection cc = CConnection.GetConnectionInstance();
                                SqlConnection conn = cc.GetConnection();
                                string sFullAddress = sAddress;
                                string[] addressArry = sFullAddress.Split(',');
                                address.sAddressLine1 = addressArry[0];
                                address.sCity = addressArry[1];
                                address.sPostalCode = addressArry[2];
                                address.sLatitude = latlng[0];
                                address.sLogitude = latlng[1];
                                List<int> iList = address.AddAddress(conn, address.sAddressLine1, address.sCity, address.sPostalCode, decimal.Parse(address.sLatitude, System.Globalization.CultureInfo.InvariantCulture), decimal.Parse(address.sLogitude, System.Globalization.CultureInfo.InvariantCulture));
                                if (iList[0] == 1)
                                {
                                    dr = MessageBox.Show("Are you sure you want to add this address?.", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (dr == DialogResult.Yes)
                                    {
                                        iAddressID = iList[1];
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("This address already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch
                            {
                                MessageBox.Show("The address was in the wrong format" + Environment.NewLine + "Ensure that the address selected has the following:"
                                    + Environment.NewLine + "*Street number"
                                    + Environment.NewLine + "*Street name"
                                    + Environment.NewLine + "*City name"
                                    + Environment.NewLine + "*Postal code"
                                    + Environment.NewLine + " "
                                    + Environment.NewLine + "Also make sure that the address is spelt correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("The address could not be found. Please ensure that the address entered has no unneccessary special characters or spelling mistakes." + Environment.NewLine + "If not there might be a problem with the server." + Environment.NewLine + Environment.NewLine + "If problem persists please contact administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
            private bool ValidateAddressTextBoxes()
        {
            bool isValid = true;
            int iOut;
            if (txtAddressLine1.Text == "" || txtCity.Text == "" || txtPostalCode.Text == "" || txtStreetNyumber.Text == "")
            {
                MessageBox.Show("Please ensure that all text feilds are filled in.", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isValid = false;
            }
            else if (!(int.TryParse(txtPostalCode.Text, out iOut)))
            {
                MessageBox.Show("The postal code feild is a numeric only feild.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return isValid;

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

