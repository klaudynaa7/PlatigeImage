using DevExpress.XtraEditors.Controls;
using System.Data.SqlClient;
using PlatigeImage.Infrastructure.Connection;
using Microsoft.Extensions.DependencyInjection;
using PlatigeImage.Resources;
using PlatigeImage.Data;
using Microsoft.EntityFrameworkCore;

namespace PlatigeImage
{
    public partial class DatabaseConnectionForm : Form
    {
        private const string _databaseQuery = "SELECT name FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb');";
        private readonly DatabaseConfig _dbConfig;
        private readonly IServiceProvider _serviceProvider;

        public DatabaseConnectionForm(DatabaseConfig dbConfig, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _dbConfig = dbConfig;
            _serviceProvider = serviceProvider;
        }

        private void btnListOfDatabase_Click(object sender, EventArgs e)
        {
            FillDatabase();
            btnListOfDatabase.Show();
        }

        private void FillDatabase()
        {
            if (!CheckServerNameIsCompleted())
                return;

            cbDatabase.Properties.Items.Clear();
            var connectionString = BuildConnectionString(includeDatabase: false);

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(_databaseQuery, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            cbDatabase.Properties.Items.Add(new ImageListBoxItem(reader.GetString(0)));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{StringResource.ConnectionToTheServerFailed}: {ex.Message}");
            }
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            UpdateDatabaseConfig();

            try
            {
                await InitializeDatabaseAsync();
                OpenMainForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{StringResource.ConnectionToTheDatabaseFailed}: {ex.Message}");
            }
        }

        private async Task InitializeDatabaseAsync()
        {
            var connectionString = BuildConnectionString();
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            dbContext.Database.SetConnectionString(connectionString);
            await dbContext.Database.MigrateAsync();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            var connectionString = BuildConnectionString();
            var connectionChecker = new DatabaseConnectionChecker(connectionString);

            string message = connectionChecker.CheckConnection()
                ? StringResource.DatabaseConnectionSuccessful
                : StringResource.ConnectionToTheDatabaseFailed;

            MessageBox.Show(message);
        }

        private bool CheckServerNameIsCompleted()
        {
            if (string.IsNullOrWhiteSpace(teServer.Text))
            {
                MessageBox.Show(StringResource.ServerNameNotCompleted);
                return false;
            }
            return true;
        }

        private string BuildConnectionString(bool includeDatabase = true)
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = teServer.Text,
                UserID = teUserId.Text,
                Password = tePassword.Text,
                IntegratedSecurity = ceIntegratedSecurity.Checked,
                TrustServerCertificate = true
            };

            if (includeDatabase)
                builder.InitialCatalog = cbDatabase.Text;

            return builder.ConnectionString;
        }

        private void UpdateDatabaseConfig()
        {
            _dbConfig.ServerName = teServer.Text;
            _dbConfig.DatabaseName = cbDatabase.Text;
            _dbConfig.UserId = teUserId.Text;
            _dbConfig.Password = tePassword.Text;
            _dbConfig.IntegratedSecurity = ceIntegratedSecurity.Checked;
        }

        private void OpenMainForm()
        {
            var mainForm = _serviceProvider.GetRequiredService<MainForm>();
            mainForm.Show();
            this.Hide();
        }
    }
}
