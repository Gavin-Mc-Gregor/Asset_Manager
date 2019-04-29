using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManager
{
    public class CConnection
    {
        private static CConnection UniqueConnection;
        

        private CConnection() { }

        public static CConnection GetConnectionInstance()
        {
            if(UniqueConnection == null)
            {
                UniqueConnection = new CConnection();
            }
            return UniqueConnection;
        }
        public SqlConnection GetConnection()
        {
          SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DPSO24P\GAVIN_SERVER;Initial Catalog=QrScanner;Integrated Security=True");
          if(conn.State == System.Data.ConnectionState.Closed)
                conn.Open();

            return conn;
           
        }
    }
}
