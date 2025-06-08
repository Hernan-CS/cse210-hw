using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

/*  ----------------- CHILD CLASS ------------------ */

/* Inherited class */
public class ListingActivity : Activity
{
    /* I could not decided which given prompt to use so I entered all of them and let the code choose one randomly */
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    /* Constructor using the base constructor to pass two strings */
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run() /* Initiates the activity */
    {
        Start();
        Random rand = new Random(); /* Create a new random number generator and store it in 'rand' */
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]); /* It generates a random index between 0 and the amount of variables in the list */
        Console.WriteLine("You may begin in:");
        ShowCountdown(5);

        /* Same logic */

        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);
        int count = 0;
        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"\nYou listed {count} items.");
        End();
    }
}