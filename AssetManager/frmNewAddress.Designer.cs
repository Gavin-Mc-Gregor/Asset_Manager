namespace AssetManager
{
    partial class frmNewAddress
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.btnCancel);
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
            this.grpAddress.TabIndex = 3;
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(240, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmNewAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 267);
            this.Controls.Add(this.grpAddress);
            this.Name = "frmNewAddress";
            this.Text = "frmNewAddress";
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.Button btnValidateAddress;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.TextBox txtStreetNyumber;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCancel;
    }
}