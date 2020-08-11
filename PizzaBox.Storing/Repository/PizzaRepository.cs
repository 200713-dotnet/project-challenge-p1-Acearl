using PizzaBox.Domain.Models;
using System.Linq;
using System.Collections.Generic;
using domain = PizzaBox.Domain.Models;
using PizzaBox.Storing;
namespace PizzaBox.Storing.Repositories
{
    public class PizzaRepository
    {
        private PizzaBoxDbContext _db;
        public void CreatePizza(PizzaModel pizza, int orderId)
        {
            var dbPizza = new PizzaModel();
            
            dbPizza.Name = pizza.Name;
            dbPizza.Size = pizza.Size;
            dbPizza.Crust = pizza.Crust;
            dbPizza.Id = orderId;
            _db.Pizzas.Add(dbPizza);
            _db.SaveChanges();
            // System.Console.WriteLine(ReadAllOrdersIds().Last());
            foreach(var t in pizza.Toppings)
            {
                CreateTopping(t.Name,ReadAllOrdersIds().Last());
            }
        }
        public void CreateTopping(string passedTopping, int pizzaId)
        {
            var topping = new ToppingConnection();
            //topping.name = passedTopping;
            //topping.PizzaId = pizzaId;
            // System.Console.WriteLine("Topping info");
            // System.Console.WriteLine("Pizza " + topping.PizzaId);
            _db.ToppingConnection.Add(topping);
            _db.SaveChanges();
            //System.Console.WriteLine(ReadAllToppingIds().Last());
            
        }
        public void CreateOrder(OrderModel order, int userId, int storeId)
        {
            var dbOrder = new OrderModel();
            //dbOrder.UserId = (userId + 1);
            //dbOrder.StoreId = (storeId + 1);
            dbOrder.TimeOrdered = System.DateTime.Now;
            //dbOrder.OrderId = dbOrder.OrderId + 1;
            
            _db.Orders.Add(dbOrder);
            _db.SaveChanges();
            System.Console.WriteLine("FRUSTRATION:Order ID added");
            System.Console.WriteLine(ReadAllOrdersIds().Last());
            foreach(var p in order.Pizzas)
            {
                CreatePizza(p, ReadAllOrdersIds().Last());
            }
            _db.SaveChanges();
            
        }
        public void CreateUser(UserModel user)
        {
            var dbUser = new UserModel();
            var userlist = ReadAllUsers();
            var userNameList = new List<string>();
            foreach(var u in userlist)
            {
                userNameList.Add(u.Name);
                System.Console.WriteLine(u.Name);
            }
            if(userNameList.Contains(user.Name))
            {
                
            }
            else
            {
                dbUser.Name = user.Name;
                _db.Users.Add(dbUser);
            }
            _db.SaveChanges();
        }
        public void CreateStore(domain.StoreModel store)
        {
            var dbStore = new StoreModel();
            var storelist = ReadAllStores();
            var storeNameList = new List<string>();
            foreach(var s in storelist)
            {
                storeNameList.Add(s.Name);
            }
            if(storeNameList.Contains(store.Name))
            {

            }
            else
            {
                dbStore.Name = store.Name;
                _db.Stores.Add(dbStore);
            }
            
            _db.SaveChanges();
        }
        public int FindStoreId(string targetName)
        {
            var storeList = ReadAllStores();
            var storeNames = new List<string>();
            foreach(var s in storeList)
            {
                storeNames.Add(s.Name);
            }
            return storeNames.IndexOf(targetName);
        }
        public int FindUserId(string targetName)
        {
            var userList = ReadAllUsers();
            var userNames = new List<string>();
            foreach(var u in userList)
            {
                userNames.Add(u.Name);
            }
            return userNames.IndexOf(targetName);
        }
        public List<UserModel> ReadAllUsers()
        {
            var userList = new List<UserModel>();
            foreach(var item in _db.Users.ToList())
            {
                userList.Add(item);
            }
            return userList;
        }
        public List<StoreModel> ReadAllStores()
        {
            var storeList = new List<StoreModel>();
            foreach(var item in _db.Stores.ToList())
            {
                storeList.Add(item);
            }
            return storeList;
        }
        public List<List<string>> ReadAllOrders()
        {
            var domainPizzaList = new List<List<string>>();
            foreach(var item in _db.Orders.ToList())
            {
                //domainPizzaList.Add(new List<string>() = {item.OrderId});
            }
            return domainPizzaList;
        }
        public List<int> ReadAllOrdersIds()
        {
            var domainPizzaList = new List<int>();
            foreach(var item in _db.Orders.ToList())
            {
                domainPizzaList.Add(item.Id);
                // System.Console.WriteLine(item.OrderId);
            }
            return domainPizzaList;
        }
        public List<int> ReadAllPizzaIds()
        {
            var domainPizzaList = new List<int>();
            foreach(var item in _db.Pizzas.ToList())
            {
                domainPizzaList.Add(item.Id);
                // System.Console.WriteLine(item.PizzaId);
            }
            return domainPizzaList;
        }
        // public List<int> ReadAllToppingIds()
        // {
        //     var domainPizzaList = new List<int>();
        //     System.Console.WriteLine("topping ids");
        //     foreach(var item in _db.ToppingModel.ToList())
        //     {
        //         domainPizzaList.Add(item.Id);
        //         // System.Console.WriteLine(item.ToppingId);
        //     }
        //     return domainPizzaList;
        // }
        // {
        //     var domainPizzaList = new List<domain.Pizza>();

        //     foreach(var item in _db.Pizza.ToList())
        //     {
        //         domainPizzaList.Add(new domain.Pizza()
        //         {
                   
                    
        //             name = item.Name;
        //             size = new String item.Size;
        //             crust = item.Crust;
        //             crust = new List<string> item.toppings;
        //         }
        //     }
        //     return _db.Pizza.ToList();
        // }
        // public void Update();
        // public void Delete();
    }
}