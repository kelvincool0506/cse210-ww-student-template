using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        // Default to 1/1
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
        
    }

    public Fraction(string fractionString)
    {
        // Parse fraction from string
        string[] parts = fractionString.Split('/');
        _numerator = int.Parse(parts[0]);
        _denominator = int.Parse(parts[1]);
       
    }

    public string ToFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public double ToDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }
 }


