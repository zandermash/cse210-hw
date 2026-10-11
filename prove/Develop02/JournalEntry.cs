class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date}, ");
        Console.WriteLine($"{_prompt}, ");
        Console.WriteLine($"{_response}, ");
    }

    public void CreateJournalEntry()
    {
        _date = "October 7, 2026"; // need to get datetime
        _prompt = "How was your day? "; // need to make promp generator class

        Console.Write($"{_prompt}");
        _response = Console.ReadLine();
    }
}

