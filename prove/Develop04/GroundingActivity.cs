using System.Data;

class GroundingActivity : BaseActivity
{

    public GroundingActivity()
    :base("Grounding Activity", "You will need at least a minute to fully take advantage of this activity.\nThis activity will help you ground yourself by guiding you to notice things in your immediate environment. This brings your focus away from internal stress and into the present moment.", 60)
    {
    }

    public void RunActivity()
    {
        StartActivity();
        StartTimer();
        int timePerPrompt = _duration / 5;
        if (timePerPrompt < 3)
        {
            timePerPrompt = 3;
        }

        Console.Clear();
        RunCountDownMessage("Notice 5 things you can see around you...", timePerPrompt);
        RunCountDownMessage("Notice 4 things you can physically feel...", timePerPrompt);
        RunCountDownMessage("Notice 3 things you can hear...", timePerPrompt);
        RunCountDownMessage("Notice 2 things you can smell...", timePerPrompt);
        RunCountDownMessage("Notice 1 thing you can taste...", timePerPrompt);
        Console.WriteLine();

        EndActivity();
    }

}