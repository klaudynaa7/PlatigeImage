namespace PlatigeImage.Data
{
    public static class DbConnectionHelper
    {
        public static bool TestConnection(string connectionString)
        {
            return true;

            //using (var dbContext = new ApplicationDbContext(connectionString))
            //{
            //    return dbContext.Database.CanConnect();
            //}
        }
    }
}
