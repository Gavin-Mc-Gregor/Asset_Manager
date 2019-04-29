using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Net;
using System.Text.RegularExpressions;

namespace AssetManager
{
    public class CAddress
    { 
        CConnection cc = CConnection.GetConnectionInstance();
        public string sLatitude { get; set; }
        public string sLogitude { get; set; }
        public int iAddressID;
        public string sAddressLine1;
        public string sCity;
        public string sPostalCode;



        public List<string> GetLatLongFromAddress(string sStreetNumber, string sAddressLine, string sCity, string sPostalCode)
        {
            List<string> latlng = new List<string>();
            string bingMapsUri = string.Format(@"http://dev.virtualearth.net/REST/v1/Locations/South%20Africa/"+sPostalCode+"/"+sCity+"/"+sAddressLine+"/"+sStreetNumber+"?o=xml&key=AmjAgnIZcGI8S0kkL3B6vWMkvhdX0Ci6De0D7QrS58TlrUvwbf44wSx1qJJUzxxt");
            XmlDocument bingMapsXmlDoc = new XmlDocument();
            bingMapsXmlDoc.Load(bingMapsUri);
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(bingMapsXmlDoc.NameTable);
            nsmgr.AddNamespace("rest", "http://schemas.microsoft.com/search/local/ws/rest/v1");
            string sLong = bingMapsXmlDoc.DocumentElement.SelectSingleNode(@".//rest:Longitude", nsmgr).InnerText;
            string sLat = bingMapsXmlDoc.DocumentElement.SelectSingleNode(@".//rest:Latitude", nsmgr).InnerText;
            string sAddress = bingMapsXmlDoc.DocumentElement.SelectSingleNode(@".//rest:FormattedAddress", nsmgr).InnerText;
            string sMatchCode = bingMapsXmlDoc.DocumentElement.SelectSingleNode(@".//rest:MatchCode", nsmgr).InnerText;
            latlng.Add(sLat);
            latlng.Add(sLong);
            latlng.Add(sAddress);
            latlng.Add(sMatchCode);
            return latlng;
        }

        public List<int> AddAddress(SqlConnection conn, string sAddressLine1, string sCity, string sPostalCode, decimal _mLatitude, decimal _mLongitude)
        {
            conn = cc.GetConnection();
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("sp_AddAddress", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@AddressLine1", sAddressLine1);
                cmd.Parameters.AddWithValue("@City", sCity);
                cmd.Parameters.AddWithValue("@PostalCode", sPostalCode);
                cmd.Parameters.AddWithValue("@Latitude", _mLatitude);
                cmd.Parameters.AddWithValue("@Longitude", _mLongitude);

                SqlParameter Message = new SqlParameter("@Message", SqlDbType.VarChar);
                Message.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(Message);
                cmd.ExecuteNonQuery();
                List<int> iList = new List<int>();
                iList.Add((int)Message.Value);
                iList.Add(Convert.ToInt32(cmd.Parameters["@ID"].Value));
                conn.Close();
                return iList;
            }
        }
        public int RemoveAddress(SqlConnection conn, int iAddressID)
        {
            conn = cc.GetConnection();
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("sp_RemoveAddress", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AddressID", iAddressID);
               
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
