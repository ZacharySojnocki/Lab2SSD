using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1A.Data;
using Lab1A.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
// I, Zachary Sojnocki, 000367577, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.
namespace Lab1A.Controllers
{
    [Produces("application/json")]
    [Route("api/DealershipApi")]
    public class DealershipApiController : Controller
    {
        // GET: api/DealershipApi
        [HttpGet]
        public IEnumerable<Dealership> Get()
        {
            return DealershipMgr.GetDealershipList();
        }

        // GET: api/DealershipApi/5
        [HttpGet("{id}", Name = "Get")]
        public Dealership Get(int id)
        {
            return DealershipMgr.GetDealership(id);
        }
        
        // POST: api/DealershipApi
        [HttpPost]
        public void Post([FromBody]Dealership value)
        {
            DealershipMgr.AddDealership(value);
        }
        
        // PUT: api/DealershipApi/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Dealership value)
        {
            DealershipMgr.UpdateDealership(id, value);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DealershipMgr.DeleteDealership(id);
        }
    }
}
