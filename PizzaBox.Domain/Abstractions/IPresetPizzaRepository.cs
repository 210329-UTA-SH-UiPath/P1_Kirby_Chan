using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Domain.Abstractions
{
    public interface IPresetPizzaRepository
    {
        List<Models.PresetPizza> GetAllPresetPizzas();

        Models.Pizza GetPresetPizzaById(int id);
    }
}
