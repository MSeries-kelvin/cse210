using System.IO;
using System.IO.Enumeration;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private ProgressManager _progressManager;

    // Construtors
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _progressManager = new ProgressManager();
    }

    // Methods
    public void Start()
    {
        int option;
        string menu = $"Menu Options:\n   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit\nSelect a choice from the menu: ";

        while (true)
        {
            DisplayPlayerInfo();
            Console.Write(menu);
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                CreateGoal();
            }
            else if (option == 2)
            {
                ListGoalDetails();
            }
            else if (option == 3)
            {
                Console.Write("Enter a file name: ");
                string fileName = Console.ReadLine();
                SaveGoals(fileName);
            }
            else if (option == 4)
            {
                Console.Write("Enter a file name: ");
                string fileName = Console.ReadLine();
                LoadGoals(fileName);
            }
            else if (option == 5)
            {
                RecordEvent();
            }
            else if (option == 6)
            {
                break;
            }
        }

    }

    public void DisplayPlayerInfo()
    {
        // Console.WriteLine($"\nYou have {_score} points.\n");
        Console.WriteLine();
        _progressManager.DisplayProgress();
        Console.WriteLine();
    }

    public void ListGoalNames()
    {
        int i = 1;

        Console.WriteLine("The Goals are:");
        foreach (Goal goal in _goals)
        {
            string name = goal.GetName();
            Console.WriteLine($"{i}. {name}");

            i++;
        }
    }

    public void ListGoalDetails()
    {
        int i = 1;
        
        Console.WriteLine("The Goals are:");
        foreach (Goal goal in _goals)
        {
            string goalDetails = goal.GetDetailsString();
            Console.WriteLine($"{i}. {goalDetails}");
            i++;
        }

    }

    public void CreateGoal()
    {
            string menu = "The types of Goals are:\n   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal\nWhich type of Goal would you like to create? ";
            Console.Write(menu);
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                // Get info for and create a Simple Goal Object
                // then append it to the list of Goals
                List<string> basicGoalDetails = GetBasicGoalDetails();
                _goals.Add(new SimpleGoal(basicGoalDetails[0], basicGoalDetails[1], int.Parse(basicGoalDetails[2])));
            }
            else if (option == 2)
            {
                // Get info for and create a Eternal Goal Object
                // then append it to the list of Goals
                List<string> basicGoalDetails = GetBasicGoalDetails();
                _goals.Add(new EternalGoal(basicGoalDetails[0], basicGoalDetails[1], int.Parse(basicGoalDetails[2])));
            }
            else if (option == 3)
            {
                // Get info for and create a Checklist Goal Object
                // then append it to the list of Goals
                List<string> basicGoalDetails = GetBasicGoalDetails();
                int target;
                int bonus;

                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(basicGoalDetails[0], basicGoalDetails[1], int.Parse(basicGoalDetails[2]), target, bonus));
            }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("What goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        
        Goal completedGoal = _goals[goalIndex];
        completedGoal.RecordEvent();

        int gainedPoints = completedGoal.GetPoints();

        _score += gainedPoints;
        
        Console.WriteLine();
        Console.WriteLine($"Congratulations! You have earned {gainedPoints} points!");
        Console.WriteLine($"You now have {_score} points.");

        _progressManager.SetCurrentPoints(_score);
    }

    public void SaveGoals(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string file)
    {
        _goals.Clear();

        string[] lines = File.ReadAllLines(file);
        int score = int.Parse(lines[0]);
        _score = score;

        _progressManager.SetCurrentPoints(score);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];

            string type = line.Substring(0, line.IndexOf(":"));
            string data = line.Substring(line.IndexOf(":") + 1);
            string[] parts = data.Split("~|~");
            
            if (type == "SimpleGoal")
            {
                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);
                bool isComplete = bool.Parse(parts[3]);

                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);

                if (isComplete)
                {
                    simpleGoal.RecordEvent();
                }

                _goals.Add(simpleGoal);
            }
            else if (type == "EternalGoal")
            {
                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);

                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
            }
            else if (type == "ChecklistGoal")
            {
                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);
                int amountCompleted = int.Parse(parts[3]);
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                checklistGoal.SetAmountCompleted(amountCompleted);

                _goals.Add(checklistGoal);
            }
        }
    }

    // helper functions
    private List<string> GetBasicGoalDetails()
    {
        List<string> basicGoalDetails = new List<string>();

        Console.Write("What is the name of your goal? ");
        basicGoalDetails.Add(Console.ReadLine());
        Console.Write("What is a short description of it? ");
        basicGoalDetails.Add(Console.ReadLine());
        Console.Write("What is the amount of point associated with this goal? ");
        basicGoalDetails.Add(Console.ReadLine());

        return basicGoalDetails;
    }

    // Getters and Setters
}