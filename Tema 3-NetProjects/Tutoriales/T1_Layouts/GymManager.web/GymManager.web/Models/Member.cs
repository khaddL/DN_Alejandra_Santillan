using System;

namespace GymManager.web.Models
{
    public class Member
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public int CityId { get; set; }

        public string Email { get; set; }

        public bool AllowNewsLetter { get; set; }
    }
}
