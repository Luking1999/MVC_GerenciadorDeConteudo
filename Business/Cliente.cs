using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Cliente
    {
        public string Nome { get; set; }

        public List<Cliente> Clientes(string cliente)
        {
            //new Database.cliente().Clientes();
            var clientes = new List<Cliente>();
            clientes.Add(new Cliente() { Nome = "Luke" });

            return clientes;
        }
    }
}
