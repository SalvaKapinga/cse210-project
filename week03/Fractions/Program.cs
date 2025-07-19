using System;

class Program
{
    static void Main(string[] args)
    {
        // Using different constructors
        Fraction f1 = new Fraction();             // 1/1
        Fraction f2 = new Fraction(5);            // 5/1
        Fraction f3 = new Fraction(3, 4);         // 3/4
        Fraction f4 = new Fraction(1, 3);         // 1/3

        // Display results
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Setters and Getters demo
        f1.SetTop(7);
        f1.SetBottom(2);
        Console.WriteLine("Updated f1:");
        Console.WriteLine(f1.GetFractionString()); // Should be 7/2
        Console.WriteLine(f1.GetDecimalValue());   // Should be 3.5
    }
}
