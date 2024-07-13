using System.Data.SqlTypes;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    // Construtors
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    // Methods
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        // Create a saveable format here
        // GoalType:{name}~|~{description}~|~{points}~|~{isComplete}
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        bool isComplete = IsComplete();

        return $"SimpleGoal:{name}~|~{description}~|~{points}~|~{isComplete}";
    }

    // Getters and Setters
}