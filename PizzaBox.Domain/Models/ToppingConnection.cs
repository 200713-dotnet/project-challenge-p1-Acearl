namespace PizzaBox.Domain.Models
{
  public class ToppingConnection : ToppingsBase
  {
    public PizzaModel pizza;
    public ToppingsBase topping;
  }
}