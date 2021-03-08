using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Contas_v1_API.Model;
using E_Contas_v1_API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace E_Contas_v1._0_API.Controllers
{
    [Route("api/Cliente")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly repository _repository;

        public ValuesController()
        {
            _repository = new repository();
        }


        
        [HttpGet]
        [Route("{id}")]
            public IActionResult Get(int id)
            {
                var results = _repository.ConsultarCliente(id);
                var model = new ClienteModel
                {
                    Nome = results.Rows[0]["Nome"].ToString(),
                    
                    Morada = results.Rows[0]["Morada"].ToString(),
                    Telefone = int.Parse(results.Rows[0]["Telefone"].ToString()),
                    Email = results.Rows[0]["Email"].ToString()
                };
                
                return Ok(model);
        }

            // POST api/values
            [HttpPost]
            public IActionResult Post([FromBody] ClienteModel request)
            {
              _repository.Inserir(request);
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
