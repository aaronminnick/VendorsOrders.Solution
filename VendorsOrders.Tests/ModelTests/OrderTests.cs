using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorsOrders.Models;

namespace VendorsOrders.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
      Vendor.ClearAll();
    }

    [TestMethod]
    public void Order_CreatesInstanceOfOrder_Order()
    {
      Order order = new Order("testTitle", "testDesc", 0, "testDate", 0);
      Assert.AreEqual(typeof(Order), order.GetType());
    }

    [TestMethod]
    public void Order_StoresAllOrdersCorrectly_List()
    {
      Order orderOne = new Order("one", "testDesc", 0, "testDate", 0);
      Order orderTwo = new Order("two", "testDesc", 0, "testDate", 0);
      List<Order> testList = new List<Order> {orderOne, orderTwo};
      CollectionAssert.AreEqual(testList, Order.AllOrders);
    }

    [TestMethod]
    public void Find_ReturnsCorrectInstanceOfOrder_Order()
    {
      Order order = new Order("testTitle", "testDesc", 0, "testDate", 0);
      int findId = order.Id;
      Assert.AreEqual(order, Order.Find(findId));
    }

    [TestMethod]
    public void Remove_CorrectlyReassignsIds_Int()
    {
      Vendor vendor = new Vendor("test", "test");
      Order orderIndexZero = new Order("zero", "testDesc", 0, "testDate", 0);
      Order orderIndexOne = new Order("one", "testDesc", 0, "testDate", 0);
      Order orderIndexTwo = new Order("two", "testDesc", 0, "testDate", 0);

      Order.Remove(1);
      Assert.AreEqual(orderIndexTwo, Order.AllOrders[1]);
    }

    [TestMethod]
    public void Remove_CorrectlyRemovesFromVendorsOrderList_List()
    {
      Vendor vendor = new Vendor("test", "test");
      Order orderIndexZero = new Order("zero", "testDesc", 0, "testDate", 0);
      vendor.Orders.Add(orderIndexZero);
      Order orderIndexOne = new Order("one", "testDesc", 0, "testDate", 0);
      vendor.Orders.Add(orderIndexOne);
      Order orderIndexTwo = new Order("two", "testDesc", 0, "testDate", 0);
      vendor.Orders.Add(orderIndexTwo);
      List<Order> testList = new List<Order> {orderIndexZero, orderIndexTwo};

      Order.Remove(1);
      Console.WriteLine(vendor.Orders);
      CollectionAssert.AreEqual(testList, vendor.Orders);
    }
  }
}