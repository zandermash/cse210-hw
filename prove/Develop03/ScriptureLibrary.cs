

class ScriptureBuilder
{
    public Scripture GetCustomScripture()
    {
        Console.Write("Enter the book: ");
        string book = Console.ReadLine();
        
        Console.Write("Enter the chapter: ");
        int chapter = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the starting verse: ");
        int verse = int.Parse(Console.ReadLine());

        Console.Write("Enter the ending verse (if there is only 1 verse enter the same as the starting verse): ");
        int endVerse = int.Parse(Console.ReadLine());        
        

        Console.Write("Enter the verse: ");
        string text = Console.ReadLine();




        return new Scripture(book, chapter, verse, endVerse, text);
    }
}