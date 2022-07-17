using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.Core
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }

        public Color Color { get; set; }

        public Vehicle Vehicle { get; set; }

        [Required]
        public decimal Price { get; set; }


    }
}
