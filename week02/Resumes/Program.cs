using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYar = 2019;
        job1._endYear = 2022;

        Job job2 = new();
        job2._jobTitle = "Programmer";
        job2._company = "Microsoft";
        job2._startYar = 2022;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "John Bull";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}