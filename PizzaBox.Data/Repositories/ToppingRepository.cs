using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaBox.Domain.Abstractions;
using PizzaBox.Domain.Models;

namespace PizzaBox.Data.Repositories
{
    public class ToppingRepository : IToppingRepository
    {
        private readonly Entities.PizzaBoxContext context;
        IMapper mapper = new Mapper();
        public ToppingRepository(Entities.PizzaBoxContext context)
        {
            this.context = context;
        }
        public List<Topping> GetAllToppings()
        {
            var Toppings = context.Toppings;
            return Toppings.Select(mapper.Map).ToList();
        }

        public Topping GetToppingById(int id)
        {
            var Topping = context.Toppings.Where(x => x.ID == id).FirstOrDefault();
            if (Topping != null)
            {
                return mapper.Map(Topping);
            }
            return new Topping();
        }
    }
}
