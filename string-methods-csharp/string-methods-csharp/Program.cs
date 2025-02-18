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
                // Correcting the start index and length for substring
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
