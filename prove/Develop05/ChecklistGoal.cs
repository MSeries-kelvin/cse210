public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Construtors
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : 
        base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Methods
    public override void RecordEvent()
    {
        _amountCompleted++;
        
        if(IsComplete())
        {
            AddPoints(_bonus);
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }

        return false;
    }

    public override string GetDetailsString()
    {
        string name = GetName();
        string description = GetDescription();
        string checkBox = "[ ]";
        
        if (IsComplete())
        {
            checkBox = "[X]";
        }

        return $"{checkBox} {name} ({description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        // Create a saveable format here
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();

        return $"ChecklistGoal:{name}~|~{description}~|~{points}~|~{_amountCompleted}~|~{_target}~|~{_bonus}";
    }

    // Getters and Setters

    public int GetBonus()
    {
        return _bonus;
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
}