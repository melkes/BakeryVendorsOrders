using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryVendorsOrders.Models;
using System;

namespace BakeryVendorsOrders.Tests
{
  [TestClass]

  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "test vendor description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Vendor";

      //Act
      Vendor newVendor = new Vendor("Test Vendor", "test vendor description");
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Test Vendor";
      Vendor.ClearAll();
      Vendor newVendor = new Vendor("Test Vendor", "test vendor description");

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void VendorDescription_HasDescription_String()
    {
      string vendorDescription = "The cafe in the museum";
      string vendorName = "Museum Cafe";

      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual(vendorDescription, result);
    }

  }
}