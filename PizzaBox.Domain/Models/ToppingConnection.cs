namespace PizzaBox.Domain.Models
{
  public class ToppingConnection
  {
    public int Id{ get; set; }
    public PizzaModel pizza { get; set; }
    public ToppingsBase topping{ get; set; }
  }
}