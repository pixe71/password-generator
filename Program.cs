using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Password Generator ===");

        // Ask for the password length with validation:
        // ensure the user enters an integer between 1 and 32
        int length;
        while (true)
        {
            Console.Write("Password length (max 32): ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out length) && length > 0 && length <= 32)
                break;
            Console.WriteLine("Error: please enter a number between 1 and 32.");
        }

        // Helper function to ask yes/no questions and validate the input:
        // re-asks if the answer is not 'y' or 'n'
        bool AskYesNo(string question)
        {
            while (true)
            {
                Console.Write(question);
                string answer = Console.ReadLine().ToLower();
                if (answer == "y") return true;
                if (answer == "n") return false;
                Console.WriteLine("Error: please answer 'y' for yes or 'n' for no.");
            }
        }

        // Ask the user which types of characters to include
        bool lowercase = AskYesNo("Include lowercase letters? (y/n): ");
        bool uppercase = AskYesNo("Include uppercase letters? (y/n): ");
        bool digits = AskYesNo("Include digits? (y/n): ");
        bool special = AskYesNo("Include special characters? (y/n): ");

        // Generate the password with the selected options
        string password = GeneratePassword(length, lowercase, uppercase, digits, special);

        // Display the result
        Console.WriteLine($"\nGenerated password: {password}");

        // Wait for user input before closing
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    // Function that generates the password based on the user's choices
    static string GeneratePassword(int length, bool lowercase, bool uppercase, bool digits, bool special)
    {
        // Character sets
        const string LOWER = "abcdefghijklmnopqrstuvwxyz";
        const string UPPER = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string DIGITS = "0123456789";
        const string SPECIAL = "!@#$%^&*()-_=+[]{}<>?/";

        // Build the pool of possible characters
        StringBuilder availableChars = new StringBuilder();

        if (lowercase) availableChars.Append(LOWER);
        if (uppercase) availableChars.Append(UPPER);
        if (digits) availableChars.Append(DIGITS);
        if (special) availableChars.Append(SPECIAL);

        // If no character type is selected, return an error message
        if (availableChars.Length == 0)
        {
            return "Error: no character type selected.";
        }

        // Build the password randomly
        StringBuilder password = new StringBuilder();
        Random rnd = new Random();

        for (int i = 0; i < length; i++)
        {
            int index = rnd.Next(availableChars.Length);      // Randomly pick an index
            password.Append(availableChars[index]);           // Add the character to the password
        }

        // Return the generated password
        return password.ToString();
    }
}
