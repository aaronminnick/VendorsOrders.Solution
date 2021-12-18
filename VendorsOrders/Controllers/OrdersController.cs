using Microsoft.AspNetCore.Mvc;
using VendorsOrders.Models;

namespace VendorsOrders.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/orders")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpPost("vendors/{vendorId}/orders")]
    public ActionResult Create(string title, string description, string price, string date, int vendorId)
    {
      Order order = new Order(title, description, float.Parse(price), date, vendorId);
      Vendor vendor = Vendor.Find(vendorId);
      vendor.Orders.Add(order);
      return RedirectToAction("Show", "Vendors", new {vendorId});
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      return View(order);
    }

    [HttpPost("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Destroy(int vendorId, int orderId)
    {
      Order.Remove(orderId);
      return RedirectToAction("Show", "Vendors", new {vendorId});
    }
  }
}