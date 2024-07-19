public class LectureEvent : Event
{
    // Member Variables
    private string _speakerName;
    private int _capacity;

    // Construtors
    public LectureEvent(string title, string description, string date, string time, Address address, string speakerName, int capacity) : base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    // Methods
    public string GetFullDetails()
    {
        // Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
        return $"{GetStandardDetails()}\nSpeaker Name: {_speakerName}\nCapacity: {_capacity}";
    }

    // Helper Functions
    // Getters and Setters

}