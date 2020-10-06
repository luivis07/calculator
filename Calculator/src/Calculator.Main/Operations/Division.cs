public class Division : IOperator
{
    public int Calculate(int num1, int num2)
    {
        return Divide(num1, num2);
    }

    public int Divide(int num1, int num2)
    {
        return num1/num2;
    }
}