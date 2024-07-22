using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");
        RunningActivity runningActivity1 = new RunningActivity("20 Nov 2024", 60, 200);
        CyclingActivity cyclingActivity1 = new CyclingActivity("15 Jun 2024", 120, 300);
        SwimmingActivity swimmingActivity1 = new SwimmingActivity("17 Dec 2024", 300, 300);

        List<Activity> activities = new List<Activity>() { runningActivity1, cyclingActivity1, swimmingActivity1 };

        Console.WriteLine();
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
        
    }
}