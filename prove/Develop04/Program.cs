using System;

class Program
{
    static void Main(string[] args)
    {
        BaseActivity activity = new BaseActivity();
        activity.RunCountDownMessage("Get ready", 5);
        activity.DisplaySpinnerMessage("Well Done ", 5);
    }
}