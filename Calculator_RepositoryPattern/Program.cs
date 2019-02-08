using System;

namespace Calculator_RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorRepository _calcRepo = new CalculatorRepository();
            decimal x = 0;
            decimal y = 0;
            decimal result;
            char symbol;
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Enter the number for your desired function: \n" +
                    "\t1. Add two numbers\n" +
                    "\t2. Subtract two numbers\n" +
                    "\t3. Multiply two numbers\n" +
                    "\t4. Divide two numbers\n" +
                    "\t5. Get a remainder\n" +
                    "\t6. Exit");
                var response = int.Parse(Console.ReadLine());
                switch (response)
                {
                    case 1:
                        symbol = '+';
                        x = GetFirstValueForCalc();
                        y = GetSecondValueForCalc();
                        result = _calcRepo.AddTwoNumbers(x, y);
                        isRunning = PrintResults(x, y, result, symbol);
                        break;
                    case 2:
                        symbol = '-';
                        x = GetFirstValueForCalc();
                        y = GetSecondValueForCalc();
                        result = _calcRepo.SubtractTwoNumbers(x, y);
                        isRunning = PrintResults(x, y, result, symbol);
                        break;
                    case 3:
                        symbol = '*';
                        x = GetFirstValueForCalc();
                        y = GetSecondValueForCalc();
                        result = _calcRepo.MultiplyTwoNumbers(x, y);
                        isRunning = PrintResults(x, y, result, symbol);
                        break;
                    case 4:
                        symbol = '/';
                        x = GetFirstValueForCalc();
                        y = GetSecondValueForCalc();
                        result = _calcRepo.DivideTwoNumbers(x, y);
                        isRunning = PrintResults(x, y, result, symbol);
                        break;
                    case 5:
                        symbol = '%';
                        x = GetFirstValueForCalc();
                        y = GetSecondValueForCalc();
                        result = _calcRepo.GetRemainder(x, y);
                        isRunning = PrintResults(x, y, result, symbol);
                        break;
                    case 6:
                        isRunning = false;
                        break;
                    default:
                        symbol = '+';
                        decimal[] values = GetValues();
                        result = _calcRepo.AddMultipleNumbers(values);
                        isRunning = PrintResults(result);
                        break;
                }
            }
        }

        static decimal GetFirstValueForCalc()
        {
            Console.Write("Enter your first number: ");
            var x = decimal.Parse(Console.ReadLine());
            return x;
        }

        static decimal GetSecondValueForCalc()
        {
            Console.Write("Enter your second number: ");
            var x = decimal.Parse(Console.ReadLine());
            return x;
        }

        static bool PrintResults(decimal x, decimal y, decimal result, char symbol)
        {
            Console.WriteLine($"{x} {symbol} {y} = {result}\n\nWould you like to continue? y/n");
            var response = Console.ReadLine().ToLower();
            Console.Clear();
            if (response.Contains("y"))
                return true;
            else
                return false;
        }

        static bool PrintResults(decimal result)
        {
            Console.WriteLine($"Your result is: {result}\n\nWould you like to continue? y/n");
            var response = Console.ReadLine().ToLower();
            Console.Clear();
            if (response.Contains("y"))
                return true;
            else
                return false;
        }

        static decimal[] GetValues()
        {
            Console.WriteLine("How many values do you have?");
            int i = int.Parse(Console.ReadLine());

            decimal[] values = new decimal[i];

            for (int index = 0; index < i; index++)
            {
                Console.Write("Enter a number: ");
                var num = decimal.Parse(Console.ReadLine());
                values[index] = num;
            }

            return values;
        }
    }
}
