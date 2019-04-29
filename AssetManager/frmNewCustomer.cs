using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManager
{
    public partial class frmNewCustomer : Form
    {
        public static int iCustomerId;
        public frmNewCustomer()
        {
            InitializeComponent();
        }

        private void btnCustomerCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            if (TextBoxValidation(txtCustomerName, txtCustomerSurname, txtContactNumber, txtCustomerEmailAddress))
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are you sure you want to add this customer?", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int isValid;
                    CCustomer customer = new CCustomer();
                    SqlConnection conn = new SqlConnection();
                    List<int> iList = customer.AddCustomer(conn, txtCustomerName.Text.ToString(), txtCustomerSurname.Text, txtCustomerEmailAddress.Text, txtContactNumber.Text);
                    isValid = iList[0];
                    if (isValid == 1)
                    {
                        MessageBox.Show("Customer has successfully been added.");
                        iCustomerId = iList[1];
                        this.Close();
                    }
                    else
                        MessageBox.Show("Customer was not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public bool TextBoxValidation(TextBox txtName, TextBox txtSurname, TextBox txtContactNumber, TextBox txtEmail)
        {
            int iOutput;
            bool isValid = true;
            if (!int.TryParse(txtContactNumber.Text, out iOutput) || (txtContactNumber.Text.Length > 11))
            {
                MessageBox.Show("The contact number feild is a numeric only feild, that only allows ten numbers.", "Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                isValid = false;
                return isValid;
            }
            else if (txtContactNumber.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtSurname.Text == "")
            {
                MessageBox.Show("Ensure that all text feilds are filled in.", "Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                isValid = false;
                return isValid;
            }
            else if (!IsValidEmailAddress(txtEmail.Text))
            {
                MessageBox.Show("Email address not valid.", "Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                isValid = false;
                return isValid;
            }
            return isValid;
        }
        public static bool IsValidEmailAddress(string address) => !(address is null) && new EmailAddressAttribute().IsValid(address);
    }
}
