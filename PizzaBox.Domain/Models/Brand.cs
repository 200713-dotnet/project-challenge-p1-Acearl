using System.Collections.Generic;
using PizzaBox.Domain.Factories;

namespace PizzaBox.Domain.Models
{
  public class Brand
  {
    public IFactory PizzaFactory { get; private set; }
    public IFactory OrderFactory { get; private set; }
    private static Brand _brand;

    private Brand()
    {
      PizzaFactory = new PizzaFactory();
      //OrderFactory = new OrderFactory();
    }

    public static Brand Instance()
    {
      if (_brand == null)
      {
        _brand = new Brand();
      }

      return _brand;
    }
  }
}
