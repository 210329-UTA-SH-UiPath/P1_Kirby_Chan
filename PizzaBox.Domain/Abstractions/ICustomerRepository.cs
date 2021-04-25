using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Domain.Abstractions
{
    public interface ICustomerRepository
    {
        Models.Customer GetCustomerByName(string name);
    }
}
