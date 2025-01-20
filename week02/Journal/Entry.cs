using System;

public class Entry
{
    public DateTime Date { get; }
    public string Text { get; }
    public string Prompt { get; }

    public Entry(DateTime date, string text, string prompt)
    {
        Date = date;
        Text = text;
        Prompt = prompt;
    }

    public void Display()
    {
        Console.WriteLine($"{Date.ToShortDateString()} - {Prompt}");
        Console.WriteLine(Text);
        Console.WriteLine();
    }
}
