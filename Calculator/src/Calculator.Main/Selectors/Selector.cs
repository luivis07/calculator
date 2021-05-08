using System;
using System.Linq;

public class Selector : ISelector
{
    private readonly IOperator[] _operators;
    public Selector(IOperator[] operators)
    {
        _operators = operators;
    }

    public IOperator GetOperator(string option)
    {
        var op = _operators.SingleOrDefault(o => o.Matches(option));
        if (op == null)
            throw new InvalidOperationException();
        return op;
    }
}