using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstractions;
using PizzaBox.Domain.Models;

namespace PizzaBox.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly Entities.PizzaBoxContext context;
        IMapper mapper = new Mapper();
        public OrderRepository(Entities.PizzaBoxContext context)
        {
            this.context = context;
        }
        public List<Order> GetAllOrders()
        {
            var Orders = context.Orders;
            return Orders.Select(mapper.Map).ToList();
        }
        public void AddOrder(Order Order)
        {
            Order.TimePlaced = System.DateTime.Now;
            context.Add(mapper.Map(Order));
            context.SaveChanges();
        }

        public List<Order> GetOrderHistoryByCustomer(int id)
        {
            var OrderHistory = context.Orders.Where(x => x.Customer.ID == id)
                .Include(order => order.Customer)
                .Include(order => order.Store)
                .Include(order => order.Pizzas).ThenInclude(pizza => pizza.PresetPizza)
                .Include(order => order.Pizzas).ThenInclude(pizza => pizza.Toppings)
                .Include(order => order.Pizzas).ThenInclude(pizza => pizza.Crust)
                .Include(order => order.Pizzas).ThenInclude(pizza => pizza.Size);
            if (OrderHistory == null)
            {
                return null;
            }
            return OrderHistory.Select(mapper.Map).ToList();
        }

        public List<Order> GetOrderHistoryByStore(int id)
        {
            var OrderHistory = context.Orders.Where(x => x.Store.ID == id)
                .Include(order => order.Customer)
                .Include(order => order.Store)
                .Include(order => order.Pizzas).ThenInclude(pizza => pizza.PresetPizza)
                .Include(order => order.Pizzas).ThenInclude(pizza => pizza.Toppings)
                .Include(order => order.Pizzas).ThenInclude(pizza => pizza.Crust)
                .Include(order => order.Pizzas).ThenInclude(pizza => pizza.Size);
            if (OrderHistory == null)
            {
                return null;
            }
            return OrderHistory.Select(mapper.Map).ToList();
        }
    }
}
