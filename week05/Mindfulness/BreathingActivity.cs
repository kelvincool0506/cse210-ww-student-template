public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Breathe in... Breathe out...");
        ShowSpinner(5); // Simulate breathing exercise
        DisplayEndingMessage();
    }
}
