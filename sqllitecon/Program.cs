using System;
using System.Data.SQLite;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string connectionString = "Data Source=C:\\Users\\Aminc\\OneDrive - HTL Spengergasse\\3. Klasse\\SWP\\Graf\\MySQL\\sqllite_test";

            
            string query = "SELECT Wert, Spalte2 FROM mytable";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            Console.WriteLine(reader["Wert"].ToString()+reader["Spalte2"]);
                           
                            
                        }
                    }
                }

                connection.Close();
            }

            Console.ReadKey();
        }
    }
}

