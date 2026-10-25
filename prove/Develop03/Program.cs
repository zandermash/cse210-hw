using System;
using System.Diagnostics;
using System.Formats.Asn1;

class Program
{
    // To excede the requirements, I let the user input their own scripture.

    static void Main(string[] args)
    {
        ScriptureBuilder build = new ScriptureBuilder();
        Scripture myScripture = build.GetCustomScripture();
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

