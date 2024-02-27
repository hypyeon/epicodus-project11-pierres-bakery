using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_GetsPriceOfBreadAfterDiscount_Bread()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetNum_ReturnsNumOfLoavesOrdered_Int()
    {
      int num = 5;
      Bread newOrder = new Bread(num);
      int result = newOrder.orderAmount;
      Assert.AreEqual(num, result);
    }
  }
}