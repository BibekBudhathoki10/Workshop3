using System;

namespace Task2
{
    internal class NullOperations
    {
        // Method that performs all the required null operations
        public void PerformNullChecks()
        {
            // Step 1: Declare a string variable named username and assign null to it
            string username = null;

            // Step 2: Use the Ternary Operator (? :) to check whether username is null
            string message = (username == null) ? "Username is not available" : username;
            Console.WriteLine(message);

            // Step 3: Perform the same null checking using the Null-Coalescing Operator (??)
            Console.WriteLine(username ?? "Username is not available (checked using ??)");

            // Step 4: Use the Null-Coalescing Assignment Operator (??=)
            // Assign a value to username only if it is currently null
            username ??= "DefaultUser";

            // Step 5: Print the updated value of username
            Console.WriteLine($"Updated Username: {username}");
        }
    }
}
