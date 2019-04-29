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
    
    public partial class frmSelectItem : Form
    {
        public static int ItemID;
        public frmSelectItem()
        {
            InitializeComponent();
            PopulateComboBox();
        }

        private void frmSelectItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qrScannerDataSet16.sp_GetItemInfo' table. You can move, or remove it, as needed.
            this.sp_GetItemInfoTableAdapter.Fill(this.qrScannerDataSet16.sp_GetItemInfo);

        }
        private void cmbItemSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            CConnection cc = CConnection.GetConnectionInstance();
            SqlConnection conn = cc.GetConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ItemTypeSearch", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Search", cmbItemSearch.SelectedItem.ToString());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvSelectItems.DataSource = dt;
            conn.Close();
        }
        void PopulateComboBox()
        {
            cmbItemSearch.Items.Clear();
            CItemType itemType = new CItemType();
            foreach (CItemType type in itemType.GetItemTypes())
            {
                cmbItemSearch.Items.Add(type.GetTypeName());
            }
        }

        private void btnItemSelectCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectItem_Click(object sender, EventArgs e)
        {
            if (dgvSelectItems.SelectedRows.Count > 0)
            {


                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are you sure you want to select this item?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int iSelectedRow = dgvSelectItems.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedrow = dgvSelectItems.Rows[iSelectedRow];
                    ItemID = int.Parse(selectedrow.Cells[0].Value.ToString());
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select an item first.", "Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmSelectItem_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }
    }
}
