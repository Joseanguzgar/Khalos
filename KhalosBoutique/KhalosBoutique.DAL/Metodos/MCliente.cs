using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhalosBoutique.DATA;
using KhalosBoutique.DAL.Interfaces;
using ServiceStack.OrmLite;

namespace KhalosBoutique.DAL.Metodos
{
    public class MCliente : MBase, ICliente
    {
        public void ActualizarCliente(Cliente cliente)
        {
            db.Update(cliente);
        }

        public Cliente BuscarCliente(int idCliente)
        {
            return db.Select<Cliente>(x => x.Id_Cliente == idCliente).FirstOrDefault();
        }

        public Cliente BuscarClienteIdentificacion(string identificacion)
        {
            return db.Select<Cliente>(x => x.Identificacion == identificacion).FirstOrDefault();
        }

        public void EliminarCliente(int idCliente)
        {
            db.Delete<Cliente>(x => x.Id_Cliente == idCliente);
        }

        public void InsertarCliente(Cliente cliente)
        {
            db.Insert(cliente);
        }

        public List<Cliente> ListarClientes()
        {
            return db.Select<Cliente>();
        }
    }
}
