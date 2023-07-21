using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace PierresDistribution.Controllers;

public class HomeController : Controller
{
    [HttpGet("/")]
    public ActionResult Index()
    { 
        return View(); 
    }
}
