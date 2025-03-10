using System;

public class Resume
{
    public string _name;

    //initializing my list to a new list before using it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("jobs:");

        //observer the  custom Data type "job" in this loop
        foreach (Job job in _jobs)
        {
            //this displays method on each job
            job.Display();
        }
    }
}