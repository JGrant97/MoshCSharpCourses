using System;

namespace Fake_database_connection
{
    public abstract class DbConnection
    {
        private string _connectionString { get; set; }
        private TimeSpan _timeout { get; set; }

        public DbConnection(string connection, TimeSpan timeout)
        {
            if (string.IsNullOrWhiteSpace(connection))
            {
                throw new ArgumentNullException("Connection string");
            }
            else if(timeout.TotalSeconds <= 0)
            {
                throw new TimeoutException("Database connectiont timed out");
            }

            _connectionString = connection;
            _timeout = timeout;
        }

        public abstract void Open();

        public abstract void Close();

    }
}
