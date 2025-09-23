using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and set to 0.
            double num1 = 0;
            double num2 = 0;

            // Display a welcome message.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to enter the first number.
            Console.WriteLine("Enter the first number, then press Enter");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to enter the second number.
            Console.WriteLine("Enter the second number, then press Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            // Use a switch statement to perform the calculation.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    // Prevent division by zero.
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("That is not a valid option. Please choose a, s, m, or d.");
                    break;
            }

            // Wait for the user to respond before closing the console window.
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}