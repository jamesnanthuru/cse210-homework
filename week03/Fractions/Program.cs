using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Test the no-argument constructor (1/1)
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // 2. Test the one-argument constructor (5/1)
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // 3. Test the two-argument constructor (3/4)
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // 4. Test another two-argument constructor (1/3)
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // 5. Test the Getters and Setters (Encapsulation in action)
        Console.WriteLine("\n--- Testing Encapsulation ---");
        Fraction f5 = new Fraction();
        
        // We cannot do f5._top = 6; (This would cause a compiler error because it is private)
        // Instead, we must use the public setter method:
        f5.SetTop(6);
        f5.SetBottom(7);
        
        Console.WriteLine($"New Fraction: {f5.GetFractionString()}");
        Console.WriteLine($"New Decimal: {f5.GetDecimalValue()}");
    }
}