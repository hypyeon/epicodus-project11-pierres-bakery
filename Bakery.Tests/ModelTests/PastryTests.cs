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

    [TestMethod]
    public void GetOrderAmount_ReturnsNumOfPastryOrdered_Int()
    {
      int num = 5;
      Pastry newOrder = new Pastry(num);
      int result = newOrder.GetOrderAmount();
      Assert.AreEqual(num, result);
    }
  }
}