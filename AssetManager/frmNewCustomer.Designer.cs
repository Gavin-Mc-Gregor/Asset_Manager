namespace AssetManager
{
    partial class frmNewCustomer
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
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.grpCustomer.SuspendLayout();
            this.SuspendLayout();
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
            this.grpCustomer.Controls.Add(this.btnCustomerAdd);
            this.grpCustomer.Location = new System.Drawing.Point(12, 12);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(293, 240);
            this.grpCustomer.TabIndex = 3;
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
            // frmNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 263);
            this.Controls.Add(this.grpCustomer);
            this.Name = "frmNewCustomer";
            this.Text = "frmNewCustomer";
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomer;
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
        private System.Windows.Forms.Button btnCustomerAdd;
    }
}