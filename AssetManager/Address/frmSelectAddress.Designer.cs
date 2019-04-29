namespace AssetManager
{
    partial class frmSelectAddress
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
            this.txtAddressSearch = new System.Windows.Forms.TextBox();
            this.btnItemAddressCancel = new System.Windows.Forms.Button();
            this.btnSelectAddress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAddressItems = new System.Windows.Forms.DataGridView();
            this.aIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLine1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aAddressCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLatitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLongitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectAddressDataSource = new AssetManager.SelectAddressDataSource();
            this.addressTableAdapter = new AssetManager.SelectAddressDataSourceTableAdapters.AddressTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddressItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAddressDataSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddressSearch
            // 
            this.txtAddressSearch.Location = new System.Drawing.Point(145, 15);
            this.txtAddressSearch.Name = "txtAddressSearch";
            this.txtAddressSearch.Size = new System.Drawing.Size(202, 20);
            this.txtAddressSearch.TabIndex = 18;
            this.txtAddressSearch.TextChanged += new System.EventHandler(this.txtAddressSearch_TextChanged);
            // 
            // btnItemAddressCancel
            // 
            this.btnItemAddressCancel.Location = new System.Drawing.Point(583, 444);
            this.btnItemAddressCancel.Name = "btnItemAddressCancel";
            this.btnItemAddressCancel.Size = new System.Drawing.Size(75, 23);
            this.btnItemAddressCancel.TabIndex = 17;
            this.btnItemAddressCancel.Text = "Cancel";
            this.btnItemAddressCancel.UseVisualStyleBackColor = true;
            this.btnItemAddressCancel.Click += new System.EventHandler(this.btnItemAddressCancel_Click_1);
            // 
            // btnSelectAddress
            // 
            this.btnSelectAddress.Location = new System.Drawing.Point(15, 444);
            this.btnSelectAddress.Name = "btnSelectAddress";
            this.btnSelectAddress.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAddress.TabIndex = 16;
            this.btnSelectAddress.Text = "Select Address";
            this.btnSelectAddress.UseVisualStyleBackColor = true;
            this.btnSelectAddress.Click += new System.EventHandler(this.btnSelectAddress_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Search by address name:";
            // 
            // dgvAddressItems
            // 
            this.dgvAddressItems.AllowUserToAddRows = false;
            this.dgvAddressItems.AllowUserToDeleteRows = false;
            this.dgvAddressItems.AutoGenerateColumns = false;
            this.dgvAddressItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddressItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aIDDataGridViewTextBoxColumn,
            this.aLine1DataGridViewTextBoxColumn,
            this.aAddressCityDataGridViewTextBoxColumn,
            this.aLatitudeDataGridViewTextBoxColumn,
            this.aLongitudeDataGridViewTextBoxColumn,
            this.aPostalCodeDataGridViewTextBoxColumn});
            this.dgvAddressItems.DataSource = this.addressBindingSource;
            this.dgvAddressItems.Location = new System.Drawing.Point(12, 47);
            this.dgvAddressItems.Name = "dgvAddressItems";
            this.dgvAddressItems.ReadOnly = true;
            this.dgvAddressItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddressItems.Size = new System.Drawing.Size(646, 391);
            this.dgvAddressItems.TabIndex = 14;
            // 
            // aIDDataGridViewTextBoxColumn
            // 
            this.aIDDataGridViewTextBoxColumn.DataPropertyName = "A_ID";
            this.aIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.aIDDataGridViewTextBoxColumn.Name = "aIDDataGridViewTextBoxColumn";
            this.aIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aIDDataGridViewTextBoxColumn.Width = 40;
            // 
            // aLine1DataGridViewTextBoxColumn
            // 
            this.aLine1DataGridViewTextBoxColumn.DataPropertyName = "A_Line1";
            this.aLine1DataGridViewTextBoxColumn.HeaderText = "Address Line";
            this.aLine1DataGridViewTextBoxColumn.Name = "aLine1DataGridViewTextBoxColumn";
            this.aLine1DataGridViewTextBoxColumn.ReadOnly = true;
            this.aLine1DataGridViewTextBoxColumn.Width = 160;
            // 
            // aAddressCityDataGridViewTextBoxColumn
            // 
            this.aAddressCityDataGridViewTextBoxColumn.DataPropertyName = "A_Address_City";
            this.aAddressCityDataGridViewTextBoxColumn.HeaderText = "City";
            this.aAddressCityDataGridViewTextBoxColumn.Name = "aAddressCityDataGridViewTextBoxColumn";
            this.aAddressCityDataGridViewTextBoxColumn.ReadOnly = true;
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
            // aPostalCodeDataGridViewTextBoxColumn
            // 
            this.aPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "A_PostalCode";
            this.aPostalCodeDataGridViewTextBoxColumn.HeaderText = "Postal Code";
            this.aPostalCodeDataGridViewTextBoxColumn.Name = "aPostalCodeDataGridViewTextBoxColumn";
            this.aPostalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataMember = "Address";
            this.addressBindingSource.DataSource = this.selectAddressDataSource;
            // 
            // selectAddressDataSource
            // 
            this.selectAddressDataSource.DataSetName = "SelectAddressDataSource";
            this.selectAddressDataSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressTableAdapter
            // 
            this.addressTableAdapter.ClearBeforeFill = true;
            // 
            // frmSelectAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 476);
            this.Controls.Add(this.txtAddressSearch);
            this.Controls.Add(this.btnItemAddressCancel);
            this.Controls.Add(this.btnSelectAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAddressItems);
            this.Name = "frmSelectAddress";
            this.Text = "frmSelectAddress";
            this.Load += new System.EventHandler(this.frmSelectAddress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddressItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAddressDataSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddressSearch;
        private System.Windows.Forms.Button btnItemAddressCancel;
        private System.Windows.Forms.Button btnSelectAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAddressItems;
        private SelectAddressDataSource selectAddressDataSource;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private SelectAddressDataSourceTableAdapters.AddressTableAdapter addressTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLine1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aAddressCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLatitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLongitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPostalCodeDataGridViewTextBoxColumn;
    }
}