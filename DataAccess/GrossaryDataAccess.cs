using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;

namespace DataAccess
{
    public static class GrossaryDataAccess
    {
        public static void AddGrossary(HC_GrossaryItemDTO grossaryItem, string connectionString)
        {
            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Insert into GrossaryItems(ID) VALUES('" + grossaryItem.id + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }
    }
}
