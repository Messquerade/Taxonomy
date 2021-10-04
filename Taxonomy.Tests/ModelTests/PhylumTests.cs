using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taxonomy.Models;
using System.Collections.Generic;
using System;

namespace Taxonomy.Tests
{
  [TestClass]
  public class PhylumTests : IDisposable
  {
    public void Dispose()
    {
      Phylum.ClearAll();
    }

    [TestMethod]
    public void PhylumConstructor_CreatesInstanceOf_Phylum()
    {
      Phylum newPhylum = new Phylum("test name", "test description", "test origin", "test zone");
      Assert.AreEqual(typeof(Phylum), newPhylum.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyListFromDatabase_List()
    {
      List<Phylum> newList = new List<Phylum> {};
      List<Phylum> result = Phylum.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}