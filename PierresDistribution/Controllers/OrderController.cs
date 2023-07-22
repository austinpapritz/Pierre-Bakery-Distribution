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
}
