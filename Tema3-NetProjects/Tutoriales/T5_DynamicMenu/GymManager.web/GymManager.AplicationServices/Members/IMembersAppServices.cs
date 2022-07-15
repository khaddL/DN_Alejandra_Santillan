using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationServices.Members
{
    public interface IMembersAppServices
    {

        List<Member> GetMembers();

        int AddMember(Member member);

        void RemoveMember(int memberId);

        Member GetMember(int memberId);

        void EditMember(Member member);

    }
}
