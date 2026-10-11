using System.ComponentModel;
using System.IO;
using System.IO.Enumeration;

class FileManager
{
    JournalEntry myjournal = new JournalEntry ();
    
    public void WriteToFile(List<string> entries, string filename)
    {

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string entry in entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }
    public List<string> LoadFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        List<string> loadedEntries = new List<string> {};
        foreach (string line in lines)
        {
            //string[] parts = line.Split(",");
            loadedEntries.Add(line);
            
            // string firstName = parts[0];
            // string lastName = parts[1];
        }
        return loadedEntries;
    }
}
