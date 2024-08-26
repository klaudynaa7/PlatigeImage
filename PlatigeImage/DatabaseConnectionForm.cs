using DevExpress.XtraEditors.Controls;
using System.Data.SqlClient;
using System.Data;

namespace PlatigeImage
{
    public partial class DatabaseConnectionForm : Form
    {
        public DatabaseConnectionForm()
        {
            InitializeComponent();
        }

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

                if (string.IsNullOrWhiteSpace(teDataSource.Text))
                {
                    MessageBox.Show("Prosz� wpisa� nazw� serwera");
                    return;
                }

                var sqlCon = new SqlConnection("Data Source = " + teDataSource.Text +
                                               "; User Id = " + teLogin.Text +
                                               "; Password = " + tePassword.Text +
                                               //"; Integrated Security= " + ceIntegratedSecurity.EditValue +
                                               ";");
                sqlCon.Open();
                var sqlCommand = new SqlCommand
                {
                    Connection = sqlCon,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "sp_databases"
                };

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    cbDatabase.Properties.Items.Add(new ImageComboBoxItem(sqlDataReader.GetString(0), sqlDataReader.GetString(0), -1));
                }
                sqlCon.Close();
            }
            catch
            {
                MessageBox.Show("Po��czenie do serwera nie powiod�o si�");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
