using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryVendorsOrders.Models;
using System;

namespace BakeryVendorsOrders.Tests
{
  [TestClass]
  // public class VendorTests : IDisposable
  // {

  //   public void Dispose()
  //   {
  //     Vendor.ClearAll();
  //   }
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    // [TestMethod]
    // public void GetDescription_ReturnsDescription_String()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";

    //   //Act
    //   Item newItem = new Item(description);
    //   string result = newItem.Description;

    //   //Assert
    //   Assert.AreEqual(description, result);
    // }
  }
}