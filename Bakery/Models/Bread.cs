namespace Bakery.Models
{
  public class Bread
  {
    public int orderAmount { get; }
    public Bread(int num)
    {
      orderAmount = num;
    }
  }
}