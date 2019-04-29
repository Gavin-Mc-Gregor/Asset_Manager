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
    public partial class frmItemType : Form
    {
        CItemType itemType;
        SqlConnection conn;
        public frmItemType()
        {
            InitializeComponent();
        }

        private void frmItemType_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            itemType = new CItemType();
            this.itemTypeTableAdapter.Fill(this.qrScannerDataSet11.ItemType);
            txtItemID.Enabled = false;
            if(dgvItemTypes.Rows.Count > 0)
            dgvItemTypes.Rows[0].Selected = true;
        }

        private void dataviewItemTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvItemTypes.Rows[e.RowIndex];
                txtItemID.Text = row.Cells[0].Value.ToString();
                txtItemType.Text = row.Cells[1].Value.ToString();
                txtPrice.Text = row.Cells[2].Value.ToString();
                txtDesc.Text = row.Cells[3].Value.ToString();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditItemType_Click(object sender, EventArgs e)
        {
            if (dgvItemTypes.SelectedRows.Count >= 1 && txtItemID.Text != "")
            {
                btnEdit.Visible = true;
                btnAdd.Visible = false;
                LayoutChangeState();
            }
            else
                MessageBox.Show("Please select an item to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddItemType_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            txtItemID.Text = "Generated automatially";
            btnEdit.Visible = false;
            btnAdd.Visible = true;
            LayoutChangeState();
        }
        private void LayoutChangeState()
        {
            if(grpManageItemTypes.Enabled == false)
            {
                dgvItemTypes.Enabled = false;
                grpManageItemTypes.Enabled = true;
                btnAddItemType.Enabled = false;
                btnEditItemType.Enabled = false;
                btnRemoveItemType.Enabled = false;
            }
            else
            {
                dgvItemTypes.Enabled = true;
                grpManageItemTypes.Enabled = false;
                btnAddItemType.Enabled = true;
                btnEditItemType.Enabled = true;
                btnRemoveItemType.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LayoutChangeState();
        }
        private void ClearTextBoxes()
        {
            txtItemID.Clear();
            txtDesc.Clear();
            txtItemType.Clear();
            txtPrice.Clear();
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            decimal Parsedvalue;
            
            if (decimal.TryParse(txtPrice.Text.ToString(), out Parsedvalue))
            {
                
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are you sure you wan to add this Item Type?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                { 
                    itemType = new CItemType();
                    int isValid;
                    isValid = itemType.AddItemType(conn, txtItemType.Text.ToString(), Convert.ToDecimal(txtPrice.Text) , txtDesc.Text.ToString());
                    if (isValid == 1)
                    {
                        MessageBox.Show("Item type successfully added.");
                        LayoutChangeState();
                        RefreshDataSouce();
                    }
                    else
                        MessageBox.Show("Item type already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
                MessageBox.Show("The price feild is a numeric only feild.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void RefreshDataSouce()
        {
            DataTable dt = new DataTable();
            conn = new SqlConnection(@"Data Source=DESKTOP-DPSO24P\GAVIN_SERVER;Initial Catalog=QrScanner;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_GetItemTypes", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvItemTypes.DataSource = dt;
        }

        private void btnRemoveItemType_Click(object sender, EventArgs e)
        {
            if (dgvItemTypes.SelectedRows.Count >= 1 && txtItemID.Text != "")
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are you sure you want to remove this item type?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int isValid;
                    isValid = itemType.RemoveItemType(conn, Convert.ToInt32(txtItemID.Text));
                    if (isValid == 1)
                    {
                        MessageBox.Show("Item type was removes successfully.");
                        RefreshDataSouce();
                    }
                    else
                        MessageBox.Show("Item Type was not removed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Please select an item to Remove.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are you sure you want to Update this item type?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int isValid;
                    isValid = itemType.EditItemTpye(conn, Convert.ToInt32(txtItemID.Text), txtItemType.Text.ToString(), Convert.ToDecimal(txtPrice.Text), txtDesc.Text.ToString());
                    if (isValid == 1)
                    {
                        MessageBox.Show("Item type was updated successfully.");
                        RefreshDataSouce();
                    }
                    else
                        MessageBox.Show("Item Type was not updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
        }
    }

}
