using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sciensa.Desafio.API.Cliente.Models
{
    public class ClienteModel
    {
        public ClienteModel()
        {
            Conta = new List<ContaModel>();
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public long CPF { get; set; }

        public string Endereco { get; set; }

        public List<ContaModel> Conta { get; set; }
    }
}
