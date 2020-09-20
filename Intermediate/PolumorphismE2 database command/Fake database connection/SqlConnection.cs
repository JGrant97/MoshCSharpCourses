using System;

namespace Fake_database_connection
{
    public class SqlConnection : DbConnection
    {
        private string _connection { get; set; }
        private static TimeSpan _timeout = TimeSpan.FromMilliseconds(500);

        public SqlConnection(string connection) : base (connection, _timeout)
        {
            _connection = connection;

        }
        public override void Open()
        {
            Console.WriteLine("SQL connection opened with {0}. ", _connection);
        }

        public override void Close()
        {
            Console.WriteLine("SQL connection with {0} closed. ", _connection);

        }
    }
}
