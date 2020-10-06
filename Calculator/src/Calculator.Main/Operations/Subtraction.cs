public class Subtraction : IOperator
{
    public int Calculate(int num1, int num2)
    {
        return Subtract(num1, num2);
    }

    public int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }
}