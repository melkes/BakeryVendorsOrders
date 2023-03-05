using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryVendorsOrders.Models;
using System;

namespace BakeryVendorsOrders.Tests
{
  [TestClass]

  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test order", "test description", 10, "test date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "36 doughnuts";
      string description = "test description";

      //Act
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }


      [TestMethod]
    public void GetAll_ReturnsAListOf_Order()
    {
      Order.ClearAll();
      Order orderTest = new Order("test order", "test description", 10, "test date");
      List<Order> testingList = new List<Order>{orderTest};
      List<Order> orderList = Order.GetAll();

      CollectionAssert.AreEqual(orderList, testingList);
    }

  }
}
