namespace PierresDistribution.Models;

public class Order
{
}

public class OrderItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public OrderItem(Product product, int qty)
    {
        Product = product;
        Quantity = qty;
    }
}