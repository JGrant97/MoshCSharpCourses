using System;
using System.Collections.Generic;
using System.Text;

namespace Fake_database_connection
{
    class OracleConnection : DbConnection
    {
        private string _connection { get; set; }
        private static TimeSpan _timeout = TimeSpan.FromMilliseconds(300);
        public OracleConnection(string connection) : base(connection, _timeout)
        {
            _connection = connection;
        }
        public override void Open()
        {
            Console.WriteLine("Oracle connection opened with {0}. ", _connection);
        }

        public override void Close()
        {
            Console.WriteLine("Oracle connection with {0} closed. ", _connection);

        }
    }
}
