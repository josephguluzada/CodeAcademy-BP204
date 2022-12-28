using System.Data.SqlClient;

namespace AdoNetTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Sabina Alizade");
            GetData(10);
            //GetAllDatas();
            //InsertData();
            //DeleteData();
        }

        public static void GetData(int id)
        {
            string connectionString = "Server=CATALYST\\SQLEXPRESS;Database=UniversityDB;Trusted_Connection=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT Fullname FROM Students WHERE Id = {id}", connection);

                string fullName = (string)command.ExecuteScalar();
                Console.WriteLine(fullName);
            }
        } 

        public static void GetAllDatas()
        {
            string connectionString = "Server=CATALYST\\SQLEXPRESS;Database=UniversityDB;Trusted_Connection=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Students", connection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader[0]} - {reader[1]} {reader[3]}");
                    }
                }
            }
        }


        public static void InsertData()
        {
            string connectionString = "Server=CATALYST\\SQLEXPRESS;Database=UniversityDB;Trusted_Connection=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Students Values ('Rasim Balayev',21,1303,1)", connection);

                int check = command.ExecuteNonQuery();

                if(check > 0)
                    Console.WriteLine("Inserted");
                else
                    Console.WriteLine("Error!");
            }
        }

        public static void DeleteData()
        {
            string connectionString = "Server=CATALYST\\SQLEXPRESS;Database=UniversityDB;Trusted_Connection=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Students WHERE Id = 13", connection);

                int check = command.ExecuteNonQuery();

                if (check > 0)
                    Console.WriteLine("Deleted!");
                else
                    Console.WriteLine("Error!");
            }
        }
    }
}