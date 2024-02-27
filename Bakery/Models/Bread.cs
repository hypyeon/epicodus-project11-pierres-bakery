namespace Bakery.Models
{
  public class Bread
  {
    public int orderAmount { get; }
    public Bread(int num)
    {
      orderAmount = num;
    }

    public int ApplyDeal()
    {
      if (orderAmount % 3 == 0)
      {
        int times = orderAmount / 3;
        return orderAmount - times;
      }
      else 
      {
        if (orderAmount < 3)
        {
          return orderAmount;
        }
        else
        {
          int remainder = orderAmount % 3;
          int amountOfThree = (orderAmount - remainder) / 3; 
          return orderAmount - amountOfThree;
        }
      }
    }
  }
}