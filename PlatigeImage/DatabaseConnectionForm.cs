using DevExpress.XtraEditors.Controls;
using System.Data.SqlClient;
using PlatigeImage.Data;

namespace PlatigeImage
{
    public partial class DatabaseConnectionForm : Form
    {
        public string? ServerName { get; private set; }
        public string? Username { get; private set; }
        public string? Password { get; private set; }
        public string? DatabaseName { get; private set; }
        public bool IntegratedSecurity { get; private set; }

        public DatabaseConnectionForm() => InitializeComponent();

        private void btnListOfDatabase_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FillDatabase();
            btnListOfDatabase.Show();
            Cursor = Cursors.Default;
        }

        private void FillDatabase()
        {
            try
            {
                cbDatabase.Properties.Items.Clear();

                if (!CheckServerNameIsCompleted())
                    return;

                var connectionString = new SqlConnection($"Server={teServer.Text};User Id={teUserId.Text};Password={tePassword.Text};Integrated Security={ceIntegratedSecurity.Checked};TrustServerCertificate=True;");
                connectionString.Open();
                var query = "SELECT name FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb');";
                using (var command = new SqlCommand(query, connectionString))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        cbDatabase.Properties.Items.Add(new ImageListBoxItem(reader.GetString(0)));
                }
                connectionString.Close();
            }
            catch
            {
                MessageBox.Show("Po³¹czenie do serwera nie powiod³o siê");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ServerName = teServer.Text;
            Username = teUserId.Text;
            Password = tePassword.Text;
            DatabaseName = cbDatabase.Text;
            IntegratedSecurity = ceIntegratedSecurity.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            var connectionString = $"Server={teServer.Text};User Id={teUserId.Text};Password={tePassword.Text};Database={cbDatabase.Text};Integrated Security={ceIntegratedSecurity.Checked};TrustServerCertificate=True;";

            if (DbConnectionHelper.TestConnection(connectionString))
                MessageBox.Show("Po³¹czenie z baz¹ danych udane.");
            else
                MessageBox.Show("Po³¹czenie z baz¹ danych nie powiod³o siê");
        }

        private bool CheckServerNameIsCompleted()
        {
            if (string.IsNullOrWhiteSpace(teServer.Text))
            {
                MessageBox.Show("Proszê wpisaæ nazwê serwera");
                return false;
            }
            else
                return true;
        }
    }
}
