using System;

class Program
{
    static void Main()
    {
        /* 1 Kings 1:7-9 is my farvorite scripture, it helped me when I was younger, for it talks about that. 
        Regarding the code, although it's difficult to memorize many verses than just one, I display 
        from 7 to 9 and make some of the words disappear gradually. I intended to display many verses and not
        only one. */
        Reference reference = new Reference("1 Kings", 1, 7, 9);
        /*For that, I stored them in a list.*/
        List<string> verses = new List<string>
        {
        "And now, O Lord my God, thou hast made thy servant king instead of David my father: and I am but a little child: I know not how to go out or come in.",
        "And thy servant is in the midst of thy people which thou hast chosen, a great people, that cannot be numbered nor counted for multitude.",
        "Give therefore thy servant an understanding heart to judge thy people, that I may discern between good and bad: for who is able to judge this thy so great a people?"
        };

        /* List where the verses are stored */
        List<Scripture> scriptures = new List<Scripture>();
        /* Loop to iterate through the variables as long as i is less than the number of variables inside the verses list. */
        for (int i = 0; i < verses.Count; i++)
        {
            /* We add them to the previous list.*/
            scriptures.Add(new Scripture(verses[i]));
        }

        /* I've created a method to check if at least one scripture still has some visible words, since the 
        code will stop when all of the words are hidden, so this method it's used for that to happen. */
        bool AnyWordsVisible()
        {
            foreach (var s in scriptures)
            {
                if (!s.AllWordsHidden())
                {
                    return true;
                }
            }
            return false;
        }


        /* While loop wokrs as longs as there are verses with visible words, otherwise it will stop. */
        while (AnyWordsVisible())
        {
            /* The specifications sugggested us using .Clear() method, but for some reason I haven't took in, when 
            I try to debug the code, an error displays, I googled for a solution and this seems to work. 
            I always use the debugger tool, since it helps to understand how everything works step by step. */
            try
            {
                Console.Clear();
            }
            catch (IOException) { }
            /* I print the reference, in this case: 1 Kings 1:7-9, provided and stored before. */
            Console.WriteLine(reference.GetDisplayText());

            /* Loop to iterate through the variables. Same logic as the last one. And I use the method .GetDisplayText() from the scriptures class. */
            for (int i = 0; i < scriptures.Count; i++)
            {
                /* I print it adding the number of the verse at the beginning, starting from 7, that part won't disappear, since the method doesn't affect it. */
                Console.WriteLine($"{7 + i}. {scriptures[i].GetDisplayText()}");
            }

            /* Ask for the input. */
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to quit.");
            string input = Console.ReadLine();

            /* If it's quit, the loop breaks and the code below start to work. */
            if (input.ToLower() == "quit")
                break;

            /* Another loop to iterate the variables, store them in a variable and call the method .HideRandomWords(), with 5 as an argument, from the scripture class. */
            foreach (var scripture in scriptures)
            {
                scripture.HideRandomWords(5);
            }
        }

        /* I found a compacter way to write the try-catch statements, I obviously googled it. */
        try { Console.Clear(); } catch (IOException) { }

        Console.WriteLine(reference.GetDisplayText());

        /* The last part of the code that works when all the words are hidden or when the user types "quit". 
        Another loop, same logic, using the method .GetDisplayText() from the scriptures class to display the text. */
        for (int i = 0; i < scriptures.Count; i++)
        {
            /* I print the verses. */
            Console.WriteLine($"{7 + i}. {scriptures[i].GetDisplayText()}");
        }
            /* Final message. */
            Console.WriteLine("\n My job was done, all words are now hidden. I hope you memorized everything!");
    }
}