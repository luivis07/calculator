using System;
using System.Linq;

public class Selector : ISelector
{
    private readonly IOperator[] operators;
    public Selector(IOperator[] operators)
    {
        this.operators = operators;
    }

    public IOperator GetOperator(string option)
    {
        switch (option)
        {
            case "a":
                return operators.FirstOrDefault(f => f is Addition);
            case "b":
                return operators.FirstOrDefault(f => f is Subtraction);
            case "c":
                return operators.FirstOrDefault(f => f is Multiplication);
            case "d":
                return operators.FirstOrDefault(f => f is Division);
            default:
                throw new NotImplementedException();
        }
    }
}