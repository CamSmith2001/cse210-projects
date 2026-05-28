using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {



        Entry newEntry = new Entry();
        newEntry._entryPrompt = 
        newEntry._entryResponse = Console.ReadLine();
        newEntry._moodResponse = "bleh";
        newEntry._dateTime = "Sep 1st";
        newEntry.DisplayEntry();
    }
}