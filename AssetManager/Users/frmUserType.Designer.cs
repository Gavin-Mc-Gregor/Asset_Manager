namespace AssetManager
{
    partial class frmUserType
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserType = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddUserType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter new user type.";
            // 
            // txtUserType
            // 
            this.txtUserType.Location = new System.Drawing.Point(15, 50);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(170, 20);
            this.txtUserType.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(110, 89);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddUserType
            // 
            this.btnAddUserType.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddUserType.Location = new System.Drawing.Point(15, 89);
            this.btnAddUserType.Name = "btnAddUserType";
            this.btnAddUserType.Size = new System.Drawing.Size(75, 23);
            this.btnAddUserType.TabIndex = 2;
            this.btnAddUserType.Text = "Add";
            this.btnAddUserType.UseVisualStyleBackColor = true;
            this.btnAddUserType.Click += new System.EventHandler(this.btnAddUserType_Click);
            // 
            // frmUserType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 133);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddUserType);
            this.Controls.Add(this.txtUserType);
            this.Controls.Add(this.label1);
            this.Name = "frmUserType";
            this.Text = "Add User Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddUserType;
    }
}