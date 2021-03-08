using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DistributedService.Model;
using Domain.Custumer;
using Infrastructure.Data.Repositories;
using Infrastructure.Data.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DistributedService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustumerController : ControllerBase
    {
        // GET: api/Custumer
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Custumer/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Custumer
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RegisterCustumerModel model)
        {
            var unitOfWork = new OrderUnityOfWork();


            var custumer = new Custumer(name: model.Name, id: model.Id);

            var custumerRepository = new CustumerRepository(unitOfWork);

            await custumerRepository.Add(custumer);

            unitOfWork.BeginTansaction();
            await custumerRepository.Add(custumer);
            await unitOfWork.Commit();

            return Ok();
        }

        // PUT: api/Custumer/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
