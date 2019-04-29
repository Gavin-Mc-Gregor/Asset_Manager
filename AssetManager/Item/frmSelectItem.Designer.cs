namespace AssetManager
{
    partial class frmSelectItem
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
            this.dgvSelectItems = new System.Windows.Forms.DataGridView();
            this.iQrCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iAvailabilityDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.spGetItemInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qrScannerDataSet16 = new AssetManager.QrScannerDataSet16();
            this.sp_GetItemInfoTableAdapter = new AssetManager.QrScannerDataSet16TableAdapters.sp_GetItemInfoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbItemSearch = new System.Windows.Forms.ComboBox();
            this.btnSelectItem = new System.Windows.Forms.Button();
            this.btnItemSelectCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrScannerDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelectItems
            // 
            this.dgvSelectItems.AllowUserToAddRows = false;
            this.dgvSelectItems.AllowUserToDeleteRows = false;
            this.dgvSelectItems.AutoGenerateColumns = false;
            this.dgvSelectItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iQrCodeDataGridViewTextBoxColumn,
            this.iTTypeDataGridViewTextBoxColumn,
            this.iTDescriptionDataGridViewTextBoxColumn,
            this.iTPriceDataGridViewTextBoxColumn,
            this.iAvailabilityDataGridViewCheckBoxColumn});
            this.dgvSelectItems.DataSource = this.spGetItemInfoBindingSource;
            this.dgvSelectItems.Location = new System.Drawing.Point(12, 47);
            this.dgvSelectItems.Name = "dgvSelectItems";
            this.dgvSelectItems.ReadOnly = true;
            this.dgvSelectItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectItems.Size = new System.Drawing.Size(547, 391);
            this.dgvSelectItems.TabIndex = 0;
            // 
            // iQrCodeDataGridViewTextBoxColumn
            // 
            this.iQrCodeDataGridViewTextBoxColumn.DataPropertyName = "I_QrCode";
            this.iQrCodeDataGridViewTextBoxColumn.HeaderText = "QrCode";
            this.iQrCodeDataGridViewTextBoxColumn.Name = "iQrCodeDataGridViewTextBoxColumn";
            this.iQrCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTTypeDataGridViewTextBoxColumn
            // 
            this.iTTypeDataGridViewTextBoxColumn.DataPropertyName = "IT_Type";
            this.iTTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.iTTypeDataGridViewTextBoxColumn.Name = "iTTypeDataGridViewTextBoxColumn";
            this.iTTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTDescriptionDataGridViewTextBoxColumn
            // 
            this.iTDescriptionDataGridViewTextBoxColumn.DataPropertyName = "IT_Description";
            this.iTDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.iTDescriptionDataGridViewTextBoxColumn.Name = "iTDescriptionDataGridViewTextBoxColumn";
            this.iTDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTPriceDataGridViewTextBoxColumn
            // 
            this.iTPriceDataGridViewTextBoxColumn.DataPropertyName = "IT_Price";
            this.iTPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.iTPriceDataGridViewTextBoxColumn.Name = "iTPriceDataGridViewTextBoxColumn";
            this.iTPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iAvailabilityDataGridViewCheckBoxColumn
            // 
            this.iAvailabilityDataGridViewCheckBoxColumn.DataPropertyName = "I_Availability";
            this.iAvailabilityDataGridViewCheckBoxColumn.HeaderText = "Availability";
            this.iAvailabilityDataGridViewCheckBoxColumn.Name = "iAvailabilityDataGridViewCheckBoxColumn";
            this.iAvailabilityDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // spGetItemInfoBindingSource
            // 
            this.spGetItemInfoBindingSource.DataMember = "sp_GetItemInfo";
            this.spGetItemInfoBindingSource.DataSource = this.qrScannerDataSet16;
            // 
            // qrScannerDataSet16
            // 
            this.qrScannerDataSet16.DataSetName = "QrScannerDataSet16";
            this.qrScannerDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_GetItemInfoTableAdapter
            // 
            this.sp_GetItemInfoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by item type:";
            // 
            // cmbItemSearch
            // 
            this.cmbItemSearch.FormattingEnabled = true;
            this.cmbItemSearch.Location = new System.Drawing.Point(121, 15);
            this.cmbItemSearch.Name = "cmbItemSearch";
            this.cmbItemSearch.Size = new System.Drawing.Size(143, 21);
            this.cmbItemSearch.TabIndex = 5;
            this.cmbItemSearch.SelectedIndexChanged += new System.EventHandler(this.cmbItemSearch_SelectedIndexChanged);
            // 
            // btnSelectItem
            // 
            this.btnSelectItem.Location = new System.Drawing.Point(15, 444);
            this.btnSelectItem.Name = "btnSelectItem";
            this.btnSelectItem.Size = new System.Drawing.Size(75, 23);
            this.btnSelectItem.TabIndex = 6;
            this.btnSelectItem.Text = "Select Item";
            this.btnSelectItem.UseVisualStyleBackColor = true;
            this.btnSelectItem.Click += new System.EventHandler(this.btnSelectItem_Click);
            // 
            // btnItemSelectCancel
            // 
            this.btnItemSelectCancel.Location = new System.Drawing.Point(484, 444);
            this.btnItemSelectCancel.Name = "btnItemSelectCancel";
            this.btnItemSelectCancel.Size = new System.Drawing.Size(75, 23);
            this.btnItemSelectCancel.TabIndex = 7;
            this.btnItemSelectCancel.Text = "Cancel";
            this.btnItemSelectCancel.UseVisualStyleBackColor = true;
            this.btnItemSelectCancel.Click += new System.EventHandler(this.btnItemSelectCancel_Click);
            // 
            // frmSelectItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 476);
            this.Controls.Add(this.btnItemSelectCancel);
            this.Controls.Add(this.btnSelectItem);
            this.Controls.Add(this.cmbItemSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSelectItems);
            this.Name = "frmSelectItem";
            this.Text = "frmSelectItem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSelectItem_FormClosed);
            this.Load += new System.EventHandler(this.frmSelectItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrScannerDataSet16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelectItems;
        private QrScannerDataSet16 qrScannerDataSet16;
        private System.Windows.Forms.BindingSource spGetItemInfoBindingSource;
        private QrScannerDataSet16TableAdapters.sp_GetItemInfoTableAdapter sp_GetItemInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iQrCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn iAvailabilityDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbItemSearch;
        private System.Windows.Forms.Button btnSelectItem;
        private System.Windows.Forms.Button btnItemSelectCancel;
    }
}