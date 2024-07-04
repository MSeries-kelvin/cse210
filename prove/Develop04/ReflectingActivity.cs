public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    // Constructors
    public ReflectingActivity(string name, string description) :
        base(name, description)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    // Methods
    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        Console.Clear();

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(10);
            Console.WriteLine();
        }

        Console.WriteLine();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(_questions.Count);
        string randomQuestion = _questions[randomIndex];
        return randomQuestion;
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {prompt} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.Write($"> {question} ");
    }
}