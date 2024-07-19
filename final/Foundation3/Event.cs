public class Event
{
    // Member Variables
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    // Construtors
    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // Methods
    public string GetStandardDetails()
    {
        // Standard details - Lists the title, description, date, time, and address.
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress:\n{_address.GetAddress()}";
    }

    public string GetShortDescription()
    {
        // Short description - Lists the type of event, title, and the date.
        return $"Type: {GetType()}\nTitle: {_title}\nDate: {_date}";
    }
    
    // Helper Functions
    // Getters and Setters
}
