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

    // Add price field 
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
    public List<OrderItem> Items { get; set; }

    // Add Order price total

    public Order(int date)
    {
        Date = date;
        _orderList.Add(this);
        Id = _orderList.Count;
        Items = new List<OrderItem>();
    }

        public Order(int date, params OrderItem[] items)
    {
        Date = date;
        _orderList.Add(this);
        Id = _orderList.Count;
        Items = new List<OrderItem>(items);

    }

    public void AddOrderItem(OrderItem item) 
    {
        Items.Add(item);
    }

    public static List<Order> GetAll()
    {
        return _orderList;
    }

    public static void ClearAll()
    {
        _orderList.Clear();
    }

}

