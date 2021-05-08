public class Addition : IOperator
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Calculate(int num1, int num2)
    {
        return Add(num1, num2);
    }

    public bool Matches(string operationToken)
    {
        return string.Equals(operationToken, "a");
    }
}