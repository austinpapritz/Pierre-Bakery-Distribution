using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace PierresDistribution.Controllers;

public class OrderController : Controller
{
    [HttpGet("/vendors/{vendorId}/orders")]
    public ActionResult Index()
    { 
        return View(); 
    }
}
