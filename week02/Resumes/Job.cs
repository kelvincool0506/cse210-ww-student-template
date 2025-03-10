using System;
using System.Collections.Generic;
public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYar;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYar}-{_endYear}");
    }
}