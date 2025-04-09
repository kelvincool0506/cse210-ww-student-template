using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.AddGoal(new SimpleGoal("Run a marathon", 1000));
        manager.AddGoal(new EternalGoal("Read scriptures", 100));
        manager.AddGoal(new ChecklistGoal("Attend temple", 50, 500, 3));

        bool running = true;
        while (running)
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine("1. Display goals");
            Console.WriteLine("2. Record event");
            Console.WriteLine("3. Show score");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Load goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.DisplayGoals();
                    break;
                case "2":
                    Console.WriteLine("\nRecord an event:");
                    manager.DisplayGoals();
                    Console.Write("Select a goal: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(index);
                    break;
                case "3":
                    Console.WriteLine($"Your score: {manager.GetScore()}");
                    break;
                case "4":
                    manager.SaveGoals("goals.txt");
                    Console.WriteLine("Goals saved!");
                    break;
                case "5":
                    manager.LoadGoals("goals.txt");
                    Console.WriteLine("Goals loaded!");
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
