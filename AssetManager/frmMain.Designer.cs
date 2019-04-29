namespace AssetManager
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sp_GetItemInfoTableAdapter = new AssetManager.QrScannerDataSet10TableAdapters.sp_GetItemInfoTableAdapter();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustomerEmailAddress = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomeID = new System.Windows.Forms.TextBox();
            this.btnCustomerCancel = new System.Windows.Forms.Button();
            this.btnCustomerEdit = new System.Windows.Forms.Button();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qrScannerDataSet13 = new AssetManager.QrScannerDataSet13();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.gpUsers = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstbxUsers = new System.Windows.Forms.ListBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grpbxAddUsers = new System.Windows.Forms.GroupBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddUserType = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtUseranme = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.tabItem = new System.Windows.Forms.TabPage();
            this.btnManageItemTypes = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.grpManageItems = new System.Windows.Forms.GroupBox();
            this.btnItemEdit = new System.Windows.Forms.Button();
            this.btnItemCancel = new System.Windows.Forms.Button();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.radAvailability = new System.Windows.Forms.RadioButton();
            this.txtQrCode = new System.Windows.Forms.TextBox();
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.iQrCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iAvailabilityDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.spGetItemInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qrScannerDataSet10 = new AssetManager.QrScannerDataSet10();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRemoveAddress = new System.Windows.Forms.Button();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.dgvAddress = new System.Windows.Forms.DataGridView();
            this.aIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLine1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aAddressCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLatitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLongitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qrScannerDataSet14 = new AssetManager.QrScannerDataSet14();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpBooking = new System.Windows.Forms.GroupBox();
            this.btnBookingCancel = new System.Windows.Forms.Button();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTodaysDate = new System.Windows.Forms.DateTimePicker();
            this.grpBookingAddress = new System.Windows.Forms.GroupBox();
            this.cbAddress = new System.Windows.Forms.CheckBox();
            this.btnExistingAddress = new System.Windows.Forms.Button();
            this.btnNewAddress = new System.Windows.Forms.Button();
            this.grpBookingItem = new System.Windows.Forms.GroupBox();
            this.cbItem = new System.Windows.Forms.CheckBox();
            this.btnSelectItem = new System.Windows.Forms.Button();
            this.grpBookingCustomer = new System.Windows.Forms.GroupBox();
            this.cbCustomer = new System.Windows.Forms.CheckBox();
            this.btnExistingCustomer = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bExpiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qrScannerDataSet15 = new AssetManager.QrScannerDataSet15();
            this.qrScannerDataSet12 = new AssetManager.QrScannerDataSet12();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new AssetManager.QrScannerDataSet12TableAdapters.CustomerTableAdapter();
            this.customerTableAdapter1 = new AssetManager.QrScannerDataSet13TableAdapters.CustomerTableAdapter();
            this.addressTableAdapter = new AssetManager.QrScannerDataSet14TableAdapters.AddressTableAdapter();
            this.bookingTableAdapter = new AssetManager.QrScannerDataSet15TableAdapters.BookingTableAdapter();
            this.qrScannerDataSet17 = new AssetManager.QrScannerDataSet17();
            this.itemTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTypeTableAdapter = new AssetManager.QrScannerDataSet17TableAdapters.ItemTypeTableAdapter();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabCustomers.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrScannerDataSet13)).BeginInit();
            this.tabUser.SuspendLayout();
            this.gpUsers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpbxAddUsers.SuspendLayout();
            this.tabItem.SuspendLayout();
            this.grpManageItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrScannerDataSet10)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrScannerDataSet14)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.grpBooking.SuspendLayout();
            this.grpBookingAddress.SuspendLayout();
            this.grpBookingItem.SuspendLayout();
            this.grpBookingCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrScannerDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrScannerDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrScannerDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_GetItemInfoTableAdapter
            // 
            this.sp_GetItemInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tabCustomers
            // 
            this.tabCustomers.BackColor = System.Drawing.Color.White;
            this.tabCustomers.Controls.Add(this.btnRemoveCustomer);
            this.tabCustomers.Controls.Add(this.btnEditCustomer);
            this.tabCustomers.Controls.Add(this.btnAddCustomer);
            this.tabCustomers.Controls.Add(this.grpCustomer);
            this.tabCustomers.Controls.Add(this.dgvCustomers);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Size = new System.Drawing.Size(861, 381);
            this.tabCustomers.TabIndex = 3;
            this.tabCustomers.Text = "Customes";
            this.tabCustomers.Click += new System.EventHandler(this.tabCustomers_Click);
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.Location = new System.Drawing.Point(194, 261);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(107, 23);
            this.btnRemoveCustomer.TabIndex = 5;
            this.btnRemoveCustomer.Text = "Remove Customer";
            this.btnRemoveCustomer.UseVisualStyleBackColor = true;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(95, 261);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(87, 23);
            this.btnEditCustomer.TabIndex = 4;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(8, 261);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(81, 23);
            this.btnAddCustomer.TabIndex = 3;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.label13);
            this.grpCustomer.Controls.Add(this.label12);
            this.grpCustomer.Controls.Add(this.label11);
            this.grpCustomer.Controls.Add(this.label10);
            this.grpCustomer.Controls.Add(this.label9);
            this.grpCustomer.Controls.Add(this.txtCustomerEmailAddress);
            this.grpCustomer.Controls.Add(this.txtContactNumber);
            this.grpCustomer.Controls.Add(this.txtCustomerSurname);
            this.grpCustomer.Controls.Add(this.txtCustomerName);
            this.grpCustomer.Controls.Add(this.txtCustomeID);
            this.grpCustomer.Controls.Add(this.btnCustomerCancel);
            this.grpCustomer.Controls.Add(this.btnCustomerEdit);
            this.grpCustomer.Controls.Add(this.btnCustomerAdd);
            this.grpCustomer.Enabled = false;
            this.grpCustomer.Location = new System.Drawing.Point(8, 3);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(293, 240);
            this.grpCustomer.TabIndex = 2;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Manage Customers";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Email Address:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Contact Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Surname:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Customer ID:";
            // 
            // txtCustomerEmailAddress
            // 
            this.txtCustomerEmailAddress.Location = new System.Drawing.Point(120, 161);
            this.txtCustomerEmailAddress.Name = "txtCustomerEmailAddress";
            this.txtCustomerEmailAddress.Size = new System.Drawing.Size(167, 20);
            this.txtCustomerEmailAddress.TabIndex = 7;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(120, 127);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(167, 20);
            this.txtContactNumber.TabIndex = 6;
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Location = new System.Drawing.Point(120, 95);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(167, 20);
            this.txtCustomerSurname.TabIndex = 5;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(120, 65);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(167, 20);
            this.txtCustomerName.TabIndex = 4;
            // 
            // txtCustomeID
            // 
            this.txtCustomeID.Enabled = false;
            this.txtCustomeID.Location = new System.Drawing.Point(120, 36);
            this.txtCustomeID.Name = "txtCustomeID";
            this.txtCustomeID.Size = new System.Drawing.Size(167, 20);
            this.txtCustomeID.TabIndex = 3;
            // 
            // btnCustomerCancel
            // 
            this.btnCustomerCancel.Location = new System.Drawing.Point(212, 211);
            this.btnCustomerCancel.Name = "btnCustomerCancel";
            this.btnCustomerCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerCancel.TabIndex = 2;
            this.btnCustomerCancel.Text = "Cancel";
            this.btnCustomerCancel.UseVisualStyleBackColor = true;
            this.btnCustomerCancel.Click += new System.EventHandler(this.btnCustomerCancel_Click);
            // 
            // btnCustomerEdit
            // 
            this.btnCustomerEdit.Location = new System.Drawing.Point(6, 211);
            this.btnCustomerEdit.Name = "btnCustomerEdit";
            this.btnCustomerEdit.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerEdit.TabIndex = 1;
            this.btnCustomerEdit.Text = "Edit";
            this.btnCustomerEdit.UseVisualStyleBackColor = true;
            this.btnCustomerEdit.Click += new System.EventHandler(this.btnCustomerEdit_Click);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Location = new System.Drawing.Point(6, 211);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerAdd.TabIndex = 0;
            this.btnCustomerAdd.Text = "Add ";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoGenerateColumns = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDataGridViewTextBoxColumn,
            this.cNumberDataGridViewTextBoxColumn,
            this.cNameDataGridViewTextBoxColumn,
            this.cSurnameDataGridViewTextBoxColumn,
            this.cEmailDataGridViewTextBoxColumn});
            this.dgvCustomers.DataSource = this.customerBindingSource1;
            this.dgvCustomers.Location = new System.Drawing.Point(307, 3);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(551, 358);
            this.dgvCustomers.TabIndex = 1;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "C_ID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "Customer ID";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNumberDataGridViewTextBoxColumn
            // 
            this.cNumberDataGridViewTextBoxColumn.DataPropertyName = "C_Number";
            this.cNumberDataGridViewTextBoxColumn.HeaderText = "Contact Number";
            this.cNumberDataGridViewTextBoxColumn.Name = "cNumberDataGridViewTextBoxColumn";
            this.cNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "C_Name";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            this.cNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cSurnameDataGridViewTextBoxColumn
            // 
            this.cSurnameDataGridViewTextBoxColumn.DataPropertyName = "C_Surname";
            this.cSurnameDataGridViewTextBoxColumn.HeaderText = "Customer Surname";
            this.cSurnameDataGridViewTextBoxColumn.Name = "cSurnameDataGridViewTextBoxColumn";
            this.cSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEmailDataGridViewTextBoxColumn
            // 
            this.cEmailDataGridViewTextBoxColumn.DataPropertyName = "C_Email";
            this.cEmailDataGridViewTextBoxColumn.HeaderText = "Customer Email";
            this.cEmailDataGridViewTextBoxColumn.Name = "cEmailDataGridViewTextBoxColumn";
            this.cEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.qrScannerDataSet13;
            // 
            // qrScannerDataSet13
            // 
            this.qrScannerDataSet13.DataSetName = "QrScannerDataSet13";
            this.qrScannerDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.gpUsers);
            this.tabUser.Location = new System.Drawing.Point(4, 22);
            this.tabUser.Name = "tabUser";
            this.tabUser.Size = new System.Drawing.Size(861, 381);
            this.tabUser.TabIndex = 2;
            this.tabUser.Text = "Users";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // gpUsers
            // 
            this.gpUsers.BackColor = System.Drawing.Color.Transparent;
            this.gpUsers.Controls.Add(this.groupBox1);
            this.gpUsers.Controls.Add(this.grpbxAddUsers);
            this.gpUsers.Location = new System.Drawing.Point(8, 11);
            this.gpUsers.Name = "gpUsers";
            this.gpUsers.Size = new System.Drawing.Size(845, 363);
            this.gpUsers.TabIndex = 0;
            this.gpUsers.TabStop = false;
            this.gpUsers.Text = "Manage Users";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstbxUsers);
            this.groupBox1.Controls.Add(this.btnAddUser);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Location = new System.Drawing.Point(15, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 324);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Useres";
            // 
            // lstbxUsers
            // 
            this.lstbxUsers.FormattingEnabled = true;
            this.lstbxUsers.Location = new System.Drawing.Point(26, 19);
            this.lstbxUsers.Name = "lstbxUsers";
            this.lstbxUsers.Size = new System.Drawing.Size(190, 238);
            this.lstbxUsers.TabIndex = 0;
            this.lstbxUsers.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAddUser
            // 
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddUser.Location = new System.Drawing.Point(26, 281);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(63, 23);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemove.Location = new System.Drawing.Point(159, 281);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(57, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Staff";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // grpbxAddUsers
            // 
            this.grpbxAddUsers.Controls.Add(this.txtUserID);
            this.grpbxAddUsers.Controls.Add(this.label6);
            this.grpbxAddUsers.Controls.Add(this.btnEdit);
            this.grpbxAddUsers.Controls.Add(this.btnAddUserType);
            this.grpbxAddUsers.Controls.Add(this.btnCancel);
            this.grpbxAddUsers.Controls.Add(this.btnAdd);
            this.grpbxAddUsers.Controls.Add(this.txtSurname);
            this.grpbxAddUsers.Controls.Add(this.txtUseranme);
            this.grpbxAddUsers.Controls.Add(this.txtPassword);
            this.grpbxAddUsers.Controls.Add(this.txtName);
            this.grpbxAddUsers.Controls.Add(this.label5);
            this.grpbxAddUsers.Controls.Add(this.label4);
            this.grpbxAddUsers.Controls.Add(this.label3);
            this.grpbxAddUsers.Controls.Add(this.label2);
            this.grpbxAddUsers.Controls.Add(this.label1);
            this.grpbxAddUsers.Controls.Add(this.cmbUserType);
            this.grpbxAddUsers.Enabled = false;
            this.grpbxAddUsers.Location = new System.Drawing.Point(333, 19);
            this.grpbxAddUsers.Name = "grpbxAddUsers";
            this.grpbxAddUsers.Size = new System.Drawing.Size(389, 324);
            this.grpbxAddUsers.TabIndex = 3;
            this.grpbxAddUsers.TabStop = false;
            this.grpbxAddUsers.Text = "Add User";
            this.grpbxAddUsers.UseCompatibleTextRendering = true;
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Location = new System.Drawing.Point(125, 29);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(156, 20);
            this.txtUserID.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(38, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "User ID:";
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnEdit.Location = new System.Drawing.Point(53, 281);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit User";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddUserType
            // 
            this.btnAddUserType.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAddUserType.Location = new System.Drawing.Point(288, 210);
            this.btnAddUserType.Name = "btnAddUserType";
            this.btnAddUserType.Size = new System.Drawing.Size(93, 23);
            this.btnAddUserType.TabIndex = 12;
            this.btnAddUserType.Text = "Add User Type";
            this.btnAddUserType.UseVisualStyleBackColor = true;
            this.btnAddUserType.Click += new System.EventHandler(this.btnAddUserType_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCancel.Location = new System.Drawing.Point(217, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnAdd.Location = new System.Drawing.Point(53, 281);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(125, 100);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(156, 20);
            this.txtSurname.TabIndex = 9;
            // 
            // txtUseranme
            // 
            this.txtUseranme.Location = new System.Drawing.Point(125, 135);
            this.txtUseranme.Name = "txtUseranme";
            this.txtUseranme.Size = new System.Drawing.Size(156, 20);
            this.txtUseranme.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(125, 173);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(156, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 20);
            this.txtName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(40, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "User Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(38, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(38, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // cmbUserType
            // 
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Location = new System.Drawing.Point(125, 210);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(157, 21);
            this.cmbUserType.TabIndex = 0;
            // 
            // tabItem
            // 
            this.tabItem.Controls.Add(this.btnManageItemTypes);
            this.tabItem.Controls.Add(this.btnRemoveItem);
            this.tabItem.Controls.Add(this.btnEditItem);
            this.tabItem.Controls.Add(this.grpManageItems);
            this.tabItem.Controls.Add(this.dgvItems);
            this.tabItem.Controls.Add(this.btnAddItem);
            this.tabItem.Location = new System.Drawing.Point(4, 22);
            this.tabItem.Name = "tabItem";
            this.tabItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabItem.Size = new System.Drawing.Size(861, 381);
            this.tabItem.TabIndex = 1;
            this.tabItem.Text = "Items";
            this.tabItem.UseVisualStyleBackColor = true;
            // 
            // btnManageItemTypes
            // 
            this.btnManageItemTypes.Location = new System.Drawing.Point(6, 333);
            this.btnManageItemTypes.Name = "btnManageItemTypes";
            this.btnManageItemTypes.Size = new System.Drawing.Size(119, 23);
            this.btnManageItemTypes.TabIndex = 16;
            this.btnManageItemTypes.Text = "Manage Item Types";
            this.btnManageItemTypes.UseVisualStyleBackColor = true;
            this.btnManageItemTypes.Click += new System.EventHandler(this.btnManageItemTypes_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(79, 184);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(86, 23);
            this.btnRemoveItem.TabIndex = 15;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Location = new System.Drawing.Point(171, 184);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(68, 23);
            this.btnEditItem.TabIndex = 14;
            this.btnEditItem.Text = "Edit Item";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // grpManageItems
            // 
            this.grpManageItems.Controls.Add(this.btnItemEdit);
            this.grpManageItems.Controls.Add(this.btnItemCancel);
            this.grpManageItems.Controls.Add(this.btnItemAdd);
            this.grpManageItems.Controls.Add(this.label7);
            this.grpManageItems.Controls.Add(this.radAvailability);
            this.grpManageItems.Controls.Add(this.txtQrCode);
            this.grpManageItems.Controls.Add(this.cmbItemType);
            this.grpManageItems.Controls.Add(this.label8);
            this.grpManageItems.Enabled = false;
            this.grpManageItems.Location = new System.Drawing.Point(6, 7);
            this.grpManageItems.Name = "grpManageItems";
            this.grpManageItems.Size = new System.Drawing.Size(234, 171);
            this.grpManageItems.TabIndex = 12;
            this.grpManageItems.TabStop = false;
            this.grpManageItems.Text = "Manage Items";
            // 
            // btnItemEdit
            // 
            this.btnItemEdit.Location = new System.Drawing.Point(19, 130);
            this.btnItemEdit.Name = "btnItemEdit";
            this.btnItemEdit.Size = new System.Drawing.Size(75, 23);
            this.btnItemEdit.TabIndex = 13;
            this.btnItemEdit.Text = "Edit";
            this.btnItemEdit.UseVisualStyleBackColor = true;
            this.btnItemEdit.Visible = false;
            this.btnItemEdit.Click += new System.EventHandler(this.btnItemEdit_Click);
            // 
            // btnItemCancel
            // 
            this.btnItemCancel.Location = new System.Drawing.Point(153, 130);
            this.btnItemCancel.Name = "btnItemCancel";
            this.btnItemCancel.Size = new System.Drawing.Size(75, 23);
            this.btnItemCancel.TabIndex = 12;
            this.btnItemCancel.Text = "Cancel";
            this.btnItemCancel.UseVisualStyleBackColor = true;
            this.btnItemCancel.Click += new System.EventHandler(this.btnItemCancel_Click);
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Location = new System.Drawing.Point(19, 130);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(75, 23);
            this.btnItemAdd.TabIndex = 11;
            this.btnItemAdd.Text = "Add";
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Visible = false;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(17, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Qr Code:";
            // 
            // radAvailability
            // 
            this.radAvailability.AutoSize = true;
            this.radAvailability.Location = new System.Drawing.Point(20, 53);
            this.radAvailability.Name = "radAvailability";
            this.radAvailability.Size = new System.Drawing.Size(74, 17);
            this.radAvailability.TabIndex = 9;
            this.radAvailability.TabStop = true;
            this.radAvailability.Text = "Availability";
            this.radAvailability.UseVisualStyleBackColor = true;
            this.radAvailability.CheckedChanged += new System.EventHandler(this.radAvailability_CheckedChanged);
            this.radAvailability.Click += new System.EventHandler(this.radAvailability_Click);
            // 
            // txtQrCode
            // 
            this.txtQrCode.Location = new System.Drawing.Point(83, 27);
            this.txtQrCode.Name = "txtQrCode";
            this.txtQrCode.Size = new System.Drawing.Size(145, 20);
            this.txtQrCode.TabIndex = 6;
            // 
            // cmbItemType
            // 
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Location = new System.Drawing.Point(83, 76);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(145, 21);
            this.cmbItemType.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(20, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Item Type:";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoGenerateColumns = false;
            this.dgvItems.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iQrCodeDataGridViewTextBoxColumn,
            this.iTTypeDataGridViewTextBoxColumn,
            this.iTDescriptionDataGridViewTextBoxColumn,
            this.iTPriceDataGridViewTextBoxColumn,
            this.iAvailabilityDataGridViewCheckBoxColumn});
            this.dgvItems.DataSource = this.spGetItemInfoBindingSource;
            this.dgvItems.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvItems.Location = new System.Drawing.Point(256, 7);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(597, 367);
            this.dgvItems.TabIndex = 0;
            this.dgvItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGWItems_CellClick);
            // 
            // iQrCodeDataGridViewTextBoxColumn
            // 
            this.iQrCodeDataGridViewTextBoxColumn.DataPropertyName = "I_QrCode";
            this.iQrCodeDataGridViewTextBoxColumn.HeaderText = "Qr Code";
            this.iQrCodeDataGridViewTextBoxColumn.Name = "iQrCodeDataGridViewTextBoxColumn";
            this.iQrCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTTypeDataGridViewTextBoxColumn
            // 
            this.iTTypeDataGridViewTextBoxColumn.DataPropertyName = "IT_Type";
            this.iTTypeDataGridViewTextBoxColumn.HeaderText = "Item Type";
            this.iTTypeDataGridViewTextBoxColumn.Name = "iTTypeDataGridViewTextBoxColumn";
            this.iTTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTDescriptionDataGridViewTextBoxColumn
            // 
            this.iTDescriptionDataGridViewTextBoxColumn.DataPropertyName = "IT_Description";
            this.iTDescriptionDataGridViewTextBoxColumn.HeaderText = "Item Description";
            this.iTDescriptionDataGridViewTextBoxColumn.Name = "iTDescriptionDataGridViewTextBoxColumn";
            this.iTDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTPriceDataGridViewTextBoxColumn
            // 
            this.iTPriceDataGridViewTextBoxColumn.DataPropertyName = "IT_Price";
            this.iTPriceDataGridViewTextBoxColumn.HeaderText = "Item Price";
            this.iTPriceDataGridViewTextBoxColumn.Name = "iTPriceDataGridViewTextBoxColumn";
            this.iTPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iAvailabilityDataGridViewCheckBoxColumn
            // 
            this.iAvailabilityDataGridViewCheckBoxColumn.DataPropertyName = "I_Availability";
            this.iAvailabilityDataGridViewCheckBoxColumn.HeaderText = "Item Availability";
            this.iAvailabilityDataGridViewCheckBoxColumn.Name = "iAvailabilityDataGridViewCheckBoxColumn";
            this.iAvailabilityDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // spGetItemInfoBindingSource
            // 
            this.spGetItemInfoBindingSource.DataMember = "sp_GetItemInfo";
            this.spGetItemInfoBindingSource.DataSource = this.qrScannerDataSet10;
            // 
            // qrScannerDataSet10
            // 
            this.qrScannerDataSet10.DataSetName = "QrScannerDataSet10";
            this.qrScannerDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(4, 184);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(69, 23);
            this.btnAddItem.TabIndex = 13;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabItem);
            this.tabMain.Controls.Add(this.tabUser);
            this.tabMain.Controls.Add(this.tabCustomers);
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Location = new System.Drawing.Point(1, 3);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(869, 407);
            this.tabMain.TabIndex = 0;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRemoveAddress);
            this.tabPage1.Controls.Add(this.btnAddAddress);
            this.tabPage1.Controls.Add(this.dgvAddress);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(861, 381);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Addresses";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAddress
            // 
            this.btnRemoveAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAddress.Location = new System.Drawing.Point(87, 352);
            this.btnRemoveAddress.Name = "btnRemoveAddress";
            this.btnRemoveAddress.Size = new System.Drawing.Size(101, 23);
            this.btnRemoveAddress.TabIndex = 3;
            this.btnRemoveAddress.Text = "Remove Address";
            this.btnRemoveAddress.UseVisualStyleBackColor = true;
            this.btnRemoveAddress.Click += new System.EventHandler(this.btnRemoveAddress_Click);
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAddress.Location = new System.Drawing.Point(8, 352);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(75, 23);
            this.btnAddAddress.TabIndex = 2;
            this.btnAddAddress.Text = "Add Address";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // dgvAddress
            // 
            this.dgvAddress.AllowUserToAddRows = false;
            this.dgvAddress.AllowUserToDeleteRows = false;
            this.dgvAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAddress.AutoGenerateColumns = false;
            this.dgvAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aIDDataGridViewTextBoxColumn,
            this.aLine1DataGridViewTextBoxColumn,
            this.aAddressCityDataGridViewTextBoxColumn,
            this.aPostalCodeDataGridViewTextBoxColumn,
            this.aLatitudeDataGridViewTextBoxColumn,
            this.aLongitudeDataGridViewTextBoxColumn});
            this.dgvAddress.DataSource = this.addressBindingSource1;
            this.dgvAddress.Location = new System.Drawing.Point(3, 3);
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.ReadOnly = true;
            this.dgvAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddress.Size = new System.Drawing.Size(855, 342);
            this.dgvAddress.TabIndex = 0;
            // 
            // aIDDataGridViewTextBoxColumn
            // 
            this.aIDDataGridViewTextBoxColumn.DataPropertyName = "A_ID";
            this.aIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.aIDDataGridViewTextBoxColumn.Name = "aIDDataGridViewTextBoxColumn";
            this.aIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aLine1DataGridViewTextBoxColumn
            // 
            this.aLine1DataGridViewTextBoxColumn.DataPropertyName = "A_Line1";
            this.aLine1DataGridViewTextBoxColumn.HeaderText = "Address Line";
            this.aLine1DataGridViewTextBoxColumn.Name = "aLine1DataGridViewTextBoxColumn";
            this.aLine1DataGridViewTextBoxColumn.ReadOnly = true;
            this.aLine1DataGridViewTextBoxColumn.Width = 200;
            // 
            // aAddressCityDataGridViewTextBoxColumn
            // 
            this.aAddressCityDataGridViewTextBoxColumn.DataPropertyName = "A_Address_City";
            this.aAddressCityDataGridViewTextBoxColumn.HeaderText = "City";
            this.aAddressCityDataGridViewTextBoxColumn.Name = "aAddressCityDataGridViewTextBoxColumn";
            this.aAddressCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aPostalCodeDataGridViewTextBoxColumn
            // 
            this.aPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "A_PostalCode";
            this.aPostalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            this.aPostalCodeDataGridViewTextBoxColumn.Name = "aPostalCodeDataGridViewTextBoxColumn";
            this.aPostalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aLatitudeDataGridViewTextBoxColumn
            // 
            this.aLatitudeDataGridViewTextBoxColumn.DataPropertyName = "A_Latitude";
            this.aLatitudeDataGridViewTextBoxColumn.HeaderText = "Latitude";
            this.aLatitudeDataGridViewTextBoxColumn.Name = "aLatitudeDataGridViewTextBoxColumn";
            this.aLatitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aLongitudeDataGridViewTextBoxColumn
            // 
            this.aLongitudeDataGridViewTextBoxColumn.DataPropertyName = "A_Longitude";
            this.aLongitudeDataGridViewTextBoxColumn.HeaderText = "Longitude";
            this.aLongitudeDataGridViewTextBoxColumn.Name = "aLongitudeDataGridViewTextBoxColumn";
            this.aLongitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressBindingSource1
            // 
            this.addressBindingSource1.DataMember = "Address";
            this.addressBindingSource1.DataSource = this.qrScannerDataSet14;
            // 
            // qrScannerDataSet14
            // 
            this.qrScannerDataSet14.DataSetName = "QrScannerDataSet14";
            this.qrScannerDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpBooking);
            this.tabPage2.Controls.Add(this.grpBookingAddress);
            this.tabPage2.Controls.Add(this.grpBookingItem);
            this.tabPage2.Controls.Add(this.grpBookingCustomer);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(861, 381);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Bookings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpBooking
            // 
            this.grpBooking.Controls.Add(this.btnBookingCancel);
            this.grpBooking.Controls.Add(this.btnCreateBooking);
            this.grpBooking.Controls.Add(this.label15);
            this.grpBooking.Controls.Add(this.label14);
            this.grpBooking.Controls.Add(this.dtpExpiryDate);
            this.grpBooking.Controls.Add(this.dtpTodaysDate);
            this.grpBooking.Location = new System.Drawing.Point(9, 3);
            this.grpBooking.Name = "grpBooking";
            this.grpBooking.Size = new System.Drawing.Size(391, 143);
            this.grpBooking.TabIndex = 7;
            this.grpBooking.TabStop = false;
            this.grpBooking.Text = "Booking";
            // 
            // btnBookingCancel
            // 
            this.btnBookingCancel.Location = new System.Drawing.Point(302, 106);
            this.btnBookingCancel.Name = "btnBookingCancel";
            this.btnBookingCancel.Size = new System.Drawing.Size(75, 23);
            this.btnBookingCancel.TabIndex = 8;
            this.btnBookingCancel.Text = "Cancel";
            this.btnBookingCancel.UseVisualStyleBackColor = true;
            this.btnBookingCancel.Click += new System.EventHandler(this.btnBookingCancel_Click);
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.Location = new System.Drawing.Point(18, 106);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(90, 23);
            this.btnCreateBooking.TabIndex = 7;
            this.btnCreateBooking.Text = "Add Booking";
            this.btnCreateBooking.UseCompatibleTextRendering = true;
            this.btnCreateBooking.UseVisualStyleBackColor = true;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Booking Expiry Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Todays Date:";
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Location = new System.Drawing.Point(177, 58);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(200, 20);
            this.dtpExpiryDate.TabIndex = 2;
            // 
            // dtpTodaysDate
            // 
            this.dtpTodaysDate.Enabled = false;
            this.dtpTodaysDate.Location = new System.Drawing.Point(177, 19);
            this.dtpTodaysDate.Name = "dtpTodaysDate";
            this.dtpTodaysDate.Size = new System.Drawing.Size(200, 20);
            this.dtpTodaysDate.TabIndex = 1;
            // 
            // grpBookingAddress
            // 
            this.grpBookingAddress.Controls.Add(this.cbAddress);
            this.grpBookingAddress.Controls.Add(this.btnExistingAddress);
            this.grpBookingAddress.Controls.Add(this.btnNewAddress);
            this.grpBookingAddress.Location = new System.Drawing.Point(11, 217);
            this.grpBookingAddress.Name = "grpBookingAddress";
            this.grpBookingAddress.Size = new System.Drawing.Size(391, 58);
            this.grpBookingAddress.TabIndex = 6;
            this.grpBookingAddress.TabStop = false;
            this.grpBookingAddress.Text = "Select Address";
            // 
            // cbAddress
            // 
            this.cbAddress.AutoSize = true;
            this.cbAddress.Enabled = false;
            this.cbAddress.Location = new System.Drawing.Point(17, 25);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(109, 17);
            this.cbAddress.TabIndex = 2;
            this.cbAddress.Text = "Address Selected";
            this.cbAddress.UseVisualStyleBackColor = true;
            // 
            // btnExistingAddress
            // 
            this.btnExistingAddress.Location = new System.Drawing.Point(269, 19);
            this.btnExistingAddress.Name = "btnExistingAddress";
            this.btnExistingAddress.Size = new System.Drawing.Size(108, 23);
            this.btnExistingAddress.TabIndex = 1;
            this.btnExistingAddress.Text = "Existing Address";
            this.btnExistingAddress.UseVisualStyleBackColor = true;
            this.btnExistingAddress.Click += new System.EventHandler(this.btnExistingAddress_Click);
            // 
            // btnNewAddress
            // 
            this.btnNewAddress.Location = new System.Drawing.Point(155, 19);
            this.btnNewAddress.Name = "btnNewAddress";
            this.btnNewAddress.Size = new System.Drawing.Size(102, 23);
            this.btnNewAddress.TabIndex = 0;
            this.btnNewAddress.Text = "New Address";
            this.btnNewAddress.UseVisualStyleBackColor = true;
            this.btnNewAddress.Click += new System.EventHandler(this.btnNewAddress_Click);
            // 
            // grpBookingItem
            // 
            this.grpBookingItem.Controls.Add(this.cbItem);
            this.grpBookingItem.Controls.Add(this.btnSelectItem);
            this.grpBookingItem.Location = new System.Drawing.Point(11, 281);
            this.grpBookingItem.Name = "grpBookingItem";
            this.grpBookingItem.Size = new System.Drawing.Size(391, 57);
            this.grpBookingItem.TabIndex = 5;
            this.grpBookingItem.TabStop = false;
            this.grpBookingItem.Text = "Select Item";
            // 
            // cbItem
            // 
            this.cbItem.AutoSize = true;
            this.cbItem.Enabled = false;
            this.cbItem.Location = new System.Drawing.Point(18, 24);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(88, 17);
            this.cbItem.TabIndex = 1;
            this.cbItem.Text = "ItemSelected";
            this.cbItem.UseVisualStyleBackColor = true;
            // 
            // btnSelectItem
            // 
            this.btnSelectItem.Location = new System.Drawing.Point(155, 20);
            this.btnSelectItem.Name = "btnSelectItem";
            this.btnSelectItem.Size = new System.Drawing.Size(100, 23);
            this.btnSelectItem.TabIndex = 0;
            this.btnSelectItem.Text = "Select Item";
            this.btnSelectItem.UseVisualStyleBackColor = true;
            this.btnSelectItem.Click += new System.EventHandler(this.btnSelectItem_Click);
            // 
            // grpBookingCustomer
            // 
            this.grpBookingCustomer.Controls.Add(this.cbCustomer);
            this.grpBookingCustomer.Controls.Add(this.btnExistingCustomer);
            this.grpBookingCustomer.Controls.Add(this.btnNewCustomer);
            this.grpBookingCustomer.Location = new System.Drawing.Point(9, 152);
            this.grpBookingCustomer.Name = "grpBookingCustomer";
            this.grpBookingCustomer.Size = new System.Drawing.Size(393, 59);
            this.grpBookingCustomer.TabIndex = 4;
            this.grpBookingCustomer.TabStop = false;
            this.grpBookingCustomer.Text = "Select Customer";
            // 
            // cbCustomer
            // 
            this.cbCustomer.AutoSize = true;
            this.cbCustomer.Enabled = false;
            this.cbCustomer.Location = new System.Drawing.Point(19, 29);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(115, 17);
            this.cbCustomer.TabIndex = 2;
            this.cbCustomer.Text = "Customer Selected";
            this.cbCustomer.UseVisualStyleBackColor = true;
            // 
            // btnExistingCustomer
            // 
            this.btnExistingCustomer.Location = new System.Drawing.Point(269, 23);
            this.btnExistingCustomer.Name = "btnExistingCustomer";
            this.btnExistingCustomer.Size = new System.Drawing.Size(110, 23);
            this.btnExistingCustomer.TabIndex = 1;
            this.btnExistingCustomer.Text = "Existing Customer";
            this.btnExistingCustomer.UseVisualStyleBackColor = true;
            this.btnExistingCustomer.Click += new System.EventHandler(this.btnExistingCustomer_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(155, 23);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(102, 23);
            this.btnNewCustomer.TabIndex = 0;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bIDDataGridViewTextBoxColumn,
            this.bDateDataGridViewTextBoxColumn,
            this.bExpiryDateDataGridViewTextBoxColumn,
            this.bStatusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.bookingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(410, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(445, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // bIDDataGridViewTextBoxColumn
            // 
            this.bIDDataGridViewTextBoxColumn.DataPropertyName = "B_ID";
            this.bIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.bIDDataGridViewTextBoxColumn.Name = "bIDDataGridViewTextBoxColumn";
            this.bIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDateDataGridViewTextBoxColumn
            // 
            this.bDateDataGridViewTextBoxColumn.DataPropertyName = "B_Date";
            this.bDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.bDateDataGridViewTextBoxColumn.Name = "bDateDataGridViewTextBoxColumn";
            this.bDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bExpiryDateDataGridViewTextBoxColumn
            // 
            this.bExpiryDateDataGridViewTextBoxColumn.DataPropertyName = "B_ExpiryDate";
            this.bExpiryDateDataGridViewTextBoxColumn.HeaderText = "ExpiryDate";
            this.bExpiryDateDataGridViewTextBoxColumn.Name = "bExpiryDateDataGridViewTextBoxColumn";
            this.bExpiryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bStatusDataGridViewCheckBoxColumn
            // 
            this.bStatusDataGridViewCheckBoxColumn.DataPropertyName = "B_Status";
            this.bStatusDataGridViewCheckBoxColumn.HeaderText = "Booking Status";
            this.bStatusDataGridViewCheckBoxColumn.Name = "bStatusDataGridViewCheckBoxColumn";
            this.bStatusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.qrScannerDataSet15;
            // 
            // qrScannerDataSet15
            // 
            this.qrScannerDataSet15.DataSetName = "QrScannerDataSet15";
            this.qrScannerDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qrScannerDataSet12
            // 
            this.qrScannerDataSet12.DataSetName = "QrScannerDataSet12";
            this.qrScannerDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.qrScannerDataSet12;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // addressTableAdapter
            // 
            this.addressTableAdapter.ClearBeforeFill = true;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // qrScannerDataSet17
            // 
            this.qrScannerDataSet17.DataSetName = "QrScannerDataSet17";
            this.qrScannerDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTypeBindingSource
            // 
            this.itemTypeBindingSource.DataMember = "ItemType";
            this.itemTypeBindingSource.DataSource = this.qrScannerDataSet17;
            // 
            // itemTypeTableAdapter
            // 
            this.itemTypeTableAdapter.ClearBeforeFill = true;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataMember = "Address";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(869, 411);
            this.Controls.Add(this.tabMain);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabCustomers.ResumeLayout(false);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrScannerDataSet13)).EndInit();
            this.tabUser.ResumeLayout(false);
            this.gpUsers.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpbxAddUsers.ResumeLayout(false);
            this.grpbxAddUsers.PerformLayout();
            this.tabItem.ResumeLayout(false);
            this.grpManageItems.ResumeLayout(false);
            this.grpManageItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrScannerDataSet10)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrScannerDataSet14)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.grpBooking.ResumeLayout(false);
            this.grpBooking.PerformLayout();
            this.grpBookingAddress.ResumeLayout(false);
            this.grpBookingAddress.PerformLayout();
            this.grpBookingItem.ResumeLayout(false);
            this.grpBookingItem.PerformLayout();
            this.grpBookingCustomer.ResumeLayout(false);
            this.grpBookingCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrScannerDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrScannerDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrScannerDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private QrScannerDataSet10TableAdapters.sp_GetItemInfoTableAdapter sp_GetItemInfoTableAdapter;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.GroupBox gpUsers;
        private System.Windows.Forms.GroupBox grpbxAddUsers;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddUserType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtUseranme;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ListBox lstbxUsers;
        private System.Windows.Forms.TabPage tabItem;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.BindingSource spGetItemInfoBindingSource;
        private QrScannerDataSet10 qrScannerDataSet10;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn iQrCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn iAvailabilityDataGridViewCheckBoxColumn;
        private System.Windows.Forms.RadioButton radAvailability;
        private System.Windows.Forms.TextBox txtQrCode;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.GroupBox grpManageItems;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnManageItemTypes;
        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.Button btnItemEdit;
        private System.Windows.Forms.Button btnItemCancel;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private QrScannerDataSet12 qrScannerDataSet12;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private QrScannerDataSet12TableAdapters.CustomerTableAdapter customerTableAdapter;
        private QrScannerDataSet13 qrScannerDataSet13;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private QrScannerDataSet13TableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRemoveCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustomerEmailAddress;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomeID;
        private System.Windows.Forms.Button btnCustomerCancel;
        private System.Windows.Forms.Button btnCustomerEdit;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvAddress;
       
        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.Button btnRemoveAddress;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private QrScannerDataSet14 qrScannerDataSet14;
        private System.Windows.Forms.BindingSource addressBindingSource1;
        private QrScannerDataSet14TableAdapters.AddressTableAdapter addressTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLine1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aAddressCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPostalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLatitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLongitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QrScannerDataSet15 qrScannerDataSet15;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private QrScannerDataSet15TableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bExpiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.GroupBox grpBooking;
        private System.Windows.Forms.Button btnBookingCancel;
        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.DateTimePicker dtpTodaysDate;
        private System.Windows.Forms.GroupBox grpBookingAddress;
        private System.Windows.Forms.CheckBox cbAddress;
        private System.Windows.Forms.Button btnExistingAddress;
        private System.Windows.Forms.Button btnNewAddress;
        private System.Windows.Forms.GroupBox grpBookingItem;
        private System.Windows.Forms.CheckBox cbItem;
        private System.Windows.Forms.Button btnSelectItem;
        private System.Windows.Forms.GroupBox grpBookingCustomer;
        private System.Windows.Forms.CheckBox cbCustomer;
        private System.Windows.Forms.Button btnExistingCustomer;
        private System.Windows.Forms.Button btnNewCustomer;
        private QrScannerDataSet17 qrScannerDataSet17;
        private System.Windows.Forms.BindingSource itemTypeBindingSource;
        private QrScannerDataSet17TableAdapters.ItemTypeTableAdapter itemTypeTableAdapter;
    }
}