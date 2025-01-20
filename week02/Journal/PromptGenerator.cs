using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What church program was held at the chapel today?",
        "How did I see the hand of the Lord in my life today?",
        "What was the most interesting activity I engaged in today?",
        "How would you summarise everything that happened today in two lines?"
    };

    public string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
