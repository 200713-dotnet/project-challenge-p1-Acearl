using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class PizzaModel : AModel
  {
    public CrustModel Crust { get; set; }
    public SizeModel Size { get; set; }
    public List<ToppingsBase> Toppings { get; set; }
    public double price{get; set;}

    // public static implicit operator PizzaModel(PizzaModel v)
    // {
    //     throw new NotImplementedException();
    // }
    }
}
