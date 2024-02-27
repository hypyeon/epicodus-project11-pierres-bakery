using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_DefinesOrderAmountOfPastry_Pastry()
    {
      Pastry newOrder = new Pastry(3);
      Assert.AreEqual(typeof(Pastry), newOrder.GetType());
    }
  }
}