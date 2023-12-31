namespace PierresDistribution.Models;
public class Vendor
{
    private static List<Vendor> _vendorList = new() { };
    public string Name { get; set; }

    public string Description { get; set; }
    public int Id { get; }

    public List<Order> VendorOrders { get; set; }

    public Vendor(string name)
    {
        Name = name;
        _vendorList.Add(this);
        Id = _vendorList.Count;
        VendorOrders = new List<Order> { };
    }

    public Vendor(string name, string description)
    {
        Name = name;
        Description = description;
        _vendorList.Add(this);
        Id = _vendorList.Count;
        VendorOrders = new List<Order> { };
    }

    public void AddOrder(Order order)
    {
        VendorOrders.Add(order);
    }

    public static Vendor GetVendorById(int id)
    {
        return _vendorList[id - 1];
    }

    public Order FindByDate(int date)
    {
        return this.VendorOrders.FirstOrDefault(order => order.Date == date);
    }

    public static List<Vendor> GetAll()
    {
        return _vendorList;
    }

    public static void ClearAll()
    {
        _vendorList.Clear();
    }

}
