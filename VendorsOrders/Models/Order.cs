using System.Collections.Generic;

namespace VendorsOrders.Models
{
  public class Order
  {
    private static List<Order> _allOrders = new List<Order> {};

    public string Title { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public string Date { get; set; }

    public Order(string title, string description, float price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      
      _allOrders.Add(this);
    }
  }
}