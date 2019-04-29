using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;



namespace AssetManager
{
    public partial class frmAddAddress : Form
    {
        public static int iAddressID;
        SqlConnection conn;
        public frmAddAddress()
        {
            InitializeComponent();
            conn = new SqlConnection();
            gMapBingMap.MapProvider = GMapProviders.BingMap;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

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
                        dr = MessageBox.Show("Is this the address you are looking for?" + Environment.NewLine + latlng[2], "Addrress", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            txtLatitude.Text = string.Format("{0:N6}", latlng[0]);
                            txtLongitude.Text = string.Format("{0:N6}", latlng[1]);
                            txtAddress.Text = latlng[2];
                            gMapBingMap.Position = new GMap.NET.PointLatLng(double.Parse(latlng[0], System.Globalization.CultureInfo.InvariantCulture), double.Parse(latlng[1], System.Globalization.CultureInfo.InvariantCulture));
                            gMapBingMap.MaxZoom = 18;
                            gMapBingMap.MinZoom = 1;
                            gMapBingMap.Zoom = 18;
                            GroupBoxChangeState();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("The address could not be found. Please ensure that the address entered has no unneccessary special characters or spelling mistakes." + Environment.NewLine + "If not there might be a problem with the server." + Environment.NewLine + Environment.NewLine + "If problem persists please contact administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void GroupBoxChangeState()
        {
            if (grpAddress.Enabled)
            {
                grpAddress.Enabled = false;
                grpAddressInfo.Enabled = true;
            }
            else
            {
                grpAddress.Enabled = true;
                grpAddressInfo.Enabled = false; ;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtLatitude.Clear();
            txtLongitude.Clear();
            GroupBoxChangeState();
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            try
            {
                CAddress address = new CAddress();
                string sFullAddress = txtAddress.Text;
                string[] addressArry = sFullAddress.Split(',');
                address.sAddressLine1 = addressArry[0];
                address.sCity = addressArry[1];
                address.sPostalCode = addressArry[2];
                List<int> iList = address.AddAddress(conn, address.sAddressLine1, address.sCity, address.sPostalCode, decimal.Parse(txtLatitude.Text, System.Globalization.CultureInfo.InvariantCulture), decimal.Parse(txtLongitude.Text, System.Globalization.CultureInfo.InvariantCulture)); 
                if (iList[0] == 1)
                {
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show("Address has been saved successfully." + Environment.NewLine + "Would you like to add another address?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        GroupBoxChangeState();
                        ClearTextBoxes();
                        iAddressID = iList[1];
                    }
                    if (dr == DialogResult.No)
                    {
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
                ClearTextBoxes();
                GroupBoxChangeState();
            }
        }

        private void ClearTextBoxes()
        {
            txtAddressLine1.Clear();
            txtCity.Clear();
            txtLatitude.Clear();
            txtLongitude.Clear();
            txtPostalCode.Clear();
            txtStreetNyumber.Clear();
            txtAddress.Clear();
        }
    }
}

