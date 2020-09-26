using System;

namespace Calculator.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var addition = new Addition();
            var subtraction = new Subtraction();
            var multiplication = new Multiplication();
            var division = new Division();
            var userPrompt = new UserPrompt();

            var menu = userPrompt.GetMenu();
            Console.WriteLine(menu);
            var selection = Console.ReadLine();
            
            Console.WriteLine(userPrompt.PromptFirstNumber());
            var num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(userPrompt.PromptSecondNumber());
            var num2 = Convert.ToInt32(Console.ReadLine());

            var result = 0;
            string resultMessage;
            switch (selection)
            {
                case "a":
                result = addition.Add(num1, num2);
                break;
                case "b":
                result = subtraction.Subtract(num1, num2);
                break;
                case "c":
                result = multiplication.Multiply(num1, num2);
                break;
                case "d":
                result = division.Divide(num1, num2);
                break;
                default:
                resultMessage = "Goodbye";
                break;
            }
            resultMessage = userPrompt.DisplayResult(result);
            Console.WriteLine(resultMessage);
        }
    }
}
