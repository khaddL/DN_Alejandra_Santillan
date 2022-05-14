using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Membership
{
    public class Types
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }


        [Required (ErrorMessage ="Only accept monetary value")]
        [Range(1.00, 99999.99)]
        public double Cost { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedOn { get; set; }

        public int Duration { get; set; }
    }
}
