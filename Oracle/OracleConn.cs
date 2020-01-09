using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FNCORCL2.Oracle
{
    public class OracleConn
    {
        public string connectionString = "User Id=sys;Password=Burnleyfc_12;Data Source=localhost:1521/FNC";

        public DataSet Query(string SQLString)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    OracleDataAdapter command = new OracleDataAdapter(SQLString, connection);

                    command.Fill(ds, "ds");
                }
                catch (OracleException ex)
                {
                    throw new Exception(ex.Message);
                }
                connection.Close();
                return ds;
            }
        }

        public int QueryCUD(string SQLString)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = SQLString;
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        return 1;
                    }
                }
                catch (OracleException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
