// Base class
public abstract class Shape
{
    public string Color { get; set; }

    public Shape(string color)
    {
        Color = color;
    }

    // Abstract method for computing area
    public abstract double GetArea();
}
