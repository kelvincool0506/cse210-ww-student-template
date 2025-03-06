using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"your grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("you passed");
        }
        else
        {
            Console.WriteLine("Try Again Next Time");
        }
        

    }
}