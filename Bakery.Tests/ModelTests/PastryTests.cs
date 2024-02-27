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

    [TestMethod]
    public void ApplyDeal_ReturnsNumOfPastriesWhenDealApplied_Int()
    {
      Pastry firstTest = new Pastry(3);
      int result1 = firstTest.ApplyDeal();
      Assert.AreEqual(3, result1);

      Pastry secondTest = new Pastry(4);
      int result2 = secondTest.ApplyDeal();
      Assert.AreEqual(3, result2);

      Pastry thirdTest = new Pastry(8);
      int result3 = thirdTest.ApplyDeal();
      Assert.AreEqual(6, result3);
    }
  }
}