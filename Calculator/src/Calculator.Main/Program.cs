using System;

namespace Calculator.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("Enter a selection ('q' to quit):");
            Console.WriteLine("a) Addition");
            Console.WriteLine("b) Subtraction");
            Console.WriteLine("c) Multiplication");
            Console.WriteLine("d) Division");
            
            var selection = Console.ReadLine();
            
            Console.WriteLine("Enter first number");
            var num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter second number");
            var num2 = Convert.ToInt32(Console.ReadLine());

            var result = 0;
            var resultMessage = "The result is {0}";
            switch (selection)
            {
                case "a":
                result = num1 + num2;
                resultMessage = string.Format(resultMessage, result);
                break;
                case "b":
                result = num1 - num2;
                resultMessage = string.Format(resultMessage, result);
                break;
                case "c":
                result = num1 * num2;
                resultMessage = string.Format(resultMessage, result);
                break;
                case "d":
                result = num1 / num2;
                resultMessage = string.Format(resultMessage, result);
                break;
                default:
                resultMessage = "Goodbye";
                break;
            }
            Console.WriteLine(resultMessage);
        }
    }
}
