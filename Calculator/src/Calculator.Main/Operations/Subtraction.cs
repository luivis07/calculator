public class Subtraction : IOperator
{
    public string OperationToken => "b";

    public string OperationName => "Subtraction";

    public int Calculate(int num1, int num2)
    {
        return Subtract(num1, num2);
    }

    public int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    public bool Matches(string operationToken)
    {
        return string.Equals(operationToken, OperationToken);
    }
}