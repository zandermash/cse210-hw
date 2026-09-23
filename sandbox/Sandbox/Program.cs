using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bonjour tout le monde!");

        // Input / Output
        int a = 10;
        Console.WriteLine($"a is {a}"); // this is how to do a formated string
        //Console.Write();
        Console.ReadLine(); // reads a line
        int x = 10;
        int y = 21;
        int z = 30;

/*
|| = OR
&& = AND
*/

        if (x == 10 || y == 21 && z == 30)
        {
            Console.WriteLine ("X is 10");
            Console.WriteLine ("Y is fun");
        }
        else if (x == 20)
        {
            Console.WriteLine("We are in the else if.");
        }
        else
        {
            Console.WriteLine("Z is not so much fun");
        }
    }
}