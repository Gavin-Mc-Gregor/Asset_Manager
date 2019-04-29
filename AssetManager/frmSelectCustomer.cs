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
    public partial class frmSelectCustomer : Form
    {
        public static int iCustomerID;
        public frmSelectCustomer()
        {
            InitializeComponent();
        }

        private void frmSelectCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qrScannerDataSet19.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.qrScannerDataSet19.Customer);

        }

        private void btnItemSelectCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            CConnection cc = CConnection.GetConnectionInstance();
            DataTable dt = new DataTable();
            SqlConnection conn = cc.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_CustomerSearch", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SearchValue", txtCustomerSearch.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvSelectCustomer.DataSource = dt;
            conn.Close();
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            if (dgvSelectCustomer.SelectedRows.Count > 0)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are you sure you want to select this customer?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int iRowIndex = dgvSelectCustomer.SelectedCells[0].RowIndex;
                    DataGridViewRow row = dgvSelectCustomer.Rows[iRowIndex];
                    iCustomerID = int.Parse(row.Cells[0].Value.ToString());
                    this.Close();
                }
            }
            else
                MessageBox.Show("Please select a row", "Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
