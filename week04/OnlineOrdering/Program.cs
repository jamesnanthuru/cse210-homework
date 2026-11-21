using System;

class Program
{
    static void Main(string[] args)
    {
        // --- Order 1: USA Customer ---
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        
        order1.AddProduct(new Product("Laptop", "P001", 899.99, 1));
        order1.AddProduct(new Product("Wireless Mouse", "P002", 25.50, 2));
        order1.AddProduct(new Product("Mousepad", "P003", 15.00, 1));

        // --- Order 2: International Customer ---
        Address address2 = new Address("456 High St", "London", "Greater London", "United Kingdom");
        Customer customer2 = new Customer("Jane Doe", address2);
        Order order2 = new Order(customer2);
        
        order2.AddProduct(new Product("Smartphone", "P004", 699.00, 1));
        order2.AddProduct(new Product("Phone Case", "P005", 19.99, 1));

        // --- Display Order 1 ---
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        // --- Display Order 2 ---
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}\n");
    }
}