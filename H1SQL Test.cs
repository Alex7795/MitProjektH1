using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace testsql
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database = H1Project;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            string query = "SELECT * FROM Cars";

            MySqlCommand commandsDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            databaseConnection.Open();

            reader = commandsDatabase.ExecuteReader();
            while(reader.Read())
            Console.WriteLine(reader.GetString(0) + reader.GetString(1) + reader.GetString(2) + reader.GetString(3) + reader.GetString(4) + reader.GetString(5) + reader.GetString(6) + reader.GetString(7) + reader.GetString(8) + reader.GetString(9));
        }
    }
}
