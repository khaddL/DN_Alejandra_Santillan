using GymManager.Core.Members;
using System.Collections.Generic;

namespace GymManager.web.Models
{
    public class MemberListViewModel
    {

        public int NewMembersCount { get; set; }

        public List<Member> Members { get; set; }   
    }
}
