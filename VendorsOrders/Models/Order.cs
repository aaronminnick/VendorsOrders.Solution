using System.Collections.Generic;

namespace VendorsOrders.Models
{
  public class Order
  {
    public static List<Order> AllOrders = new List<Order> {};

    public string Title { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public string Date { get; set; }
    public int VendorId { get; set; }
    public int Id { get; set; }

    public Order(string title, string description, float price, string date, int vendorId)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      VendorId = vendorId;

      AllOrders.Add(this);
      Id = AllOrders.Count - 1;
    }
  }
}