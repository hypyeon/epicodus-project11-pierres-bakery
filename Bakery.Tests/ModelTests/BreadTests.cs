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

    [TestMethod]
    public void ApplyDeal_ReturnsNumOfLoavesWhenDealApplied_Int()
    {
      Bread firstTest = new Bread(6);
      int result1 = firstTest.ApplyDeal();
      Assert.AreEqual(4, result1);

      Bread secondTest = new Bread(7);
      int result2 = secondTest.ApplyDeal();
      Assert.AreEqual(5, result2);

      Bread thirdTest = new Bread(4);
      int result3 = thirdTest.ApplyDeal();
      Assert.AreEqual(3, result3);

      Bread fourthTest = new Bread(9);
      int result4 = fourthTest.ApplyDeal();
      Assert.AreEqual(6, result4);
    }

    [TestMethod]
    public void GetPrice_ReturnsTotalPriceAfterConsideringDeal_Int()
    {
      Bread firstTest = new Bread(6);
      int expected1 = firstTest.ApplyDeal() * 5;
      int result1 = firstTest.GetPrice();
      Assert.AreEqual(expected1, result1);

      Bread secondTest = new Bread(7);
      int expected2 = secondTest.ApplyDeal() * 5;
      int result2 = secondTest.GetPrice();
      Assert.AreEqual(expected2, result2);

      Bread thirdTest = new Bread(5);
      int expected3 = 20;
      int result3 = thirdTest.GetPrice();
      Assert.AreEqual(expected3, result3);
    }
  }
}