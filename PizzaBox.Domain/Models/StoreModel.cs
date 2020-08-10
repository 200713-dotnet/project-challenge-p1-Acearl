using System.Collections.Generic;
using PizzaBox.Domain.Factories;

namespace PizzaBox.Domain.Models
{
  public class StoreModel : AModel
  {
    private IFactory _factory;
    private static StoreModel _store;

    public void CreateOrder()
    {
      AModel pm = _factory.Create();
    }
  }
}
