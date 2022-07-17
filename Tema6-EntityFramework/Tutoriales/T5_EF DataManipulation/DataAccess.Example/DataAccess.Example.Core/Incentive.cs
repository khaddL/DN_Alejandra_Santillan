using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.Core
{
    public class Incentive
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal Amount { get; set; }
    }
}
