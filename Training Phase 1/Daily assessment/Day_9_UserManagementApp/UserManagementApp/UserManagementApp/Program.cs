using System;

namespace UserManagementApp  // Ensure this matches your project namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example for username and password (you can replace this with actual input)
            string? username = "testuser";  // nullable string
            string? password = "password123";  // nullable string

            // Null check before using the username and password
            if (username == null || password == null)
            {
                Console.WriteLine("Username or password cannot be null.");
                return;  // Exit if null
            }

            // Create a user with the provided username and password
            UserModel user = new UserModel(username, password);

            // Authenticate the user
            if (user.Authenticate(password))
            {
                Console.WriteLine("User authenticated successfully!");
            }
            else
            {
                Console.WriteLine("Authentication failed.");
            }
        }
    }

    public class UserModel
    {
        private string _username;
        private string _password;

        // Constructor to initialize username and password
        public UserModel(string? username, string? password)
        {
            // Ensure that the username and password are not null
            if (username == null || password == null)
            {
                throw new ArgumentNullException("Username and password cannot be null.");
            }
            _username = username;
            _password = password;
        }

        // Authenticate the user
        public bool Authenticate(string? enteredPassword)
        {
            if (enteredPassword == null)
            {
                Console.WriteLine("Entered password cannot be null.");
                return false;
            }

            return _password == enteredPassword;  // Simple authentication logic
        }
    }
}
