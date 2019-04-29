using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssetManager
{
    class CLogin
    {
        CConnection cc = CConnection.GetConnectionInstance();
        private static CLogin UniqueInstance;
        private string sUserName;
        private string sPassword;

        public CLogin(string sUserName, string sPassowrd)
        {
            this.sUserName = sUserName;
            this.sPassword = sPassowrd;
        }

        private CLogin() { }

        public string GetUser()
        {
            return sUserName;
        }
        public void SetUser(string _sUserName)
        {
            sUserName = _sUserName;
        }
        public static CLogin GetInstance()
        {
            if(UniqueInstance == null)
            {
                UniqueInstance = new CLogin();
            }
            return UniqueInstance;
        }

        public int DoLogin(string _sUserName, string _sPassowrd )
        {
            SqlConnection conn = cc.GetConnection();
            using (conn)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("p_GetLogin", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserName", _sUserName);
                    cmd.Parameters.AddWithValue("@Password", _sPassowrd);

                    SqlParameter IsValid = new SqlParameter("@IsValid", SqlDbType.Int);
                    IsValid.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(IsValid);
                    cmd.ExecuteNonQuery();
                    int isValid = (int)IsValid.Value;
                    conn.Close();
                    return isValid;
                }
                catch { return 0; }
            }
          
        }

    }
}
