using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string response;
        int number;
        int sum = 0;
        float avg = 0;

        

        Console.WriteLine("--Enter a list of numbers, type 0 when finished.--");
        do {
            Console.Write("Enter number: ");
            response = Console.ReadLine();

            if (response != "0")
            {
            number = int.Parse(response);
            numbers.Add(number);    
            }
            
        } while (response != "0");

        int lgnum = numbers[0];
        
        foreach (int i in numbers)
        {
            sum += i;
            avg = ((float)sum)/numbers.Count;

            if (i > lgnum)
            {
                lgnum = i;
            } 

        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {lgnum}");
    }
}