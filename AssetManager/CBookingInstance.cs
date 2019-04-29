using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManager
{
    public class CBookingInstance
    {
        public int iAddressID;
        public int iCustomerID;
        public int iBookingID;
        public int iItemID;
        public int iUserID;

        public CBookingInstance()
        {
        }

        public CBookingInstance(int iAddressID, int iCustomerID, int iBookingID, int iItemID, int iUserID)
        {
            this.iAddressID = iAddressID;
            this.iCustomerID = iCustomerID;
            this.iBookingID = iBookingID;
            this.iItemID = iItemID;
            this.iUserID = iUserID;
        }

        public int CreateBookingInstance()
        {
            CConnection cc = CConnection.GetConnectionInstance();
            SqlConnection conn = cc.GetConnection();

            SqlCommand cmd = new SqlCommand("sp_CreateBookingInstance", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerID", iCustomerID);
            cmd.Parameters.AddWithValue("@AddressID", iAddressID);
            cmd.Parameters.AddWithValue("@BookingID", iBookingID);
            cmd.Parameters.AddWithValue("@UserID", iUserID);
            cmd.Parameters.AddWithValue("@ItemID", iItemID);

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
