using System;

namespace Fake_database_connection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("www.mySQLdbconnection.com");
            sqlConnection.Open();
            sqlConnection.Close();

            var oracleConnection = new OracleConnection("www.myOracledbconnection.com");
            oracleConnection.Open();
            oracleConnection.Close();

        }
    }
}
