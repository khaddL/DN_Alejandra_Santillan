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
        private static List<Member> Members = new List<Member>();

        public int AddMember(Member member)
        {
            member.Id = new Random().Next();
            Members.Add(member);

            return member.Id;
        }

        public void RemoveMember(int memberId)
        {
            var m = Members.Where(x => x.Id == memberId).FirstOrDefault();
            Members.Remove(m);
        }


        public void EditMember(Member member)
        {
            var m = Members.Where(x => x.Id == member.Id).FirstOrDefault();
            m.AllowNewsLetter = member.AllowNewsLetter;
            m.BirthDay = member.BirthDay;
            m.CityId = member.CityId;
            m.Email = member.Email;
            m.LastName = member.LastName;
            m.Name = member.Name;
        }

        public Member GetMember(int memberId)
        {
            var m = Members.Where(x => x.Id == memberId).FirstOrDefault();
            return m;
        }

       
        public List<Member> GetMembers()
        {
            
          

            return Members;




        }

        
    }
}
