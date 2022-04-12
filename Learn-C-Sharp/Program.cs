using System;

namespace LearnCSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Read a name and Print in console
            Console.WriteLine("Hello, pleas enter you first name: ");
            string firstName = Console.ReadLine(); // Console.ReadLine alwasy return a string.

            Console.WriteLine("Hello, pleas enter you last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Your full name is: " + firstName + " " + lastName); // Concatination Syntax

            Console.WriteLine("Your full name is: {0} {1}", firstName, lastName); // Placeholder Syntax

            Console.WriteLine($"Your full name is: {firstName} {lastName}"); // Interpolation Syntax


            // Read a number and do addition of two number
            Console.WriteLine("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine()); // Console.ReadLine alwasy return a string but now we parse they string into the integer.

            Console.WriteLine("Enter first number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Addition of two number is: " + (number1 + number2));
        }
    }
}
