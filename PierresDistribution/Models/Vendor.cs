namespace PierresDistribution.Models;
public class Vendor
{
    private static List<Vendor> _vendorList = new() { };
    public string Name { get; set; }
    public int Id { get; }

    public List<Order> VendorOrders { get; set; }

    public Vendor(string name)
    {
        Name = name;
        _vendorList.Add(this);
        Id = _vendorList.Count;
        VendorOrders = new List<Order> { };
    }


    // Method for adding Order to list

    // GetOrderByDay()

    // GetOrderByWeek()

    // GetOrderByMonth()

    // GetOrderByYear()

    // GetOrderByVendorId()

    public static AddOrder(params Order[] orders)
    {
        VendorOrders.Add(orders);
    }

    public static Vendor GetVendorById(int id)
    {
        return _vendorList[id-1];
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
