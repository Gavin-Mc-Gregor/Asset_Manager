using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManager.Booking
{
    public class CBooking
    {
        CConnection cc = CConnection.GetConnectionInstance();
        private int iBookingID;
        private DateTime dtBookingDate;
        private DateTime dtExpirtyDate;
        private bool bStatus;

        public CBooking()
        {
        }

        public CBooking(DateTime dtBookingDate, DateTime dtExpirtyDate)
        {
            this.dtBookingDate = dtBookingDate;
            this.dtExpirtyDate = dtExpirtyDate;
        }

        public CBooking(int iBookingID, DateTime dtBookingDate, DateTime dtExpirtyDate, bool bStatus)
        {
            this.iBookingID = iBookingID;
            this.dtBookingDate = dtBookingDate;
            this.dtExpirtyDate = dtExpirtyDate;
            this.bStatus = bStatus;
        }

        public int CreateBooking(DateTime BookingDate, DateTime ExpiryDate)
        {
            SqlConnection conn =  cc.GetConnection();            
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("sp_CreateBooking", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@BookingDate", BookingDate);
                cmd.Parameters.AddWithValue("@ExpiryDate",ExpiryDate);
                cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                int iID = Convert.ToInt32(cmd.Parameters["@ID"].Value);  
                conn.Close();
                return iID;
            }

        }
    }
}
