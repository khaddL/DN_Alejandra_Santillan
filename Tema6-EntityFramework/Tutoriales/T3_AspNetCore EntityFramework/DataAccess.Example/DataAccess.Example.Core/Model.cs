using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.Core
{
    public class Model
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string ModelName { get; set; }

        [Required]
        public int FirstProductionYear { get; set; }

        public List<Vehicle> Vehicles { get; set; }

        public Model()
        {
            Vehicles = new List<Vehicle>();
        }
    }
}
