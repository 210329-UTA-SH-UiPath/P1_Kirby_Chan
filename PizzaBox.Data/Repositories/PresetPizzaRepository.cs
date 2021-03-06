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
    public class PresetPizzaRepository : IPresetPizzaRepository
    {
        private readonly Entities.PizzaBoxContext context;
        IMapper mapper = new Mapper();
        public PresetPizzaRepository(Entities.PizzaBoxContext context)
        {
            this.context = context;
        }
        public List<PresetPizza> GetAllPresetPizzas()
        {
            var PresetPizzas = context.PresetPizzas.Include(pizza => pizza.Toppings);
            return PresetPizzas.Select(mapper.Map).ToList();
        }

        public PresetPizza GetPresetPizzaById(int id)
        {
            var PresetPizza = context.PresetPizzas.Where(x => x.ID == id).Include(pizza => pizza.Toppings).FirstOrDefault();
            if (PresetPizza == null)
            {
                return null;
            }
            return mapper.Map(PresetPizza);
        }
    }
}
