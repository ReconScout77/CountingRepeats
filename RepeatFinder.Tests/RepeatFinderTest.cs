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
      RepeatCounter repeats = new RepeatCounter("any", "any");
      int expected = 1;

      int actual = repeats.CountRepeats();

      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountRepeats_ReturnsOneFromMultiple_Int()
    {
      RepeatCounter repeats = new RepeatCounter("any", "match any");
      int expected = 1;

      int actual = repeats.CountRepeats();

      Assert.AreEqual(expected, actual);
    }
  }
}
