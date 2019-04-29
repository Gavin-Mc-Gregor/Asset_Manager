
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManager
{

   
    public partial class frmLogin : Form
    {
        

        CLogin login = CLogin.GetInstance();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (login.DoLogin(txtUserName.Text, txtPassword.Text) == 1)
            {
                login.SetUser(txtUserName.Text);
                this.Hide();
                frmMain main = new frmMain();
                main.Show();
                
            }
            else
                MessageBox.Show("Invalid User Name or Password!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
