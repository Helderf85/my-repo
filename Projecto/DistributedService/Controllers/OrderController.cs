using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DistributedService.Model;
using Domain.Order;
using Infrastructure.Data.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace DistributedService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RegisterOrderModel model)
        {
           /* var unitOfWork = new OrderUnityOfWork();
            
            

            var order = new Order(orderDate: model.OrderDate,
                OrderItem: OrderItem(quantidade:));

            var invoiceRepository = new InvoiveRepository(unitOfWork);

            await invoiceRepository.Add(invoice);

            unitOfWork.BeginTansaction();
            await invoiceRepository.Add(invoice);
            await unitOfWork.Commit();
            */
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
