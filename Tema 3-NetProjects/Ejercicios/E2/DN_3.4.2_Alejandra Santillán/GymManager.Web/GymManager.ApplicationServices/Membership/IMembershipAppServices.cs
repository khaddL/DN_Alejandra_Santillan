using GymManager.Core.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Membership
{
    public interface IMembershipAppServices
    {
        List<Types> GetTypes();

        int AddMembership(Types types);

        void RemoveMembership(int Membership);

        Types GetMembership(int Membership);

        void EditMembership(Types types);
    }
}
