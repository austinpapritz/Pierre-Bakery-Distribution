namespace PierresDistribution.Models;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

public class Bread : Product
{
    public Bread(string name, decimal price) : base(name, price)
    {
    }
}

public class Pastry : Product
{
    public Pastry(string name, decimal price) : base(name, price)
    {
    }
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

public class Order
{
    private static List<Order> _orderList = new List<Order> { };
    public int Id { get; }
    public int Date { get; set; }

    public Order(int date)
    {
        Date = date;
        _orderList.Add(this);
        Id = _orderList.Count;
    }
}

// AddOrderItem() to Order

// GetAll() OrderItems in an order

// ClearAll OrderItems from an order