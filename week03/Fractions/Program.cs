using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.ToFractionString());
        Console.WriteLine(f1.ToDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.ToFractionString());
        Console.WriteLine(f2.ToDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.ToFractionString());
        Console.WriteLine(f3.ToDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.ToFractionString());
        Console.WriteLine(f4.ToDecimalValue());

        // Additional test case for a fraction as a string
        Fraction f5 = new Fraction("7/8");
        Console.WriteLine(f5.ToFractionString());
        Console.WriteLine(f5.ToDecimalValue());
    }
}
