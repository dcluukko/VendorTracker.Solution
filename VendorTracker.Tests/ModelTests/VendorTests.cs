using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.TestTools
{
  [TestClass]
  public class VendorTest
  {

    [TestMethod]
    public void VendorConstructor_CreatesInstanceofVendor_Vendor()
    {
      Vendor newVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    } 

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Petunias";
      Vendor newVendor = new Vendor(name);
      //Act
      string compare = newVendor.Name;
      //Assert
      Assert.AreEqual(name, compare);

    }
  }
}