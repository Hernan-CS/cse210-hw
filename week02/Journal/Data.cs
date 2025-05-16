using System;
using System.Collections.Generic;

public class Data
{
    /* IMPORTANT: I didn't create them as public, for I run the code before when the prompts lists 
    were public and the code didn't work at all, since changes are being done in different 
    classes, so that I avoid bugs and future problems I just make them private and this 
    lists are only used and manipulated WITHIN this class. I've done that and it worked. */

    /* The list of string containing all of the question prompts. */
    private List<string> _questionPrompts = new List<string>
    {
        "What challenged you today?",
        "How did you show kindness today?",
        "Who did you talk to today, and how was that conversation?",
        "What made today different from yesterday?",
        "What's something you want to do better tomorrow?",
        "Did you do something outside your comfort zone? What? If not, why?",
        "What's something you want to let go of?",
        "What would you say to your future self?",
        "What stressed you out, and how did you handle it?",
        "Are you doing well lately?",
        "Did you talk to your parents today? If not, why?",
        "What are some of your habits?",
        "Are you interested in learning a new skill? What?",
        "How do you see yourself in 10 years?",
        "When was the last time you tried a new food?",
        "Did anything surprise you today?",
        "What's was your favorite part of today?",
        "Is there something you've ever wanted to do? What?",
        "How are you growing as a person?",
        "Are you going through any hardship lately?",
        "Are you okay?"
    };

    /* The list of string containing all of the enter prompts. */
    private List<string> _enterPrompts = new List<string>
    {
        "I don't bite, tell me about it: ",
        "Let me know: ",
        "I'm all ears: ",
        "I'm listening: ",
        "Time to answer: ",
        "Let it out: ",
        "I'm ready when you are: ",
        "What's on your mind?: ",
        "Where to begin, right? Take it easy: ",
        "Your thoughts go here: ",
        "Tell me everything: ",
        "You've got the floor: ",
        "It's your time to speak: ",
        "One word at a time: ",
        "Don't worry, no judgment here: "
    };

    /* I create the random number generator, a very useful class in C# */
    private Random _random = new Random();

    /* In summary, I create a method with an optional input named "listType", the input may vary depending 
    on which entries you are looking for, yet if you don't provide one it will give you the default one "main". */
    public string GetRandomPrompt(string listType = "main")
    {
        List<string> selectedList;

        /* If the input is "enter". */
        if (listType == "enter")
        {
            selectedList = _enterPrompts;
        }
        /* If the input is "question". */
        else if (listType == "question")
        {
            selectedList = _questionPrompts;
        }
        /* If no input was given. */
        else if (listType == "main")
        {
            selectedList = _questionPrompts;
        }
        /* If no input was given again. */
        else
        {
            Console.WriteLine("Error: Unknown prompt list type. Back to default.");
            selectedList = _questionPrompts;
        }

        /* I generate a random number starting from 0 until the amount of items withing the list. */
        int index = _random.Next(selectedList.Count);
        /* Finally, I return that variable. */
        return selectedList[index];
    }
}
