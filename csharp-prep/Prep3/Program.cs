using System;

class Program
{
    static void Main(string[] args)
    {

        // Console.Write("What is the magic number? ");
        // string magic = Console.ReadLine();
        // int mNumber = int.Parse(magic);

        int guess = -1;

        Random randomgenerator = new Random();
        int magicNumber = randomgenerator.Next(1, 100);

        while (guess != magicNumber)
        {

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
 
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}