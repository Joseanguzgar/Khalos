using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhalosBoutique.DAL.Metodos;
using KhalosBoutique.DATA;

namespace KhalosBoutique.DAL.Interfaces
{
   public interface IDetalle_Factura
    {
        void FacturarConjunto(Detalle_Factura factura);
        List<Detalle_Factura> ListaDetalles();
        void EliminarDetalle(int idDetalle);
        Detalle_Factura BuscarDetalle(int idDetalle);
        List<Detalle_Factura> ListarCompra(int idFactura);
    }
}
