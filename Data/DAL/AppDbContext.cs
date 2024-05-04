using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
    public class AppDbContext
    {
        string conString = "Server=DESKTOP-D323LT8\\SQLEXPRESS;Database=AdoNetBack;Trusted_Connection=true;" +
            "Integrated Security=true;TrustServerCertificate=true;";
        public SqlConnection sqlConnection;

        public AppDbContext()
        {
            sqlConnection = new SqlConnection(conString);
        }

        public void NonQuery(string command) 
        { 
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            var result = sqlCommand.ExecuteNonQuery();

            if (result > 0)
            {
                Console.WriteLine("Completed " + result);
            }else
            {
                Console.WriteLine("failed");
            }
            sqlConnection.Close();
        }

        public DataTable Query(string selectCommand)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
    }
}
