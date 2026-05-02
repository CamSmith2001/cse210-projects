using System;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

class Program
{


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int userNumber = int.Parse(number);
        return userNumber;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write($"Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int favNum)
    {
        int square = favNum * favNum;
        return square;
    }

    static void DisplayResult(string userName, int squareNum, int birthYear)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNum}");
        int age = 2026 - birthYear;
        Console.WriteLine($"{userName}, you will turn {age} this year."); 
    }



    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        PromptUserBirthYear(out int birthYear);
        int squareNum = SquareNumber(userNum);
        DisplayResult(userName, squareNum, birthYear);
    }


}