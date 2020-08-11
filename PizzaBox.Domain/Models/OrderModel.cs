using System.Collections.Generic;
using System;

namespace PizzaBox.Domain.Models
{
  public class OrderModel : AModel
  {
    public UserModel user { get; set; }
    public List<PizzaModel> Pizzas { get; set; }
    public DateTime TimeOrdered{get; set;} 
    public double price{get; set;} 
  }
}
