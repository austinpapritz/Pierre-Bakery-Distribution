namespace PierresDistribution.Controllers;

public class OrderController : Controller
{
    [Route("/")]
    public ActionResult Index()
    { 
        return View(); 
    }
}
