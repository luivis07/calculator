using System;
using Unity;

namespace Calculator.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = RegisterContainer();
            
            var selector = container.Resolve<ISelector>();
            var userPrompt = container.Resolve<IUserPrompt>();

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

        static IUnityContainer RegisterContainer()
        {
            var container = new UnityContainer();
            container.RegisterSingleton<ISelector, Selector>();
            container.RegisterSingleton<IUserPrompt, UserPrompt>();
            return container;
        }
    }
}
