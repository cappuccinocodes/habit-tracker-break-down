using Microsoft.Data.Sqlite;

namespace habit_tracker_breakdown
{
    class Program
    {
        // We declare a string that will hold the address of the connection
        static string connectionString = @"Data Source=db.db";

        // Main Method: Starting Point of the application
        static void Main()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                // Open the Connection
                connection.Open();

                // Create a command
                var tableCmd = connection.CreateCommand();

                // Say what the command is (in SQL language)

                /* Create Table with three properties, and the Id property will be an 
                identifier for the rows (primary key) and increment itself (autoincrement)*/

                tableCmd.CommandText =
                    @$"CREATE TABLE IF NOT EXISTS drinking_water 
                    (Id INTEGER PRIMARY KEY AUTOINCREMENT, 
                    Date TEXT, 
                    Quantity INTEGER ) ";
                

                // Execute the command against the database. ExecuteNonQuery returns no values. 
                tableCmd.ExecuteNonQuery();

                // Close the Connection
                connection.Close();
            }
        }
    }
}