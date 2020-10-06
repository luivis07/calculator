using System;

public class Selector
{
    private readonly Addition addition = new Addition();
    private readonly Subtraction subtraction = new Subtraction();
    private readonly Multiplication multiplication = new Multiplication();
    private readonly Division division = new Division();
    public IOperator GetOperator(string option)
    {
        switch (option)
        {
            case "a":
                return addition;
            case "b":
                return subtraction;
            case "c":
                return multiplication;
            case "d":
                return division;
            default:
                throw new NotImplementedException();
        }
    }
}