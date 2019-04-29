using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManager
{
    class CUserType
    {
        private string sUserType;

        public CUserType(string _sUserType)
        {
            sUserType = _sUserType;
        }
        public CUserType()
        {
           
        }

        public string getUsertype()
        {
            return sUserType;
        }

        public int AddUserType(SqlConnection conn, string UserType)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-DPSO24P\GAVIN_SERVER;Initial Catalog=QrScanner;Integrated Security=True");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("sp_AddUsersTypes", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserType", UserType);
                SqlParameter Message = new SqlParameter("@Message", SqlDbType.Int);
                Message.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(Message);
                cmd.ExecuteNonQuery();
                int sMessage = (int)Message.Value;
                conn.Close();
                return sMessage;
            }
        }
        public List<CUserType> GetCUserTypes(SqlConnection conn)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-DPSO24P\GAVIN_SERVER;Initial Catalog=QrScanner;Integrated Security=True");
            List<CUserType> list = new List<CUserType>();
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("select * from UserType", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new CUserType(reader["UT_UserType"].ToString()));
                }
                 conn.Close();
                return list;
               
            }
            

        }
        
    }
}
