using System;

namespace Etap0
{
    public class Program
    {
        public double Calculate(double num1, double num2, string x)
        {
            double result = 0;

            // Use a switch statement to do the math.
            switch (x)
            {
                case "a":
                    result = num1 + num2;
                    Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                    break;
                case "s":
                    result = num1 - num2;
                    Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                    break;
                case "m":
                    result = num1 * num2;
                    Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor until they do so.
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    result = num1 / num2;
                    Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                    break;
            }

            return result;
        }


        static void Main(string[] args)
        {
            // Declare variables and then initialize to zero.
            double num1 = 0; double num2 = 0;

            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number.
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");
            string x = Console.ReadLine();

            var program = new Program();
            program.Calculate(num1, num2, x);

            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
