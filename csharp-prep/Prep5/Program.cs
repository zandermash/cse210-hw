using System;

class Program
{
        static void DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the Program!");
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
        string input = Console.ReadLine();
        int userNumber = int.Parse(input);
            return userNumber;
    }

        static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter your Birth Year: ");
        string input = Console.ReadLine();
        birthYear = int.Parse(input);
    }

        static int SquareNumber(int userNumber)
    {
        int square = userNumber * userNumber;
            return square;
    }

        static void DisplayResult(string userName, int userNumber, int birthYear, int squaredNumber)
    {
        int age = 2026 - birthYear;
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        Console.WriteLine($"{userName}, you will turn {age} this year");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        PromptUserBirthYear(out int birthYear);
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, userNumber, birthYear, squaredNumber);
    }


}