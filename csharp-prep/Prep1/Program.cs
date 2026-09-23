using System;

class Program
{
    static void Main(string[] args)
    {
        string firstName;
        string lastName;

        Console.Write("Please enter your first name");
        firstName = Console.ReadLine();

        Console.Write("Please enter your last name:");
        lastName = Console.ReadLine();

<<<<<<< HEAD
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
=======
        Console.WriteLine($"Your name is: {lastName}, {firstName} {lastName}");
>>>>>>> 452cc2006252e1f947cf93214c95423758fd6849
    }
}