using System;

namespace ScriptureHiding
{
    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            // Create a scripture reference
            var reference = new Reference("John", 3, 16);

            // Create a scripture with the reference and text
            var scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son");

            // Main loop
            while (!scripture.IsCompletelyHidden())
            {
                Console.Clear(); // Clear the console
                Console.WriteLine(scripture.GetDisplayText());

                Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                // Hide 2 random words each time
                scripture.HideRandomWords(2);
            }

            // Final display when all words are hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ending.");
            }
        }
    }
}