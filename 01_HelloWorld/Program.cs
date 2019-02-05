using System;

namespace _01_HelloWorld
{
    class Program
    {
        //Challenge: write "Hello World" to the Console
        //Challenge: write Hello to the console by using a string variable. Output should say "Hello World"

        //Challenge: create and assign two string variables one for first name and one for last name and using interpolation output that to the console as "Hello FirstName LastName".

        //Challenge: Get the user's first name, last name, and age and output to the console "Good Morning, FirstName LastName, your age is unknown."
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            string hello = "Hello World";
            Console.WriteLine(hello);

            string firstName = "Ransford";
            string lastName = "Walker";

            Console.WriteLine($"{hello}, {firstName} {lastName}");

            Console.WriteLine("Enter your First Name:");
            string first = Console.ReadLine();

            Console.WriteLine("Enter your Last Name:");
            string last = Console.ReadLine();

            Console.WriteLine($"Good Morning, {first} {last}! Your age is unknown.");

            Console.ReadKey();
        }
    }
}
