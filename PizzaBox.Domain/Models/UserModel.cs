using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class UserModel : AModel
  {
    
    public string orderHistory { get; set; }
    public List<OrderModel> Orders { get; set; } = new List<OrderModel>();
    
  }
}