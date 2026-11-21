using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        
        foreach (Product p in _products)
        {
            totalCost += p.GetTotalCost();
        }

        // Add shipping cost based on location
        if (_customer.IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "--- PACKING LABEL ---\n";
        foreach (Product p in _products)
        {
            label += p.GetPackingInfo() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "--- SHIPPING LABEL ---\n";
        label += $"{_customer.GetName()}\n";
        label += _customer.GetAddress().GetFullAddress() + "\n";
        return label;
    }
}