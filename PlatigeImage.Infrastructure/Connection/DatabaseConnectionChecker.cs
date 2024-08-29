using Microsoft.Data.SqlClient;

namespace PlatigeImage.Infrastructure.Connection
{
    public class DatabaseConnectionChecker(string connectionString)
    {
        private readonly string _connectionString = connectionString;

        public bool CheckConnection()
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
