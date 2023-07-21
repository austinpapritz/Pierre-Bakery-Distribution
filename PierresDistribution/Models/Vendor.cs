namespace PierresDistribution.Models;
public class Vendor
{
    private static List<Vendor> _vendorList = new() { };
    public string Name { get; set; }
    public int Id { get; }

    public List<List<Order>> VendorOrders { get; set; }

    public Vendor(string name)
    {
        Name = name;
        _vendorList.Add(this);
        Id = _vendorList.Count;
        VendorOrders = new List<List<Order>> { };
    }

    public static Vendor GetVendorById(int id)
    {
        // Code here
    }

    public static void ClearAll()
    {
        _vendorList.Clear();
    }
}
