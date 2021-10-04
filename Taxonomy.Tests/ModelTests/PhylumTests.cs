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

    public PhylumTests()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=sami;port=3306;database=taxonomy_test;";
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

    
  [TestMethod]
  public void Save_SavesToDatabase_PhylumList()
  {
    Phylum newPhylum = new Phylum("test name", "test description", "test origin", "test zone");

    newPhylum.Save();
    List<Phylum> result = Phylum.GetAll();
    List<Phylum> testList = new List<Phylum>{newPhylum};
    
    CollectionAssert.AreEqual(testList, result);
  }
    // [TestMethod]
    // public void Find_ReturnsPhylumFromDataBase_Phylum()
    // {

    // }
  }
}