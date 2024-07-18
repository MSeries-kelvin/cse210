public class Order
{
    // Member Variables
    private List<Product> _products;
    private Customer _customer;

    // Constructors
    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    // Methods
    public string CalculateCostOfOrder()
    {   
        double costOfOrder = 0;

        foreach (Product product in _products)
        {
            costOfOrder += product.CalculateTotal();
        }
        
        int shippingFee = 5;

        if (!_customer.LivesInUSA())
        {
            shippingFee = 35;
        }
        
        costOfOrder += shippingFee;
        
        return $"${costOfOrder}";
    }

    public string GetPackagingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += product.GetName() + " " + product.GetProductId() + "\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return _customer.GetName() + "\n\n" + _customer.GetAddress().GetAddress();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}
    