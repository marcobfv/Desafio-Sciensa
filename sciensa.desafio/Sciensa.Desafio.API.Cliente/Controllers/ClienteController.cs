using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClienteModel = Sciensa.Desafio.API.Cliente.Models;

namespace Sciensa.Desafio.API.Cliente.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        public List<ClienteModel.Cliente> clientes = new List<Models.Cliente>();

        // GET api/values
        [HttpGet]
        public IEnumerable<ClienteModel.Cliente> Get()
        {
            return clientes;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ClienteModel.Cliente Get(int id)
        {
            return clientes.Where(c => c.Id.Equals(id)).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]ClienteModel.Cliente cliente)
        {
            clientes.Add(cliente);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]ClienteModel.Cliente cliente)
        {
            
        }
    }
}
