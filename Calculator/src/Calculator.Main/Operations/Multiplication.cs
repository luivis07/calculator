public class Multiplication : IOperator
{
    public int Calculate(int num1, int num2)
    {
        return Multiply(num1, num2);
    }

    public int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    public bool Matches(string operationToken)
    {
        return string.Equals(operationToken, "c");
    }
}