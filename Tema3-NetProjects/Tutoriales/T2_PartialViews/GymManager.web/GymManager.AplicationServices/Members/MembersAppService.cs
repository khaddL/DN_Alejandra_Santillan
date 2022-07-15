using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationServices.Members
{
    public class MembersAppService : IMembersAppServices
    {
        public List<Member> GetMembers()
        {
            List<Member> members = new List<Member>();

            members.Add(new Member
            {

                Name = "Ale",
                LastName = "Santillan",
                Birthday = new DateTime(1997,12, 3),
                AllowNewsLetter = true,
                CityId =    1,
                Email = "ale.santillan.0312@gmail.com"
              

            });

            members.Add(new Member
            {

                Name = "Katherine",
                LastName = "SS",
                Birthday = new DateTime(1990, 5, 15),
                AllowNewsLetter = true,
                CityId = 1,
                Email = "khat@gmail.com"


            });

            members.Add(new Member
            {

                Name = "Mason",
                LastName = "Phoeth",
                Birthday = new DateTime(1995, 6, 12),
                AllowNewsLetter = true,
                CityId = 1,
                Email = "masspt@gmail.com"


            });

            members.Add(new Member
            {

                Name = "Victor",
                LastName = "Smith",
                Birthday = new DateTime(1994, 5, 7),
                AllowNewsLetter = true,
                CityId = 1,
                Email = "vics@gmail.com"


            });

            members.Add(new Member
            {

                Name = "Timothy",
                LastName = "Marth",
                Birthday = new DateTime(1990, 2, 17),
                AllowNewsLetter = true,
                CityId = 1,
                Email = "thimmm@gmail.com"


            });


            members.Add(new Member
            {

                Name = "Stacy",
                LastName = "Craig",
                Birthday = new DateTime(1997, 12, 3),
                AllowNewsLetter = true,
                CityId = 1,
                Email = "staccig@gmail.com"


            });


            members.Add(new Member
            {

                Name = "Linett",
                LastName = "Drew",
                Birthday = new DateTime(1999, 7, 25),
                AllowNewsLetter = true,
                CityId = 1,
                Email = "Linwe@gmail.com"


            });

            members.Add(new Member
            {

                Name = "Nembow",
                LastName = "Qwerty",
                Birthday = new DateTime(1989, 4, 18),
                AllowNewsLetter = true,
                CityId = 1,
                Email = "nemqty@gmail.com"


            });

            return members;




        }
    }
}
