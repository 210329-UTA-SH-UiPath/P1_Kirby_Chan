using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Client.Models
{
    /// <summary>
    /// Pizza Model
    /// </summary>
    public class Pizza
    {
        public Pizza()
        {
            Toppings = new List<Topping>();
            Crust = new Crust();
            Size = new Size();
        }

        public int ID { get; set; }
        [Required]
        public PresetPizza PresetPizza { get; set; }
        [Required]
        public Order Order { get; set; }
        [Required]
        public Crust Crust { get; set; }
        [Required]
        public Size Size { get; set; }
        [Required]
        public List<Topping> Toppings { get; set; }
        public decimal Price
        {
            get
            {
                var price = 0.0m;
                price += Crust.Price;
                price += Size.Price;
                price += Toppings.Sum(t => t.Price);
                return price;
            }
            set
            {
            }
        }
    }
}