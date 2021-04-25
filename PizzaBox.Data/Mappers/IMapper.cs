using PizzaBox.Domain.Models;

namespace PizzaBox.Data
{
    /// <summary>
    /// Mapper Interface
    /// </summary>
    public interface IMapper
    {
        PizzaBox.Domain.Models.Crust Map(PizzaBox.Data.Entities.Crust Crust);
        PizzaBox.Data.Entities.Crust Map(PizzaBox.Domain.Models.Crust Crust);
        PizzaBox.Domain.Models.Customer Map(PizzaBox.Data.Entities.Customer Customer);
        PizzaBox.Data.Entities.Customer Map(PizzaBox.Domain.Models.Customer Customer);
        PizzaBox.Domain.Models.Order Map(PizzaBox.Data.Entities.Order Order);
        PizzaBox.Data.Entities.Order Map(PizzaBox.Domain.Models.Order Order);
        PizzaBox.Domain.Models.Pizza Map(PizzaBox.Data.Entities.Pizza Pizza);
        PizzaBox.Data.Entities.Pizza Map(PizzaBox.Domain.Models.Pizza Pizza);
        PizzaBox.Domain.Models.PresetPizza Map(PizzaBox.Data.Entities.PresetPizza PresetPizza);
        PizzaBox.Data.Entities.PresetPizza Map(PizzaBox.Domain.Models.PresetPizza PresetPizza);
        PizzaBox.Domain.Models.Size Map(PizzaBox.Data.Entities.Size Size);
        PizzaBox.Data.Entities.Size Map(PizzaBox.Domain.Models.Size Size);
        PizzaBox.Domain.Models.Store Map(PizzaBox.Data.Entities.Store Store);
        PizzaBox.Data.Entities.Store Map(PizzaBox.Domain.Models.Store Store);
        PizzaBox.Domain.Models.Topping Map(PizzaBox.Data.Entities.Topping Topping);
        PizzaBox.Data.Entities.Topping Map(PizzaBox.Domain.Models.Topping Topping);

    }
}