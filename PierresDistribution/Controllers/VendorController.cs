using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace PierresDistribution.Controllers;

public class VendorController : Controller
{
    [HttpGet("/")]
    public ActionResult Index()
    { 
        return View(); 
    }
}
