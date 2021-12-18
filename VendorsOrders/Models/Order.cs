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

    public static Order Find(int id)
    {
      return AllOrders[id];
    }

    public static void Remove(int id)
    {
      Order order = Find(id);
      Vendor.Find(order.VendorId).Orders.Remove(order);
      AllOrders.Remove(order);
      
      for (int i = 0; i < AllOrders.Count; i++)
      {
        AllOrders[i].Id = i;
      }
    }

    public static void ClearAll()
    {
      AllOrders.Clear();
    }
  }
}