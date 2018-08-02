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
        public class MFactura : MBase, IFactura
        {
            public void ActualizarFactura(Factura factura)
            {
                db.Update(factura);
            }

            public Factura BuscarFactura(int idFactura)
            {
                return db.Select<Factura>(x => x.Id_Factura == idFactura).FirstOrDefault();
            }

            public void EliminarFactura(int idFactura)
            {
                db.Delete<Factura>(x => x.Id_Factura == idFactura);
            }

            public void Facturar(Factura factura)
            {

                db.Insert(factura);
            }

            public List<Factura> ListarFacturas()
            {
                return db.Select<Factura>();
            }
        }
    }
}

