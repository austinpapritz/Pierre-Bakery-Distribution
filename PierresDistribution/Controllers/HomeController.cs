using Microsoft.AspNetCore.Mvc;
namespace PierresDistribution.Controllers;

public class HomeController : Controller
{
    [Route("/")]
    public ActionResult Index()
    { 
        return View(); 
    }
}
