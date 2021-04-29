using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Client.Models
{
    /// <summary>
    /// Order Model
    /// </summary>
    public class Order
    {
        public Order()
        {
            Pizzas = new List<Pizza>();
        }

        [Key]
        public int ID { get; set; }
        [Required]
        public  Store Store { get; set; }
        [Required]
        public  Customer Customer { get; set; }
        [Required]
        public List<Pizza> Pizzas { get; set; }
        public decimal TotalPrice
        {
            get
            {
                return Pizzas.Sum(p => p.Price);
            }
            set { }
        }
        public DateTime TimePlaced { get; set; }
    }
}