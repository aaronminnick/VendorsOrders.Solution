using System.Collections.Generic;

namespace VendorsOrders.Models
{
  public class Vendor
  {
    public static List<Vendor> AllVendors = new List<Vendor> {};

    public string Name { get; set; }
    public string Description { get; set}
    public List<Order> Orders { get; set; } = new List<Order> {};

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;

      AllVendors.Add(this);
    }
  }
}