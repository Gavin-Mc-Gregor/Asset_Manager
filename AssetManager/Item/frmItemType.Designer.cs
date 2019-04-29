namespace AssetManager
{
    partial class frmItemType
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
            this.grpManageItemTypes = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemType = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRemoveItemType = new System.Windows.Forms.Button();
            this.btnAddItemType = new System.Windows.Forms.Button();
            this.dgvItemTypes = new System.Windows.Forms.DataGridView();
            this.iTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qrScannerDataSet11 = new AssetManager.QrScannerDataSet11();
            this.itemTypeTableAdapter = new AssetManager.QrScannerDataSet11TableAdapters.ItemTypeTableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEditItemType = new System.Windows.Forms.Button();
            this.grpManageItemTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrScannerDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // grpManageItemTypes
            // 
            this.grpManageItemTypes.Controls.Add(this.btnEdit);
            this.grpManageItemTypes.Controls.Add(this.btnCancel);
            this.grpManageItemTypes.Controls.Add(this.btnAdd);
            this.grpManageItemTypes.Controls.Add(this.label2);
            this.grpManageItemTypes.Controls.Add(this.txtItemType);
            this.grpManageItemTypes.Controls.Add(this.txtItemID);
            this.grpManageItemTypes.Controls.Add(this.label1);
            this.grpManageItemTypes.Controls.Add(this.txtDesc);
            this.grpManageItemTypes.Controls.Add(this.label10);
            this.grpManageItemTypes.Controls.Add(this.txtPrice);
            this.grpManageItemTypes.Controls.Add(this.label9);
            this.grpManageItemTypes.Enabled = false;
            this.grpManageItemTypes.Location = new System.Drawing.Point(12, 12);
            this.grpManageItemTypes.Name = "grpManageItemTypes";
            this.grpManageItemTypes.Size = new System.Drawing.Size(240, 324);
            this.grpManageItemTypes.TabIndex = 17;
            this.grpManageItemTypes.TabStop = false;
            this.grpManageItemTypes.Text = "Manage Item Types";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(13, 295);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(153, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 295);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Item Type:";
            // 
            // txtItemType
            // 
            this.txtItemType.Location = new System.Drawing.Point(83, 65);
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.Size = new System.Drawing.Size(145, 20);
            this.txtItemType.TabIndex = 11;
            // 
            // txtItemID
            // 
            this.txtItemID.Enabled = false;
            this.txtItemID.Location = new System.Drawing.Point(83, 29);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(145, 20);
            this.txtItemID.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Item type ID:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(13, 157);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(208, 131);
            this.txtDesc.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label10.Location = new System.Drawing.Point(10, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(83, 109);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(145, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(10, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Description:";
            // 
            // btnRemoveItemType
            // 
            this.btnRemoveItemType.Location = new System.Drawing.Point(147, 342);
            this.btnRemoveItemType.Name = "btnRemoveItemType";
            this.btnRemoveItemType.Size = new System.Drawing.Size(105, 23);
            this.btnRemoveItemType.TabIndex = 19;
            this.btnRemoveItemType.Text = "Remove Item Type";
            this.btnRemoveItemType.UseVisualStyleBackColor = true;
            this.btnRemoveItemType.Click += new System.EventHandler(this.btnRemoveItemType_Click);
            // 
            // btnAddItemType
            // 
            this.btnAddItemType.Location = new System.Drawing.Point(12, 342);
            this.btnAddItemType.Name = "btnAddItemType";
            this.btnAddItemType.Size = new System.Drawing.Size(105, 23);
            this.btnAddItemType.TabIndex = 18;
            this.btnAddItemType.Text = "Add Item Types";
            this.btnAddItemType.UseVisualStyleBackColor = true;
            this.btnAddItemType.Click += new System.EventHandler(this.btnAddItemType_Click);
            // 
            // dgvItemTypes
            // 
            this.dgvItemTypes.AllowUserToAddRows = false;
            this.dgvItemTypes.AllowUserToDeleteRows = false;
            this.dgvItemTypes.AutoGenerateColumns = false;
            this.dgvItemTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iTIDDataGridViewTextBoxColumn,
            this.iTTypeDataGridViewTextBoxColumn,
            this.iTPriceDataGridViewTextBoxColumn,
            this.iTDescriptionDataGridViewTextBoxColumn});
            this.dgvItemTypes.DataSource = this.itemTypeBindingSource;
            this.dgvItemTypes.Location = new System.Drawing.Point(258, 12);
            this.dgvItemTypes.Name = "dgvItemTypes";
            this.dgvItemTypes.ReadOnly = true;
            this.dgvItemTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemTypes.Size = new System.Drawing.Size(449, 426);
            this.dgvItemTypes.TabIndex = 20;
            this.dgvItemTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataviewItemTypes_CellClick);
            // 
            // iTIDDataGridViewTextBoxColumn
            // 
            this.iTIDDataGridViewTextBoxColumn.DataPropertyName = "IT_ID";
            this.iTIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iTIDDataGridViewTextBoxColumn.Name = "iTIDDataGridViewTextBoxColumn";
            this.iTIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTTypeDataGridViewTextBoxColumn
            // 
            this.iTTypeDataGridViewTextBoxColumn.DataPropertyName = "IT_Type";
            this.iTTypeDataGridViewTextBoxColumn.HeaderText = "Item Type";
            this.iTTypeDataGridViewTextBoxColumn.Name = "iTTypeDataGridViewTextBoxColumn";
            this.iTTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTPriceDataGridViewTextBoxColumn
            // 
            this.iTPriceDataGridViewTextBoxColumn.DataPropertyName = "IT_Price";
            this.iTPriceDataGridViewTextBoxColumn.HeaderText = "Item Price";
            this.iTPriceDataGridViewTextBoxColumn.Name = "iTPriceDataGridViewTextBoxColumn";
            this.iTPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTDescriptionDataGridViewTextBoxColumn
            // 
            this.iTDescriptionDataGridViewTextBoxColumn.DataPropertyName = "IT_Description";
            this.iTDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.iTDescriptionDataGridViewTextBoxColumn.Name = "iTDescriptionDataGridViewTextBoxColumn";
            this.iTDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemTypeBindingSource
            // 
            this.itemTypeBindingSource.DataMember = "ItemType";
            this.itemTypeBindingSource.DataSource = this.qrScannerDataSet11;
            // 
            // qrScannerDataSet11
            // 
            this.qrScannerDataSet11.DataSetName = "QrScannerDataSet11";
            this.qrScannerDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTypeTableAdapter
            // 
            this.itemTypeTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEditItemType
            // 
            this.btnEditItemType.Location = new System.Drawing.Point(147, 371);
            this.btnEditItemType.Name = "btnEditItemType";
            this.btnEditItemType.Size = new System.Drawing.Size(105, 23);
            this.btnEditItemType.TabIndex = 22;
            this.btnEditItemType.Text = "Edit Item Type";
            this.btnEditItemType.UseVisualStyleBackColor = true;
            this.btnEditItemType.Click += new System.EventHandler(this.btnEditItemType_Click);
            // 
            // frmItemType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 448);
            this.Controls.Add(this.btnEditItemType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvItemTypes);
            this.Controls.Add(this.btnRemoveItemType);
            this.Controls.Add(this.btnAddItemType);
            this.Controls.Add(this.grpManageItemTypes);
            this.Name = "frmItemType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmItemType";
            this.Load += new System.EventHandler(this.frmItemType_Load);
            this.grpManageItemTypes.ResumeLayout(false);
            this.grpManageItemTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrScannerDataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpManageItemTypes;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRemoveItemType;
        private System.Windows.Forms.Button btnAddItemType;
        private System.Windows.Forms.DataGridView dgvItemTypes;
        private QrScannerDataSet11 qrScannerDataSet11;
        private System.Windows.Forms.BindingSource itemTypeBindingSource;
        private QrScannerDataSet11TableAdapters.ItemTypeTableAdapter itemTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemType;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEditItemType;
    }
}