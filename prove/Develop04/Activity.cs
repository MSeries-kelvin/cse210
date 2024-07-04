public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    // Constructors
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long in seconds, would you like for your session? ");

        int duration = int.Parse(Console.ReadLine());
        _duration = duration;

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(4);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(4);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinnerElements = new List<string>();

        spinnerElements.Add("|");
        spinnerElements.Add("/");
        spinnerElements.Add("-");
        spinnerElements.Add("\\");
        spinnerElements.Add("|");
        spinnerElements.Add("/");
        spinnerElements.Add("-");
        spinnerElements.Add("\\");

        DateTime startDate = DateTime.Now;
        DateTime endDate = startDate.AddSeconds(seconds);

        int index = 0;

        while (DateTime.Now < endDate)
        {
            Console.Write(spinnerElements[index] + " ");
            Thread.Sleep(500);
            Console.Write("\b\b \b");

            index++;

            if (index >= spinnerElements.Count)
            {
                index = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds--;
        }
    }

    // getters
    public int GetDuration()
    {
        return _duration;
    }
}