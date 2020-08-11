using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Factories;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;
using System.Linq;

namespace PizzaBox.Client.Models
{
  public class OrderViewModel
  {
    // out to the client
    public PizzaBoxDbContext _db;
    public List<CrustModel> Crusts { get; set; }
    public List<SizeModel> Sizes { get; set; }
    public List<ToppingConnection> Toppings { get; set; }
    public List<ToppingsBase> ToppingsBase { get; set; }


    // in from the client
    [Required(ErrorMessage = "Better select Crust")]
    public List<CrustModel> Crust { get; set; }
    [Required]
    public List<SizeModel> Size { get; set; }
    [Range(2,5)]
    public List<ToppingsBase> SelectedToppings { get; set; }

    public OrderViewModel(PizzaBoxDbContext dbContext)
    {
      _db = dbContext;
      Crusts = _db.Crusts.ToList();
      Sizes = _db.Sizes.ToList();
      Toppings = _db.ToppingConnection.ToList();
      ToppingsBase = _db.ToppingsBase.ToList();
    }
  }
}
