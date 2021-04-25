using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Data.Entities;

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

            Order.Pizzas.ForEach(p => apizzas.Add(pizzaMapper.Map(p)));

            //order.Customer = customerMapper.Map(model.Customer);

            //List<Domain.Abstracts.APizza> apizzas = new List<Domain.Abstracts.APizza>();
            //model.Pizzas.ToList().ForEach(p => apizzas.Add(pizzaMapper.Map(p)));
            //order.Pizzas = apizzas;

            //order.Price = model.TotalPrice;
            //order.Store = storeMapper.Map(model.Store);
            //order.TimePlaced = model.TimePlaced;

            //order.ID = model.ID;
            return mapOrder;
        }
        public Entities.Order Map(Domain.Models.Order Order)
        {
            Entities.Order order = new Entities.Order();

            order.Customer = customerMapper.Map(model.Customer, context);
            foreach (Domain.Abstracts.APizza pizza in model.Pizzas)
            {
                var mappedPizza = pizzaMapper.Map(pizza, context);
                mappedPizza.Orders.Add(order);
                order.Pizzas.Add(mappedPizza);
            }

            //model.Pizzas.ForEach(p => pizzas.Add(pizzaMapper.Map(p, context)));

            order.Store = storeMapper.Map(model.Store, context);
            order.TotalPrice = model.Price;
            order.TimePlaced = DateTime.Now;
            return order;
        }
        public Domain.Models.Pizza Map(Entities.Pizza Pizza)
        {
            List<int?> pizzaToppingsId = new List<int?>();
            pizzaToppingsId.Add(Pizza.Topping1Id);
            pizzaToppingsId.Add(Pizza.Topping2Id);
            pizzaToppingsId.Add(Pizza.Topping3Id);
            pizzaToppingsId.Add(Pizza.Topping4Id);
            pizzaToppingsId.Add(Pizza.Topping5Id);
            return new Domain.Models.Pizza
            {
                Id = Pizza.PizzaId,
                Name = Pizza.PizzaName,
                ToppingsId = pizzaToppingsId
            };
        }
        public Entities.Pizza Map(Domain.Models.Pizza Pizza)
        {
            return new Entities.Pizza
            {
                PizzaId = Pizza.Id,
                PizzaName = Pizza.Name,
                Topping1Id = Pizza.ToppingsId[0],
                Topping2Id = Pizza.ToppingsId[1],
                Topping3Id = Pizza.ToppingsId[2],
                Topping4Id = Pizza.ToppingsId[3],
                Topping5Id = Pizza.ToppingsId[4]
            };
        }
        public Domain.Models.PresetPizza Map(Entities.PresetPizza PresetPizza)
        {
            throw new System.NotImplementedException();
        }

        public Entities.PresetPizza Map(Domain.Models.PresetPizza PresetPizza)
        {
            throw new System.NotImplementedException();
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