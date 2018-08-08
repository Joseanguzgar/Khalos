using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhalosBoutique.DAL.Interfaces;
using KhalosBoutique.DATA;
using ServiceStack.OrmLite;

namespace KhalosBoutique.DAL.Metodos
{
   public class MDetalle_Factura
    {
        public class MFactura : MBase, IDetalle_Factura
        {
            public Detalle_Factura BuscarDetalle(int idDetalle)
            {
                return db.Select<Detalle_Factura>(x => x.Id_Detalle == idDetalle).FirstOrDefault();
            }

            public void EliminarDetalle(int idDetalle)
            {
                db.Delete<Detalle_Factura>(x => x.Id_Detalle == idDetalle);
            }

            public void FacturarConjunto(Detalle_Factura factura)
            {
                db.Insert(factura);
            }

            public List<Detalle_Factura> ListaDetalles()
            {
                return db.Select<Detalle_Factura>();
            }

            public List<Detalle_Factura> ListarCompra(int idFactura)
            {
                return db.Select<Detalle_Factura>(X => X.Id_Factura == idFactura);
            }
        }
    }
}

