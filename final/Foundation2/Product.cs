public class Product
{
    // Member Variables
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructors
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Methods
    public double CalculateTotal()
    {
        return _price * _quantity;
    }

    // Getters & Setters
    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }
}