using System;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Try-Catch-Finally example
            try
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine($"You entered: {num}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format.");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }

            // Throw example
            try
            {
                Console.Write("\nEnter your password: ");
                string password = Console.ReadLine();

                if (password.Length < 6)
                    throw new Exception("Password must be at least 6 characters.");
                else
                    Console.WriteLine("Password satisfied the requirement.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
