using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace PierresDistribution.Controllers;

public class OrderController : Controller
{
    [HttpGet("/vendors/{vendorId}/orders")]
    public ActionResult Index(int vendorId)
    {
        Vendor vendor = Vendor.GetVendorById(vendorId);
        // Sort the vendor's order list by date ascending. 
        // Note: OrderBy() makes it an IEnumerable and ToList() turns it back into a List.
        vendor.VendorOrders = vendor.VendorOrders.OrderBy(order => order.Date).ToList();
        return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
        // Add both vendor and product information to model.
        Dictionary<string, object> model = new Dictionary<string, object> { };
        Vendor vendor = Vendor.GetVendorById(vendorId);
        List<Product> productList = Product.GetAll();
        model.Add("vendor", vendor);
        model.Add("products", productList);
        return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string product, int quantity, int day, int month, int year, string details)
    {
        // If qty was left blank, then skip adding the order and return to order list page.
        if (quantity != 0)
        {
            // Grab the vendor by Id 
            Vendor vendor = Vendor.GetVendorById(vendorId);
            // Find Product, combine it with the quantity value to make an OrderItem
            Product newProduct = Product.FindByName(product);
            OrderItem newOrderItem = new(newProduct, quantity);
            // Combine date values into one number
            int dateAsNumber = int.Parse(day.ToString("00") + month.ToString("00") + year.ToString("00"));
            // See if order already exists for the date.
            Order existingOrder = vendor.FindByDate(dateAsNumber);
            if (existingOrder != null)
            {   
                // If so, add the OrderItem to the existing order.
                existingOrder.AddOrderItem(newOrderItem);
            }
            else
            {
                // Otherwise, create new order, add the OrderItem to order, add order to vendor.
                Order newOrder = new(dateAsNumber, details);
                newOrder.AddOrderItem(newOrderItem);
                vendor.AddOrder(newOrder);
            }
        } 
        return RedirectToAction("Index", new { vendorId = vendorId });
    }
}
