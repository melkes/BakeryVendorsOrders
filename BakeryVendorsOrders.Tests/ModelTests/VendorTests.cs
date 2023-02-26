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
      string name = "Museum Cafe";

      //Act
      Vendor newVendor = new Vendor(name);
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Museum Cafe";
      Vendor.ClearAll();
      Vendor newVendor = new Vendor(name);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void VendorDescription_HasDescription_String()
    {
      string vendorDescription = "The cafe in the museum";

      Vendor newVendor = new Vendor(vendorDescription);
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual(vendorDescription, result);
    }
// Not sure how to add this yet. 
// Added a second argument in new Vendor constructor in HomeController to deal with MSTest error, however it then seems to cause a ton of new errors
  }
}