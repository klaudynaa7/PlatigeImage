namespace PlatigeImage.Data
{
    public static class DbConnectionHelper
    {
        public static bool TestConnection(string connectionString)
        {
            using (var dbContext = new ApplicationDbContext(connectionString))
            {
                return dbContext.Database.CanConnect();
            }
        }
    }
}
