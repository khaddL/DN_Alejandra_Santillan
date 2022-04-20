using GymManager.Core.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Membership
{
    public class MembershipAppServices : IMembershipAppServices
    {
        public List<Types> GetTypes()
        {
            List<Types> types = new List<Types>();

            types.Add(new Types
            {
                Name = "Premium",
                Cost = 25.50,
                CreatedOn = DateTime.Now,
                Duration = 2


            }) ;

            types.Add(new Types
            {
                Name = "Basic",
                Cost = 10.00,
                CreatedOn = DateTime.Now,
                Duration = 1


            });

            types.Add(new Types
            {
                Name = "Mamadisimo",
                Cost = 35.60,
                CreatedOn = DateTime.Now,
                Duration = 3


            });
            return types;
        }
    }
}
