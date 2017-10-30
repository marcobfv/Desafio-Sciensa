using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sciensa.Desafio.API.Cliente.Models
{
    public static class ContaContext
    {
        private static List<ContaModel> _contas;
        private static int _id = 1;
        private static IEnumerable<object> _clientes;

        public static List<ContaModel> Contas
        {
            get { return _contas; }
        }

        public static void Initialize()
        {
            if (Contas != null) return;

            _contas = new List<ContaModel>();
        }

        public static void IncluirConta(ContaModel conta)
        {
            Initialize();

            conta.Id = _id++;

            _contas.Add(conta);
        }

        public static bool AtualizarConta(int id, ContaModel conta)
        {
            Initialize();

            var result = _contas.Where(it => it.Id.Equals(id)).Select(c =>
            {
                c.Agencia = conta.Agencia;
                c.IdCliente = conta.IdCliente;
                c.Numero = conta.Numero;
                c.Saldo = conta.Saldo;
                c.Tipo = conta.Tipo;
               return c;
            })
           .ToList();

            if (result != null || result.Count > 0)
                return true;

            else
                return false;
        }

        public static bool DeletarConta(int id)
        {
            Initialize();

            var conta = _contas.Where(it => it.Id.Equals(id)).First();

            if (conta != null)
                _contas.Remove(conta);
            else
                return false;

            return true;
        }
    }
}
