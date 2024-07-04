public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    // Constructors
    public ListingActivity(string name, string description) :
        base(name, description)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    // Methods
    public void Run()
    {
        DisplayStartingMessage();

        GetRandomPrompt();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            GetListFromUser();
        }

        Console.WriteLine($"You listed {_count} itmes");

        Console.WriteLine();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        Console.WriteLine("List as many responses you can do to the following prompt:");
        Console.WriteLine($"--- {randomPrompt} ---");
        Console.WriteLine("You may begin in ");
        ShowCountDown(5);
    }

    public List<string> GetListFromUser()
    {
        Console.Write("> ");
        Console.ReadLine();
        _count++;
        return new List<string>();
    }
}