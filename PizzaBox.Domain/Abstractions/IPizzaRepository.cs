using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Domain.Abstractions
{
    public interface IPizzaRepository
    {
        List<Models.Pizza> GetAllPizzas();

        Models.Pizza GetPizzaById(int id);

        void AddPizza(Models.Pizza Pizza);
    }
}
