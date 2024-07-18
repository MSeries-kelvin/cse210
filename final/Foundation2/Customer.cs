public class Customer
{
    // Member Variables
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Methods
    public bool LivesInUSA()
    {
        return _address.LivesInUSA();
    }

    // Getters & Setters
    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }
}