namespace PlatigeImage.Infrastructure.Connection
{
    public class ConnectionDetails
    {
        private static ConnectionDetails? _connectionInfo;
        private static readonly object lockObject = new();

        public string? ServerName { get; private set; }
        public string? UserId { get; private set; }
        public string? Password { get; private set; }
        public string? DatabaseName { get; private set; }
        public bool IntegratedSecurity { get; private set; }

        private ConnectionDetails(string? serverName, string? userId, string? password, string? databaseName, bool integratedSecurity)
        {
            ServerName = serverName;
            UserId = userId;
            Password = password;
            DatabaseName = databaseName;
            IntegratedSecurity = integratedSecurity;
        }

        public static ConnectionDetails GetInstance(string? serverName, string? userId, string? password, string? databaseName, bool integratedSecurity)
        {
            lock (lockObject)
            {
                if (_connectionInfo == null)
                {
                    _connectionInfo = new ConnectionDetails(serverName, userId, password, databaseName, integratedSecurity);
                }
            }
            return _connectionInfo;
        }

        public static ConnectionDetails GetInstance()
        {
            if (_connectionInfo == null)
            {
                throw new InvalidOperationException("No server access data");
            }
            return _connectionInfo;
        }

        public string GetConnectionString()
        {
            return $"Server={ServerName};Database={DatabaseName};User Id={UserId};Password={Password};Integrated Security={IntegratedSecurity};TrustServerCertificate=True;";
        }
    }
}