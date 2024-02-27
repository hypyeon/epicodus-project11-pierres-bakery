namespace Bakery.Models
{
  public class Pastry
  {
    public int orderAmount { get; }
    public Pastry(int num)
    {
      orderAmount = num;
    }
  }
}