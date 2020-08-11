using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;
namespace PizzaBox.Storing
{
  public class PizzaBoxDbContext : DbContext
  {
    public DbSet<UserModel> Users { get; set; }
    public DbSet<StoreModel> Stores { get; set; }
    public DbSet<OrderModel> Orders { get; set; }
    public DbSet<PizzaModel> Pizzas { get; set; } //create table
    public DbSet<CrustModel> Crusts { get; set; }
    public DbSet<ToppingsBase> ToppingsBase { get; set; }
    public DbSet<ToppingConnection> ToppingConnection { get; set; }
    
    public DbSet<SizeModel> Sizes { get; set; }

    public PizzaBoxDbContext(DbContextOptions options) : base(options){} //dependency injection

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<StoreModel>().HasKey(e => e.Id);
      builder.Entity<UserModel>().HasKey(e => e.Id);
      builder.Entity<OrderModel>().HasKey(e => e.Id);
      builder.Entity<PizzaModel>().HasKey(e => e.Id); //primary constraint
      builder.Entity<CrustModel>().HasKey(e => e.Id);
      builder.Entity<SizeModel>().HasKey(e => e.Id);
      builder.Entity<ToppingsBase>().HasKey(e => e.Id);
      builder.Entity<ToppingConnection>().HasKey(e => e.Id);
    }
  }
}