using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); 

        // a do-while loop or collect numbr fro a user
        int userNumber = -1;
        while(userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            //Add numbers to the list only if is not 0
            if(userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        //firstly compute the sum
        int sum =0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"the sum is: {sum}");

        //secondly compute the averag
        float averag = ((float)sum) / numbers.Count;
        Console.WriteLine($"thee averag is: {averag}");

        //thirdly finding the max

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"the max is:{max}");

        //strecht challenge: find the smallest postive number
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"the smallesr postive number is:{smallestPositive}");
        }
        else
        {
            Console.WriteLine("no positive numbr were entered.");
        }

        //strech challenge2: sort the list and display it
        numbers.Sort();
        Console.WriteLine("the sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
    
}
