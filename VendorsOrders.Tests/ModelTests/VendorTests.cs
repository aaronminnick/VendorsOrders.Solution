using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorsOrders.Models;

namespace VendorsOrders.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void Vendor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor vendor = new Vendor("testName", "testDesc");
      Assert.AreEqual(typeof(Vendor), vendor.GetType());
    }

    [TestMethod]
    public void Vendor_StoresAllVendorsCorrectly_List()
    {
      Vendor vendorOne = new Vendor("one", "testDesc");
      Vendor vendorTwo = new Vendor("two", "testDesc");
      List<Vendor> testList = new List<Vendor> {vendorOne, vendorTwo};
      CollectionAssert.AreEqual(testList, Vendor.AllVendors);
    }

    [TestMethod]
    public void Find_ReturnsCorrectInstanceOfVendor_Vendor()
    {
      Vendor vendor = new Vendor("test", "test");
      int findId = vendor.Id;
      Assert.AreEqual(vendor, Vendor.Find(findId));
    }
  }
}