using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

class BaseActivity
{
    private string _name;
    private string _description;
    protected int _duration;
    private DateTime _endTime;
    private int _minimum;

    public BaseActivity(string name, string description, int minimum)
    {
        _name = name;
        _description = description;
        _minimum = minimum;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");

        ObtainDuration(_minimum);

        Console.Clear();
        RunSpinnerMessage("Get Ready...", 5);

    }

    public void EndActivity()
    {
        RunSpinnerMessage("Well Done!", 5);
        RunSpinnerMessage($"You have completed {_duration} seconds of {_name}", 5);
    }

    public void ObtainDuration(int minimum)
    {
        Console.WriteLine($"How long, in seconds, do you want this session to last? (I recommend a minimum of {minimum} seconds)");
        Console.Write("> ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
    }


    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now > _endTime;
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        Console.Write($"{message} ");

        int cursor = Console.CursorLeft;

        for(int i = seconds; i > 0; i--)
        {
            Console.CursorLeft = cursor;
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
        Console.WriteLine();
        Console.CursorVisible = true;
    }

    public void RunSpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        Console.Clear();
        Console.Write($"{message} ");
        for (int i=0; i<seconds; i++)
        {
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
        Console.CursorVisible = true;
    }
}