using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter.Models;

namespace AnimalShelter.Tests
{
  [TestClass]
  public class AnimalTests // : IDisposable
  {
    // public void Dispose()
    // {
    //   ClassName.ClearAll();
    // }

    [TestMethod]
    public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    }
  }
}