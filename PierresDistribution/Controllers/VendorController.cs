namespace PierresDistribution.Controllers;

public class VendorController : Controller
{
    [Route("/")]
    public ActionResult Index()
    { 
        return View(); 
    }
}
