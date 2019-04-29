namespace AssetManager
{
    partial class frmAddAddress
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
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.btnValidateAddress = new System.Windows.Forms.Button();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtStreetNyumber = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gMapBingMap = new GMap.NET.WindowsForms.GMapControl();
            this.grpAddressInfo = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpAddress.SuspendLayout();
            this.grpAddressInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.btnValidateAddress);
            this.grpAddress.Controls.Add(this.txtPostalCode);
            this.grpAddress.Controls.Add(this.txtCity);
            this.grpAddress.Controls.Add(this.txtAddressLine1);
            this.grpAddress.Controls.Add(this.txtStreetNyumber);
            this.grpAddress.Controls.Add(this.label19);
            this.grpAddress.Controls.Add(this.label18);
            this.grpAddress.Controls.Add(this.label17);
            this.grpAddress.Controls.Add(this.label15);
            this.grpAddress.Location = new System.Drawing.Point(12, 12);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(321, 247);
            this.grpAddress.TabIndex = 2;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Manage Addresses";
            // 
            // btnValidateAddress
            // 
            this.btnValidateAddress.Location = new System.Drawing.Point(9, 205);
            this.btnValidateAddress.Name = "btnValidateAddress";
            this.btnValidateAddress.Size = new System.Drawing.Size(106, 23);
            this.btnValidateAddress.TabIndex = 16;
            this.btnValidateAddress.Text = "Validate Address";
            this.btnValidateAddress.UseVisualStyleBackColor = true;
            this.btnValidateAddress.Click += new System.EventHandler(this.btnValidateAddress_Click);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(97, 146);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(218, 20);
            this.txtPostalCode.TabIndex = 15;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(97, 120);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(218, 20);
            this.txtCity.TabIndex = 14;
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(97, 65);
            this.txtAddressLine1.Multiline = true;
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(218, 49);
            this.txtAddressLine1.TabIndex = 12;
            // 
            // txtStreetNyumber
            // 
            this.txtStreetNyumber.Location = new System.Drawing.Point(97, 39);
            this.txtStreetNyumber.Name = "txtStreetNyumber";
            this.txtStreetNyumber.Size = new System.Drawing.Size(218, 20);
            this.txtStreetNyumber.TabIndex = 11;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 123);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "City:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Postal Code:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Address Line:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Street Number:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 537);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(9, 150);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(75, 23);
            this.btnAddAddress.TabIndex = 1;
            this.btnAddAddress.Text = "Add";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(147, 57);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(168, 20);
            this.txtLongitude.TabIndex = 16;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(147, 35);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(168, 20);
            this.txtLatitude.TabIndex = 17;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(9, 87);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(306, 57);
            this.txtAddress.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Latitude:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Longitude:";
            // 
            // gMapBingMap
            // 
            this.gMapBingMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapBingMap.Bearing = 0F;
            this.gMapBingMap.CanDragMap = true;
            this.gMapBingMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapBingMap.GrayScaleMode = false;
            this.gMapBingMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapBingMap.LevelsKeepInMemmory = 5;
            this.gMapBingMap.Location = new System.Drawing.Point(339, -2);
            this.gMapBingMap.MarkersEnabled = true;
            this.gMapBingMap.MaxZoom = 2;
            this.gMapBingMap.MinZoom = 2;
            this.gMapBingMap.MouseWheelZoomEnabled = true;
            this.gMapBingMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapBingMap.Name = "gMapBingMap";
            this.gMapBingMap.NegativeMode = false;
            this.gMapBingMap.PolygonsEnabled = true;
            this.gMapBingMap.RetryLoadTile = 0;
            this.gMapBingMap.RoutesEnabled = true;
            this.gMapBingMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapBingMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapBingMap.ShowTileGridLines = false;
            this.gMapBingMap.Size = new System.Drawing.Size(675, 576);
            this.gMapBingMap.TabIndex = 22;
            this.gMapBingMap.Zoom = 0D;
            // 
            // grpAddressInfo
            // 
            this.grpAddressInfo.Controls.Add(this.btnCancel);
            this.grpAddressInfo.Controls.Add(this.txtAddress);
            this.grpAddressInfo.Controls.Add(this.btnAddAddress);
            this.grpAddressInfo.Controls.Add(this.label2);
            this.grpAddressInfo.Controls.Add(this.txtLongitude);
            this.grpAddressInfo.Controls.Add(this.label1);
            this.grpAddressInfo.Controls.Add(this.txtLatitude);
            this.grpAddressInfo.Enabled = false;
            this.grpAddressInfo.Location = new System.Drawing.Point(12, 265);
            this.grpAddressInfo.Name = "grpAddressInfo";
            this.grpAddressInfo.Size = new System.Drawing.Size(321, 183);
            this.grpAddressInfo.TabIndex = 23;
            this.grpAddressInfo.TabStop = false;
            this.grpAddressInfo.Text = "Validated Address";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(240, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 572);
            this.Controls.Add(this.grpAddressInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gMapBingMap);
            this.Controls.Add(this.grpAddress);
            this.Name = "frmAddAddress";
            this.Text = "Add Address";
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.grpAddressInfo.ResumeLayout(false);
            this.grpAddressInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.TextBox txtStreetNyumber;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private GMap.NET.WindowsForms.GMapControl gMapBingMap;
        private System.Windows.Forms.Button btnValidateAddress;
        private System.Windows.Forms.GroupBox grpAddressInfo;
        private System.Windows.Forms.Button btnCancel;
    }
}