using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManager
{
    public partial class frmUserType : Form
    {
        public string sType { get; set; }

        public frmUserType()
        {
            InitializeComponent();
        }

        private void btnAddUserType_Click(object sender, EventArgs e)
        {
            sType = txtUserType.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
