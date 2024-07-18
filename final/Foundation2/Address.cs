public class Address
{
    // Member Variables
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    // Constructors
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    // Methods
    public bool LivesInUSA()
    {
        return _country == "USA";
    }

    public string GetAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
    }
}