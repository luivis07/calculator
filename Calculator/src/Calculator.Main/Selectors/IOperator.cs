public interface IOperator
{
    int Calculate(int num1, int num2);

    bool Matches(string operationToken);
    string OperationToken { get; }
    string OperationName { get; }
}