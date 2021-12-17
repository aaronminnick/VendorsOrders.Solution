using Microsoft.AspNetCore.Mvc;

namespace VendorsOrders.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/orders")]
    public ActionResult Index()
    {
      return View();
    }
    
    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("vendors/{id}/orders")]
    public ActionResult Create()
    {
      return RedirectToAction("Show");
    }

    [HttpGet("/vendors/{id}/orders/{id}")]
    public ActionResult Show()
    {
      return View();
    }
  }
}