using System.Data;
using System.Data.SqlClient;

namespace Cashiering_Rasonable_IT13L
{
    public class DB_Connections
    {
        // Change the Initial Catalog to your database name
        private string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_Cashiering_Rasonable_IT13;Integrated Security=True";
        private SqlConnection conn;

        public DB_Connections()
        {
            conn = new SqlConnection(connString);
        }

        public SqlConnection GetConn() => conn;

        public void OpenConn()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public void CloseConn()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
