public class EternalGoal : Goal
{
    // Construtors
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    // Methods
    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }

    // Getters and Setters
}