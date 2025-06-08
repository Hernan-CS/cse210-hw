using System;

class Program
{
    static void Main(string[] args)
    {
        /* Game main loop */
        while (true)
        {
            /* Clear terminal & display options */
            Console.Clear();
            /* Display the menu */
            Console.WriteLine("|-----Mindfulness Program-----|");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            /* I used a switch statement to choose among the options, once one is chosen, it runs an specific code depending on the input */
            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ReflectionActivity().Run();
                    break;
                case "3":
                    new ListingActivity().Run();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid input. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}