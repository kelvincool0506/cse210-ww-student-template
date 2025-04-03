public class ReflectingActivity : Activity
{
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _questions = new List<string> { "Why did this experience matter to you?", "What lessons can you take from it?" };
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        return "Think of a time when you overcame a challenge.";
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine("Consider the following questions:");
        foreach (string question in _questions)
        {
            Console.WriteLine(question);
        }
    }
}
