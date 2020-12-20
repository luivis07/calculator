public interface IUserPrompt
{
    string GetMenu();
    string PromptFirstNumber();
    string PromptSecondNumber();
    string DisplayResult(int result);
    string DisplayExitMessage();
}