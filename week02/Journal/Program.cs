using System;

/* A lot of things I learned in last courses were applied here, since creativity was required, so I did my best using either loops, switch statement and imported new classes, so I can
use collections in a better way and also read and write files. Throughout the code, I'll sometimes add a comment above a line and explain why it is written like that. */

class Program
{
    static void Main()
    {
        /* Setting the needed variables and constructors, ready to be used. */
        Journal journal = new Journal();
        Data data = new Data();
        bool menu = true;

        /* Introduction message! */
        Console.WriteLine("Have you ever wondered if there's some app that would help you to save and show what you write, perhaps past events, reminders or random thoughts. \nWell, you'll experience the beta phase of this application, which is intended to simulate a Journal App, give it a try.");

        /* This will keep the code running as long as the boolean variable named menu maintains as true. That's why option 5 change its value to false. */
        while (menu)
        {
            /* I intended to give a better experience to the user when using this app, thus I made a simple to understand design. */
            Console.WriteLine("\n:----- Journal Menu -----:");
            Console.WriteLine("| 1. Write               |");
            Console.WriteLine("| 2. Display             |");
            Console.WriteLine("| 3. Save journal        |");
            Console.WriteLine("| 4. Load journal        |");
            Console.WriteLine("| 5. Quit                |");
            Console.WriteLine(":------------------------:");
            Console.Write("\nGo ahead! Choose an action (1-5): ");
            string choice = Console.ReadLine();

            /* As I mentioned, I feel more comfortable using switch statements. Personally, it's easier to understand for me. */
            switch (choice)
            {
                case "1":
                    /* Even though, we were expected to use a random generator to display the questions, I wanted to 
                    make it friendlier by adding also a random prompt when the app asks for an answer/input.*/
                    string questionPrompt = data.GetRandomPrompt("question");
                    string enterPrompt = data.GetRandomPrompt("enter");
                    /* Then, I print them both. */
                    Console.WriteLine($"\n{questionPrompt}");
                    Console.Write($"\n{enterPrompt}");
                    /* I store the response in a variable */
                    string response = Console.ReadLine();
                    /* And I get the date by using DateTime.Now but adding ToShortDateString to only show the month, day and year, without hours, and finally store in the variable. */
                    string date = DateTime.Now.ToShortDateString();

                    /* I create a new variable called entry and call the constructor of the Entry class, finally, I pass the values. */
                    Entry entry = new Entry(date, questionPrompt, response);
                    /* And I added it by using the method AddEntry that I created in the Journal class. */
                    journal.AddEntry(entry);
                    break;

                case "2":
                    /* I call the method that will display the entries. This method continues within the Journal class. */
                    journal.DisplayEntries();
                    break;

                case "3":
                    /*I ask the user to set a name for the file and pass it to the method, so the process continues within the other classes.*/
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    /* I enter the filename I want, store it and pass it using the method LoadFromFile within the Journal class. */
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    /* I stop the loop the whole code by changing the value of bool menu from true to false. */
                    menu = false;
                    break;
            } /*I almost forgot to say that I use break to break/stop the loop whenever an option is matched.*/
        }

        /* The goodbye message! */
        Console.WriteLine("\nIt was a pleasure, see you later!");
    }
}