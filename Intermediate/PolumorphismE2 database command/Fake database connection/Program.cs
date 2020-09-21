using System;

namespace Fake_database_connection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("www.mySQLdbconnection.com");
            var sqlDbCommand = new DbCommand(sqlConnection, "SELECT * FROM TABLE X");
            sqlDbCommand.Execute();

            var oracleConnection = new OracleConnection("www.myOracledbconnection.com");
            var oracleDbCommand = new DbCommand(oracleConnection, "SELECT * FROM TABLE Y");
            oracleDbCommand.Execute();
        }
    }
}
