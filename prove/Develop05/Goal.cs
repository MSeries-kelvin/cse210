using System.ComponentModel.Design;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    // Construtors
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Methods
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string checkBox = "[ ]";
        
        if (IsComplete())
        {
            checkBox = "[X]";
        }

        return $"{checkBox} {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();

    // Getters and Setters
    public string GetName()
    {
        return _shortName;
    }

    // public void SetName();

    public string GetDescription()
    {
        return _description;
    }

    // public void SetDescription();

    public int GetPoints()
    {
        return _points;
    }

    public void AddPoints(int points)
    {
        _points += points;
    }
}