using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Hernan Cancino", "Multiplication");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();

        MathAssignment m1 = new MathAssignment("Hernan Cancino", "Multiplication", "7", "0-100");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment w1 = new WritingAssignment("Magda Santiago", "Peruvian History", "Black Death in Peru - 19030");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
    }
}