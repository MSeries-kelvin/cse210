public class BreathingActivity : Activity
{
    // Constructors
    public BreathingActivity(string name, string description) :
        base(name, description)
    {
        
    }

    // Methods
    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("Breath in...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Now breath out...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}
