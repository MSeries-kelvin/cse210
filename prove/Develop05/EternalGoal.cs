public class EternalGoal : Goal
{
    // Construtors
    public EternalGoal(string name, string description, int points) : 
        base(name, description, points) 
    {/* it does nothing */}

    // Methods
    public override void RecordEvent() {/* it does nothing */}

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        // Create a saveable format here
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();

        return $"EternalGoal:{name}~|~{description}~|~{points}";
    }

    // Getters and Setters
}