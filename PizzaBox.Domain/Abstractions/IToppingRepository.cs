using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Domain.Abstractions
{
    public interface IToppingRepository
    {
        List<Models.Topping> GetAllToppings();
        Models.Topping GetToppingById(int id);
    }
}
