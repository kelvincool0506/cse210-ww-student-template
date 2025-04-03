public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _prompts = new List<string> { "Describe your favorite memory.", "List your goals for the year." };
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Please respond to the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        var userResponses = GetListFromUser();
        _count = userResponses.Count;
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        Console.WriteLine("Enter your responses (type 'end' to stop):");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "end")
                break;
            responses.Add(input);
        }
        return responses;
    }
}
