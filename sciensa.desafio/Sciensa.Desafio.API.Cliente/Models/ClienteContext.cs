using System.Collections.Generic;
using System.Linq;

namespace Sciensa.Desafio.API.Cliente.Models
{
    public static class ClienteContext
    {
        private static List<ClienteModel> _clientes;
        private static int _id = 1;

        public static List<ClienteModel> Clientes
        {
            get { return _clientes; }
        }

        public static void Initialize()
        {
            if (Clientes != null) return;

            _clientes = new List<ClienteModel>();
        }

        public static void IncluirCliente(ClienteModel cliente)
        {
            Initialize();

            cliente.Id = _id++;

            _clientes.Add(cliente);
        }

        public static bool AtualizarCliente(int id, ClienteModel cliente)
        {
            Initialize();

            var result = _clientes.Where(it => it.Id.Equals(id)).Select(c =>
            {
                c.Nome = cliente.Nome;
                c.CPF = cliente.CPF;
                c.Endereco = cliente.Endereco;
                return c;
            })
           .ToList();

            if (result != null)
                return true;

            else
                return false;
        }

        public static bool DeletarCliente(int id)
        {
            Initialize();

            var cliente = _clientes.Where(it => it.Id.Equals(id)).First();

            if (cliente != null)
                _clientes.Remove(cliente);
            else
                return false;

            return true;
        }
    }
}
