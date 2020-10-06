using System;

namespace Calculator.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var selector = new Selector();
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
            var op = selector.GetOperator(selection);
            result = op.Calculate(num1, num2);
            resultMessage = userPrompt.DisplayResult(result);
            Console.WriteLine(resultMessage);
        }
    }
}
