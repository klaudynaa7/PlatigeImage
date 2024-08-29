namespace PlatigeImage.Infrastructure.Connection
{
    public class DatabaseConfig()
    {
        public string? ServerName { get; set; }
        public string? UserId { get; set; }
        public string? Password { get; set; }
        public string? DatabaseName { get; set; }
        public bool IntegratedSecurity { get; set; }

        public string GetConnectionString()
        {
            return $"Server={ServerName};Database={DatabaseName};User Id={UserId};Password={Password};Integrated Security={IntegratedSecurity};TrustServerCertificate=True;";
        }
    }
}