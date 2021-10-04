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
      Category.ClearAll();
    }

    [TestMethod]
    public void PhylumConstructor_CreatesInstanceOf_Phylum()
    {
      Phylum newPhylum = new Phylum ();
  
    }
  }
}