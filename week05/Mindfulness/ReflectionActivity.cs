using System;
using System.Threading;
using System.Collections.Generic;

/*  ----------------- CHILD CLASS ------------------ */

/* Inherited class */
public class ReflectionActivity : Activity
{
    /* List of prompts & questions — They're to be provived to the user and be an fundamental part of the activity. */

    /* List of given prompts in the page, one will be chosen randomly */
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    /* List of given questions in the page, one will be chosen randomly */
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    /* Constructor using the base constructor */
    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you strength and resilence. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void Run()
    {
        /* This code follows the same logic as the other classes */
        Start();
        Random rand = new Random();
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("Reflect on the following questions:");

        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < end)
        {
            Console.Write("> " + _questions[rand.Next(_questions.Count)]);
            Console.WriteLine();
            ShowSpinner(5);
        }
        End();
    }


}


