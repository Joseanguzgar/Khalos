using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhalosBoutique.DAL.Interfaces;
using KhalosBoutique.DAL.Metodos;
using KhalosBoutique.DATA;

namespace KhalosBoutique.DAL.Interfaces
{
    public interface ICliente
    {
        Cliente BuscarCliente(int idCliente);
        Cliente BuscarClienteIdentificacion(string identificacion);
        void InsertarCliente(Cliente cliente);
        void ActualizarCliente(Cliente cliente);
        void EliminarCliente(int identificacion);
        List<Cliente> ListarClientes();
    }
}
