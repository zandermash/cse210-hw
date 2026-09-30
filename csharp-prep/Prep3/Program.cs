using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int x = randomGenerator.Next(1, 100);;
        bool done = false;
        int count = 0;
        while (!done)
        {
            count += 1;
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();
            int guess = int.Parse(input);
            if (guess == x)
            {
                Console.WriteLine("You guessed it!");
                done = true;
            }
            else if (guess > x)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }
        Console.WriteLine($"You guessed {count} many times!");
    }
}