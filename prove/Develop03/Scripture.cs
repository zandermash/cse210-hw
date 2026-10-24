

class Scripture
{
    private string _words;
    Word myWord = new Word();






    public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        // TODO
    }

    public void ShowScripture()
    {
        foreach(Word word in _words)
        {
            word.Display();
        }
    }





    private List<Word> ConvertToWords(string text)
    {
        List<Word> tempWords = new List<Word>();
    }
}