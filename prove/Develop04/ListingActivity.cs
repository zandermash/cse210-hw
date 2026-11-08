using System.Data;

class ListingActivity : BaseActivity
{

    public ListingActivity()
    :base("Listing Activity", "This activity will help you reflect on the good things in you life by having you list as many things as you can in a certain area", 10)
    {
    }

    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    
    public string GetRandomPrompt()
{
    Random random = new Random();
    int index = random.Next(_prompts.Count);
    return _prompts[index];
}

    public void RunActivity()
    {
        int count = 0;

        StartActivity();
        StartTimer();

        Console.Clear();
        Console.WriteLine("List as many responses as you can to the following prompt: \n");
        string prompt = GetRandomPrompt();
        Console.WriteLine($" --- {prompt} --- \n");
        Console.WriteLine("When you have something in mind, press enter to continue");
        RunCountDownMessage("You may begin in:", 5);

        while(! HasTimerExpired())
        {
            count += 1;
            Console.Write("> ");
            Console.ReadLine();
        }
        Console.WriteLine($"You listed {count} items!");
        Thread.Sleep(2000);

        EndActivity();
    }

}