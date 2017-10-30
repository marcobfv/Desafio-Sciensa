using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sciensa.Desafio.API.Cliente.Models;
using Microsoft.AspNetCore.Cors;

namespace Sciensa.Desafio.API.Cliente.Controllers
{
    [Route("api/[controller]")]
    public class ContaController : Controller
    {
        [HttpGet("{id}")]
        public ContaModel Get(int id)
        {
            return ContaContext.Contas.Where(it => it.Id.Equals(id)).FirstOrDefault();
        }

        [HttpPost]
        public IActionResult Post([FromBody]ContaModel conta)
        {
            ContaContext.IncluirConta(conta);

            return new OkResult();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]ContaModel conta)
        {
            var result = ContaContext.AtualizarConta(id, conta);

            if (result)
                return new OkResult();
            else
                return new NotFoundResult();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = ContaContext.DeletarConta(id);

            if (result)
                return new OkResult();
            else
                return new NotFoundResult();
        }
    }
}
