using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Factories
{
  public class PizzaFactory : IFactory
  {
    public AModel Create()
    {
      var p = new PizzaModel();

      p.Crust = new CrustModel();
      p.Size = new SizeModel();
      p.Toppings = new List<PizzaBox.Domain.Models.ToppingModel>{ new PizzaBox.Domain.Models.ToppingModel() };

      return p;
    }
  }
}
