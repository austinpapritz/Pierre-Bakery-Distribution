using Microsoft.AspNetCore.Http.Features;

namespace PierresDistribution.Models;

public class Product
{
    public static List<Product> _productList = new() { };
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
        _productList.Add(this);
    }

    public static List<Product> GetAll()
    {
        return _productList;
    } 
    public static Product FindByName(string name)
    {
        return _productList.FirstOrDefault(product => product.Name == name);
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
    public decimal Subtotal { get; }
    public OrderItem(Product product, int qty)
    {
        Product = product;
        Quantity = qty;
        Subtotal = qty * Product.Price;
    }


}

public class Order
{
    private static List<Order> _orderList = new List<Order> { };

    public int Id { get; }
    public int Date { get; set; }
    public string Details { get; set; }

    public List<OrderItem> Items { get; set; }

    public decimal TotalPrice { get; set; }

    // Constructors
    public Order(int date)
    {
        Date = date;
        _orderList.Add(this);
        Id = _orderList.Count;
        Items = new List<OrderItem>();
        TotalPrice = TotalPriceCalc(Items);
    }

    public Order(int date, string details)
    {
        Date = date;
        Details = details;
        _orderList.Add(this);
        Id = _orderList.Count;
        Items = new List<OrderItem>();
        TotalPrice = TotalPriceCalc(Items);
    }

    public Order(int date, params OrderItem[] items)
    {
        Date = date;
        _orderList.Add(this);
        Id = _orderList.Count;
        Items = new List<OrderItem>(items);
        TotalPrice = TotalPriceCalc(Items);
    }

    public Order(int date, string details, params OrderItem[] items)
    {
        Date = date;
        Details = details;
        _orderList.Add(this);
        Id = _orderList.Count;
        Items = new List<OrderItem>(items);
        TotalPrice = TotalPriceCalc(Items);
    }

    // Methods
    public static decimal TotalPriceCalc(List<OrderItem> items)
    {
        decimal count = 0;
        foreach (OrderItem item in items)
        {
            count += item.Subtotal;
        }
        return count;
    }

    public static Order FindByDate(int date)
    {
        return _orderList.FirstOrDefault(order => order.Date == date);
    }

    public void AddOrderItem(OrderItem item)
    {
        Items.Add(item);
        // Update total price of order.
        this.TotalPrice = TotalPriceCalc(this.Items);
    }

    public void AddOrderItems(List<OrderItem> items)
    {
        foreach (OrderItem item in items)
        {
            this.Items.Add(item);
        }
        // Update total price of order.
        this.TotalPrice = TotalPriceCalc(this.Items);
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

