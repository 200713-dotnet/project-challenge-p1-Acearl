namespace PizzaBox.Domain.Models
{
  public class ToppingModel
  {
    public int Id { get; set; }
    public PizzaModel Pizza;
    public ToppingModel topping;
  }
}