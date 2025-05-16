using System;

public class Entry
{
    /* 
    The reason why I use { get; set; } is because it allows the value to be read and written.
    But, why just not write it like this?:

    public string Date;
    public string Prompt;
    public string Response;

    Because, adding { get; set; } methods make it more flexible to be used, that's why I preferred to the regular variable declaration way. It's
    like, instead of having a public space where everything can be changed and seen, I place a door, so now it is private and I decide what, how, why 
    and when it is changed, at least, that's how I understand it.
    */
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    /*I set three inputs to the Entry constructor and later assign them to internal variables in this class.*/
    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    /* I found out that I must use override and came to the following conclusion, explained in my own words: toString (it's used to return an object as text) is an special 
    method that all C# classes have, so they inherit it automatically, thus in order to change it and don't make the code get confused I must use override, to specify 
    that I'm replacing the original method. Correct me in the feedback if I'm wrong, I spent hours reading and I won't always get the correct answer.*/
    public override string ToString()
    {
        /* So, I return them with this format. */
        return $"\nDate: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }

    public string ToFileFormat()
    {
        /* This is the format that will be used when passing the text to the file. 
        In this case, I'll use "|° to split them all when the user ask to load a file, but any symbol can be used anyways. */
        return $"{Date}|{Prompt}|{Response}";
    }

    public static Entry FromFileFormat(string line)
    {
        /*As I said, I split it every "|" and return them by their index. */
        string[] parts = line.Split('|');
        return new Entry(parts[0], parts[1], parts[2]);
    }
}