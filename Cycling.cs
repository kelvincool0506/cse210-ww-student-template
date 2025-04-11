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