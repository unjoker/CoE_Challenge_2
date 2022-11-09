using System;

namespace CoE_Challenges
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter your email: ");
            var email = Console.ReadLine();
            CalculateVacationsFor(employeeID: email);
        }

        private static void CalculateVacationsFor(string employeeID)
        {
            if (!EmailUtils.IsValid(employeeID))
            {
                Console.WriteLine("Invalid Email Address");
                return;
            }

            Console.WriteLine($"Calculating vacations for employee: {employeeID}");
        }
    }

    class EmailUtils
    {
        public static bool IsValid(string email) => email.ToLower().EndsWith("@acme.com");
    }
}
