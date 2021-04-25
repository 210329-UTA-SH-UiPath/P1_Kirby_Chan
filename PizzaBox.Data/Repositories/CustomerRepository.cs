using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaBox.Domain.Abstractions;
using PizzaBox.Domain.Models;

namespace PizzaBox.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Entities.PizzaBoxContext context;
        IMapper mapper = new Mapper();
        public CustomerRepository(Entities.PizzaBoxContext context)
        {
            this.context = context;
        }
        public Customer GetCustomerByName(string name)
        {
            var Customer = context.Customers.Where(x => x.Name == name).FirstOrDefault();
            if (Customer == null)
            {
                context.Add(mapper.Map(new Domain.Models.Customer { Name = name }));
                context.SaveChanges();

                Customer = context.Customers.Where(x => x.Name == name).FirstOrDefault();
            }

            return mapper.Map(Customer);
        }
    }
}
