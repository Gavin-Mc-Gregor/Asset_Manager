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
    public partial class frmSelectAddress : Form
    {
        public static int iAddressID;
        public frmSelectAddress()
        {
            InitializeComponent();
        }

        private void frmSelectAddress_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'selectAddressDataSource.Address' table. You can move, or remove it, as needed.
            this.addressTableAdapter.Fill(this.selectAddressDataSource.Address);

        }

        private void txtAddressSearch_TextChanged(object sender, EventArgs e)
        {
            CConnection cc = CConnection.GetConnectionInstance();
            SqlConnection conn = cc.GetConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_AddressSearch", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SearchValue", txtAddressSearch.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvAddressItems.DataSource = dt;
            conn.Close();
        }

        private void btnItemAddressCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectAddress_Click_1(object sender, EventArgs e)
        {
            if (dgvAddressItems.SelectedRows.Count > 0)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are you sure you want to select this address?", "are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int RowIndex = dgvAddressItems.SelectedCells[0].RowIndex;
                    DataGridViewRow row = dgvAddressItems.Rows[RowIndex];
                    iAddressID = int.Parse(row.Cells[0].Value.ToString());
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select an address.", "Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

