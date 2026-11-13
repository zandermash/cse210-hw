using System;
using System.Diagnostics;
/*
    To exceed the requirements in this assignment, I added a new activity, Grounding Activity. This activity goes through the 5
    senses to help the user de-stress and focus on their environment. It is to help ground them in the present.
    Building this revealed issues, because to get the most out of the activity, it needs to be around 60 seconds. To make this work the 
    best, I made _duration protected rather than private, so I could access it in GroundingActivity. I then took the value that
    was passed into _duration (the one the user gave for how long they want to spend in the activity) and divided it by 5 (for
    each sense). That way it wouldn't awkwardly repeat over and over and would have the perfect split between each part of the 
    activity.
    I also decided to add a "recommended minimum" to each activity. So now, BaseActivity wants the _name of the activity, 
    _description, and _minimum. For each activity I added a recommended minimum to be displayed to the user so they could get the
    most out of the activity.
    Another issue I ran into while building the GroundingActivity, was that the countdown was larger than 1 value, and so it 
    would go from 12, to 1111, 1110, 119, and would not replace the leading 1s. To fix this, I did some research and found that 
    \b doesn't actually delete anything, rather it brings the cursor back one so the value could be rewritten. So after some more
    research, I found that I could get the same result using Console.CursorLeft = cursor.
    Using this, I customized the "RunCountDownMessage()" method to find out the original position of the cursor using int cursor = Console.CursorLeft, 
    and then bringing the cursor back to that value after each count using Console.CursorLeft = cursor. This seemed to have worked,
    but the other problem is it would go from 11 to 10, 90, 80, 70, and so forth, stopping at 10. To fix this I just added Console.Write("\b \b")
    after the sleep logic. This fixed the issue and now everything runs smoothly!
    I also added logic so that if the user added anything that would be less than 3 seconds per prompt, it would force 3 seconds 
    per prompt. This way the prompts dont go by in the blink of an eye.
*/
class Program
{
    static void Main(string[] args)
    {

        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();
        GroundingActivity groundingActivity = new GroundingActivity();

        bool done = false;
        int answer = 0;
        while (!done)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");            
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Start Grounding activity");
            Console.WriteLine("5. Quit");
            Console.Write("Please choose an optiton: ");
            answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                breathingActivity.RunActivity();
            }
            else if (answer == 2)
            {
                reflectingActivity.RunActivity();
            }
            else if (answer == 3)
            {
                listingActivity.RunActivity();
            }
            else if (answer == 4)
            {
                groundingActivity.RunActivity();
            }
            else if (answer == 5)
            {
                done = true;
            }
        }
    }
}