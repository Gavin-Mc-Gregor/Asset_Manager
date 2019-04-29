namespace AssetManager
{
    partial class frmSelectCustomer
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
            this.btnItemSelectCancel = new System.Windows.Forms.Button();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSelectCustomer = new System.Windows.Forms.DataGridView();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.qrScannerDataSet19 = new AssetManager.QrScannerDataSet19();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new AssetManager.QrScannerDataSet19TableAdapters.CustomerTableAdapter();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrScannerDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnItemSelectCancel
            // 
            this.btnItemSelectCancel.Location = new System.Drawing.Point(484, 444);
            this.btnItemSelectCancel.Name = "btnItemSelectCancel";
            this.btnItemSelectCancel.Size = new System.Drawing.Size(75, 23);
            this.btnItemSelectCancel.TabIndex = 12;
            this.btnItemSelectCancel.Text = "Cancel";
            this.btnItemSelectCancel.UseVisualStyleBackColor = true;
            this.btnItemSelectCancel.Click += new System.EventHandler(this.btnItemSelectCancel_Click);
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Location = new System.Drawing.Point(15, 444);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnSelectCustomer.TabIndex = 11;
            this.btnSelectCustomer.Text = "Select Customer";
            this.btnSelectCustomer.UseVisualStyleBackColor = true;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search customer by name:";
            // 
            // dgvSelectCustomer
            // 
            this.dgvSelectCustomer.AllowUserToAddRows = false;
            this.dgvSelectCustomer.AllowUserToDeleteRows = false;
            this.dgvSelectCustomer.AutoGenerateColumns = false;
            this.dgvSelectCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDataGridViewTextBoxColumn,
            this.cNumberDataGridViewTextBoxColumn,
            this.cNameDataGridViewTextBoxColumn,
            this.cSurnameDataGridViewTextBoxColumn,
            this.cEmailDataGridViewTextBoxColumn});
            this.dgvSelectCustomer.DataSource = this.customerBindingSource;
            this.dgvSelectCustomer.Location = new System.Drawing.Point(12, 47);
            this.dgvSelectCustomer.Name = "dgvSelectCustomer";
            this.dgvSelectCustomer.ReadOnly = true;
            this.dgvSelectCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectCustomer.Size = new System.Drawing.Size(547, 391);
            this.dgvSelectCustomer.TabIndex = 8;
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Location = new System.Drawing.Point(151, 15);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(209, 20);
            this.txtCustomerSearch.TabIndex = 13;
            this.txtCustomerSearch.TextChanged += new System.EventHandler(this.txtCustomerSearch_TextChanged);
            // 
            // qrScannerDataSet19
            // 
            this.qrScannerDataSet19.DataSetName = "QrScannerDataSet19";
            this.qrScannerDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.qrScannerDataSet19;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "C_ID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIDDataGridViewTextBoxColumn.Width = 40;
            // 
            // cNumberDataGridViewTextBoxColumn
            // 
            this.cNumberDataGridViewTextBoxColumn.DataPropertyName = "C_Number";
            this.cNumberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.cNumberDataGridViewTextBoxColumn.Name = "cNumberDataGridViewTextBoxColumn";
            this.cNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "C_Name";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            this.cNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // cSurnameDataGridViewTextBoxColumn
            // 
            this.cSurnameDataGridViewTextBoxColumn.DataPropertyName = "C_Surname";
            this.cSurnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.cSurnameDataGridViewTextBoxColumn.Name = "cSurnameDataGridViewTextBoxColumn";
            this.cSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cSurnameDataGridViewTextBoxColumn.Width = 120;
            // 
            // cEmailDataGridViewTextBoxColumn
            // 
            this.cEmailDataGridViewTextBoxColumn.DataPropertyName = "C_Email";
            this.cEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.cEmailDataGridViewTextBoxColumn.Name = "cEmailDataGridViewTextBoxColumn";
            this.cEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.cEmailDataGridViewTextBoxColumn.Width = 120;
            // 
            // frmSelectCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 477);
            this.Controls.Add(this.txtCustomerSearch);
            this.Controls.Add(this.btnItemSelectCancel);
            this.Controls.Add(this.btnSelectCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSelectCustomer);
            this.Name = "frmSelectCustomer";
            this.Text = "frmSelectCustomer";
            this.Load += new System.EventHandler(this.frmSelectCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrScannerDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnItemSelectCancel;
        private System.Windows.Forms.Button btnSelectCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSelectCustomer;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private QrScannerDataSet19 qrScannerDataSet19;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private QrScannerDataSet19TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmailDataGridViewTextBoxColumn;
    }
}