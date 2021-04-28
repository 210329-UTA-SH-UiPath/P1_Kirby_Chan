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
    public class PizzaRepository : IPizzaRepository
    {
        private readonly Entities.PizzaBoxContext context;
        IMapper mapper = new Mapper();
        public PizzaRepository(Entities.PizzaBoxContext context)
        {
            this.context = context;
        }
        public List<Pizza> GetAllPizzas()
        {
            var Pizzas = context.Pizzas;
            return Pizzas.Include(pizza => pizza.PresetPizza)
                .Include(pizza => pizza.Toppings)
                .Include(pizza => pizza.Crust)
                .Include(pizza => pizza.Size)
                .Select(mapper.Map).ToList();
        }

        public Pizza GetPizzaById(int id)
        {
            var Pizza = context.Pizzas.Where(x => x.ID == id)
                .Include(pizza => pizza.PresetPizza)
                .Include(pizza => pizza.Toppings)
                .Include(pizza => pizza.Crust)
                .Include(pizza => pizza.Size)
                .FirstOrDefault();
            if (Pizza == null)
            {
                return null;
            }
            return mapper.Map(Pizza);
        }
        public void AddPizza(Pizza Pizza)
        {
            context.Add(mapper.Map(Pizza));
            context.SaveChanges();
        }
    }
}
