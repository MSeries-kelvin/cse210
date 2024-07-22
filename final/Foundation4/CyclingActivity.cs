public class CyclingActivity : Activity
{
    // Member Variables
    private double _speed;

    // Construtors
    public CyclingActivity(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }
    
    // Methods
    public override double GetDistance()
    {
        // Divides GetLength() by 60 to convert
        // length (minutes) to 'hour'
        return _speed * (GetLength() / 60);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    // Helper Functions
    // Getters and Setters
}