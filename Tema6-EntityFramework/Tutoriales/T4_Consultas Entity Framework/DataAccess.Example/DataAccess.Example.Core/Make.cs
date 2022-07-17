using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.Core
{
    public class Make
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string ModelName { get; set; }

        [Required]
        [StringLength(100)]
        public string Country { get; set; }

        public List<Vehicle> Vehicles { get; set; }

        


    }
}
