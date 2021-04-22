using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBox.Data.Entities
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}