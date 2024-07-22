public class SwimmingActivity : Activity
{
    // Member Variables
    private int _numbersOfLaps;

    // Construtors
    public SwimmingActivity(string date, int length, int numbersOfLaps) : base(date, length)
    {
        _numbersOfLaps = numbersOfLaps;
    }

    // Methods
    public override double GetDistance()
    {
        return _numbersOfLaps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        // Divides GetLength() by 60 to convert
        // length (minutes) to 'hour'
        return GetDistance() / GetLength() * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    // Helper Functions
    // Getters and Setters
}