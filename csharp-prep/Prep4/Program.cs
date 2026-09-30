using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        bool done = false;
        int sum = 0;
        double ave = 0;
        int largest = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (!done)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int numberList = int.Parse(input);
            if (numberList == 0)
            {
                done = true;
            }
            else
            {
                numbers.Add(numberList);
            }
        }
        foreach (int i in numbers)
        {
            sum += i;
            ave = (double)sum / numbers.Count;
            if (i > largest)
            {
                largest = i;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {ave}");
        Console.WriteLine($"The largest number in the list is: {largest}");
    }
}