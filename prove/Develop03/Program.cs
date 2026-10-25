using System;
using System.Diagnostics;
using System.Formats.Asn1;

class Program
{
    // To excede the requirements, I added a new class called Scripture Library with a few
    // options of preloaded scriptures for the user to choose from, or the option to use their own scripture
    // and the option to add that scripture to the list of preloaded scriptures so they can use that later.

    static void Main(string[] args)
    {
        Scripture myScripture = new Scripture("Moses", 1, 39, 
            "Behold, this is my work and my glory to bring to pass the immortality and eternal life of man");
        bool done = false;
        while (!done)
        {
            Console.Clear();
            myScripture.ShowScripture();
            Console.Write("\n\nPress enter to continue or type 'quit' to finish:\n");
            
            if(myScripture.IsCompletelyHidden() == true)
            {
                done = true;
            }
            else
            {
                string answer =Console.ReadLine();
                if (answer == "quit")
                {
                    done = true;
                }
                else
                {
                    myScripture.HideRandomWords(3);
                }
            }
        }
    }
}

