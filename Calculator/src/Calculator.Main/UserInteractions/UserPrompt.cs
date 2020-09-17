using System;

public class UserPrompt
{
    public string GetMenu()
    {
        return @"Welcome!" +
                "Enter a selection ('q' to quit):" +
                "a) Addition" +
                "b) Subtraction" +
                "c) Multiplication" +
                "d) Division";
    }

    public string PromptFirstNumber()
    {
        return @"Enter first number";
    }
    public string PromptSecondNumber()
    {
        return @"Enter second number";
    }
    public string DisplayResult(int result)
    {
        return @$"The result is {result}";
    }
    public string DisplayExitMessage()
    {
        return @"Goodbye";
    }
}