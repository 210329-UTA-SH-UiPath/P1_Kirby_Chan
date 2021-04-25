using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return Pizzas.Select(mapper.Map).ToList();
        }

        public Pizza GetPizzaById(int id)
        {
            var Pizza = context.Pizzas.Where(x => x.ID == id).FirstOrDefault();
            if (Pizza == null)
            {
                return null;
            }
            return mapper.Map(Pizza);
        }
    }
}
