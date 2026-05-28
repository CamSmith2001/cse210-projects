using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);        
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        Fraction f5 = new Fraction();
        Random random = new Random();
        for (int i = 0; i < 20; i++)
        {
            int top = random.Next(1, 11);
            int bottom = random.Next(1, 11);
            f5.SetTop(top);
            f5.SetBottom(bottom);
            Console.WriteLine($"Fraction {i + 1}: String: {f5.GetFractionString()} Number: {f5.GetDecimalValue()}");
            // Console.WriteLine($"String: {f5.GetFractionString()}");
            // Console.WriteLine($"Number: {f5.GetDecimalValue()}");
        }
    }
}