using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Members
{
    public class Member
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string BirthDate { get; set; }

        public int city { get; set; }

        public string email { get; set; }

        public bool AllowsNewsLetter { get; set; }

    }
}