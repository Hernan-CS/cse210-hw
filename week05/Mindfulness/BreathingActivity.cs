using System;
using System.Threading;

/*  ----------------- CHILD CLASS ------------------ */

/* This class inherites from the class Activity, thus it's able to use the data */
public class BreathingActivity : Activity
{
    /* Constructor using the base constructor call to pass two strings: The name and the description*/
    public BreathingActivity() : base("Breathing Activity",
        "Let's help you chill out a bit with some deep breathing. Just relax, follow the rhythm, and focus on your breath. ")
    {
    }

    public void Run() /* Function to get the code started */
    {
        Start(); /* Starts the activity — Function explained within the Activity.cs*/
        /* Same loop logic as the one withing the parent class */
        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < end)
        {
            Console.Write("Breath in...");
            ShowCountdown(4);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountdown(4);
            Console.WriteLine();
        }
        End(); /* Closes the activity — Function explained within the Activity.cs*/
    }
}