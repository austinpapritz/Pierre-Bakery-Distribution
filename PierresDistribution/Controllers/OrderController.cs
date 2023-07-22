using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace PierresDistribution.Controllers;

public class OrderController : Controller
{
    [HttpGet("/vendors/{vendorId}/orders")]
    public ActionResult Index(int vendorId)
    { 
        Vendor vendor = Vendor.GetVendorById(vendorId);
        return View(vendor); 
    }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
        Dictionary<string, object> model = new Dictionary<string, object> { };
        Vendor vendor = Vendor.GetVendorById(vendorId);
        List<Product> productList = Product.GetAll();
        model.Add("vendor", vendor);
        model.Add("products", productList);
        return View(model);
    }

    // [HttpPost("/vendors/{vendorId}/orders")]
    // public ActionResult Create(string product, decimal price, int quantity, int day, int month, int year, int vendorId)
    // {
    //     Product product = new
    //     return RedirectToAction("Index", vendorId)
    // }
}
