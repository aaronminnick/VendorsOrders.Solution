using Microsoft.AspNetCore.Mvc;

namespace VendorsOrders.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}