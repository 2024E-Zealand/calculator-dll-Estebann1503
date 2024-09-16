using System;
using CalculatorClassLibrary;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Calculator class from the CalculatorClassLibrary
            CalculatorClassLibrary.Calculator calculator = new CalculatorClassLibrary.Calculator();

            while (true)
            {
                Console.WriteLine("Enter the first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Choose an operation (+, -, *, /):");
                string operation = Console.ReadLine();

                double result = 0;

                try
                {
                    switch (operation)
                    {
                        case "+":
                            result = calculator.Add(num1, num2);
                            break;
                        case "-":
                            result = calculator.Subtract(num1, num2);
                            break;
                        case "*":
                            result = calculator.Multiply(num1, num2);
                            break;
                        case "/":
                            result = calculator.Divide(num1, num2);
                            break;
                        default:
                            Console.WriteLine("Invalid operation");
                            continue;
                    }

                    Console.WriteLine($"The result is: {result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }

                Console.WriteLine("Do you want to perform another calculation? (y/n)");
                string continueCalculation = Console.ReadLine();

                if (continueCalculation.ToLower() != "y")
                {
                    break;
                }
            }
        }
    }
}
