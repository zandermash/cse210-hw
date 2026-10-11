class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;
    public List<string> JournalEntries = new List<string> {};


    public void DisplayEntry()
    {


        foreach (string finished in JournalEntries)
        {
            Console.WriteLine(finished);
        }
        ;
    }

    public string CreateJournalEntry()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();

        PromptGenerator prompts = new PromptGenerator ();
        _prompt = prompts.Prompts();

        Console.WriteLine(_prompt);
        Console.Write("> ");
        _response = Console.ReadLine();

        string entry = $"{_date} \n{_prompt}\n{_response}\n";
        JournalEntries.Add(entry);
        
        return "";
    }
}

