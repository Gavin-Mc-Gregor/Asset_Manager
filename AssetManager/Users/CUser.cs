using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManager
{
    class CUser
    {
        private static CUser UniqueLogin;
        public int sID;
        public string sUserName;
        public string sPassword;
        public string sName;
        public string sSurname;
        public string sUserType;
        
        
        
        CUser(string _sName, string _sSurname, string _sUserName, string _sPassword, string _sUserType)
        {
            sName = _sName;
            sSurname = _sSurname;
            sUserName = _sUserName;
            sPassword = _sPassword;
            sUserType = _sUserType;
        }
        CUser(int _sID, string _sName, string _sSurname, string _sUserName, string _sPassword, string _sUserType)
        {
            sID = _sID;
            sName = _sName;
            sSurname = _sSurname;
            sUserName = _sUserName;
            sPassword = _sPassword;
            sUserType = _sUserType;
        }
        private CUser(string _sName, string _sSurname, string _sUserName)
        {
            sName = _sName;
            sSurname = _sSurname;
            sUserName = _sUserName;
        }


        private CUser()
        {
         
        }
        public static CUser GetInstance()
        {
            if(UniqueLogin == null)
            {
                UniqueLogin = new CUser();
            }
            return UniqueLogin;
        }

        public List<CUser> getUsers()
        {
            CConnection cc = CConnection.GetConnectionInstance();
            SqlConnection conn = cc.GetConnection();
            List<CUser> list = new List<CUser>();
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("select * from Users", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add( new CUser(reader["U_Name"].ToString(), reader["U_Surname"].ToString()," |" + reader["U_UserName"].ToString()));

                }
                conn.Close();
                return list;
                
            }

        }
        public CUser GetUser(SqlConnection conn, string sNameandSurname)
        {
           
            string sUserName= sNameandSurname.Substring(sNameandSurname.IndexOf('|') + 1);
            conn = new SqlConnection(@"Data Source=DESKTOP-DPSO24P\GAVIN_SERVER;Initial Catalog=QrScanner;Integrated Security=True");
            CUser user = new CUser();
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("sp_GetUser", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserName", sUserName);

                cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Surname", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@UserType",SqlDbType.VarChar, 20).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                user.sID = (int)(cmd.Parameters["@ID"].Value);
                user.sName = Convert.ToString(cmd.Parameters["@Name"].Value);
                user.sSurname = Convert.ToString(cmd.Parameters["@Surname"].Value);
                user.sPassword = Convert.ToString(cmd.Parameters["@Password"].Value);
                user.sUserType = Convert.ToString(cmd.Parameters["@UserType"].Value);
                user.sUserName = sUserName;

                return user;
            }
        }

        public int AddNewUser(SqlConnection conn, string sUserName, string sPassword, string sName , string sSurname , string sUserType)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-DPSO24P\GAVIN_SERVER;Initial Catalog=QrScanner;Integrated Security=True");
            if( conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("sp_AddUsers", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@U_Name", sName);
                cmd.Parameters.AddWithValue("@U_Surname", sSurname);
                cmd.Parameters.AddWithValue("@UT_UserType", sUserType);
                cmd.Parameters.AddWithValue("@U_UserName", sUserName);
                cmd.Parameters.AddWithValue("@U_Password", sPassword);


                SqlParameter Message = new SqlParameter("@Message", SqlDbType.VarChar);
                Message.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(Message);
                cmd.ExecuteNonQuery();
                int sMessage = (int)Message.Value;
                conn.Close();
                return sMessage;
            }

           
        }
        public int RemoveUser(SqlConnection conn, int sUserId)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-DPSO24P\GAVIN_SERVER;Initial Catalog=QrScanner;Integrated Security=True");
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("sp_RemoveUser", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserID", sUserId);
                SqlParameter Message = new SqlParameter("@Message", SqlDbType.VarChar);
                Message.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(Message);
                cmd.ExecuteNonQuery();
                int sMessage = (int)Message.Value;
                conn.Close();
                return sMessage;
            }
        }
        public int EditUser(SqlConnection conn , int iUserID, string sName, string sSurname, string sUserName, string sPassword, string sUserType)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-DPSO24P\GAVIN_SERVER;Initial Catalog=QrScanner;Integrated Security=True");
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("sp_EditUser", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserID", iUserID);
                cmd.Parameters.AddWithValue("@Name", sName);
                cmd.Parameters.AddWithValue("@Surname", sSurname);
                cmd.Parameters.AddWithValue("@UserTypes", sUserType);
                cmd.Parameters.AddWithValue("@UserName", sUserName);
                cmd.Parameters.AddWithValue("@Password", sPassword);


                SqlParameter Message = new SqlParameter("@Message", SqlDbType.VarChar);
                Message.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(Message);
                cmd.ExecuteNonQuery();
                int sMessage = (int)Message.Value;
                conn.Close();
                return sMessage;
            }

        }
        public int GetUserID (string sUserName)
        {
            CConnection cc = CConnection.GetConnectionInstance();
            SqlConnection conn = cc.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_GetUserID", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UserName", sUserName);
          
            cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();
            int iID = Convert.ToInt32(cmd.Parameters["@ID"].Value);
            conn.Close();
            return iID;
        }
    

    }
}
