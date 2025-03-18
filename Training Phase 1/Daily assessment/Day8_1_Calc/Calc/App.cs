//Interface where user interact with the calculator

using CalculatorLib;
using System;

namespace SimpleCalcApp
{
    internal class App
    {
        static void Main()
        {
            var calc = new Calc();

            while (true)
            {
                Console.Write("Enter first number (or 'q' to quit): ");
                var input1 = Console.ReadLine();
                if (input1?.ToLower() == "q") break;

                if (!double.TryParse(input1, out double num1))
                {
                    Console.WriteLine("Invalid number. Try again.");
                    continue;
                }

                Console.Write("Enter second number: ");
                var input2 = Console.ReadLine();
                if (!double.TryParse(input2, out double num2))
                {
                    Console.WriteLine("Invalid number. Try again.");
                    continue;
                }

                Console.Write("Choose operation (+, -, *, /): ");
                var op = Console.ReadLine();

                try
                {
                    double result = op switch
                    {
                        "+" => calc.Add(num1, num2),
                        "-" => calc.Subtract(num1, num2),
                        "*" => calc.Multiply(num1, num2),
                        "/" => calc.Divide(num1, num2),
                        _ => throw new InvalidOperationException("Invalid operation.")
                    };
                    Console.WriteLine($"Result: {result}\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}\n");
                }
            }
        }
    }
}
