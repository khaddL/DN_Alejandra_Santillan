using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.Core
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        
        public Make Make { get; set; }

        public Model Model { get; set; }

        [Required]
        public int Year { get; set; }

        public List<Inventory> Inventories { get; set; }



    }
}
