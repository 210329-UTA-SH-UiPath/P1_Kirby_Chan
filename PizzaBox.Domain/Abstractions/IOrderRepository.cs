using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Domain.Abstractions
{
    public interface IOrderRepository
    {
        void AddOrder(Models.Order Order);

        List<Models.Order> GetOrderHistoryByCustomer(int id);

        List<Models.Order> GetOrderHistoryByStore(int id);
    }
}
