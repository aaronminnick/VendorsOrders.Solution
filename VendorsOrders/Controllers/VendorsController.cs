using Microsoft.AspNetCore.Mvc;
using VendorsOrders.Models;

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
    public ActionResult Create(string name, string description)
    {
      Vendor vendor = new Vendor(name, description);
      return Redirect("/"); //redirect to home is assignment requirement
    }

    [HttpGet("/vendors/{vendorId}")]
    public ActionResult Show(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpPost("/vendors/{vendorId}")]
    public ActionResult Destroy(int vendorId)
    {
      Vendor.Remove(vendorId);
      return RedirectToAction("Index");
    }
  }
}