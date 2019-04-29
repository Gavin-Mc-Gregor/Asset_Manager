using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManager
{
    class CCustomer
    {
        private int iCustomerID;
        private string sCustomerName;
        private string sCustomerSurname;
        private string sCustomerEmail;

        public CCustomer(int iCustomerID, string sCustomerName, string sCustomerSurname, string sCustomerEmail)
        {
            this.iCustomerID = iCustomerID;
            this.sCustomerName = sCustomerName;
            this.sCustomerSurname = sCustomerSurname;
            this.sCustomerEmail = sCustomerEmail;
        }

        public CCustomer()
        {
        }

        public CCustomer(int iCustomerID)
        {
            this.iCustomerID = iCustomerID;
        }

        public List<int> AddCustomer(SqlConnection conn, string _sCustomerName, string _sCustomerSurname, string _sCustomerEmail, string _sCustomerNumber)
        {
            List<int> iList = new List<int>();
            conn = new SqlConnection(@"Data Source=DESKTOP-DPSO24P\GAVIN_SERVER;Initial Catalog=QrScanner;Integrated Security=True");
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("sp_AddCustomer", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@CustomerNumber", _sCustomerNumber);
                cmd.Parameters.AddWithValue("@CustomerName", _sCustomerName);
                cmd.Parameters.AddWithValue("@CustomerSurname", _sCustomerSurname);
                cmd.Parameters.AddWithValue("@CustomerEmail", _sCustomerEmail);
                cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;



                SqlParameter Message = new SqlParameter("@Message", SqlDbType.VarChar);
                Message.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(Message);
                cmd.ExecuteNonQuery();
                iList.Add((int)Message.Value);
                iList.Add(Convert.ToInt32(cmd.Parameters["@ID"].Value));
                conn.Close();
                return iList;
            }
        }

        public int EditCustomer(SqlConnection conn , int _iCustomerID, string _sCustomerName, string _sCustomerSurname, string _sCustomerNumber, string _sCustomerEmail)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-DPSO24P\GAVIN_SERVER;Initial Catalog=QrScanner;Integrated Security=True");
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("sp_EditCustomer", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustomerID", _iCustomerID);
                cmd.Parameters.AddWithValue("@CustomerNumber", _sCustomerNumber);
                cmd.Parameters.AddWithValue("@CustomerName", _sCustomerName);
                cmd.Parameters.AddWithValue("@CustomerSurname", _sCustomerSurname);
                cmd.Parameters.AddWithValue("@CustomerEmail", _sCustomerEmail);

                SqlParameter Message = new SqlParameter("@Message", SqlDbType.VarChar);
                Message.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(Message);
                cmd.ExecuteNonQuery();
                int sMessage = (int)Message.Value;
                conn.Close();
                return sMessage;
            }
        }

        public int RemoveCustomer(SqlConnection conn, int _iCustomerID)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-DPSO24P\GAVIN_SERVER;Initial Catalog=QrScanner;Integrated Security=True");
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("sp_RemoveCustomer", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustomerID", _iCustomerID);
               
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
