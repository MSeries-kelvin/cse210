public class ReceptionEvent : Event
{
    // Member Variables
    private string _email;

    // Construtors
    public ReceptionEvent(string title, string description, string date, string time, Address address, string email) : 
        base(title, description, date, time, address)
    {
        _email = email;
    }

    // Methods
    public string GetFullDetails()
    {
        // Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
        return $"{GetStandardDetails()}\nEmail: {_email}";
    }

    // Helper Functions
    // Getters and Setters
}