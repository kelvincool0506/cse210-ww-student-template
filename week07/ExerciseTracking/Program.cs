using System;
using System.Collections.Generic;

// Base Activity class
abstract class Activity
{
    // Encapsulated private attributes
    private string name;
    private double time; // in hours
    
    // Constructor for shared attributes
    public Activity(string name, double time)
    {
        this.name = name;
        this.time = time;
    }

    // Public properties for accessing private attributes
    public string Name => name;
    public double Time => time;

    // Abstract methods for calculation (to be overridden)
    public abstract double GetDistance();
    public abstract double GetSpeed(); // Distance per time
    public abstract double GetPace();  // Time per distance

    // GetSummary method
    public virtual string GetSummary()
    {
        return $"Activity: {name}, Time: {time} hrs, Distance: {GetDistance()} km, Speed: {GetSpeed()} km/hr, Pace: {GetPace()} hrs/km";
    }
}

// Derived class for Running
class Running : Activity
{
    private double distance; // in kilometers

    public Running(string name, double time, double distance) : base(name, time)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;
    public override double GetSpeed() => distance / Time;
    public override double GetPace() => Time / distance;
}

// Derived class for Swimming
class Swimming : Activity
{
    private double laps; // number of laps
    private double lapLength; // length of a lap in kilometers

    public Swimming(string name, double time, double laps, double lapLength) : base(name, time)
    {
        this.laps = laps;
        this.lapLength = lapLength;
    }

    public override double GetDistance() => laps * lapLength;
    public override double GetSpeed() => GetDistance() / Time;
    public override double GetPace() => Time / GetDistance();
}

// Derived class for Cycling
class Cycling : Activity
{
    private double distance; // in kilometers

    public Cycling(string name, double time, double distance) : base(name, time)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;
    public override double GetSpeed() => distance / Time;
    public override double GetPace() => Time / distance;
}

// Program class
class Program
{
    static void Main(string[] args)
    {
        // Create activities
        Running run = new Running("Morning Run", 1.5, 10);
        Swimming swim = new Swimming("Pool Swim", 2, 30, 0.05); // 30 laps of 50 meters (0.05 km)
        Cycling cycle = new Cycling("Weekend Cycling", 3, 60);

        // Add activities to a list
        List<Activity> activities = new List<Activity> { run, swim, cycle };

        // Iterate and display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
