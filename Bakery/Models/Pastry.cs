namespace Bakery.Models
{
  public class Pastry
  {
    public int orderAmount { get; }
    public Pastry(int num)
    {
      orderAmount = num;
    }

    public int GetOrderAmount()
    {
      return orderAmount;
    }

    public int ApplyDeal()
    {
      if (orderAmount % 4 == 0)
      {
        int times = orderAmount / 4;
        return orderAmount - times;
      }
      else 
      {
        if (orderAmount < 4)
        {
          return orderAmount;
        }
        else
        {
          int remainder = orderAmount % 4;
          int amountOfFour = (orderAmount - remainder) / 4; 
          return orderAmount - amountOfFour;
        }
      }
    }

    public int GetPrice()
    {
      return ApplyDeal() * 2;
    }
  }
}