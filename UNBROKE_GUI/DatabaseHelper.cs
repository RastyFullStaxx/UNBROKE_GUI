using System;
using MySql.Data.MySqlClient;

namespace UNBROKE_GUI
{
    internal class DatabaseHelper
    {
        private string connectionString;

        // Singleton instance
        private static DatabaseHelper instance;

        // Private constructor to enforce singleton pattern
        private DatabaseHelper()
        {
            // Initialize connection string here
            connectionString = "server=localhost;database=unbroke;uid=root;pwd='180503';";
        }

        // Public static method to get the singleton instance
        public static DatabaseHelper GetInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseHelper();
            }
            return instance;
        }

        // Method to get database connection
        public MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }

        // Method to test database connection
        public bool TestConnection()
        {
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful.");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection failed: " + ex.Message);
                    return false;
                }
            }
        }

        // Method to insert a new user into the database
        public bool InsertUser(string username, string hashedPassword)
        {
            // SQL query with parameters
            string query = "INSERT INTO `user` (`username`, `password_hash`, `first_name`, `last_name`) " +
                           "VALUES (@username, @password, '', '')"; // Provide default empty values or NULLs

            // Create MySqlConnection
            using (MySqlConnection connection = GetConnection())
            {
                // Open the connection
                try
                {
                    connection.Open();

                    // Create MySqlCommand
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", hashedPassword);

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Rows affected: {rowsAffected}");

                        return true; // Insertion successful
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inserting user: {ex.Message}");
                    return false; // Insertion failed
                }
            }
        }


        public bool SetupProfile(int userId, string firstname, string lastname, byte[] profileImage, bool profileSetup)
        {
            // SQL query with parameters
            string query = "UPDATE `user` " +
                           "SET `first_name` = @firstname, " +
                           "`last_name` = @lastname, " +
                           "`profile_image` = @profileImage, " +
                           "`profile_setup` = @profileSetup " +
                           "WHERE `user_id` = @userId";

            // Create MySqlConnection
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    // Create MySqlCommand
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@userId", userId);
                        command.Parameters.AddWithValue("@firstname", firstname);
                        command.Parameters.AddWithValue("@lastname", lastname);
                        command.Parameters.Add("@profileImage", MySqlDbType.Blob).Value = profileImage;
                        command.Parameters.AddWithValue("@profileSetup", profileSetup);

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Rows affected: {rowsAffected}");

                        return rowsAffected > 0; // If rows affected > 0, update successful
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error updating profile: {ex.Message}");
                    return false; // Update failed
                }
            }
        }
        public string GetFirstNameByUserID(int userID)
        {
            string firstname = null; // Default value or error indicator

            // SQL query to fetch firstname based on user_id
            string query = "SELECT first_name FROM `user` WHERE user_id = @userID";

            // Create MySqlConnection
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    // Create MySqlCommand
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameter to the command
                        command.Parameters.AddWithValue("@userID", userID);

                        // Execute the command and fetch firstname
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            firstname = result.ToString(); // Convert result to string
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching firstname: {ex.Message}");
                }
            }

            return firstname;
        }
        public string GetLastNameByUserID(int userID)
        {
            string firstname = null; // Default value or error indicator

            // SQL query to fetch firstname based on user_id
            string query = "SELECT last_name FROM `user` WHERE user_id = @userID";

            // Create MySqlConnection
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    // Create MySqlCommand
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameter to the command
                        command.Parameters.AddWithValue("@userID", userID);

                        // Execute the command and fetch firstname
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            firstname = result.ToString(); // Convert result to string
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching firstname: {ex.Message}");
                }
            }

            return firstname;
        }
        public decimal GetTotalBudgetByID(int userID)
        {
            decimal budget = 0; // Default value or error indicator

            // SQL query to fetch total_budget based on the highest budget_id for user_id
            string query = "SELECT total_budget FROM `budget` " +
                           "WHERE user_id = @userID " +
                           "ORDER BY budget_id DESC LIMIT 1";

            // Create MySqlConnection
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    // Create MySqlCommand
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameter to the command
                        command.Parameters.AddWithValue("@userID", userID);

                        // Execute the command and fetch total_budget
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            budget = Convert.ToDecimal(result); // Convert result to decimal
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching total budget: {ex.Message}");
                    // Optionally handle the exception or log it
                    throw; // Rethrow the exception to propagate it up for better debugging
                }
            }

            return budget;
        }



        public string GetUsernamebyUserID(int ID)
        {
            string username = null; // Default value or error indicator

            // SQL query to fetch username based on user_id
            string query = "SELECT username FROM `user` WHERE user_id = @ID";

            // Create MySqlConnection
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    // Create MySqlCommand
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameter to the command
                        command.Parameters.AddWithValue("@ID", ID);

                        // Execute the command and fetch username
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            username = result.ToString(); // Convert result to string
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching username: {ex.Message}");
                }
            }

            return username;
        }
        public int GetUserIdByUsername(string username)
        {
            int userId = -1; // Default value or error indicator

            // SQL query to fetch user_id based on username
            string query = "SELECT user_id FROM `user` WHERE username = @username";

            // Create MySqlConnection
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    // Create MySqlCommand
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@username", username);

                        // Execute the command and fetch userId
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            userId = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching user_id: {ex.Message}");
                }
            }

            return userId;
        }
        // Example method in DatabaseHelper.cs
        public bool ValidateUser(string username, string password)
        {
            bool isValid = false;
            string query = "SELECT `password_hash` FROM `user` WHERE `username` = @username";

            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        string hashedPassword = command.ExecuteScalar() as string;

                        if (hashedPassword != null)
                        {
                            isValid = BCrypt.Net.BCrypt.Verify(password, hashedPassword);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error validating user: {ex.Message}");
                }
            }

            return isValid;
        }

        // Method to check if profile setup is completed for a user
        public bool IsProfileSetup(string username)
        {
            // SQL query to check if profile_setup is true for the given username
            string query = "SELECT profile_setup FROM `user` WHERE username = @username";

            // Initialize profile setup status
            bool profileSetup = false;

            // Create MySqlConnection
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    // Create MySqlCommand
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@username", username);

                        // Execute the command and fetch profile_setup status
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            profileSetup = Convert.ToBoolean(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error checking profile setup: {ex.Message}");
                }
            }

            return profileSetup;
        }
     
        public bool InsertBudgetDate(int userId, DateTime startDate, DateTime endDate)
        {   
           // SQL query with parameters
        string query = "INSERT INTO `budget` (`user_id`, `start_date`, `end_date`, `total_budget`, `savings`) " +
                   "VALUES (@userId, @startDate, @endDate, 0.0, 0.0)";

            // Create MySqlConnection
             using (MySqlConnection connection = GetConnection())
            {
        try
        {
            connection.Open();

            // Create MySqlCommand
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                // Add parameters to the command
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);

                // Execute the command
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"Rows affected: {rowsAffected}");

                return rowsAffected > 0; // Insertion successful if rows affected > 0
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inserting budget: {ex.Message}");
            return false; // Insertion failed
            }
          }
         }
        public bool InsertBudget(int userId, Decimal budget)
        {
            // SQL query with parameters
            string query = "INSERT INTO `budget` (`user_id`, `total_budget`,`savings` ) " +
                       "VALUES (@userId, @budget, 0.0 )";

            // Create MySqlConnection
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    // Create MySqlCommand
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@userId", userId);
                        command.Parameters.AddWithValue("@budget", budget);


                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Rows affected: {rowsAffected}");

                        return rowsAffected > 0; // Insertion successful if rows affected > 0
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inserting budget: {ex.Message}");
                    return false; // Insertion failed
                }
            }
        }
        public byte[] GetProfileImageByUsername(string username)
        {
            byte[] profileImage = null;

            // SQL query to fetch profile image based on username
            string query = "SELECT profile_image FROM `user` WHERE username = @username";

            // Create MySqlConnection
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    // Create MySqlCommand
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@username", username);

                        // Execute the command and fetch profile image
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            profileImage = (byte[])result; // Convert result to byte array
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching profile image: {ex.Message}");
                    // Handle exception as needed
                }
            }

            return profileImage;
        }

    }
}
