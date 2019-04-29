using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManager
{
    class CItem
    {
      

        public CItem(int iQrCode, int iItemTypeID, bool bAvailability)
        {
            
        }

        public CItem()
        {
        }

        public int EditItem(SqlConnection conn ,int QrCode, bool bAvailability, string sItemTypeName)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-DPSO24P\GAVIN_SERVER;Initial Catalog=QrScanner;Integrated Security=True");
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("sp_EditItem", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@QrCode", QrCode);
                cmd.Parameters.AddWithValue("@Availability", bAvailability);
                cmd.Parameters.AddWithValue("@ItemTypeName", sItemTypeName);

                SqlParameter Message = new SqlParameter("@Message", SqlDbType.VarChar);
                Message.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(Message);
                cmd.ExecuteNonQuery();
                int sMessage = (int)Message.Value;
                conn.Close();
                return sMessage;
            }
        }

        public int RemoveItem(SqlConnection conn, int ItemID)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-DPSO24P\GAVIN_SERVER;Initial Catalog=QrScanner;Integrated Security=True");
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("sp_RemoveItem", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@ItemID", ItemID);
               
                SqlParameter Message = new SqlParameter("@Message", SqlDbType.VarChar);
                Message.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(Message);
                cmd.ExecuteNonQuery();
                int sMessage = (int)Message.Value;
                conn.Close();
                return sMessage;
            }

        }
        public int AddItem(SqlConnection conn , bool bAvailability, string sItemType )
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-DPSO24P\GAVIN_SERVER;Initial Catalog=QrScanner;Integrated Security=True");
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("sp_AddItem", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

               
                cmd.Parameters.AddWithValue("@Availability", bAvailability);
                cmd.Parameters.AddWithValue("@ItemType", sItemType);
                


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
