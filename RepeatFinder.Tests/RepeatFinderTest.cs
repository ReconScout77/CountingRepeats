using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RepeatFinder.Models;
using System;

namespace RepeatFinder.Tests
{
  [TestClass]
  public class RepeatFinderTest
  {
    [TestMethod]
    public void CountRepeats_ReturnsOne_Int()
    {
      Finder find = new Finder("any", "any");
      int expected = 1;

      int actual = find.CountRepeats();

      Assert.AreEqual(expected, actual);
    }
  }
}
