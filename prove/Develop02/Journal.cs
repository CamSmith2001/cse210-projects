using System;
using System.IO;

public class Journal
{
    public string _csjournalName;
    public List<Entry> _csjournalEntries = new List<Entry>();
    

    public Journal()
    {
        _csjournalName = "";
        _csjournalEntries = new List<Entry>();
    }

    public void DisplayJournal()
    {
        Console.WriteLine(_csjournalEntries);
    }

    public void SaveJournal()
    {
        Console.Write("What is the name of the text file? ");
        _csjournalName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(_csjournalName);

        using (StreamWriter outputFile = new StreamWriter(_csjournalName))
        {
            outputFile.WriteLine(_csjournalEntries);
        }
    }

    public void LoadJournal()
    {
        string[] lines = System.IO.File.ReadAllLines(_csjournalName);

        Console.WriteLine("Loading previous journal entries.");

        foreach (string line in lines)
        {
            line = _csjournalEntries;
        }
    }
}