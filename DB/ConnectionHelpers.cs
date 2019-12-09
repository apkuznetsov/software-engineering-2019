using System.Data;
using System.Data.SqlClient;

namespace GasStationMs.App.DB
{
    internal  class ConnectionHelpers
    {
        internal static SqlConnection OpenConnection()
        {
            //Get connection string
            var connectionStr = Properties.Settings.Default.GasStationMsDBConnectionString;

            SqlConnection connection = new SqlConnection(connectionStr);

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            return connection;
        }

        internal static void CloseConnection(SqlConnection connection)
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }
}
