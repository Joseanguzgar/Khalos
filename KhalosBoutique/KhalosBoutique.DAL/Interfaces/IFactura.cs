using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhalosBoutique.DATA;

namespace KhalosBoutique.DAL.Interfaces
{
    public interface IFactura
    {
        List<Factura> ListarFacturas();
        Factura BuscarFactura(int idFactura);
        void ActualizarFactura(Factura factura);
        void EliminarFactura(int idFactura);
        void Facturar(Factura factura);
    }
}
