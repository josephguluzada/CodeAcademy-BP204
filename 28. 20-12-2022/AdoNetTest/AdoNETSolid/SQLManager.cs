using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNETSolid
{
    public static class SQLManager
    {
        static string _connectionString = "Server=CATALYST\\SQLEXPRESS;Database=UniversityDB;Trusted_Connection=True";
        static SqlConnection _sqlConnection = null;

        public static SqlConnection SqlConnection 
        { 
            get
            {
                if( _sqlConnection is null ) _sqlConnection = new SqlConnection(_connectionString);
                return _sqlConnection;
            }
        }

        public static int Execute(string command)
        {
            int check;
            SqlConnection.Open();
            using (SqlCommand sqlCommand = new SqlCommand(command, SqlConnection))
            {
                check = sqlCommand.ExecuteNonQuery();
            }
            SqlConnection.Close();

            return check;
        }

        public static DataTable ReadAll(string command)
        {
            DataTable dataTable = new DataTable();
            SqlConnection.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(command,SqlConnection))
            {
                adapter.Fill(dataTable);
            }
            SqlConnection.Close();

            return dataTable;
        }
    }
}
