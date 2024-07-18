using System;

class Program
{
    static void Main(string[] args)
    {      
        Order order1 = new Order(new Customer("Davido", new Address("No. 21 Edewor Street", "Eku", "Delta", "Nigeria")));
        order1.AddProduct(new Product("Maggi", "00231idDabvn", 3.99, 5));
        order1.AddProduct(new Product("Salt", "0kaie000dajd", 1.50, 2));
        order1.AddProduct(new Product("Pepper", "0adlaieoawe", 2.00, 3));

        Console.WriteLine(order1.GetPackagingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.CalculateCostOfOrder());
        
        Console.WriteLine("\n-------------------------------\n");

        Order order2 = new Order(new Customer("Burna", new Address("No. 13 Old Sapele Road", "Eku", "Delta", "Nigeria")));
        order2.AddProduct(new Product("Ball", "kaoeodjalddl", 5.00, 8));
        order2.AddProduct(new Product("T-Shirt", "eo20alieoao", 17.99, 3));
        order2.AddProduct(new Product("Chair", "ie03la3al323l", 35.00, 7));

        Console.WriteLine(order2.GetPackagingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.CalculateCostOfOrder());
    }
}