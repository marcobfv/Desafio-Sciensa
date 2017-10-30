using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sciensa.Desafio.API.Cliente.Models;
using Microsoft.ServiceFabric.Data;
using Microsoft.AspNetCore.Cors;

namespace Sciensa.Desafio.API.Cliente.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        [HttpGet]
        public IEnumerable<ClienteModel> Get()
        {
            return ClienteContext.Clientes;
        }

        [HttpGet("{id}")]
        public ClienteModel Get(int id)
        {
            return ClienteContext.Clientes.Where(c => c.Id.Equals(id)).FirstOrDefault();
        }

        [HttpPost("{*cliente}")]
        public IActionResult Post([FromBody]ClienteModel cliente)
        {
            ClienteContext.IncluirCliente(cliente);

            return new OkResult();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]ClienteModel cliente)
        {
            var result = ClienteContext.AtualizarCliente(id, cliente);

            if (result)
                return new OkResult();
            else
                return new NotFoundResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = ClienteContext.DeletarCliente(id);

            if (result)
                return new OkResult();
            else
                return new NotFoundResult();
        }
    }
}
