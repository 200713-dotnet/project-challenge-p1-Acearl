namespace PizzaBox.Domain.Models
{
  public class ToppingBase : AModel
  {
    public double price{get; set;} 
    public void IWantPizza()
    {
      var b = Brand.Instance();

      var p = b.PizzaFactory.Create();
    }
  }
}