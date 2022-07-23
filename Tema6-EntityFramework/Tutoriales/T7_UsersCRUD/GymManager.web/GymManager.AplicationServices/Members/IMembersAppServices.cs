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

        Task<List<Member>> GetMembersAsync();

        Task<int> AddMemberAsync(Member member);

        Task RemoveMemberAsync(int memberId);

        Task<Member> GetMembersAsync(int memberId);


        Task EditMemberAsync(Member member);

    }
}
