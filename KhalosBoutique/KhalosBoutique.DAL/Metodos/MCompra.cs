using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhalosBoutique.DATA;
using KhalosBoutique.DAL.Interfaces;
using ServiceStack.OrmLite;
using KhalosBoutique.DAL.Metodos;


namespace KhalosBoutique.DAL.Métodos
{
    public class MCompra : MBase, ICompra
    {
        public List<ViewCompras> ListarProductoparaCompra()
        {
            return db.SqlList<ViewCompras>("EXEC sp_ListarProductosCompra");
        }
    }
}
