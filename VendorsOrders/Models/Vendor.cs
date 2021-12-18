using System.Collections.Generic;

namespace VendorsOrders.Models
{
  public class Vendor
  {
    public static List<Vendor> AllVendors = new List<Vendor> {};

    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; set; }
    public List<Order> Orders { get; set; } = new List<Order> {};

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;

      AllVendors.Add(this);
      Id = AllVendors.Count - 1;
    }

    public static Vendor Find(int id)
    {
      return AllVendors[id];
    }

    public static void Remove(int id)
    {
      AllVendors.RemoveAt(id);
      for (int i = 0; i < AllVendors.Count; i++)
      {
        AllVendors[i].Id = i;
      }
    }

    public static void ClearAll()
    {
      AllVendors.Clear();
    }
  }
}