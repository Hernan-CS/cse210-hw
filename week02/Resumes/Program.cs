using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("---Résumé---");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Junior Programmer";
        job1._startYear = 2013;
        job1._endYear = 2017;

        Job job2 = new Job();
        job2._company = "Mojang";
        job2._jobTitle = "Designer";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "John Doe";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}