using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using AssetManager.Booking;

namespace AssetManager
{
    public partial class frmMain : Form
    {
        CUser User;
        CUserType usertype;
        CBookingInstance bookinginstance = new CBookingInstance();
        SqlConnection conn = new SqlConnection();
        CItemType itemType;
        bool isChecked = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qrScannerDataSet17.ItemType' table. You can move, or remove it, as needed.
            this.itemTypeTableAdapter.Fill(this.qrScannerDataSet17.ItemType);
            // TODO: This line of code loads data into the 'qrScannerDataSet15.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.qrScannerDataSet15.Booking);
            // TODO: This line of code loads data into the 'qrScannerDataSet14.Address' table. You can move, or remove it, as needed.
            this.addressTableAdapter.Fill(this.qrScannerDataSet14.Address);
            // TODO: This line of code loads data into the 'qrScannerDataSetAddressData.Address' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'qrScannerDataSet13.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.qrScannerDataSet13.Customer);
            // TODO: This line of code loads data into the 'qrScannerDataSet12.Customer' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'qrScannerDataSet10.sp_GetItemInfo' table. You can move, or remove it, as needed.
            this.sp_GetItemInfoTableAdapter.Fill(this.qrScannerDataSet10.sp_GetItemInfo);
            // TODO: This line of code loads data into the 'qrScannerDataSet9.view_GetItems' table. You can move, or remove it, as needed.
            PopulateItemTypeCmb();

            txtQrCode.Enabled = false;
            if (dgvItems.Rows.Count > 1)
            {
                cmbItemType.SelectedIndex = 0;
                dgvItems.Rows[0].Selected = false;
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearUserText();
            btnAdd.Visible = false;
            btnEdit.Visible = true;
            grpbxAddUsers.Enabled = true;
            grpbxAddUsers.Text = "Edit User";

            User = CUser.GetInstance();
            User = User.GetUser(conn, lstbxUsers.SelectedItem.ToString());

            txtUserID.Text = User.sID.ToString();
            txtName.Text = User.sName;
            txtPassword.Text = User.sPassword;
            txtSurname.Text = User.sSurname;
            txtUseranme.Text = User.sUserName;

            cmbUserType.SelectedIndex = cmbUserType.FindStringExact(User.sUserType);

        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedIndex == 1)
            {
                PopulateUserList();
                PopulateComboBox();
                lstbxUsers.SelectedIndex = 0;
            }
            else if (tabMain.SelectedIndex == 0)
            {
                PopulateItemTypeCmb();

                txtQrCode.Enabled = false;
                if (dgvItems.Rows.Count > 1)
                {
                    cmbItemType.SelectedIndex = 0;
                    dgvItems.Rows[0].Selected = false;
                }

            }

        }
        private void PopulateUserList()
        {
            lstbxUsers.Items.Clear();
            User = CUser.GetInstance();
            foreach (CUser user in User.getUsers())
            {
                lstbxUsers.Items.Add(user.sName + " " + user.sSurname + user.sUserName);
            }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ClearUserTextBoxes();
            DisableUserButtons();
            grpbxAddUsers.Enabled = true;
            btnEdit.Visible = false;
            btnAdd.Visible = true;
            grpbxAddUsers.Text = "Add User";
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            cmbUserType.Items.Clear();
            usertype = new CUserType();
            List<CUserType> list = usertype.GetCUserTypes(conn);
            foreach (CUserType type in list)
            {
                cmbUserType.Items.Add(type.getUsertype());
            }
            cmbUserType.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            EnableUserButtons();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPassword.Text != "" && txtSurname.Text != "" && txtUseranme.Text != "")
            {
                User = CUser.GetInstance();
                int IsValid = User.AddNewUser(conn, txtUseranme.Text, txtPassword.Text, txtName.Text, txtSurname.Text, cmbUserType.SelectedItem.ToString());
                if (IsValid == 1)
                {
                    MessageBox.Show("User added successfully!");
                    PopulateUserList();
                    ClearUserTextBoxes();
                    lstbxUsers.SelectedIndex = 0;
                    EnableUserButtons();
                }
                else
                    MessageBox.Show("User with this username already exists.");
            }
            else
                MessageBox.Show("Please fill in all the text boxes available.");
        }

        public void btnAddUserType_Click(object sender, EventArgs e)
        {

            string sType;
            using (frmUserType form = new frmUserType())
            {
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int iResult;
                    sType = form.sType;
                    usertype = new CUserType();
                    iResult = usertype.AddUserType(conn, sType);
                    if (iResult == 1)
                    {

                        MessageBox.Show("User Type successfully added!");

                        cmbUserType.Items.Clear();
                        foreach (CUserType type in usertype.GetCUserTypes(conn))
                        {
                            cmbUserType.Items.Add(type.getUsertype());

                        }
                    }
                    else
                        MessageBox.Show("User name already exists!");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPassword.Text != "" && txtSurname.Text != "" && txtUseranme.Text != "")
            {
                User = CUser.GetInstance();
                int IsValid;
                IsValid = User.EditUser(conn, Convert.ToInt32(txtUserID.Text), txtName.Text, txtSurname.Text, txtUseranme.Text, txtPassword.Text, cmbUserType.SelectedItem.ToString());

                if (IsValid == 1)
                {
                    MessageBox.Show("User updated successfully!");
                }
                else
                    MessageBox.Show("There was an error updating this user!");
                PopulateUserList();
            }
        }

        private void DisableUserButtons()
        {
            lstbxUsers.Enabled = false;
            btnAddUser.Enabled = false;
            btnRemove.Enabled = false;

        }
        private void EnableUserButtons()
        {
            grpbxAddUsers.Enabled = false;
            lstbxUsers.Enabled = true;
            btnAddUser.Enabled = true;
            btnRemove.Enabled = true;

        }
        private void ClearUserText()
        {
            txtUserID.Clear();
            txtName.Clear();
            txtPassword.Clear();
            txtUseranme.Clear();
            txtSurname.Clear();
        }
        public void ClearUserTextBoxes()
        {
            txtUserID.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            txtSurname.Text = "";
            txtUseranme.Text = "";
            cmbUserType.SelectedIndex = 0;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you want to remove this user?", "OK", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                User = CUser.GetInstance();
                int IsValid;
                IsValid = User.RemoveUser(conn, Convert.ToInt32(txtUserID.Text));
                if (IsValid == 1)
                {
                    MessageBox.Show("User has successfully been removed!");
                    PopulateUserList();
                    ClearUserTextBoxes();
                    lstbxUsers.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Please select a user to be removed.");
                }
            }
        }

        private void dataGWItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvItems.Rows[e.RowIndex];
                txtQrCode.Text = row.Cells[0].Value.ToString();
                decimal mPrice = Convert.ToDecimal(row.Cells[3].Value);
                radAvailability.Checked = (bool)row.Cells[4].Value;
                cmbItemType.SelectedIndex = cmbItemType.FindStringExact(row.Cells[1].Value.ToString());
            }
        }

        private void EnableItemTextBoxes()
        {

            grpManageItems.Enabled = true;
        }


        private void btnManageItemTypes_Click(object sender, EventArgs e)
        {
            frmItemType frmItemType = new frmItemType();
            frmItemType.FormClosed += delegate
            {
                RefreshDataSource(dgvCustomers, "sp_GetItemInfo");
                PopulateItemTypeCmb();
            };
            frmItemType.Show();

        }

        private void PopulateItemTypeCmb()
        {
            cmbItemType.Items.Clear();
            itemType = new CItemType();
            foreach (CItemType type in itemType.GetItemTypes())
            {
                cmbItemType.Items.Add(type.GetTypeName());
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            btnItemAdd.Visible = true;
            btnItemEdit.Visible = false;
            ItemTextboxesChangeState();
            ClearItemTextboxes();
            txtQrCode.Text = "Generated automatically";
            if (dgvItems.Rows.Count > 0)
                dgvItems.Rows[0].Selected = false;


        }
        public void ItemTextboxesChangeState()
        {
            if (grpManageItems.Enabled == true)
            {
                grpManageItems.Enabled = false;
                btnAddItem.Enabled = true;
                btnEditItem.Enabled = true;
                dgvItems.Enabled = true;
                btnRemoveItem.Enabled = true;
            }
            else
            {
                grpManageItems.Enabled = true;
                btnEditItem.Enabled = false;
                btnAddItem.Enabled = false;
                dgvItems.Enabled = false;
                btnRemoveItem.Enabled = false;
            }
        }
        public void ClearItemTextboxes()
        {
            txtQrCode.Clear();
            radAvailability.Checked = false;
            if (dgvItems.Rows.Count > 1)
                cmbItemType.SelectedIndex = 0;
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {

            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you want to add this Item?", "OK", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                CItem item = new CItem();
                int IsValid = item.AddItem(conn, Convert.ToBoolean(radAvailability.Checked), cmbItemType.SelectedItem.ToString());
                if (IsValid == 1)
                {
                    MessageBox.Show("User added successfully!");
                    RefreshDataSource(dgvCustomers, "sp_GetItemInfo");
                }
                else
                    MessageBox.Show("There was a problem adding the item.");
            }
            ItemTextboxesChangeState();
        }

        private void btnItemCancel_Click(object sender, EventArgs e)
        {
            ItemTextboxesChangeState();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count >= 1)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are your sure you would like to remove this item?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int isValid;
                    CItem item = new CItem();
                    isValid = item.RemoveItem(conn, Convert.ToInt32(txtQrCode.Text));
                    if (isValid == 1)
                    {
                        MessageBox.Show("Item was successfully removed.", "User removed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataSource(dgvCustomers, "sp_GetItemInfo");
                    }
                    else
                    {
                        MessageBox.Show("User was not removed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ItemTextboxesChangeState();
                }
            }
            else
                MessageBox.Show("Please select an item to remove.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count >= 1)
            {
                btnItemAdd.Visible = false;
                btnItemEdit.Visible = true;
                ItemTextboxesChangeState();
            }
            else
                MessageBox.Show("Please select an item to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnItemEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are your sure you would like to update this item?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int isValid;
                CItem item = new CItem();
                isValid = item.EditItem(conn, Convert.ToInt32(value: txtQrCode.Text), radAvailability.Checked, cmbItemType.SelectedItem.ToString());
                RefreshDataSource(dgvCustomers, "sp_GetItemInfo");
                ItemTextboxesChangeState();
            }
            else
            {
                MessageBox.Show("Item could not be updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void radAvailability_Click(object sender, EventArgs e)
        {
            if (radAvailability.Checked && !isChecked)
                radAvailability.Checked = false;
            else
            {
                radAvailability.Checked = true;
                isChecked = false;
            }

        }

        private void radAvailability_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = radAvailability.Checked;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataSource(dgvCustomers, "sp_GetItemInfo");
            PopulateItemTypeCmb();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            btnCustomerAdd.Visible = true;
            btnCustomerEdit.Visible = false;
            CustomerLayoutChange();
            ClearCustomerTextBoxes();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.Rows.Count < 1 || txtCustomeID.Text == "" || txtCustomeID.Text == "Generated automatically")
            {
                MessageBox.Show("Please select an item to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnCustomerAdd.Visible = false;
                btnCustomerEdit.Visible = true;
                CustomerLayoutChange();
            }
        }
        private void ClearCustomerTextBoxes()
        {
            txtCustomeID.Text = "Generated automatically";
            txtCustomerName.Clear();
            txtCustomerSurname.Clear();
            txtContactNumber.Clear();
            txtCustomerEmailAddress.Clear();
        }
        private void CustomerLayoutChange()
        {
            if (grpCustomer.Enabled == false)
            {
                grpCustomer.Enabled = true;
                btnAddCustomer.Enabled = false;
                btnEditCustomer.Enabled = false;
                btnRemoveCustomer.Enabled = false;
                dgvCustomers.Enabled = false;
            }
            else
            {
                grpCustomer.Enabled = false;
                btnAddCustomer.Enabled = true;
                btnEditCustomer.Enabled = true;
                btnRemoveCustomer.Enabled = true;
                dgvCustomers.Enabled = true;
            }
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.Rows.Count < 1 || txtCustomeID.Text == "" || txtCustomeID.Text == "Generated automatically")
            {

                MessageBox.Show("Please select an item to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are you sure you want to remove this customer?", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int isValid;
                    CCustomer customer = new CCustomer();
                    isValid = customer.RemoveCustomer(conn, Convert.ToInt32(txtCustomeID.Text));
                    if (isValid == 1)
                    {
                        MessageBox.Show("Customer has successfully been removed.");
                        RefreshDataSource(dgvCustomers, "sp_GetCustomerInfo");
                    }
                    else
                        MessageBox.Show("Customer was not removed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void RefreshDataSource(DataGridView dgv, string sCommandString)
        {
            //todo: Fix refreshing bugs.
            DataTable dt = new DataTable();
            CConnection cc = CConnection.GetConnectionInstance();
            conn = cc.GetConnection();

            SqlCommand cmd = new SqlCommand(sCommandString, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv.DataSource = dt;
            conn.Close();
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
                    isValid = customer.AddCustomer(conn, txtCustomerName.Text.ToString(), txtCustomerSurname.Text, txtCustomerEmailAddress.Text, txtContactNumber.Text)[0];
                    if (isValid == 1)
                    {
                        MessageBox.Show("Customer has successfully been add.");
                        RefreshDataSource(dgvCustomers, "sp_GetCustomerInfo");
                        CustomerLayoutChange();
                    }
                    else
                        MessageBox.Show("Customer was not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCustomerEdit_Click(object sender, EventArgs e)
        {
            if (TextBoxValidation(txtCustomerName, txtCustomerSurname, txtContactNumber, txtCustomerEmailAddress))
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are you sure you want to edit this customer?", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int isValid;
                    CCustomer customer = new CCustomer();
                    isValid = customer.EditCustomer(conn, Convert.ToInt32(txtCustomeID.Text), txtCustomerName.Text, txtCustomerSurname.Text, txtContactNumber.Text, txtCustomerEmailAddress.Text);
                    if (isValid == 1)
                    {
                        MessageBox.Show("Customer has successfully been updated.");
                        RefreshDataSource(dgvCustomers, "sp_GetCustomerInfo");
                        CustomerLayoutChange();
                    }
                    else
                        MessageBox.Show("Customer was not updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnCustomerCancel_Click(object sender, EventArgs e)
        {
            CustomerLayoutChange();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCustomers.Rows[e.RowIndex];
                txtCustomeID.Text = row.Cells[0].Value.ToString();
                txtCustomerName.Text = row.Cells[2].Value.ToString();
                txtCustomerSurname.Text = row.Cells[3].Value.ToString();
                txtCustomerEmailAddress.Text = row.Cells[4].Value.ToString();
                txtContactNumber.Text = row.Cells[1].Value.ToString();
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


        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            frmAddAddress address = new frmAddAddress();
            address.FormClosed += delegate
            {
                RefreshDataSource(dgvAddress, "sp_GetAddressInfo");
            };
            address.Show();

        }


        private void btnRemoveAddress_Click(object sender, EventArgs e)
        {
            if (dgvAddress.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please Select an item to remove");
            }
            else
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are you sure you want to delete this address?", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    CAddress address = new CAddress();
                    int iRowIndex = dgvAddress.SelectedCells[0].RowIndex;
                    int IsValid = address.RemoveAddress(conn, int.Parse(dgvAddress.Rows[iRowIndex].Cells[0].Value.ToString()));
                }
                RefreshDataSource(dgvAddress, "sp_GetAddressInfo");
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBookingCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmNewCustomer customer = new frmNewCustomer();
            customer.Show();
            customer.FormClosed += delegate
            {
                if (frmNewCustomer.iCustomerId != 0)
                {
                    bookinginstance.iAddressID = frmNewCustomer.iCustomerId;
                    cbCustomer.Checked = true;
                }
            };
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            if (dtpTodaysDate.Value.Day < dtpExpiryDate.Value.Day)
            {
                if (cbAddress.Checked == true && cbCustomer.Checked == true && cbItem.Checked == true)
                {
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show("Are you sure you want to add this booking?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        CUser user = CUser.GetInstance();
                        CLogin login = CLogin.GetInstance();
                        CBooking booking = new CBooking();
                        int iBookingID = booking.CreateBooking(dtpTodaysDate.Value, dtpExpiryDate.Value);
                        bookinginstance.iUserID = user.GetUserID(login.GetUser());
                        bookinginstance.iBookingID = iBookingID;
                        bookinginstance.CreateBookingInstance();
                        MessageBox.Show("Booking has been created.", "Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                    MessageBox.Show("Ensure that you have selected a customer, an address and an item.", "Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Please select a date greater than todays date.", "Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnNewAddress_Click(object sender, EventArgs e)
        {
            frmNewAddress address = new frmNewAddress();
            address.FormClosed += delegate
            {
               if(frmNewAddress.iAddressID != 0)
                {
                    bookinginstance.iAddressID = frmNewAddress.iAddressID;
                    cbAddress.Checked = true;
                }
            };
            address.Show();
        }

        private void btnSelectItem_Click(object sender, EventArgs e)
        {
            frmSelectItem frmSI = new frmSelectItem();
            frmSI.Show();
            frmSI.FormClosed += delegate
            {
                if (frmSelectItem.ItemID != 0)
                {
                    bookinginstance.iItemID = frmSelectItem.ItemID;
                    cbItem.Checked = true;
                }
                else
                    cbItem.Checked = false;
            };
        }
        private void tabCustomers_Click(object sender, EventArgs e)
        {

        }

        private void btnExistingAddress_Click(object sender, EventArgs e)
        {
            frmSelectAddress frmaddress = new frmSelectAddress();
            frmaddress.Show();
            frmaddress.FormClosed += delegate
            {
                if (frmSelectAddress.iAddressID != 0)
                {
                    bookinginstance.iAddressID = frmSelectAddress.iAddressID;
                    cbAddress.Checked = true;
                }
                else
                {
                    cbAddress.Checked = false;
                }
            };
        }

        private void btnExistingCustomer_Click(object sender, EventArgs e)
        {
            frmSelectCustomer customer = new frmSelectCustomer();
            customer.Show();
            customer.FormClosed += delegate
            {
                if(frmSelectCustomer.iCustomerID != 0)
                {
                    bookinginstance.iCustomerID = frmSelectCustomer.iCustomerID;
                    cbCustomer.Checked = true;
                }
            };
        }
    }
}


           
        