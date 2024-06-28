using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNBROKE_GUI;

namespace UNBROKE_GUI
{

    public class Authentication
    {
        private string currentUser; // Store the username of the current user
        public enum LoginStatus
        {
            Success,
            ProfileSetupNeeded,
            InvalidCredentials,
            Error
        }
        // Method to authenticate user login
        public LoginStatus Login(string username, string password)
        {
            // Validate username and password against the database
            DatabaseHelper db = DatabaseHelper.GetInstance();
            bool isValid = db.ValidateUser(username, password);

            if (isValid)
            {
                // Check if profile setup is done
                bool profileSetup = db.IsProfileSetup(username);
                if (!profileSetup)
                {
                    currentUser = username; // Set the current user
                    Console.WriteLine($"User '{username}' logged in. Profile setup needed.");
                    return LoginStatus.ProfileSetupNeeded;
                }
                else
                {
                    currentUser = username; // Set the current user
                    Console.WriteLine($"User '{username}' logged in.");
                    return LoginStatus.Success;
                }
            }
            else
            {
                Console.WriteLine($"Invalid username or password.");
                return LoginStatus.InvalidCredentials;
            }
        }

        // Method to retrieve the username of the current user
        public string GetCurrentUsername()
        {
            return currentUser;
        }

        // Method to check if a user is currently logged in
        public bool IsLoggedIn()
        {
            return !string.IsNullOrEmpty(currentUser);
        }

        // Method to log out the current user
        public void Logout()
        {
            currentUser = null; // Clear current user session
            Console.WriteLine("User logged out.");
        }
    }
}
