using System.Data.SqlClient;

namespace BUDSgui
{
    internal class DatabaseConnection
    {
        private string connectionString_;
        private SqlConnection connection_;

        public DatabaseConnection()
        {
            connectionString_ = "Data Source=se361-buds-workflow.database.windows.net;Initial Catalog=BUDS-WorkFlow;User ID=azureuser;Password=BUDS.Butler.edu;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Integrated Security=False";
            connection_ = new SqlConnection(connectionString_);
        }

        public void open()
        {
            connection_.Open();
        }

        public void close()
        {
            connection_.Close();
        }
        public string ConnectionString_
        {
            get { return connectionString_; }
            set { connectionString_ = value; }
        }

        public SqlConnection Connection
        {
            get { return connection_; }
            set { connection_ = value; }
        }

    }
}
