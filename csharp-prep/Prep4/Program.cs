using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int addNumber = -1;

        while (addNumber != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            addNumber = int.Parse(input);
            
            if(addNumber != 0)
            {
                numbers.Add(addNumber);
            }

        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int highest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > highest)
            {
                highest = number;
            }
        }

        Console.WriteLine($"The max is: {highest}");



    }
}