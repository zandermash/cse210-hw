using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your current grade percentage?");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);

        if (percentage >= 90)
        {
            Console.WriteLine("You have an A");
        }
        else if (percentage >= 80 && percentage < 90)
        {
            Console.WriteLine("You have a B");
        }
        else if (percentage >= 70 && percentage < 80)
        {
            Console.WriteLine("You have a C");
        }
        else if (percentage >= 60 && percentage < 70)
        {
            Console.WriteLine("You have a D");
        }
        else
        {
            Console.WriteLine("You have an F");
        }
        if (percentage >= 70)
        {
            Console.WriteLine("You have passed the class!");
        }
        else
        {
            Console.WriteLine("You did not pass the class. You got it next time!");
        }
    }
}