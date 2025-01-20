using System;

public class Entry
{
    private DateTime _date;
    private string _text;

    public Entry(DateTime date, string text)
    {
        _date = date;
        _text = text;
    }

    public void Display()
    {
        Console.WriteLine($"{_date}: {_text}");
    }
}
