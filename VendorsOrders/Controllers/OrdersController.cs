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

    [HttpGet("/vendors/{vendorId}}/orders/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("vendors/{vendorId}/orders")]
    public ActionResult Create()
    {
      return RedirectToAction("Show");
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show()
    {
      return View();
    }
  }
}