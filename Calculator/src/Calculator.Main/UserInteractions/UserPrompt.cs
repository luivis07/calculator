using System;
using System.Text;

public class UserPrompt : IUserPrompt
{
    private readonly IOperator[] _operators;

    public UserPrompt(IOperator[] operators)
    {
        _operators = operators;
    }
    public string GetMenu()
    {
        var sb = new StringBuilder();
        sb.AppendLine("Welcome!");
        sb.AppendLine("Enter a selection ('q' to quit):");
        foreach(var op in _operators)
        {

            sb.AppendFormat("{0}) {1}",op.OperationToken, op.OperationName);
            sb.AppendLine();
        }
        return sb.ToString();
    }

    public string PromptFirstNumber()
    {
        return @"Enter first number";
    }
    public string PromptSecondNumber()
    {
        return @"Enter second number";
    }
    public string DisplayResult(int result)
    {
        return @$"The result is {result}";
    }
    public string DisplayExitMessage()
    {
        return @"Goodbye";
    }
}