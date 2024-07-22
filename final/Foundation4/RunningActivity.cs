public class RunningActivity : Activity
{
    // Member Variables
    private double _distance;

    // Construtors
    public RunningActivity(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    // Methods
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()   
    {
        // Divides GetLength() by 60 to convert
        // length (minutes) to 'hour'
        return _distance / (GetLength() / 60);
    }

    public override double GetPace()
    {
        return GetLength() / _distance;
    }

    // Helper Functions
    // Getters and Setters
}