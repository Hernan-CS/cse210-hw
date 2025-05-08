using System;
class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);
        int guess;

        Console.WriteLine("Welcome to the Magic Number Game! Here you're going to try to guess a random number. Show time!");

        do {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            
            if (guess < magic_number){
                Console.WriteLine("Higher");
            }
            else if (guess > magic_number){
                Console.WriteLine("Lower");
            }
            
        } while (guess != magic_number);

        Console.WriteLine("You guessed it!");

    }
}