using System;
using System.Threading;

/*  ----------------- PARENT CLASS ------------------ */

public class Activity
{
    private string _name;
    private string _description; /* Variables (set as private) */
    private int _duration;

    /* Constructor with parameters */
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    /* NOTE: I've created both the Start() and End() functions. They will be part of the aesthetic design it initiates as well as closes the activity. */
    public void Start()
    {
        Console.Clear(); /* Clear the terminal */
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine(_description); /* Display the variables, previously assigned */
        Console.Write("\nEnter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine()); /* Parse the input into an integer and store it */
        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3); /* Function explained in a bit */

    }
    public void End()
    {
        /* Final message when the activity finishes. */
        Console.WriteLine("\nGreat job!");
        ShowSpinner(2);
        Console.WriteLine($"You've completed {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    /* Note: Next, I'll explain the following animation functions */

    protected void ShowSpinner(int seconds) /* Function to show an spinner animation (set as protected) */
    {
        string[] spinner = { "|", "/", "—", "\\" }; /* This four strings will bring the spinner to live */
        DateTime end = DateTime.Now.AddSeconds(seconds); /* It'll add the amount of given seconds to current time */
        int i = 0;
        while (DateTime.Now < end) /* The loop will last until it reaches the 'end' time */
        {
            /* I'm using % (modulo operator). This works the following way: It divides 'i' by the amount of variables 
            in the list and gives the remainder. In the beginning, i = 0, so the operations goes like 0 % 4 is equal to 0, so 
            the variable with index 0 is printed, then i = 1, thanks to the 'i++' line and the next operation goes like 1 % 4 is 
            equal to 1, and so forth. This way, every single variable is printed by their index and gives the impression of an animation */
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250); /* Sleep() function pauses the program for 250 miliseconds, that way the animation goes more slowly and looks better */
            Console.Write("\b"); /* It moves the cursor one space back, useful to overwrite */
            i++; /* Increases the value of i so the next character is selected */
        }
    }

    protected void ShowCountdown(int seconds) /* Animation to show a countdown (set as protected, too) */
    {
        for (int i = seconds; i > 0; i--) /* For loop starting from the seconds value now stored in 'i' and goes down by using 'i--', so it would go like 10, 9, 8, 7, ... , 0 */
        {
            Console.Write(i);
            Thread.Sleep(1000); /* Function to pause the program for 1000 miliseconds */
            Console.Write("\b \b"); /* Moves the cursor back again, it overwrites the last one. */
        }
    }

    public int GetDuration() => _duration; /* Getter */
    /* Different way to write it:
    {
        return _duration;
    }
    - Wrapped up as '=> _duration' ('=>' symbol used to return)
    */
}