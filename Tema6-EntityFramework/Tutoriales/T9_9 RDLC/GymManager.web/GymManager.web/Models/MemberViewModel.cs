using GymManager.Core.Members;
using System;

namespace GymManager.web.Models
{
    public class MemberViewModel
    {
        public int Id { get; set; }

       

        public string Name { get; set; }

        
        public string LastName { get; set; }


       
        public DateTime BirthDay { get; set; }

    
        public int CityId { get; set; }

        public string Email { get; set; }

        public bool AllowNewsLetter { get; set; }

        public City city { get; set; }
    }
}
