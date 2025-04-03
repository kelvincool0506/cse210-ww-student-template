using System;
using System.Collections.Generic;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}: {_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending {_name}. Duration: {_duration} seconds.");
    }

    public void ShowSpinner(int seconds)
    {
        Console.WriteLine($"Displaying spinner for {seconds} seconds...");
        // Simulate spinner
    }

    public void ShowCountDown(int seconds)
    {
        Console.WriteLine($"Counting down for {seconds} seconds...");
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"{i}...");
            System.Threading.Thread.Sleep(1000); // Simulate countdown
        }
    }
}
