using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Factories;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;
using System.Linq;

namespace PizzaBox.Client.Models
{
  public class PizzaViewModel
  {
    // out to the client
    public PizzaBoxDbContext _db;
    public List<CrustModel> Crusts { get; set; }
    public List<SizeModel> Sizes { get; set; }
    public List<ToppingModel> Toppings { get; set; }
    public List<CheckBoxTopping> Toppings2 { get; set; }


    // in from the client
    [Required(ErrorMessage = "Better select Crust")]
    public string Crust { get; set; }
    [Required]
    public string Size { get; set; }
    [Range(2,5)]
    public List<string> SelectedToppings { get; set; }
    public List<string> SelectedToppings2 { get; set; }

    public PizzaViewModel(PizzaBoxDbContext dbContext)
    {
      _db = dbContext;
      Crusts = _db.Crusts.ToList();
      Sizes = _db.Sizes.ToList();
      Toppings = _db.Toppings.ToList();
    }
  }

  public class CheckBoxTopping : ToppingModel
  {
    public string Text { get; set; }
    public bool IsSelected { get; set; }
  }
}
