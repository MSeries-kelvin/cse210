using System.IO;

public class LogKeeper
{
    private int _log;

    public LogKeeper()
    {
        _log = 0;
    }

    // method
    public void Add()
    {
        _log++;
    }

    public void ShowLog()
    {
        if (_log > 0)
        {
            Console.WriteLine($"Congratulations you've performed {_log} activities");
        }
        else
        {
            Console.WriteLine($"You completed {_log} activities");
        }
    }
    
    public void SaveToFile(string file)
    {
        using(StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_log);
        }
    }

    public void LoadFromFile(string file)
    {
        string[] log = System.IO.File.ReadAllLines(file);
        _log = int.Parse(log[0]);
    }
}