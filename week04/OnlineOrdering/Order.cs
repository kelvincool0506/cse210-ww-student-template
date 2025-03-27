using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (Product product in products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost
        total += customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder("Packing Label:\n");
        foreach (Product product in products)
        {
            label.AppendLine($"{product.GetName()} (ID: {product.GetProductId()})");
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress()}";
    }
}
