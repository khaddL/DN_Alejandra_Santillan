using DataAccess.Example.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.EntityFramework
{
    public interface IQueriesExample
    {
        List<Make> GetMakes();

        List<Vehicle> GetVehiclesByPrice(decimal from, decimal to);
    }
}
