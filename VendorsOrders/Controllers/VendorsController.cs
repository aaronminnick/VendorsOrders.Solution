using Microsoft.AspNetCore.Mvc;

namespace VendorsOrders.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create()
    {
      return RedirectToAction("/"); //redirect to home is assignment requirement
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show()
    {
      return View();
    }
  }
}