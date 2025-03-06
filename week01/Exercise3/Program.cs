class Program 
{
    static void Main(string[] args)
    {
        // For Parts 1 and 2, where the user specified the number...
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        int guess = 0; 
        int attempts = 0;

        Console.WriteLine(" Welcome to the Guess My Number game.");
        Console.Write("What is the magic number? ");

        // Use a while loop here...

        while (guess != magicNumber)
        {
            Console.WriteLine("what is your guess?");
            guess = int.Parse(Console.ReadLine());

            attempts++;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("lower");
            }
            else
            {
                Console.WriteLine($"Congratulations! you Guessed right in  {attempts} attempts.");
            }
        }
    } // This closes the Main method

} // This closes the Program class
