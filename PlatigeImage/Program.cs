using Microsoft.EntityFrameworkCore;
using PlatigeImage.Data;

namespace PlatigeImage
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            DatabaseConnectionForm connectionForm = new DatabaseConnectionForm();

            if (connectionForm.ShowDialog() == DialogResult.OK)
            {
                string connectionString = $"Server={connectionForm.ServerName};Database={connectionForm.DatabaseName};User Id={connectionForm.Username};Password={connectionForm.Password};Integrated Security={connectionForm.IntegratedSecurity};TrustServerCertificate=True;";

                using (var dbContext = new ApplicationDbContext(connectionString))
                {
                    if (DbConnectionHelper.TestConnection(connectionString))
                    {
                        dbContext.Database.Migrate();
                        Application.Run(new MainForm(dbContext));
                    }
                    else
                        MessageBox.Show("Po��czenie z baz� danych nie powiod�o si�");
                }

                ApplicationConfiguration.Initialize();
                Application.Run(new DatabaseConnectionForm());
            }
        }
    }
}