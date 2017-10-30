using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sciensa.Desafio.API.Cliente.Models
{
    public class ContaModel
    {
        public int Id { get; set; }

        public int IdCliente { get; set; }

        public int Agencia { get; set; }

        public int Numero { get; set; }

        public string Tipo { get; set; }

        public decimal Saldo { get; set; }
    }
}
