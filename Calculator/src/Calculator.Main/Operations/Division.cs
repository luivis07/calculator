public class Division : IOperator
{
    public string OperationToken => "d";

    public string OperationName => "Division";

    public int Calculate(int num1, int num2)
    {
        return Divide(num1, num2);
    }

    public int Divide(int num1, int num2)
    {
        return num1/num2;
    }

    public bool Matches(string operationToken)
    {
        return string.Equals(operationToken, OperationToken);
    }
}