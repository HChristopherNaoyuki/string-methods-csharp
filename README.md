# String Methods in C#

## Description
StringMethodsCSharp is a C# console application that demonstrates various string manipulation methods. This project includes converting strings to uppercase and lowercase, creating usernames, formatting phone numbers, calculating string length, and extracting substrings. Exception handling is implemented to manage potential errors.

## Features
- Converts full names to uppercase and lowercase.
- Creates usernames by inserting "@" and replacing spaces with underscores.
- Formats phone numbers by replacing hyphens with spaces.
- Calculates and displays the length of a full name.
- Extracts and displays first and last names from a full name.
- Implements exception handling for invalid substring ranges and other unexpected errors.

## Code Overview
The `Program` class contains the `Main` method, which:
1. Initializes strings for a full name and a phone number.
2. Converts the full name to uppercase and then to lowercase, displaying the results.
3. Creates a username by inserting "@" at the beginning and replacing spaces with underscores.
4. Formats the phone number by replacing hyphens with spaces.
5. Calculates and displays the length of the full name.
6. Extracts and displays the first and last names from the full name.
7. Implements exception handling to catch and display errors.

## C# Script
```csharp
using System;

namespace StringMethodsCSharp
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                // String Methods

                string fullname = "James Kroos";
                string phoneNumber = "+1-234-567-8901";

                // Convert fullname to upper case and then to lower case
                fullname = fullname.ToUpper();
                Console.WriteLine("Uppercase: " + fullname);
                fullname = fullname.ToLower();
                Console.WriteLine("Lowercase: " + fullname);

                // Convert fullname to username
                // Replace any spaces with an underscore
                string username = fullname.Insert(0, "@");
                username = username.Replace(" ", "_");
                Console.WriteLine("Username: " + username);

                // Replace hyphens in the phone number with spaces
                phoneNumber = phoneNumber.Replace("-", " ");
                Console.WriteLine("Formatted Phone Number: " + phoneNumber);

                // Length of fullname
                Console.WriteLine("Length of fullname: " + fullname.Length + " character(s) long.");

                // Display first-name from fullname
                string firstname = fullname.Substring(0, 5);
                Console.WriteLine("Firstname: " + firstname);

                // Display last-name from fullname
                string lastname = fullname.Substring(6);
                Console.WriteLine("Lastname: " + lastname);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Handle specific exception for invalid substring range
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle any other unexpected exceptions
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure that the program waits for a key press before exiting
                Console.ReadKey();
            }
        }
    }
}
```

---
