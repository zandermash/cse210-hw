class Scripture
{
    private List<Word> _words;
    private Reference _reference;


    public Scripture (string book, int chapter, int verse, string text)
    {
        _words = ConvertToWordList(text);

        _reference = new Reference(book, chapter, verse);
        
        // _words[0].Hide();
    }

    public Scripture (string book, int chapter, int startVerse, int endVerse, string text)
    {
        _words = ConvertToWordList(text);

        _reference = new Reference(book, chapter, startVerse, endVerse);
    }

    public void ShowScripture()
    {
        Console.Write($"{_reference.GetDisplayText()}\n");

        foreach(Word word in _words)
        {
            word.Display();
        }
    }


    /***************************************************************
    * ConvertToWordList() - this method will recieve a string parmater,
    * which is a paragraph of text.  It will split that text into words
    * and add those words to a List<word> and return the list
    *****************************************************************/
    private List<Word> ConvertToWordList(string text)
    {
        List<Word> tempWordList = new List<Word>();
        string[] tempWords = text.Split(' ');
        foreach(string w in tempWords)
        {
            Word tempWord = new Word(w);
            tempWordList.Add(tempWord);
        }

        return tempWordList;
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsUnhidden = 0;
        int wordsHidden = 0;
        foreach(Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                wordsUnhidden++;
            }
        }
        if (wordsUnhidden < numberToHide)
        {
            numberToHide = wordsUnhidden;
        }
        while (wordsHidden < numberToHide)
        {
            int ranNumber = random.Next(_words.Count);
            if (_words[ranNumber].IsHidden() == false)
            {
                _words[ranNumber].Hide();
                wordsHidden++;
            }
        }
    }
        public bool IsCompletelyHidden()
    {

        foreach(Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}