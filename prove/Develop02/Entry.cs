using System;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _entryPrompt;
    public string _moodResponse;
    public string _entryResponse;
    public string _dateTime;

    public Entry()
    {
        _entryPrompt = "";
        _moodResponse = "";
        _entryResponse = "";
        _dateTime = "";
    }

    public void DisplayEntry()
    {
        Console.WriteLine(_entryPrompt);
        Console.WriteLine(_entryResponse);
        Console.WriteLine(_moodResponse);
        Console.WriteLine(_dateTime);
    }
}