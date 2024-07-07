using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using UNBROKE_GUI.Enums;

namespace UNBROKE_GUI
{
    internal class DatabaseHelper
    {
        public class Expense
        {
            public int ExpenseId { get; set; }
            public ExpenseCategory Category { get; set; }
            public ExpenseSubCategory Subcategory { get; set; }
            public decimal Amount { get; set; }
        }

        private string connectionString;

        // Singleton instance
        private static DatabaseHelper instance;

        // Private constructor to enforce singleton pattern
        private DatabaseHelper()
        {
            // Initialize connection string here
            //RASTY = connectionString = "server=localhost;database=unbroke;uid=root;pwd='180503';";
            //EJAY = connectionString = "server=localhost;database=unbroke;uid=root;pwd='';";

            connectionString = "server=localhost;port=3307;database=unbroke;uid=root;pwd='';";

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
            string query = "UPDATE `user` " +
                           "SET `first_name` = @firstname, " +
                           "`last_name` = @lastname, " +
                           "`profile_image` = @profileImage, " +
                           "`profile_setup` = @profileSetup " +
                           "WHERE `user_id` = @userId";

            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userId", userId);
                        command.Parameters.AddWithValue("@firstname", firstname);
                        command.Parameters.AddWithValue("@lastname", lastname);
                        command.Parameters.Add("@profileImage", MySqlDbType.Blob).Value = profileImage;
                        command.Parameters.AddWithValue("@profileSetup", profileSetup);

                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Rows affected: {rowsAffected}");

                        return rowsAffected > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");

                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    return false;
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

                        // Log SQL query for debugging
                        Console.WriteLine($"Executing query: {query}");

                        // Execute the command and fetch userId
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            userId = Convert.ToInt32(result);
                            Console.WriteLine($"User ID found: {userId}");
                        }
                        else
                        {
                            Console.WriteLine($"No user found with username: {username}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching user_id: {ex.Message}");
                    throw; // Rethrow the exception to propagate it up for better debugging
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

        public bool InsertExpense(int budgetID, ExpenseCategory category, ExpenseSubCategory subCategory, decimal amount)
        {

            string query = @" INSERT INTO expense (budget_ID, category, subcategory, amount)
                           VALUES (@budgetID, @category, @subCategory, @amount)";
            using (MySqlConnection connection = GetConnection())
            {
                try
            {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@budgetID", budgetID);
                        command.Parameters.AddWithValue("@category", category.ToString());
                        command.Parameters.AddWithValue("@subCategory", subCategory.ToString());
                        command.Parameters.AddWithValue("@amount", amount);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
               
                }
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
            }
        }
        public bool UpdateExpense(int budgetID, ExpenseCategory category, ExpenseSubCategory subCategory, decimal amount)
        {
            string query = @"UPDATE expense
                     SET amount = @amount
                     WHERE budget_ID = @budgetID
                     AND category = @category
                     AND subcategory = @subCategory";

            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@budgetID", budgetID);
                        command.Parameters.AddWithValue("@category", category.ToString());
                        command.Parameters.AddWithValue("@subCategory", subCategory.ToString());
                        command.Parameters.AddWithValue("@amount", amount);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception (log it, rethrow it, etc.)
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }

        public bool UpdateTotalBudget(int budgetID, decimal newTotalBudget)
        {
            string query = @"UPDATE budget
                     SET total_budget = @newTotalBudget
                     WHERE budget_id = @budgetID";

            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@budgetID", budgetID);
                        command.Parameters.AddWithValue("@newTotalBudget", newTotalBudget);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception (log it, rethrow it, etc.)
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }

        public bool UpdateTotalBudgetAndSavings(int budgetID, decimal newTotalBudget)
        {
            decimal newSavings = newTotalBudget * 0.20m;

            string query = @"UPDATE budget
                     SET total_budget = @newTotalBudget, savings = @newSavings
                     WHERE budget_id = @budgetID";

            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@budgetID", budgetID);
                        command.Parameters.AddWithValue("@newTotalBudget", newTotalBudget);
                        command.Parameters.AddWithValue("@newSavings", newSavings);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception (log it, rethrow it, etc.)
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }


        public bool InsertSavings(int userID, int budgetID, decimal amount)
        {
            string query = @"UPDATE budget SET savings = @amount WHERE budget_id = @budgetID AND user_id = @userID";

            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@budgetID", budgetID);
                        command.Parameters.AddWithValue("@userID", userID);
                        command.Parameters.AddWithValue("@amount", amount);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception (log it, rethrow it, etc.)
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }


        public bool InsertBudget(int userId, decimal totalBudget, DateTime startDate, DateTime? endDate)
        {
            string query = @"
        INSERT INTO `budget` (`user_id`, `start_date`, `end_date`, `total_budget`, `savings`) 
        VALUES (@userId, @startDate, @endDate, @totalBudget, 0.0)";

            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userId", userId);
                        command.Parameters.AddWithValue("@startDate", startDate);

                        if (endDate.HasValue)
                        {
                            command.Parameters.AddWithValue("@endDate", endDate.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@endDate", DBNull.Value);
                        }

                        command.Parameters.AddWithValue("@totalBudget", totalBudget);

                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Rows affected: {rowsAffected}");

                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inserting budget: {ex.Message}");
                    return false;
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
        // Method to get start_date by user_id
        public DateTime GetStartDateByUserID(int userID)
        {
            DateTime startDate = DateTime.MinValue; // Default value or error indicator

            // SQL query to fetch start_date based on user_id
            string query = "SELECT start_date FROM `budget` " +
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

                        // Execute the command and fetch start_date
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            startDate = Convert.ToDateTime(result); // Convert result to DateTime
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching start_date: {ex.Message}");
                    // Optionally handle the exception or log it
                    throw; // Rethrow the exception to propagate it up for better debugging
                }
            }

            return startDate;
        }

        public DateTime GetEndDateByUserID(int userID)
        {
            DateTime endDate = DateTime.MaxValue; // Default value or error indicator

            // SQL query to fetch end_date of the highest budget_id based on user_id
            string query = "SELECT end_date FROM `budget` " +
                           "WHERE budget_id = (SELECT MAX(budget_id) FROM `budget` WHERE user_id = @userID)";

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

                        // Execute the command and fetch end_date
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            endDate = Convert.ToDateTime(result); // Convert result to DateTime
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching end_date: {ex.Message}");
                    // Optionally handle the exception or log it
                    throw; // Rethrow the exception to propagate it up for better debugging
                }
            }

            return endDate;
        }

        // Method to fetch the highest budget ID for a given user ID
        public int GetHighestBudgetIdByUserId(int userId)
        {
            int highestBudgetId = -1; // Default value or error indicator

            // SQL query to fetch highest budget_id based on user_id
            string query = "SELECT MAX(budget_id) FROM `budget` WHERE user_id = @userId";

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
                        command.Parameters.AddWithValue("@userId", userId);

                        // Execute the command and fetch highest budget_id
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            highestBudgetId = Convert.ToInt32(result); // Convert result to integer
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching highest budget ID: {ex.Message}");
                    // Optionally handle the exception or log it
                    throw; // Rethrow the exception to propagate it up for better debugging
                }
            }

            return highestBudgetId;
        }

        public List<Expense> GetExpensesByBudgetId(int budgetId)
        {
            List<Expense> expenses = new List<Expense>();
            string query = "SELECT expense_ID, category, subcategory, amount FROM `expense` WHERE budget_ID = @budgetId";

            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@budgetId", budgetId);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Expense expense = new Expense
                                {
                                    ExpenseId = reader.GetInt32("expense_ID"),
                                    Category = (ExpenseCategory)Enum.Parse(typeof(ExpenseCategory), reader.GetString("category")),
                                    Subcategory = (ExpenseSubCategory)Enum.Parse(typeof(ExpenseSubCategory), reader.GetString("subcategory")),
                                    Amount = reader.GetDecimal("amount")
                                };
                                expenses.Add(expense);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching expenses: {ex.Message}");
                    throw;
                }
            }

            return expenses;
        }


        public bool UpdateProfile(int userId, string username, string passwordHash, string firstname, string lastname, byte[] profileImage)
        {
            string query = "UPDATE `user` " +
                           "SET `username` = @username, " +
                           "`password_hash` = @passwordHash, " +
                           "`first_name` = @firstname, " +
                           "`last_name` = @lastname, " +
                           "`profile_image` = @profileImage " +
                           "WHERE `user_id` = @userId";

            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userId", userId);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@passwordHash", passwordHash);
                        command.Parameters.AddWithValue("@firstname", firstname);
                        command.Parameters.AddWithValue("@lastname", lastname);
                        command.Parameters.Add("@profileImage", MySqlDbType.Blob).Value = profileImage;

                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Rows affected: {rowsAffected}");

                        return rowsAffected > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"MySQL Exception: {ex.Message}");
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    return false;
                }
            }
        }

        public int CountTotalBudgetsByUserID(int userID)
        {
            int totalBudgets = 0;

            // SQL query to count total budgets for a specific user
            string query = "SELECT COUNT(*) FROM `budget` WHERE `user_id` = @userID";

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

                        // Execute the command and fetch the count of budgets
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            totalBudgets = Convert.ToInt32(result); // Convert result to int
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error counting total budgets for user: {ex.Message}");
                }
            }

            return totalBudgets;
        }

    }
}
