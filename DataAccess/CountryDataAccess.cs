using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;

namespace DataAccess
{
    public static class CountryDataAccess
    {
        public static void AddCountry(WHO_GHOCountryDTO country, string connectionString) {
            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Insert into Countries(COPYRIGHT) VALUES('"+ country.copyright +"')"; 
            cmd.ExecuteNonQuery(); 
            conn.Close();
            conn.Dispose();
        }
    }
}
