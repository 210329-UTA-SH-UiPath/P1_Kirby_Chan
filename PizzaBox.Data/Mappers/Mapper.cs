using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Data.Entities;
using System.Linq;

namespace PizzaBox.Data
{
    /// <summary>
    /// Maps DB entities to objects in Domain
    /// </summary>
    public class Mapper : IMapper
    {
        public Domain.Models.Crust Map(Entities.Crust Crust)
        {
            return new Domain.Models.Crust
            {
                ID = Crust.ID,
                Name = Crust.Name,
                Price = Crust.Price
            };
        }
        public Entities.Crust Map(Domain.Models.Crust Crust)
        {
            return new Entities.Crust
            {
                ID = Crust.ID,
                Name = Crust.Name,
                Price = Crust.Price
            };
        }
        public Domain.Models.Customer Map(Entities.Customer Customer)
        {
            return new Domain.Models.Customer
            {
                ID = Customer.ID,
                Name = Customer.Name
            };
        }

        public Entities.Customer Map(Domain.Models.Customer Customer)
        {
            return new Entities.Customer
            {
                ID = Customer.ID,
                Name = Customer.Name
            };
        }
        public Domain.Models.Order Map(Entities.Order Order)
        {
            Domain.Models.Order mapOrder = new Domain.Models.Order();
            mapOrder.ID = Order.ID;
            mapOrder.Store = Map(Order.Store);
            mapOrder.Customer = Map(Order.Customer);
            mapOrder.TotalPrice = Order.TotalPrice;
            mapOrder.TimePlaced = Order.TimePlaced;

            Order.Pizzas.ToList().ForEach(p => mapOrder.Pizzas.Add( Map(p) ) );

            return mapOrder;
        }
        public Entities.Order Map(Domain.Models.Order Order)
        {
            Entities.Order mapOrder = new Entities.Order();
            
            mapOrder.ID = Order.ID;
            mapOrder.Store = Map(Order.Store);
            mapOrder.Customer = Map(Order.Customer);
            mapOrder.TotalPrice = Order.TotalPrice;
            mapOrder.TimePlaced = Order.TimePlaced;

            Order.Pizzas.ToList().ForEach(p => mapOrder.Pizzas.Add(Map(p) ) );

            return mapOrder;
        }
        public Domain.Models.Pizza Map(Entities.Pizza Pizza)
        {
            Domain.Models.Pizza mapPizza = new Domain.Models.Pizza();
            mapPizza.ID = Pizza.ID;
            mapPizza.PresetPizza = Map(Pizza.PresetPizza);
            mapPizza.Order = Map(Pizza.Order);
            mapPizza.Crust = Map(Pizza.Crust);
            mapPizza.Size = Map(Pizza.Size);
            mapPizza.Price = Pizza.Price;

            Pizza.Toppings.ToList().ForEach(t => mapPizza.Toppings.Add(Map(t) ) );

            return mapPizza;
        }
        public Entities.Pizza Map(Domain.Models.Pizza Pizza)
        {
            Entities.Pizza mapPizza = new Entities.Pizza();
            mapPizza.ID = Pizza.ID;
            mapPizza.PresetPizza = Map(Pizza.PresetPizza);
            mapPizza.Order = Map(Pizza.Order);
            mapPizza.Crust = Map(Pizza.Crust);
            mapPizza.Size = Map(Pizza.Size);
            mapPizza.Price = Pizza.Price;

            Pizza.Toppings.ToList().ForEach(t => mapPizza.Toppings.Add(Map(t) ) );

            return mapPizza;
        }
        public Domain.Models.PresetPizza Map(Entities.PresetPizza PresetPizza)
        {
            Domain.Models.PresetPizza mapPizza = new Domain.Models.PresetPizza();
            mapPizza.ID = PresetPizza.ID;
            mapPizza.Name = PresetPizza.Name;
            
            PresetPizza.Toppings.ToList().ForEach(t => mapPizza.Toppings.Add(Map(t) ) );

            return mapPizza;
        }

        public Entities.PresetPizza Map(Domain.Models.PresetPizza PresetPizza)
        {
            Entities.PresetPizza mapPizza = new Entities.PresetPizza();
            mapPizza.ID = PresetPizza.ID;
            mapPizza.Name = PresetPizza.Name;

            PresetPizza.Toppings.ToList().ForEach(t => mapPizza.Toppings.Add(Map(t)));

            return mapPizza;
        }

        public Domain.Models.Size Map(Entities.Size Size)
        {
            return new Domain.Models.Size
            {
                ID = Size.ID,
                Name = Size.Name,
                Price = Size.Price
            };
        }

        public Entities.Size Map(Domain.Models.Size Size)
        {
            return new Entities.Size
            {
                ID = Size.ID,
                Name = Size.Name,
                Price = Size.Price
            };
        }
        public Domain.Models.Store Map(Entities.Store Store)
        {
            return new Domain.Models.Store
            {
                ID = Store.ID,
                Name = Store.Name
            };
        }

        public Entities.Store Map(Domain.Models.Store Store)
        {
            return new Entities.Store
            {
                ID = Store.ID,
                Name = Store.Name
            };
        }
        public Domain.Models.Topping Map(Entities.Topping Topping)
        {
            return new Domain.Models.Topping
            {
                ID = Topping.ID,
                Name = Topping.Name,
                Price = Topping.Price
            };
        }

        public Entities.Topping Map(Domain.Models.Topping Topping)
        {
            return new Entities.Topping
            {
                ID = Topping.ID,
                Name = Topping.Name,
                Price = Topping.Price
            };
        }
    }
}