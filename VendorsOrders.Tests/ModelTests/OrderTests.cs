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
  }
}