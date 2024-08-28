using Microsoft.EntityFrameworkCore;
using PlatigeImage.Data;
using PlatigeImage.Infrastructure.Connection;

namespace PlatigeImage
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);

            DatabaseConnectionForm connectionForm = new DatabaseConnectionForm();

            if (connectionForm.ShowDialog() == DialogResult.OK)
            {
                string connectionString = $"Server={connectionForm.ServerName};Database={connectionForm.DatabaseName};User Id={connectionForm.UserId};Password={connectionForm.Password};Integrated Security={connectionForm.IntegratedSecurity};TrustServerCertificate=True;";

                using (var dbContext = new ApplicationDbContext(connectionString))
                {
                    if (DbConnectionHelper.TestConnection(connectionString))
                    {
                        ConnectionDetails.GetInstance(connectionForm.ServerName, connectionForm.UserId, connectionForm.Password, connectionForm.DatabaseName, connectionForm.IntegratedSecurity);
                        dbContext.Database.Migrate();
                        Application.Run(new MainForm());
                    }
                    else
                        MessageBox.Show("Po³¹czenie z baz¹ danych nie powiod³o siê");
                }

                ApplicationConfiguration.Initialize();
                Application.Run(new DatabaseConnectionForm());
            }
        }
    }
}