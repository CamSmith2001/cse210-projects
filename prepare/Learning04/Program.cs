using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Console.WriteLine();

        Assignment csa = new Assignment("Cam Smith", "Math");
        Console.WriteLine(csa.GetSummary());

        Console.WriteLine();

        MathAssignment csa2 = new MathAssignment("Cam Smith", "Fractions", "7.3", "8-19");
        Console.WriteLine(csa2.GetSummary());
        Console.WriteLine(csa2.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment csa3 = new WritingAssignment("Cam Smith", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(csa3.GetSummary());
        Console.WriteLine(csa3.GetWritingInformation());

        Console.WriteLine();
    }
}