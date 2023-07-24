using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace PierresDistribution.Controllers;

public class VendorController : Controller
{
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
        List<Vendor> allVendors = Vendor.GetAll();
        return View(allVendors);
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
        Vendor newVendor = new(name, description);
        return RedirectToAction("Index");
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
        return View();
    }
}
