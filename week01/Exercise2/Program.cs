using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter your grade percentage: ");
        string score = Console.ReadLine();

        int grade = int.Parse(score);
        string score_letter;
        if (grade >= 90)
        {
            score_letter = "A";
        }
        else if (grade >= 80)
        {
            score_letter = "B";
        }
        else if (grade >= 70)
        {
            score_letter = "C";
        }
        else if (grade >= 60)
        {
            score_letter = "D";
        }
        else
        {
            score_letter = "F";
        }
        
        if (score_letter == "A" || score_letter == "B" || score_letter == "C")
        {
            Console.WriteLine($"Your grade is {score_letter}. Congratulations for your effort and persistence!");
        }
        else
        {
            Console.WriteLine($"Your grade is {score_letter}. Lamentably, you didn't pass. Don't discourage though, there's no improvement without rocks through the success path.");
        }
        
    }

}