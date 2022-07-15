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

        private static List<Types> Type = new List<Types>();


        public int AddMembership(Types types)
        {
            types.Id = new Random().Next();
            types.CreatedOn = DateTime.Now;
            Type.Add(types);

            return types.Id;    
        }


        public void RemoveMembership(int Membership)
        {
            var m = Type.Where(x => x.Id == Membership).FirstOrDefault();

            Type.Remove(m);

        }

        public void EditMembership(Types types)
        {
            var m = Type.Where(x => x.Id == types.Id).FirstOrDefault();
            m.Name = types.Name;
            m.Cost = types.Cost;
            m.CreatedOn = types.CreatedOn = DateTime.Now;
            m.Duration = types.Duration;


        }

        public Types GetMembership(int Membership)
        {
            var m = Type.Where(x => x.Id == Membership).FirstOrDefault();
            return m;


        }

        

        public List<Types> GetTypes()
        {
            
            return Type;
        }

        
    }
}
