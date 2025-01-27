using System;

class Program
{
    static void Main(string[] args)
    {
        // Define constants for the correct username and password
        const string StoredUsername = "Alice";
        const string StoredPassword = "Wonderland123";

        try
        {
            // Prompt the user to enter their username
            Console.Write("Enter your username: ");
            string enteredUsername = Console.ReadLine();

            // Validate username input
            if (string.IsNullOrWhiteSpace(enteredUsername))
            {
                throw new ArgumentException("Username cannot be empty.");
            }

            // Prompt the user to enter their password
            Console.Write("Enter your password: ");
            string enteredPassword = Console.ReadLine();

            // Validate password input
            if (string.IsNullOrWhiteSpace(enteredPassword))
            {
                throw new ArgumentException("Password cannot be empty.");
            }

            // Authenticate user
            if (enteredUsername == StoredUsername && enteredPassword == StoredPassword)
            {
                Console.WriteLine($"Welcome, {enteredUsername}! You have successfully logged in.");
            }
            else
            {
                Console.WriteLine("Login failed. Please check your username and password.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unhandled Exception: {ex.Message}");
        }
    }
}
 
