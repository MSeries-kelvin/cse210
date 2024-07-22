public abstract class Activity
{
    // Member Variables
    private string _date;
    protected int _length;

    // Construtors
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    // Methods
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
        return $"{_date} {GetType()} ({_length} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }

    // Helper Functions
    // Getters and Setters
    public int GetLength()
    {
        return _length;
    }
}