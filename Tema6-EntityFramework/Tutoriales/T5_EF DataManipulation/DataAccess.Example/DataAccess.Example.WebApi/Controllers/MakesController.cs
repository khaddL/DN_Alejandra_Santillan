using DataAccess.Example.Core;
using DataAccess.Example.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DataAccess.Example.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        private readonly IQueriesExample _queries;

        public MakesController(IQueriesExample queries)
        { 
            _queries = queries;
        }


        [HttpGet]
        public IEnumerable<Make> Get()
        {
           var result = _queries.GetMakes();
            return result;  
        }

        [HttpGet(nameof(GetByPrice))]
        public IEnumerable<Vehicle> GetByPrice()
        {
            var result = _queries.GetVehiclesByPrice(98454, 324145);
            return result;
        }


    }
}
