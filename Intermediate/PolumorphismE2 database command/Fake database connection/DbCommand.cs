using System;

namespace Fake_database_connection
{
    public class DbCommand : DbConnection
    {
        private readonly DbConnection _dbConnection;
        private string _command { get; set; }
        private static TimeSpan _timeout = TimeSpan.FromMilliseconds(1000);

        public DbCommand(DbConnection dbConnection, string command) : base (dbConnection.ToString(), _timeout)
        {
            _dbConnection = dbConnection;
            _command = command;

            if (dbConnection == null)
            {
                throw new NullReferenceException("Database connection");
            }

            if (string.IsNullOrWhiteSpace(_command))
            {
                throw new NullReferenceException("Command");
            }
        }
        public override void Open()
        {
        }

        public override void Close()
        {
        }

        public void Execute()
        {
            Console.WriteLine("\n");
            _dbConnection.Open();
            Console.WriteLine("The following command {0} has been executed.", _command);
            _dbConnection.Close();
        }
    }
}