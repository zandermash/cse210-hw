using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Net;

class Menu
{
    public int ProcessMenu()
    {
        int response = 0;
        Console.WriteLine("Welcome to the Journaling Program!");
        JournalEntry entry = new JournalEntry ();
        FileManager file = new FileManager();
        while (response != 5)
        {
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Create new Journal entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save journal file");
            Console.WriteLine("4. Load Journal from file");
            Console.WriteLine("5. Quit ");
            Console.Write("> ");
            response = int.Parse(Console.ReadLine());

            if (response == 1)
            {
                entry.CreateJournalEntry();
            }
            
            else if (response == 2) 
            {
                entry.DisplayEntry();
            }

            else if (response == 3)
            {
                Console.WriteLine("What is the name of your new file?");
                Console.Write("> ");
                string filename = Console.ReadLine();

                file.WriteToFile(entry.JournalEntries, filename);
            }
            else if (response == 4)
            {
                
                Console.WriteLine("What is the filename?");
                Console.Write("> ");
                string filename = Console.ReadLine();
                entry.JournalEntries = file.LoadFile(filename);
            }


        }

        return 1;
    }
}