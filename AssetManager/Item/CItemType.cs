using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManager
{
    class CItemType
    {
        private int ItemTypeID;
        private decimal ItemPrice;
        private string sDescription;
        private string sItemType;

        public CItemType()
        {

        }
        public string GetTypeName()
        {
            return sItemType;
        }
        public CItemType(int itemTypeID, decimal itemPrice, string sDescription, string sItemType)
        {
            ItemTypeID = itemTypeID;
            ItemPrice = itemPrice;
            this.sDescription = sDescription;
            this.sItemType = sItemType;
        }
        public CItemType(string _sItemType)
        {
            sItemType = _sItemType;
        }

        public List<CItemType> GetItemTypes()
        {
            CConnection cc = CConnection.GetConnectionInstance();
            SqlConnection conn = cc.GetConnection();
            List<CItemType> list = new List<CItemType>();
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("select * from ItemType", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new CItemType(reader["IT_Type"].ToString()));
                }
                conn.Close();
                return list;

            }

        }
        public int AddItemType(SqlConnection conn , string sItemTypeName, decimal mprice, string sDescription)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-DPSO24P\GAVIN_SERVER;Initial Catalog=QrScanner;Integrated Security=True");
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("sp_AddItemType", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ItemType", sItemTypeName);
                cmd.Parameters.AddWithValue("@Price", mprice);
                cmd.Parameters.AddWithValue("@Description", sDescription);



                SqlParameter Message = new SqlParameter("@Message", SqlDbType.VarChar);
                Message.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(Message);
                cmd.ExecuteNonQuery();
                int sMessage = (int)Message.Value;
                conn.Close();
                return sMessage;
            }
        }
        public int RemoveItemType(SqlConnection conn, int iItemTypeId)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-DPSO24P\GAVIN_SERVER;Initial Catalog=QrScanner;Integrated Security=True");
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("sp_RemoveItemType", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ItemTypeID", iItemTypeId);
                

                SqlParameter Message = new SqlParameter("@Message", SqlDbType.VarChar);
                Message.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(Message);
                cmd.ExecuteNonQuery();
                int sMessage = (int)Message.Value;
                conn.Close();
                return sMessage;
            }
        }
        public int EditItemTpye(SqlConnection conn, int ItemTypeID, string sItemTypeName,decimal mPrice, string sDescription)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-DPSO24P\GAVIN_SERVER;Initial Catalog=QrScanner;Integrated Security=True");
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("sp_EditItemType", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ItemTypeID", ItemTypeID);
                cmd.Parameters.AddWithValue("@ItemType", sItemTypeName);
                cmd.Parameters.AddWithValue("@Price", mPrice);
                cmd.Parameters.AddWithValue("@Description", sDescription);

                SqlParameter Message = new SqlParameter("@Message", SqlDbType.VarChar);
                Message.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(Message);
                cmd.ExecuteNonQuery();
                int sMessage = (int)Message.Value;
                conn.Close();
                return sMessage;
            }
        }
      
    }
}
