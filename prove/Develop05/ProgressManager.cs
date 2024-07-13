public class ProgressManager
{
    private int _currentPoints;
    private List<int> _neededPoints;
    private List<string> _levels;

    public ProgressManager()
    {
        _currentPoints = 0;

        _levels = new List<string>();
        _levels.Add("Novice");
        _levels.Add("Explorer");
        _levels.Add("Adventurer");
        _levels.Add("Hero");
        _levels.Add("Legend");

        _neededPoints = new List<int>();
        _neededPoints.Add(5000);
        _neededPoints.Add(15000);
        _neededPoints.Add(35000);
        _neededPoints.Add(80000);
    }

    // Methods
    public void DisplayProgress()
    {
        int pointsTillNextLevel = GetPointsTillNextLevel();
        string currentLevel = GetCurrentLevel();
        string nextLevel = GetNextLevel();
        string progressBar = GetProgressBar();

        Console.WriteLine($"Level: ({currentLevel}) --> {nextLevel}");
        Console.WriteLine($"Progress: {_currentPoints}/{pointsTillNextLevel} pts : {progressBar}");
    }

    // helper functions
    private string GetCurrentLevel()
    {
        string currentLevel = "";

        for (int i = 0; i < _neededPoints.Count; i++)
        {
            if (_currentPoints < _neededPoints[i])
            {
                currentLevel = _levels[i];

                i = _neededPoints.Count;
            }
        }

        return currentLevel;
    }

    private string GetNextLevel()
    {
        string nextLevel = "";

        for (int i = 0; i < _neededPoints.Count; i++)
        {
            if (_currentPoints < _neededPoints[i])
            {
                nextLevel = _levels[i + 1];

                i = _neededPoints.Count;
            }
        }

        return nextLevel;
    }

    private int GetPointsTillNextLevel()
    {
        int pointTillNextLevel = 0;

        for (int i = 0; i < _neededPoints.Count; i++)
        {
            if (_currentPoints < _neededPoints[i])
            {
                pointTillNextLevel = _neededPoints[i];

                i = _neededPoints.Count;
            }
        }

        return pointTillNextLevel;
    }

    private string GetProgressBar()
    {
        // [#######---] 95%"
        int pointsTillNextLevel = GetPointsTillNextLevel();
        int percentComplete = _currentPoints * 100 / pointsTillNextLevel;

        string progressBar = "";

        for (int i = 10; i <= percentComplete; i += 10)
        {
            progressBar += "#";
        }

        for (int i = 10; i <= 100 - percentComplete + 10; i += 10)
        {
            progressBar += "-";
        }

        return $"[{progressBar}] {percentComplete}%";
    }

    private void checkCurrentProgress(int points)
    {
        string previousLevel = GetCurrentLevel();

        _currentPoints = points;

        string currentLevel = GetCurrentLevel();

        if (previousLevel != currentLevel)
        {
            Console.WriteLine();
            Console.WriteLine($"Congratulations! You've leveled up to ({currentLevel})!");

            switch(currentLevel)
            {
                case "Explorer":
                    Console.WriteLine("Keep pushing forward!");
                    break;
                case "Adventurer":
                    Console.WriteLine("Your skills are improving!");
                    break;
                case "Hero":
                    Console.WriteLine("You're becoming a true expert!");
                    break;
                case "Legend":
                    Console.WriteLine("You're a legend in the making!");
                    break;
            }
        }
    }

    // getter and setters
    public void SetCurrentPoints(int points)
    {
        checkCurrentProgress(points);
    }
}