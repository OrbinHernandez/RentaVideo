using Capa_Datos;
using Capa_Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class NClientes
    {
        private readonly DClientes dClientes;

        public NClientes()
        {
            dClientes = new DClientes();
        }

        public List<Clientes> ObtenerTodosLosClientes()
        {
            return dClientes.ObtenerTodosLosClientes();
        }

        public List<Clientes> ObtenerClientesActivos()
        {
            var clientes = dClientes.ObtenerTodosLosClientes();
            return clientes.Where(c => c.Estado).ToList();
        }

        public int GuardarCliente(Clientes cliente)
        {
            if (cliente.ClienteId == 0)
            {
                return dClientes.Agregar(cliente);
            }
            else
            {
                return dClientes.Editar(cliente);
            }
        }

        public int EliminarCliente(int clienteId)
        {
            return dClientes.Eliminar(clienteId);
        }
    }

}
