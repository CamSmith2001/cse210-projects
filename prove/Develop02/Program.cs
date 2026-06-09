// Name:
// Class:
// Description:

// Sources:
// 1. https://byui-cse.github.io/cse210-course-2023
// 2. Teacher Notes...
// 3. Internet Research...

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