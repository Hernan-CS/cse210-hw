using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    /* Nothing much to explain, a method to add the entry to the list in this class. */
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    /* Alike the one above, a method to display the entry using a foreach loop to iterate trough entries. */
    public void DisplayEntries()
    {
        /*I iterate through the entries and then I display them all. */
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    /* This gave me a MIGRAINE, I completely forgot about how to read and write files. 
    As a matter of fact, almost the whole code is the result of reading thousands of pages and 
    times when I questioned myself about my intelligence. But, as you can see, I finally got it! :) */
    public void SaveToFile(string filename)
    {
        /*Once I got the filename, I create a new object by calling its constructor named StreamWriter, it is useful when it comes to writing text to a file. */
        using (StreamWriter writer = new StreamWriter(filename))
        {
            /* I iterate through the entries that were added right above. */
            foreach (var entry in _entries)
            {
                /* And now I used another method created in the entry class (Entry.cs) named ToFileFormat(). */
                writer.WriteLine(entry.ToFileFormat());
            }
        }
        /* Short message to show that the action was done successfully. */
        Console.WriteLine("Journal saved.");
    }

    public void LoadFromFile(string filename)
    {
        /* To avoid problems regarding the existence of the file I use conditionals. 
        So, if it exists, I'll run this part of the code. */
        if (File.Exists(filename))
        {
            /* First, I make quick clean of the lines. */
            _entries.Clear();
            /* Then, I start reading the new lines with the method ReadAllLines() and store in an string array. */
            string[] lines = File.ReadAllLines(filename);
            /* I iterate through the lines */
            foreach (var line in lines)
            {
                /* And use the method FromFileFormat() (Splits the line every "|" as I already explained in the other file.) 
                in the Entry class, with the line as the argument. */
                _entries.Add(Entry.FromFileFormat(line));
            }
            /* Finally, I show a message that the action was done successfully. */
            Console.WriteLine("Journal loaded.");
        }
        /* Otherwise, I'll show an error message. */
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}