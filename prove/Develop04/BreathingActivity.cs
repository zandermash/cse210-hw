using System.Data;

class BreathingActivity : BaseActivity
{

    public BreathingActivity()
    :base("Breating Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 10)
    {
    }
    public void RunActivity()
    {
        StartActivity();

        StartTimer();

        while(! HasTimerExpired())
        {
            Console.Clear();
            RunCountDownMessage("Breath in...", 4);
            RunCountDownMessage("Now breath out...", 6);
            Console.WriteLine();
        }

        EndActivity();
    }
}