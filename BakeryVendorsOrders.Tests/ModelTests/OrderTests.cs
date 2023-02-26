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
      Order newOrder = new Order("test order");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Museum Cafe";

      //Act
      Vendor newVendor = new Vendor(name);
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }
  }
}